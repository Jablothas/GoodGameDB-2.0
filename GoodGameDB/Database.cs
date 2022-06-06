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
    public partial class Database : Form
    {
        // MySQL Connection
        string query = "";
        DataTable table;
        Panel latestActivePnl = null;
        public static Panel InfoPanel;

        public Database()
        {
            InitializeComponent();
            LoadData();

            Pnl_Info.Visible = false;
            InfoPanel = Pnl_Info;
        }

        private void LoadData()
        {
            query = "SELECT id, games.name, date, location, note, score, replay, " +
                "s_id, score_values.name, gameplay, presentation, narrative, quality, sound, content, pacing, balance, impression, total " +
                "FROM games " + 
                "INNER JOIN score_values " +
                "ON games.score = score_values.s_id " +
                "ORDER BY date ASC";
            table = ConnectDB.CreateDataTable(query);


            foreach (DataRow output in table.Rows)
            {

                // Create Background

                Panel Pnl_Background = new Panel()
                {
                    Name = "Pnl_" + output[1].ToString(),
                    Size = new Size(600, 38),
                    Dock = DockStyle.Top,
                    BackColor = Color.FromArgb(255, 255, 255),
                };
                Pnl_Background.MouseEnter += new EventHandler(MouseEnterOnDatabase);
                Pnl_Background.MouseLeave += new EventHandler(MouseLeaveOnDatabase);
                Pnl_Background.MouseClick += new MouseEventHandler(MouseClickOnDataBase);

                // Create Splitter

                Panel Pnl_Splitter = new Panel()
                {
                    Size = new Size(600, 1),
                    Dock = DockStyle.Top,
                    BackColor = Color.Black,
                };

                ScoreSystem.Create(10, 9, Convert.ToInt32(output[18]), Convert.ToBoolean(output["replay"]), Pnl_Background);

                Label Name = new Label()
                {
                    Name = output["name"].ToString(),
                    Text = output["name"].ToString(),
                    Location = new Point(150, 12),
                    AutoSize = true,
                };

                Label Location = new Label()
                {
                    Text = output["location"].ToString(),
                    Location = new Point(550, 12)
                };

                Label Date = new Label()
                {
                    Text = output["date"].ToString(),
                    Location = new Point(750, 12)
                };

                Label Note = new Label()
                {
                    Text = output["note"].ToString(),
                    Location = new Point(860, 12),
                    AutoSize = true,
                };

                string[] tmp_note;
                if (Note.Text.Contains('\n'))
                {
                    tmp_note = Note.Text.Split('\n');
                    Note.Text = tmp_note[0];
                }

                Pnl_Data.Controls.Add(Pnl_Background);
                Pnl_Data.Controls.Add(Pnl_Splitter);
                Pnl_Background.Controls.Add(Name);
                Pnl_Background.Controls.Add(Location);
                Pnl_Background.Controls.Add(Date);
                Pnl_Background.Controls.Add(Note);
            }

            ConnectDB.Close();
        }

        public void MouseEnterOnDatabase(object sender, EventArgs e)
        {
            if (sender is Panel panel)
            {
                panel.BackColor = Color.FromArgb(0, 171, 255);
                //panel.BackColor = Color.FromArgb(240, 240, 240); 
            }
        }

        public void MouseLeaveOnDatabase(object sender, EventArgs e)
        {
            if (sender is Panel panel)
            {
                panel.BackColor = Color.FromArgb(255, 255, 255);
            }
        }

        public void MouseClickOnDataBase(object sender, EventArgs e)
        {
            if (Main.PanelSideContent.Visible == true)
            {
                Main.PanelSideContent.Visible = false;
            }

            if (Pnl_Info.Visible == false)
            {
                Pnl_Info.Visible = true;
            }

            if (sender is Panel panel)
            {
                Pnl_InfoData.Controls.Clear();

                if (latestActivePnl == null)
                {
                    latestActivePnl = panel;
                }
                else
                {
                    latestActivePnl.BackColor = Color.FromArgb(255, 255, 255);
                    latestActivePnl.MouseEnter += MouseEnterOnDatabase;
                    latestActivePnl.MouseLeave += MouseLeaveOnDatabase;
                    latestActivePnl = panel;
                }

                foreach (DataRow line in table.Rows)
                {
                    if (("Pnl_" + line[1].ToString()) == panel.Name)
                    {
                        panel.BackColor = Color.FromArgb(0, 171, 255);
                        panel.MouseEnter -= MouseEnterOnDatabase;
                        panel.MouseLeave -= MouseLeaveOnDatabase;

                        //Label Title = new Label()
                        //{
                        //    Text = line[1].ToString(),
                        //    Location = new Point(125, 17),
                        //    ForeColor = Color.FromArgb(0, 127, 255),
                        //    AutoSize = true
                        //};
                        //Pnl_InfoData.Controls.Add(Title);

                        //Panel Splitter = new Panel()
                        //{
                        //    Location = new Point(0, 49),
                        //    BackColor = Color.DimGray,
                        //    Size = new Size(600, 1),
                        //};
                        //Pnl_InfoData.Controls.Add(Splitter);

                        Lbl_Title.Text = line["name"].ToString();

                        ScoreSystem.Draw(15, 25, "Gameplay", Convert.ToInt32(line["gameplay"]), Pnl_InfoData);
                        ScoreSystem.Draw(15, 50, "Presentation", Convert.ToInt32(line["presentation"]), Pnl_InfoData);
                        ScoreSystem.Draw(15, 75, "Narrative", Convert.ToInt32(line["narrative"]), Pnl_InfoData);
                        ScoreSystem.Draw(15, 100, "Quality", Convert.ToInt32(line["quality"]), Pnl_InfoData);
                        ScoreSystem.Draw(15, 125, "Sound", Convert.ToInt32(line["sound"]), Pnl_InfoData);
                        ScoreSystem.Draw(15, 150, "Content", Convert.ToInt32(line["content"]), Pnl_InfoData);
                        ScoreSystem.Draw(15, 175, "Pacing", Convert.ToInt32(line["pacing"]), Pnl_InfoData);
                        ScoreSystem.Draw(15, 200, "Balance", Convert.ToInt32(line["balance"]), Pnl_InfoData);
                        ScoreSystem.Draw(15, 225, "Impression", Convert.ToInt32(line["impression"]), Pnl_InfoData);

                        ScoreSystem.Create(200, 250, Convert.ToInt32(line["total"]), Convert.ToBoolean(line["replay"]), Pnl_InfoData);

                        if (line["note"].ToString() != "")
                        {
                            Lbl_Note.Text = line["note"].ToString();
                        }
                        else
                        {
                            Lbl_Note.Text = "empty";
                        }
                        

                        int ptcnt = 0;
                        query = "SELECT * FROM games WHERE name = '" + line[1].ToString() + "' ORDER BY date ASC";
                        SQLiteDataReader reader = ConnectDB.Reader(query);
                        Lbl_PtDate.Text = "";
                        Lbl_PtLocation.Text = "";
                        Lbl_PtCnt.Text = "";

                        while (reader.Read())
                        {
                            ptcnt++;
                            Lbl_PtDate.Text += Convert.ToDateTime(reader["date"]).ToShortDateString() + "\n";
                            Lbl_PtLocation.Text += "@ " + reader["location"] + "\n";
                            Lbl_PtCnt.Text += "" + ptcnt + ".\n";
                        }

                        ConnectDB.Close();

                    }
                }
            }
        }

        private void Btn_Hide_Click(object sender, EventArgs e)
        {
            Pnl_Info.Visible = false;
            latestActivePnl.BackColor = Color.FromArgb(255, 255, 255);
            latestActivePnl.MouseEnter += MouseEnterOnDatabase;
            latestActivePnl.MouseLeave += MouseLeaveOnDatabase;
            latestActivePnl = null;
        }

        private void Lbl_PtLocation_Click(object sender, EventArgs e)
        {

        }

        private void Lbl_PtDate_Click(object sender, EventArgs e)
        {

        }

        private void Lbl_PtCnt_Click(object sender, EventArgs e)
        {

        }
    }
}
