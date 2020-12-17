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
    public partial class mercedes : ContentPage
    {
        public mercedes()
        {
            InitializeComponent();
        }

        private void modelMercedes_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (modelMercedes.Items[modelMercedes.SelectedIndex] == "Mercedes-AMG GT 4")
            {
                PhotosMercedes.Source = "Mercedes-AMGGT4.jpeg";
            }
            else if (modelMercedes.Items[modelMercedes.SelectedIndex] == "G‑Класс внедорожник")
            {
                PhotosMercedes.Source = "mercedesGelik.jpg";
            }
            else if (modelMercedes.Items[modelMercedes.SelectedIndex] == "Mercedes‑AMG GT купе")
            {
                PhotosMercedes.Source = "Mercedes-AMG-GT.jpg";
            }
            else if (modelMercedes.Items[modelMercedes.SelectedIndex] == "CLS купе")
            {
                PhotosMercedes.Source = "CLSkupeMercedes.jpg";
            }
        }
    }
}