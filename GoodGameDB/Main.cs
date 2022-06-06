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
        public static Panel PanelSideContent = null;
        public decimal SumScore = 0;

        // Save current score values
        string Gametitle;
        int sGameplay = 1;
        int sPresentation = 1;
        int sNarrative = 1;
        int sQuality = 1;
        int sSound = 1;
        int sContent = 1;
        int sPacing = 1;
        int sBalance = 1;
        int sImpression = 1;
        int sTotal = 1;

        // Datafields for Input
        bool ReplayStatus = false;
        string DateComplete;
        int foreignKeyID = 0;

        ScorePreview ScorePreviewGameplay = new ScorePreview();
        ScorePreview ScorePreviewPresentation = new ScorePreview();
        ScorePreview ScorePreviewNarrative = new ScorePreview();
        ScorePreview ScorePreviewQuality = new ScorePreview();
        ScorePreview ScorePreviewSound = new ScorePreview();
        ScorePreview ScorePreviewContent = new ScorePreview();
        ScorePreview ScorePreviewPacing = new ScorePreview();
        ScorePreview ScorePreviewBalance = new ScorePreview();
        ScorePreview ScorePreviewImpression = new ScorePreview();
        ScorePreview ScoreSum = new ScorePreview();

        public Main()
        {
            InitializeComponent();
            OpenForm(new Database());
            PanelSideContent = Pnl_SideContent;


            ScorePreviewGameplay.Create(10, 20, "Gameplay", Pnl_Score);
            ScorePreviewPresentation.Create(10, 50, "Presentation", Pnl_Score);
            ScorePreviewNarrative.Create(10, 80, "Narrative", Pnl_Score);
            ScorePreviewQuality.Create(10, 110, "Quality", Pnl_Score);
            ScorePreviewSound.Create(10, 140, "Sound", Pnl_Score);
            ScorePreviewContent.Create(10, 170, "Content", Pnl_Score);
            ScorePreviewPacing.Create(10, 200, "Pacing", Pnl_Score);
            ScorePreviewBalance.Create(10, 230, "Balance", Pnl_Score);
            ScorePreviewImpression.Create(10, 260, "Impression", Pnl_Score);

            ScoreSum.SumCreate(335, 300, 19, Pnl_Score);

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
            Lbl_UserInfo.Text = Input_Game.Text + " saved to database!";

            DateComplete = Input_Year.Text + "-" + Input_Month.Text + "-" + Input_Day.Text;
            Gametitle = Input_Game.Text;
            sGameplay = Convert.ToInt32(Rate_Gameplay.Value);
            sPresentation = Convert.ToInt32(Rate_Presentation.Value);
            sNarrative = Convert.ToInt32(Rate_Narrative.Value);
            sQuality = Convert.ToInt32(Rate_Quality.Value);
            sSound = Convert.ToInt32(Rate_Sound.Value);
            sContent = Convert.ToInt32(Rate_Content.Value);
            sPacing = Convert.ToInt32(Rate_Pacing.Value);
            sBalance = Convert.ToInt32(Rate_Balance.Value);
            sImpression = Convert.ToInt32(Rate_Impression.Value);
            sTotal = sGameplay + sPresentation + sNarrative + sQuality + sSound + sContent + sPacing + sBalance + sImpression + 10;

            if (ReplayStatus == false)
            {
                ConnectDB.Insert("INSERT INTO score_values (name, gameplay, presentation, narrative, quality, sound, content, pacing, balance, impression, total)" +
                    "VALUES ('" + Gametitle + "'," +
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

                SQLiteDataReader reader = ConnectDB.Reader("SELECT * FROM score_values WHERE name = '" + Gametitle + "'");
                reader.Read();

                foreignKeyID = Convert.ToInt32(reader[0]);
                MessageBox.Show("KeyID: " + foreignKeyID);
                reader.Close();
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

            if (ReplayStatus == true)
            {
                SQLiteDataReader reader = ConnectDB.Reader("SELECT * FROM score_values WHERE name = '" + Gametitle + "'");
                reader.Read();

                foreignKeyID = Convert.ToInt32(reader[0]);
                MessageBox.Show("KeyID: " + foreignKeyID);
                reader.Close();
                ConnectDB.Close();

                ConnectDB.Insert("INSERT INTO games (name, date, location, note, score, replay)" +
                    "VALUES ('" + Input_Game.Text + "'," +
                            "'" + DateComplete + "'," +
                            "'" + Input_Location.Text + "'," +
                            "'" + Input_Note.Text + "'," +
                            "'" + foreignKeyID + "'," +
                            "'" + "1" +
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
                Btn_Add.BackColor = Color.FromArgb(0, 171, 255);
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
            //Lbl_SumScore.Text = SumScore + "";
        }

        private void Rate_Gameplay_ValueChanged(object sender, EventArgs e)
        {
            CountSum();
            sGameplay = Convert.ToInt32(Rate_Gameplay.Value);
            ScoreSum.SumUpdate(Convert.ToInt32(SumScore));
            ScorePreviewGameplay.Update(sGameplay);
        }

        private void Rate_Presentation_ValueChanged(object sender, EventArgs e)
        {
            CountSum();
            sPresentation = Convert.ToInt32(Rate_Presentation.Value);
            ScoreSum.SumUpdate(Convert.ToInt32(SumScore));
            ScorePreviewPresentation.Update(sPresentation);
        }

        private void Rate_Narrative_ValueChanged(object sender, EventArgs e)
        {
            CountSum();
            sNarrative = Convert.ToInt32(Rate_Narrative.Value);
            ScoreSum.SumUpdate(Convert.ToInt32(SumScore));
            ScorePreviewNarrative.Update(sNarrative);
        }

        private void Rate_Quality_ValueChanged(object sender, EventArgs e)
        {
            CountSum();
            sQuality = Convert.ToInt32(Rate_Quality.Value);
            ScoreSum.SumUpdate(Convert.ToInt32(SumScore));
            ScorePreviewQuality.Update(sQuality);
        }

        private void Rate_Sound_ValueChanged(object sender, EventArgs e)
        {
            CountSum();
            sSound = Convert.ToInt32(Rate_Sound.Value);
            ScoreSum.SumUpdate(Convert.ToInt32(SumScore));
            ScorePreviewSound.Update(sSound);
        }

        private void Rate_Content_ValueChanged(object sender, EventArgs e)
        {
            CountSum();
            sContent = Convert.ToInt32(Rate_Content.Value);
            ScoreSum.SumUpdate(Convert.ToInt32(SumScore));
            ScorePreviewContent.Update(sContent);
        }

        private void Rate_Pacing_ValueChanged(object sender, EventArgs e)
        {
            CountSum();
            sPacing = Convert.ToInt32(Rate_Pacing.Value);
            ScoreSum.SumUpdate(Convert.ToInt32(SumScore));
            ScorePreviewPacing.Update(sPacing);
        }

        private void Rate_Balance_ValueChanged(object sender, EventArgs e)
        {
            CountSum();
            sBalance = Convert.ToInt32(Rate_Balance.Value);
            ScoreSum.SumUpdate(Convert.ToInt32(SumScore));
            ScorePreviewBalance.Update(sBalance);
        }

        private void Rate_Impression_ValueChanged(object sender, EventArgs e)
        {
            CountSum();
            sImpression = Convert.ToInt32(Rate_Impression.Value);
            ScoreSum.SumUpdate(Convert.ToInt32(SumScore));
            ScorePreviewImpression.Update(sImpression);
        }

        private void chkReplay_CheckedChanged(object sender, EventArgs e)
        {
            if (chkReplay.Checked == true)
            {
                ReplayStatus = true;
                Pnl_HideScore.Visible = true;
            }
            if (chkReplay.Checked == false)
            {
                ReplayStatus = false;
                Pnl_HideScore.Visible = false;
            }
        }

        private void Input_Game_Enter(object sender, EventArgs e)
        {
            Input_Game.BackColor = Color.FromArgb(0, 171, 255);
        }

        private void Input_Game_Leave(object sender, EventArgs e)
        {
            Input_Game.BackColor = Color.White;
        }

        private void Input_Location_Enter(object sender, EventArgs e)
        {
            Input_Location.BackColor = Color.FromArgb(0, 171, 255);
        }

        private void Input_Location_Leave(object sender, EventArgs e)
        {
            Input_Location.BackColor = Color.White;
        }

        private void Input_Day_Enter(object sender, EventArgs e)
        {
            Input_Day.BackColor = Color.FromArgb(0, 171, 255);
        }

        private void Input_Day_Leave(object sender, EventArgs e)
        {
            Input_Day.BackColor = Color.White;
        }

        private void Input_Month_Enter(object sender, EventArgs e)
        {
            Input_Month.BackColor = Color.FromArgb(0, 171, 255);
        }

        private void Input_Month_Leave(object sender, EventArgs e)
        {
            Input_Month.BackColor = Color.White;
        }

        private void Input_Year_Enter(object sender, EventArgs e)
        {
            Input_Year.BackColor = Color.FromArgb(0, 171, 255);
        }

        private void Input_Year_Leave(object sender, EventArgs e)
        {
            Input_Year.BackColor = Color.White;
        }

        private void Input_Note_Enter(object sender, EventArgs e)
        {
            Input_Note.BackColor = Color.FromArgb(0, 171, 255);
        }

        private void Input_Note_Leave(object sender, EventArgs e)
        {
            Input_Note.BackColor = Color.White;
        }

        private void Rate_Gameplay_Enter(object sender, EventArgs e)
        {
            Rate_Gameplay.BackColor = Color.FromArgb(0, 171, 255);
        }

        private void Rate_Gameplay_Leave(object sender, EventArgs e)
        {
            Rate_Gameplay.BackColor = Color.FromArgb(20, 20, 20);
        }

        private void Rate_Presentation_Enter(object sender, EventArgs e)
        {
            Rate_Presentation.BackColor = Color.FromArgb(0, 171, 255);
        }

        private void Rate_Presentation_Leave(object sender, EventArgs e)
        {
            Rate_Presentation.BackColor = Color.FromArgb(20, 20, 20);
        }

        private void Rate_Narrative_Enter(object sender, EventArgs e)
        {
            Rate_Narrative.BackColor = Color.FromArgb(0, 171, 255);
        }

        private void Rate_Narrative_Leave(object sender, EventArgs e)
        {
            Rate_Narrative.BackColor = Color.FromArgb(20, 20, 20);
        }

        private void Rate_Quality_Enter(object sender, EventArgs e)
        {
            Rate_Quality.BackColor = Color.FromArgb(0, 171, 255);
        }

        private void Rate_Quality_Leave(object sender, EventArgs e)
        {
            Rate_Quality.BackColor = Color.FromArgb(20, 20, 20);
        }

        private void Rate_Sound_Enter(object sender, EventArgs e)
        {
            Rate_Sound.BackColor = Color.FromArgb(0, 171, 255);
        }

        private void Rate_Sound_Leave(object sender, EventArgs e)
        {
            Rate_Sound.BackColor = Color.FromArgb(20, 20, 20);
        }

        private void Rate_Content_Enter(object sender, EventArgs e)
        {
            Rate_Content.BackColor = Color.FromArgb(0, 171, 255);
        }

        private void Rate_Content_Leave(object sender, EventArgs e)
        {
            Rate_Content.BackColor = Color.FromArgb(20, 20, 20);
        }

        private void Rate_Pacing_Enter(object sender, EventArgs e)
        {
            Rate_Pacing.BackColor = Color.FromArgb(0, 171, 255);
        }

        private void Rate_Pacing_Leave(object sender, EventArgs e)
        {
            Rate_Pacing.BackColor = Color.FromArgb(20, 20, 20);
        }

        private void Rate_Balance_Enter(object sender, EventArgs e)
        {
            Rate_Balance.BackColor = Color.FromArgb(0, 171, 255);
        }

        private void Rate_Balance_Leave(object sender, EventArgs e)
        {
            Rate_Balance.BackColor = Color.FromArgb(20, 20, 20);
        }

        private void Rate_Impression_Enter(object sender, EventArgs e)
        {
            Rate_Impression.BackColor = Color.FromArgb(0, 171, 255);
        }

        private void Rate_Impression_Leave(object sender, EventArgs e)
        {
            Rate_Impression.BackColor = Color.FromArgb(20, 20, 20);
        }

        private void Input_Note_Enter_1(object sender, EventArgs e)
        {
            Input_Note.BackColor = Color.FromArgb(0, 171, 255);
        }

        private void Input_Note_Leave_1(object sender, EventArgs e)
        {
            Input_Note.BackColor = Color.White;
        }
    }
}