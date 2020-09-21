using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Lumememm_KirillKopti
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Lumememmm : ContentPage
    {
        public Lumememmm()
        {
            InitializeComponent();
        }

        private void on_Clicked(object sender, EventArgs e)
        {

            hat.Opacity = 1;
            hat2.Opacity = 1;
            head.Opacity = 1;
            body.Opacity = 1;
            legs.Opacity = 1;

        }

        private void off_Clicked(object sender, EventArgs e)
        {

            hat.Opacity = 1;
            hat2.Opacity = 1;
            head.Opacity = 1;
            body.Opacity = 1;
            legs.Opacity = 1;

        }

        private void Random_Clicked(object sender, EventArgs e)
        {

            int r = rnd.Next(0, 255);
            int g = rnd.Next(0, 255);
            int b = rnd.Next(0, 255);
            hat.BackgroundColor = new Color(r, g, b);
             r = rnd.Next(0, 255);
             g = rnd.Next(0, 255);
             b = rnd.Next(0, 255);
            hat2.BackgroundColor = Color.FromRgb(r, g, b);
            r = rnd.Next(0, 255);
            g = rnd.Next(0, 255);
            b = rnd.Next(0, 255);
            head.BackgroundColor = Color.FromRgb(r, g, b);
            r = rnd.Next(0, 255);
            g = rnd.Next(0, 255);
            b = rnd.Next(0, 255);
            body.BackgroundColor = Color.FromRgb(r, g, b);
            r = rnd.Next(0, 255);
            g = rnd.Next(0, 255);
            b = rnd.Next(0, 255);
            legs.BackgroundColor = Color.FromRgb(r, g, b);

        }

        private void Oma_Clicked(object sender, EventArgs e)
        {

        }

        private void Sulama_Clicked(object sender, EventArgs e)
        {

        }

    }
}