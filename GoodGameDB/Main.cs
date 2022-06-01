using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;
using System.IO;
using System.Windows.Forms;
using System.Data.SQLite;

namespace GoodGameDB
{
    public partial class Main : Form
    {
        // Create childforms
        private Form activeForm = null;
        // Make Panel_Title dragable when click & hold
        // --------------------------------------------------------------------------------------|
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();
        public static Panel PanelSideContent;
        public decimal SumScore = 0;

        // Save current score values
        int sGameplay = 0;
        int sPresentation = 0;
        int sNarrative = 0;
        int sQuality = 0;
        int sSound = 0;
        int sContent = 0;
        int sPacing = 0;
        int sBalance = 0;
        int sImpression = 0;
        int sTotal = 0;

        // Datafields for Input
        bool ReplayStatus = false;
        string DateComplete;
        int foreignKeyID = 0;
        string CurrentItemName; 

        public Main()
        {
            InitializeComponent();
            OpenForm(new Database());
            PanelSideContent = Pnl_SideContent;
        }

        public void OpenForm(Form childForm)
        {
            if (activeForm != null)
            {
                activeForm.Close();
            }

            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            Pnl_Content.Controls.Add(childForm);
            Pnl_Content.Tag = childForm;
            Pnl_Content.BringToFront();
            childForm.Show();
        }

        private void BtnCommit_Click(object sender, EventArgs e)
        {
            DateComplete = Input_Year.Text + "-" + Input_Month.Text + "-" + Input_Day.Text;

            if (ReplayStatus == false)
            {
                ConnectDB.Insert("INSERT INTO score_values (name, gameplay, presentation, narrative, quality, sound, content, pacing, balance, impression, total)" +
                    "VALUES ('" + Input_Game.Text + "'," +
                            "'" + sGameplay + "'," +
                            "'" + sPresentation + "'," +
                            "'" + sNarrative + "'," +
                            "'" + sQuality + "'," +
                            "'" + sSound + "'," +
                            "'" + sContent + "'," +
                            "'" + sPacing + "'," +
                            "'" + sBalance + "'," +
                            "'" + sImpression + "'," +
                            "'" + sTotal + "')");

                ConnectDB.Close();
                SQLiteDataReader reader = ConnectDB.Reader("SELECT * FROM games INNER JOIN score_values ON games.score = score_values.s_id");

                // Needs serious rework I think
                while (reader.Read())
                {
                    if (Convert.ToString(reader["name"]) == Input_Game.Text)
                    {
                        foreignKeyID = Convert.ToInt32(reader["score_values.s_id"]);
                        MessageBox.Show("" + foreignKeyID);
                    }

                }

                ConnectDB.Close();
                ConnectDB.Insert("INSERT INTO games (name, date, location, note, score, replay)" +
                    "VALUES ('" + Input_Game.Text + "'," +
                            "'" + DateComplete + "'," +
                            "'" + Input_Location.Text + "'," +
                            "'" + Input_Note.Text + "'," +
                            "'" + foreignKeyID + "'," +
                            "'" + "0" +
                    "')"); ;

                ConnectDB.Close();
            }
        }

        private void Pnl_Title_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void Btn_WindowClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Btn_MiniWindow_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Btn_Add_Click(object sender, EventArgs e)
        {
            if (Database.InfoPanel.Visible == true)
            {
                Database.InfoPanel.Visible = false;
            }
            if (Pnl_SideContent.Visible == false)
            {
                Pnl_SideContent.Visible = true;
                Btn_Add.BackColor = Color.FromArgb(118, 174, 200);
            }

            else if (Pnl_SideContent.Visible == true)
            {
                Pnl_SideContent.Visible = false;
                Btn_Add.BackColor = Color.Transparent;
            }
        }

        private void CountSum()
        {
            SumScore = Rate_Gameplay.Value + Rate_Presentation.Value + Rate_Narrative.Value + Rate_Quality.Value +
            Rate_Sound.Value + Rate_Content.Value + Rate_Pacing.Value + Rate_Balance.Value + Rate_Impression.Value + 10;
            Lbl_SumScore.Text = SumScore + "";
        }

        private void Rate_Gameplay_ValueChanged(object sender, EventArgs e)
        {
            CountSum();
            sGameplay = Convert.ToInt32(Rate_Gameplay.Value);
        }

        private void Rate_Presentation_ValueChanged(object sender, EventArgs e)
        {
            CountSum();
            sPresentation = Convert.ToInt32(Rate_Presentation.Value);
        }

        private void Rate_Narrative_ValueChanged(object sender, EventArgs e)
        {
            CountSum();
            sNarrative = Convert.ToInt32(Rate_Narrative.Value);
        }

        private void Rate_Quality_ValueChanged(object sender, EventArgs e)
        {
            CountSum();
            sQuality = Convert.ToInt32(Rate_Quality.Value);
        }

        private void Rate_Sound_ValueChanged(object sender, EventArgs e)
        {
            CountSum();
            sSound = Convert.ToInt32(Rate_Sound.Value);
        }

        private void Rate_Content_ValueChanged(object sender, EventArgs e)
        {
            CountSum();
            sContent = Convert.ToInt32(Rate_Content.Value);
        }

        private void Rate_Pacing_ValueChanged(object sender, EventArgs e)
        {
            CountSum();
            sPacing = Convert.ToInt32(Rate_Pacing.Value);
        }

        private void Rate_Balance_ValueChanged(object sender, EventArgs e)
        {
            CountSum();
            sBalance = Convert.ToInt32(Rate_Balance.Value);
        }

        private void Rate_Impression_ValueChanged(object sender, EventArgs e)
        {
            CountSum();
            sImpression = Convert.ToInt32(Rate_Impression.Value);
        }

        private void chkReplay_CheckedChanged(object sender, EventArgs e)
        {
            if (chkReplay.Checked == true)
            {
                ReplayStatus = true;
            }
            if (chkReplay.Checked == false)
            {
                ReplayStatus = false;
            }
        }

        private void Input_Game_Enter(object sender, EventArgs e)
        {
            Input_Game.BackColor = Color.FromArgb(118, 174, 200);
        }

        private void Input_Game_Leave(object sender, EventArgs e)
        {
            Input_Game.BackColor = Color.White;
        }

        private void Input_Location_Enter(object sender, EventArgs e)
        {
            Input_Location.BackColor = Color.FromArgb(118, 174, 200);
        }

        private void Input_Location_Leave(object sender, EventArgs e)
        {
            Input_Location.BackColor = Color.White;
        }

        private void Input_Day_Enter(object sender, EventArgs e)
        {
            Input_Day.BackColor = Color.FromArgb(118, 174, 200);
        }

        private void Input_Day_Leave(object sender, EventArgs e)
        {
            Input_Day.BackColor = Color.White;
        }

        private void Input_Month_Enter(object sender, EventArgs e)
        {
            Input_Month.BackColor = Color.FromArgb(118, 174, 200);
        }

        private void Input_Month_Leave(object sender, EventArgs e)
        {
            Input_Month.BackColor = Color.White;
        }

        private void Input_Year_Enter(object sender, EventArgs e)
        {
            Input_Year.BackColor = Color.FromArgb(118, 174, 200);
        }

        private void Input_Year_Leave(object sender, EventArgs e)
        {
            Input_Year.BackColor = Color.White;
        }

        private void Input_Note_Enter(object sender, EventArgs e)
        {
            Input_Note.BackColor = Color.FromArgb(118, 174, 200);
        }

        private void Input_Note_Leave(object sender, EventArgs e)
        {
            Input_Note.BackColor = Color.White;
        }
    }
}