using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Lumememm_KirillKopti
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Lund : ContentPage
    {
        BoxView head, body, legs;
        public Lund()
        {
            AbsoluteLayout abs = new AbsoluteLayout();
            head = new BoxView { Color = Color.Blue, CornerRadius = 80 };
            AbsoluteLayout.SetLayoutBounds(head, new Rectangle(0.5, 0.1, 100, 100));
            AbsoluteLayout.SetLayoutFlags(head, AbsoluteLayoutFlags.PositionProportional);
            abs.Children.Add(head);
            Content = abs;

            body = new BoxView { Color = Color.Blue, CornerRadius = 80 };
            AbsoluteLayout.SetLayoutBounds(body, new Rectangle(0.5, 0.3, 150, 150));
            AbsoluteLayout.SetLayoutFlags(body, AbsoluteLayoutFlags.PositionProportional);
            abs.Children.Add(body);
            Content = abs;

            legs = new BoxView { Color = Color.Blue, CornerRadius = 100 };
            AbsoluteLayout.SetLayoutBounds(legs, new Rectangle(0.5, 0.7, 200, 200));
            AbsoluteLayout.SetLayoutFlags(legs, AbsoluteLayoutFlags.PositionProportional);
            abs.Children.Add(legs);
            Content = abs;

            head = new Button { Text = "head" };
            head.Clicked += Btn1_Clicked;
            AbsoluteLayout.SetLayoutBounds(head, new Rectangle(0.1, 0.2, 100, 100));
            AbsoluteLayout.SetLayoutFlags(head, AbsoluteLayoutFlags.PositionProportional);
            abs.Children.Add(head);
            Content = abs;
        }
        bool flag = true;
        private void Btn1_Clicked(object sender, EventArgs e)
        {
            if (flag)
            {
                head.Opacity = 0;
                flag = false;
            }
            else
            {
                head.Opacity = 1;
                flag = true;
            }
        }
    }
}
//}