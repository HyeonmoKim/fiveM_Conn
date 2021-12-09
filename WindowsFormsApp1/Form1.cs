using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // fivem://connect/cfx.re/join/5poe46
            System.Diagnostics.Process.Start("IExplore", "fivem://connect/cfx.re/join/5poe46");
            Close();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            
        }
    }
}
