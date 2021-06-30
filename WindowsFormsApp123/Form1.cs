using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;
using System.Media;

namespace WindowsFormsApp123
{
    public partial class Form1 : Form
    {
        private Timer timer = new Timer();
        public Form1()
        {
            InitializeComponent();
            timer.Interval = 5;
            timer.Tick += Timer_Tick;
            timer.Start();
            this.panel1.BackColor = Color.Aqua;
            //var time1 = new DateTime(2021,5,1,8,20,32);
            
            //DateTime dateTime = new DateTime();
            //this.label1.Text = dateTime.Now.ToShortTimeString.ToString();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            label1.Text = $"{DateTime.Now.Hour.ToString()} : {DateTime.Now.Minute.ToString()}";
        }
    }
}
