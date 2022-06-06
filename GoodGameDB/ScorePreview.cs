using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoodGameDB
{
    internal class ScorePreview
    {
        PictureBox sfield1 = new PictureBox();
        PictureBox sfield2 = new PictureBox();
        PictureBox sfield3 = new PictureBox();
        PictureBox sfield4 = new PictureBox();
        PictureBox sfield5 = new PictureBox();
        PictureBox sfield6 = new PictureBox();
        PictureBox sfield7 = new PictureBox();
        PictureBox sfield8 = new PictureBox();
        PictureBox sfield9 = new PictureBox();
        PictureBox sfield10 = new PictureBox();

        PictureBox ScoreBackground = new PictureBox();
        Label ScoreText = new Label();

        //

        string empty = @"img/score/score_background_gray.png";
        string full = @"img/score/score_background_white.png";
        string sgreen = @"img/score/score_background_green.png";
        string syellow = @"img/score/score_background_yellow.png";
        string sorange = @"img/score/score_background_orange.png";
        string sred = @"img/score/score_background_red.png";

        public void Create(int xPos, int yPos, string name, Panel panel)
        {
            Label Lbl_Category = new Label();
            Lbl_Category.Text = name;
            Lbl_Category.Location = new Point(xPos, (yPos - 4));
            Lbl_Category.ForeColor = Color.White;
            panel.Controls.Add(Lbl_Category);

            xPos += 125;

            sfield1.Image = Image.FromFile(full);
            sfield1.Size = new Size(15, 10);
            sfield1.SizeMode = PictureBoxSizeMode.CenterImage;
            sfield1.Location = new Point(xPos, yPos);
            panel.Controls.Add(sfield1);
            xPos += 17;

            sfield2.Image = Image.FromFile(empty);
            sfield2.Size = new Size(15, 10);
            sfield2.SizeMode = PictureBoxSizeMode.CenterImage;
            sfield2.Location = new Point(xPos, yPos);
            panel.Controls.Add(sfield2);
            xPos += 17;

            sfield3.Image = Image.FromFile(empty);
            sfield3.Size = new Size(15, 10);
            sfield3.SizeMode = PictureBoxSizeMode.CenterImage;
            sfield3.Location = new Point(xPos, yPos);
            panel.Controls.Add(sfield3);
            xPos += 17;

            sfield4.Image = Image.FromFile(empty);
            sfield4.Size = new Size(15, 10);
            sfield4.SizeMode = PictureBoxSizeMode.CenterImage;
            sfield4.Location = new Point(xPos, yPos);
            panel.Controls.Add(sfield4);
            xPos += 17;

            sfield5.Image = Image.FromFile(empty);
            sfield5.Size = new Size(15, 10);
            sfield5.SizeMode = PictureBoxSizeMode.CenterImage;
            sfield5.Location = new Point(xPos, yPos);
            panel.Controls.Add(sfield5);
            xPos += 17;

            sfield6.Image = Image.FromFile(empty);
            sfield6.Size = new Size(15, 10);
            sfield6.SizeMode = PictureBoxSizeMode.CenterImage;
            sfield6.Location = new Point(xPos, yPos);
            panel.Controls.Add(sfield6);
            xPos += 17;

            sfield7.Image = Image.FromFile(empty);
            sfield7.Size = new Size(15, 10);
            sfield7.SizeMode = PictureBoxSizeMode.CenterImage;
            sfield7.Location = new Point(xPos, yPos);
            panel.Controls.Add(sfield7);
            xPos += 17;

            sfield8.Image = Image.FromFile(empty);
            sfield8.Size = new Size(15, 10);
            sfield8.SizeMode = PictureBoxSizeMode.CenterImage;
            sfield8.Location = new Point(xPos, yPos);
            panel.Controls.Add(sfield8);
            xPos += 17;

            sfield9.Image = Image.FromFile(empty);
            sfield9.Size = new Size(15, 10);
            sfield9.SizeMode = PictureBoxSizeMode.CenterImage;
            sfield9.Location = new Point(xPos, yPos);
            panel.Controls.Add(sfield9);
            xPos += 17;

            sfield10.Image = Image.FromFile(empty);
            sfield10.Size = new Size(15, 10);
            sfield10.SizeMode = PictureBoxSizeMode.CenterImage;
            sfield10.Location = new Point(xPos, yPos);
            panel.Controls.Add(sfield10);
            xPos += 17;

        }

        public void Update(int value)
        {
            switch (value)
            {
                case 1:
                    sfield1.Image = Image.FromFile(full);
                    sfield2.Image = Image.FromFile(empty);
                    sfield3.Image = Image.FromFile(empty);
                    sfield4.Image = Image.FromFile(empty);
                    sfield5.Image = Image.FromFile(empty);
                    sfield6.Image = Image.FromFile(empty);
                    sfield7.Image = Image.FromFile(empty);
                    sfield8.Image = Image.FromFile(empty);
                    sfield9.Image = Image.FromFile(empty);
                    sfield10.Image = Image.FromFile(empty);
                    break;
                case 2:
                    sfield1.Image = Image.FromFile(full);
                    sfield2.Image = Image.FromFile(full);
                    sfield3.Image = Image.FromFile(empty);
                    sfield4.Image = Image.FromFile(empty);
                    sfield5.Image = Image.FromFile(empty);
                    sfield6.Image = Image.FromFile(empty);
                    sfield7.Image = Image.FromFile(empty);
                    sfield8.Image = Image.FromFile(empty);
                    sfield9.Image = Image.FromFile(empty);
                    sfield10.Image = Image.FromFile(empty);
                    break;
                case 3:
                    sfield1.Image = Image.FromFile(full);
                    sfield2.Image = Image.FromFile(full);
                    sfield3.Image = Image.FromFile(full);
                    sfield4.Image = Image.FromFile(empty);
                    sfield5.Image = Image.FromFile(empty);
                    sfield6.Image = Image.FromFile(empty);
                    sfield7.Image = Image.FromFile(empty);
                    sfield8.Image = Image.FromFile(empty);
                    sfield9.Image = Image.FromFile(empty);
                    sfield10.Image = Image.FromFile(empty);
                    break;
                case 4:
                    sfield1.Image = Image.FromFile(full);
                    sfield2.Image = Image.FromFile(full);
                    sfield3.Image = Image.FromFile(full);
                    sfield4.Image = Image.FromFile(full);
                    sfield5.Image = Image.FromFile(empty);
                    sfield6.Image = Image.FromFile(empty);
                    sfield7.Image = Image.FromFile(empty);
                    sfield8.Image = Image.FromFile(empty);
                    sfield9.Image = Image.FromFile(empty);
                    sfield10.Image = Image.FromFile(empty);
                    break;
                case 5:
                    sfield1.Image = Image.FromFile(full);
                    sfield2.Image = Image.FromFile(full);
                    sfield3.Image = Image.FromFile(full);
                    sfield4.Image = Image.FromFile(full);
                    sfield5.Image = Image.FromFile(full);
                    sfield6.Image = Image.FromFile(empty);
                    sfield7.Image = Image.FromFile(empty);
                    sfield8.Image = Image.FromFile(empty);
                    sfield9.Image = Image.FromFile(empty);
                    sfield10.Image = Image.FromFile(empty);
                    break;
                case 6:
                    sfield1.Image = Image.FromFile(full);
                    sfield2.Image = Image.FromFile(full);
                    sfield3.Image = Image.FromFile(full);
                    sfield4.Image = Image.FromFile(full);
                    sfield5.Image = Image.FromFile(full);
                    sfield6.Image = Image.FromFile(full);
                    sfield7.Image = Image.FromFile(empty);
                    sfield8.Image = Image.FromFile(empty);
                    sfield9.Image = Image.FromFile(empty);
                    sfield10.Image = Image.FromFile(empty);
                    break;
                case 7:
                    sfield1.Image = Image.FromFile(full);
                    sfield2.Image = Image.FromFile(full);
                    sfield3.Image = Image.FromFile(full);
                    sfield4.Image = Image.FromFile(full);
                    sfield5.Image = Image.FromFile(full);
                    sfield6.Image = Image.FromFile(full);
                    sfield7.Image = Image.FromFile(full);
                    sfield8.Image = Image.FromFile(empty);
                    sfield9.Image = Image.FromFile(empty);
                    sfield10.Image = Image.FromFile(empty);
                    break;
                case 8:
                    sfield1.Image = Image.FromFile(full);
                    sfield2.Image = Image.FromFile(full);
                    sfield3.Image = Image.FromFile(full);
                    sfield4.Image = Image.FromFile(full);
                    sfield5.Image = Image.FromFile(full);
                    sfield6.Image = Image.FromFile(full);
                    sfield7.Image = Image.FromFile(full);
                    sfield8.Image = Image.FromFile(full);
                    sfield9.Image = Image.FromFile(empty);
                    sfield10.Image = Image.FromFile(empty);
                    break;
                case 9:
                    sfield1.Image = Image.FromFile(full);
                    sfield2.Image = Image.FromFile(full);
                    sfield3.Image = Image.FromFile(full);
                    sfield4.Image = Image.FromFile(full);
                    sfield5.Image = Image.FromFile(full);
                    sfield6.Image = Image.FromFile(full);
                    sfield7.Image = Image.FromFile(full);
                    sfield8.Image = Image.FromFile(full);
                    sfield9.Image = Image.FromFile(full);
                    sfield10.Image = Image.FromFile(empty);
                    break;
                case 10:
                    sfield1.Image = Image.FromFile(full);
                    sfield2.Image = Image.FromFile(full);
                    sfield3.Image = Image.FromFile(full);
                    sfield4.Image = Image.FromFile(full);
                    sfield5.Image = Image.FromFile(full);
                    sfield6.Image = Image.FromFile(full);
                    sfield7.Image = Image.FromFile(full);
                    sfield8.Image = Image.FromFile(full);
                    sfield9.Image = Image.FromFile(full);
                    sfield10.Image = Image.FromFile(full);
                    break;

            }
        }

        public void SumCreate(int xpos, int ypos, int value, Panel panel)
        {
            ScoreBackground.Location = new Point(xpos, ypos);
            ScoreBackground.Size = new Size(50, 22);
            ScoreBackground.SizeMode = PictureBoxSizeMode.Zoom;
            ScoreBackground.Image = Image.FromFile(sred);

            panel.Controls.Add(ScoreBackground);

            ScoreText.Text = "" + value;
            ScoreText.Location = new Point(8, 1);
            ScoreText.BackColor = Color.Transparent;
            ScoreText.Size = new Size(36, 19);
            ScoreText.ForeColor = Color.FromArgb(32, 33, 36);
            ScoreText.TextAlign = ContentAlignment.MiddleCenter;

            ScoreBackground.Controls.Add(ScoreText);
        }

        public void SumUpdate(int value)
        {
            ScoreText.Text = "" + value;

            if (value >= 80)
            {
                ScoreBackground.Image = Image.FromFile(sgreen);
            }
            else if (value >= 70)
            {
                ScoreBackground.Image = Image.FromFile(syellow);
            }
            else if (value >= 60)
            {
                ScoreBackground.Image = Image.FromFile(sorange);
            }
            else
            {
                ScoreBackground.Image = Image.FromFile(sred);
            }
        }
    }
}
