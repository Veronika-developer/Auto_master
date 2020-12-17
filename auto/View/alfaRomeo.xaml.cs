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
    public partial class alfaRomeo : ContentPage
    {
        public alfaRomeo()
        {
            InitializeComponent(); 
        }

        private void modelAlfaRomeo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (modelAlfaRomeo.Items[modelAlfaRomeo.SelectedIndex] == "Alfa Romeo Giulia")
            {
                PhotosAlfaRomeo.Source = "alfaRomeoGiulia.jpg";
            }
            else if (modelAlfaRomeo.Items[modelAlfaRomeo.SelectedIndex] == "Alfa Romeo Stelvio")
            {
                PhotosAlfaRomeo.Source = "alfaRomeoStelvio.jpg";
            }
            else if (modelAlfaRomeo.Items[modelAlfaRomeo.SelectedIndex] == "Alfa Romeo 159")
            {
                PhotosAlfaRomeo.Source = "alfaRomeo159.jpg";
            }
            else if (modelAlfaRomeo.Items[modelAlfaRomeo.SelectedIndex] == "Alfa Romeo 4C")
            {
                PhotosAlfaRomeo.Source = "alfaRomeo4C.jpg";
            }
        }
    }
}