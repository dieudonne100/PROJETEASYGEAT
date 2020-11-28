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

namespace ProgressBarTest
{
    public
        partial class Form1 : Form
    {
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn(
            int nLeftRect,
            int nTopRect,
            int RightRect,
            int nBottomRect,
            int nWidthEllipse,
            int nHeighEllipse
            );
        public Form1()
        {
            InitializeComponent();
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 25, 25));
            bunifuCircleProgressbar1.Value = 0;
        }

       

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void timer_Tick(object sender, EventArgs e)
        {
            bunifuCircleProgressbar1.Value += 1;
            bunifuCircleProgressbar1.Text = bunifuCircleProgressbar1.ToString() + "%";
            if (bunifuCircleProgressbar1.Value == 100)
            {
                timer.Enabled = false;
                FormConnexion form = new FormConnexion();
                form.Show();
                this.Hide();

            }
            
        }
    }
}
