using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace software
{
    public partial class splash : Form
    {
        public splash()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.Close();
        }

        private void splash_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void splash_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
