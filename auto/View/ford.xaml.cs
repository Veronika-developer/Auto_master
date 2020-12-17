using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace masterAutod.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ford : ContentPage
    {
        public ford()
        {
            InitializeComponent();
        }

        private void modelFord_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (modelFord.Items[modelFord.SelectedIndex] == "Ford Ranger")
            {
                PhotosFord.Source = "fordRanger.jpg";
            }
            else if (modelFord.Items[modelFord.SelectedIndex] == "Ford Mustang")
            {
                PhotosFord.Source = "fordMustang.jpg";
            }
            else if (modelFord.Items[modelFord.SelectedIndex] == "Ford Fiesta")
            {
                PhotosFord.Source = "fordFiesta.jpg";
            }
            else if (modelFord.Items[modelFord.SelectedIndex] == "Ford Focus")
            {
                PhotosFord.Source = "fordFocus.jpg";
            }
        }
    }
}