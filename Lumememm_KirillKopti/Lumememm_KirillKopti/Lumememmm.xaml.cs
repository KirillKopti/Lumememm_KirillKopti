using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Color = System.Drawing.Color;

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

            hat.Opacity = 0;
            hat2.Opacity = 0;
            head.Opacity = 0;
            body.Opacity = 0;
            legs.Opacity = 0;

        }
        Random rnd = new Random(); 
        private void Random_Clicked(object sender, EventArgs e)
        {

            int r = rnd.Next(0, 255);
            int g = rnd.Next(0, 255);
            int b = rnd.Next(0, 255);
            hat.BackgroundColor = Color.FromArgb(r, g, b);
            r = rnd.Next(0, 255);
            g = rnd.Next(0, 255);
            b = rnd.Next(0, 255);
            hat2.BackgroundColor = Color.FromArgb(r, g, b);
            r = rnd.Next(0, 255);
            g = rnd.Next(0, 255);
            b = rnd.Next(0, 255);
            head.BackgroundColor = Color.FromArgb(r, g, b);
            r = rnd.Next(0, 255);
            g = rnd.Next(0, 255);
            b = rnd.Next(0, 255);
            body.BackgroundColor = Color.FromArgb(r, g, b);
            r = rnd.Next(0, 255);
            g = rnd.Next(0, 255);
            b = rnd.Next(0, 255);
            legs.BackgroundColor = Color.FromArgb(r, g, b);

        }

        private void Oma_Clicked(object sender, EventArgs e)
        {

        }

        private void Sulama_Clicked(object sender, EventArgs e)
        {

        }

    }
}