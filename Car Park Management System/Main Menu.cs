using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Car_Park_Management_System
{
    public partial class frmmainmenu : Form
    {
        public frmmainmenu()
        {
            InitializeComponent();
        }

        private void btnsystem_click(object sender, EventArgs e)
        {
            frmsystem from = new frmsystem();
            from.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Report from = new Report();
            from.Show();
            this.Hide();
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            adminpanel form = new adminpanel();
            form.Show();
            this.Hide();
        }
    }
}
