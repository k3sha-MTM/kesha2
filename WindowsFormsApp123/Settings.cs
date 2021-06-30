using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp123
{
    public partial class Settings : Form
    {
        public Settings()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using ColorDialog colorDialog = new ColorDialog();
            {
                if (colorDialog.ShowDialog() == DialogResult.OK)
                {
                    this.BackColor = colorDialog.Color; 
                }
                    
            }
        }
    }
}
