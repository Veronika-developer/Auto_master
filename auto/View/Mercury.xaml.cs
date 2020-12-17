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
    public partial class Mercury : ContentPage
    {
        public Mercury()
        {
            InitializeComponent();
        }

        private void modelMercury_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (modelMercury.Items[modelMercury.SelectedIndex] == "Mercury Town Sedan")
            {
                PhotosMercury.Source = "Mercury_Town_Sedan_1947.jpg";
            }
            else if (modelMercury.Items[modelMercury.SelectedIndex] == "Mercury Colony Park")
            {
                PhotosMercury.Source = "mercury-colony-park.jpg";
            }
        }
    }
}