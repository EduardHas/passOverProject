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

        private async void Start_btn_Click(object sender, EventArgs e)
        {
            var cityName = CityInput_Tb.Text;
            float cityTemp =await Request.GetCity(cityName);
            TempOutput_Tb.Text = cityTemp.ToString();
            

        }


        private  void getTempFromFile_btn_Click(object sender, EventArgs e)
        {
            var cityName = CityInput_Tb.Text;
            float cityTemp = Request.GetCityTempFromFile(cityName);
            TempOutput_Tb.Text = cityTemp.ToString();

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

        private void CityInput_Tb_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void TempOutput_Tb_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
