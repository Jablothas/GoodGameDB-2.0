using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
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
        DateTime current;

        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();
        public Stats()
        {
            InitializeComponent();
            year1 = DateTime.Now.Year;
            query = "SELECT id, games.name, date, location, note, score, replay, " +
                    "s_id, score_values.name, gameplay, presentation, narrative, quality, sound, content, pacing, balance, impression, total " +
                    "FROM games " +
                    "INNER JOIN score_values " +
                    "ON games.score = score_values.s_id " +
                    "ORDER BY date ASC";
            table = ConnectDB.CreateDataTable(query);

            foreach (DataRow item in table.Rows)
            {

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
