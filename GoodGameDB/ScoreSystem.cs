using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoodGameDB
{
    public static class ScoreSystem
    {
        public static void Create(int xpos, int ypos, int score, bool replay, Panel panel)
        {
            string Score_Image_Path = "img/score/";
            string Score_Image = "";
            string Score_Medal = "";

            if (score >= 80)
            {
                Score_Image = "score_background_green.png";
            }
            else if (score >= 70)
            {
                Score_Image = "score_background_yellow.png";
            }
            else if (score >= 60)
            {
                Score_Image = "score_background_orange.png";
            }
            else
            {
                Score_Image = "score_background_red.png";
            }

            PictureBox Background = new PictureBox()
            {
                Image = Image.FromFile(Score_Image_Path + Score_Image),
                Location = new Point(xpos, ypos),
                SizeMode = PictureBoxSizeMode.Zoom,
                Size = new Size(50, 22),
            };
            panel.Controls.Add(Background);

            Label Score = new Label()
            {
                Text = Convert.ToString(score),
                Location = new Point(8, 1),
                BackColor = Color.Transparent,
                Size = new Size(36, 19),
                //Font = new Font(panel.Font, FontStyle.Bold),
                ForeColor = Color.FromArgb(32, 33, 36),
                TextAlign = ContentAlignment.MiddleCenter
            };
            Background.Controls.Add(Score);

            if (score >= 95)
            {
                Score_Medal = "medal_gold.png";
            }
            else if (score >= 90 && score <= 94)
            {
                Score_Medal = "medal_silver.png";
            }
            else if (score >= 85 && score <= 89)
            {
                Score_Medal = "medal_bronze.png";
            }
            else
            {
                Score_Medal = "medal_empty.png";
            }

            PictureBox Medal = new PictureBox()
            {
            Visible = true,
            Image = Image.FromFile(Score_Image_Path + Score_Medal),
            Size = new Size(30, 30),
            Location = new Point((xpos + 52), (ypos - 4)),
            SizeMode = PictureBoxSizeMode.Zoom
            };
            panel.Controls.Add(Medal);

            if (Score_Medal == "medal_empty.png")
            {
                Medal.Visible = false;
            }
            else
            {
                Medal.Visible = true;
            }

            if (replay == true)
            {
                PictureBox Replay = new PictureBox()
                {
                    Image = Image.FromFile(Score_Image_Path + "replay.png"),
                    SizeMode = PictureBoxSizeMode.Zoom,
                    Size = new Size(23, 23),
                    Location = new Point((xpos + 55), (ypos)),
                };
                panel.Controls.Add(Replay);

                if (Score_Medal != "medal_empty.png")
                {
                    Replay.Location = new Point((xpos + 85), (ypos));
                }
            }
        }

        public static void Draw(int xPos, int yPos, string name, int score, Panel panel)
        {
            Label Lbl_Category = new Label();
            Lbl_Category.Text = name;
            Lbl_Category.Location = new Point(xPos, (yPos - 4));
            Lbl_Category.ForeColor = Color.White;
            panel.Controls.Add(Lbl_Category);

            Label Lbl_ScoreDigit = new Label();
            Lbl_ScoreDigit.Text = "" + score;
            Lbl_ScoreDigit.Location = new Point((xPos + 275), (yPos - 4));
            Lbl_ScoreDigit.Size = new Size(25, 20);
            Lbl_ScoreDigit.ForeColor = Color.White;
            panel.Controls.Add(Lbl_ScoreDigit);

            for (int i = 0; i < score; i++)
            {
                PictureBox PicBox = new PictureBox();
                PicBox.Location = new Point((xPos + 100), yPos);
                PicBox.Image = Image.FromFile("img/score/score_background_white.png");
                PicBox.Size = new Size(15, 10);
                PicBox.SizeMode = PictureBoxSizeMode.CenterImage;
                panel.Controls.Add(PicBox);
                xPos += 17;
            }
            for (int i = score; i < 10; i++)
            {
                PictureBox PicBox = new PictureBox();
                PicBox.Location = new Point((xPos + 100), yPos);
                PicBox.Image = Image.FromFile("img/score/score_background_gray.png");
                PicBox.Size = new Size(15, 10);
                PicBox.SizeMode = PictureBoxSizeMode.CenterImage;
                panel.Controls.Add(PicBox);
                xPos += 17;
            }
        }

    }
}
