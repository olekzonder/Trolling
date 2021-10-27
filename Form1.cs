using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Trolling
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.button1.MouseHover += button1_MouseHover;
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }
        int _x = 650;
        int _y = 160;
        Random rnd = new Random();
        Point tmp_location;

        int _w = System.Windows.Forms.SystemInformation.PrimaryMonitorSize.Width - 100;
        int _h = System.Windows.Forms.SystemInformation.PrimaryMonitorSize.Height / 2;

        private void button1_MouseHover(object sender, EventArgs e)
        {
            Random rand = new Random();
            _x += rand.Next(-200,200);
            _y += rand.Next(-50,50);
            _w += rand.Next(-250, 250);
            _h += rand.Next(-250, 250);
            //Чтобы кнопки не улетали
            _x = Math.Abs(_x % 650);
            _y = Math.Abs(_y % 160);
            _w = Math.Abs(_w % (System.Windows.Forms.SystemInformation.PrimaryMonitorSize.Width-100));
            _h = Math.Abs(_h % (System.Windows.Forms.SystemInformation.PrimaryMonitorSize.Height/2));
            button1.Location = new Point(_x, _y);
            this.Location = new Point(_w, _h);
        }
        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("А ты усердный");
            Application.Exit();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Ну и правильно", "Верный выбор", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Application.Exit();
        }
    }
}
