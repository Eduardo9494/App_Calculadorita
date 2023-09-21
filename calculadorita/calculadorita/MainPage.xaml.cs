using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace calculadorita
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void BtnOne_Clicked(object sender, EventArgs e)
        {
            LblResult.Text = "1";

        }
        private void BtnCommon_Clicked(object sender, EventArgs e)
        {
            var button=sender as Button;
            if(LblResult.Text=="0")
            {
                LblResult.Text = button.Text;
            }
            else
            {
                LblResult.Text += button.Text;
            }

        }

        private void BtnClear_Clicked(object sender, EventArgs e)
        {
            LblResult.Text = "0";

        }
    }
}
