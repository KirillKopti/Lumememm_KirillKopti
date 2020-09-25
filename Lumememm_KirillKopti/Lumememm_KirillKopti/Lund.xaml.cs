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
            head = new BoxView { Color = Color.White, CornerRadius = 50 };
            AbsoluteLayout.SetLayoutBounds(head, new Rectangle(0.1, 0.2, 200, 99));
            AbsoluteLayout.SetLayoutFlags(head, AbsoluteLayoutFlags.All);
            abs.Children.Add(head);
            Content = abs;

            body = new BoxView { Color = Color.Yellow, CornerRadius = 60 };
            AbsoluteLayout.SetLayoutBounds(head, new Rectangle(0.4, 0.3, 200, 200));
            AbsoluteLayout.SetLayoutFlags(head, AbsoluteLayoutFlags.All);
            abs.Children.Add(body);
            Content = abs;

            legs = new BoxView { Color = Color.Green, CornerRadius = 70 };
            AbsoluteLayout.SetLayoutBounds(head, new Rectangle(0.3, 0.4, 200, 300));
            AbsoluteLayout.SetLayoutFlags(head, AbsoluteLayoutFlags.All);
            abs.Children.Add(legs);
            Content = abs;
        }
    }
}
//}