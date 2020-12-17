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
    public partial class buggati : ContentPage
    {
        public buggati()
        {
            InitializeComponent();
        }

        private void modelBugatti_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (modelBugatti.Items[modelBugatti.SelectedIndex] == "Bugatti One Off")
            {
                PhotosBugatti.Source = "bugattiOneOff.jpg";
            }
            else if (modelBugatti.Items[modelBugatti.SelectedIndex] == "Bugatti Bolide")
            {
                PhotosBugatti.Source = "bugattiBolide.jpg";
            }
            else if (modelBugatti.Items[modelBugatti.SelectedIndex] == "Bugatti Veyron")
            {
                PhotosBugatti.Source = "bugattiVeyron.jpg";
            }
            else if (modelBugatti.Items[modelBugatti.SelectedIndex] == "Bugatti Chiron")
            {
                PhotosBugatti.Source = "buggatiChiron.jpg";
            }
        }
    }
}