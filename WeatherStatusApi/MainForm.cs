using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WeatherStatusApi.Entities;

namespace WeatherStatusApi
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void Start_btn_Click(object sender, EventArgs e)
        {
            Request.GetCity(TempOutput_Tb.Text);
            TempOutput_Tb.Text = "12.9";
        }


        private void button3_Click(object sender, EventArgs e)
        {

        }
        private void AddTolList_btn_Click(object sender, EventArgs e)
        {

        }
        


        private void City_textBox_TextChanged(object sender, EventArgs e)
        {

        }








        private void stop_btn_Click(object sender, EventArgs e)
        {

        }

     
    }
}
