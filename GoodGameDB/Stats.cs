using System.Data;
using System.Runtime.InteropServices;

namespace GoodGameDB
{
    public partial class Stats : Form
    {
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;
        string query = "";
        DataTable table;
        int year1, year2, year3, year4, year5;
        int year1_count, year2_count, year3_count, year4_count, year5_count, total_count, tota_unique_count;
        int gold_count, silver_count, bronze_count;
        DateTime currentYear;

        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();
        public Stats()
        {
            InitializeComponent();
            year1 = DateTime.Now.Year;
            year2 = year1 - 1;
            year3 = year2 - 1;  
            year4 = year3 - 1;
            year5 = year4 - 1;
            lbl_year1.Text = "" + year1;
            lbl_year2.Text = "" + year2;
            lbl_year1.Text = "" + year3;
            lbl_year2.Text = "" + year4;
            lbl_year1.Text = "" + year5;
            query = "SELECT id, games.name, date, location, note, score, replay, " +
                    "s_id, score_values.name, gameplay, presentation, narrative, quality, sound, content, pacing, balance, impression, total " +
                    "FROM games " +
                    "INNER JOIN score_values " +
                    "ON games.score = score_values.s_id " +
                    "ORDER BY date ASC";
            table = ConnectDB.CreateDataTable(query);   

            foreach (DataRow item in table.Rows)
            {

                if (item[2].ToString().Contains(Convert.ToString(year1)))
                {
                    year1_count++;
                }
                if (item[2].ToString().Contains(Convert.ToString(year2)))
                {
                    year2_count++;
                }
                if (item[2].ToString().Contains(Convert.ToString(year3)))
                {
                    year3_count++;
                }
                if (item[2].ToString().Contains(Convert.ToString(year4)))
                {
                    year4_count++;
                }
                if (item[2].ToString().Contains(Convert.ToString(year5)))
                {
                    year5_count++;
                }
                if (Convert.ToInt32(item[18]) >= 85 && Convert.ToInt32(item[18]) < 90)
                {
                    bronze_count++;
                }
                if (Convert.ToInt32(item[18]) >= 90 && Convert.ToInt32(item[18]) < 95)
                {
                    silver_count++;
                }
                if (Convert.ToInt32(item[18]) >= 95)
                {
                    gold_count++;
                }


                lbl_year1cnt.Text = year1_count + " games finished";
                lbl_year2cnt.Text = year2_count + " games finished";
                lbl_year3cnt.Text = year3_count + " games finished";
                lbl_year4cnt.Text = year4_count + " games finished";
                lbl_year5cnt.Text = year5_count + " games finished";
                lbl_GoldTotal.Text = gold_count + " medals";
                lbl_SilverTotal.Text = silver_count + " medals";
                lbl_BronzeTotal.Text = bronze_count + " medals";
            }
        }

        private void Btn_ClosePopUp_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void Panel_BorderTop_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }
    }
}
