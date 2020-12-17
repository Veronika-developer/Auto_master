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
    public partial class AstonMartin : ContentPage
    {
        public AstonMartin()
        {
            InitializeComponent();
        }

        private void modelAstonMartin_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (modelAstonMartin.Items[modelAstonMartin.SelectedIndex] == "Aston Martin DB9 Volante")
            {
                PhotosAstonMartin.Source = "volante.jpg";
            }
            else if (modelAstonMartin.Items[modelAstonMartin.SelectedIndex] == "Aston Martin DB11")
            {
                PhotosAstonMartin.Source = "db11.jpg";
            }
            else if (modelAstonMartin.Items[modelAstonMartin.SelectedIndex] == "Aston Martin DBX")
            {
                PhotosAstonMartin.Source = "dbx.jpg";
            }
        }
    }
}