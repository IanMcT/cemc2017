using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using Xamarin.Forms;

namespace TempConvert
{
	public partial class MainPage : ContentPage
	{
        Boolean celsiusToFahrenheit = true;
		public MainPage()
		{
			InitializeComponent();
		}

        private void Picker_SelectedIndexChanged(object sender, EventArgs e)
        {
            Picker p = (Picker)sender;
            if (p.SelectedItem.ToString() == "Celsius to Fahrenheit")
            {
                celsiusToFahrenheit = true;
            }
            else
            {
                celsiusToFahrenheit = false;
            }
            Debug.WriteLine(p.SelectedItem);
        }

        private void btnConvert_Clicked(object sender, EventArgs e)
        {
            double temp;

            double.TryParse(entryTemperature.Text, out temp);
            if (celsiusToFahrenheit)
            {
                lblOutput.Text = (temp * 1.8 + 32).ToString() + " degrees Fahrenheit";
            }
            else
            {
                lblOutput.Text = (((temp - 32) * 5) / 9).ToString() + " degrees Celsius";
            }
        }
    }
}
