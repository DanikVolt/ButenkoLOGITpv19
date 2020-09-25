using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ButenkoLOGITpv19
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Page1 : ContentPage
    {
        BoxView pea, keha, keha2, keha3, kamen, glaz1, glaz2, gl, sh;
        public Page1()
        {
            AbsoluteLayout abs = new AbsoluteLayout();
            //голова
            pea = new BoxView { Color = Color.Gold, CornerRadius = 100 };
            AbsoluteLayout.SetLayoutBounds(pea, new Rectangle(0.5, 0.3, 70, 70)); ;
            AbsoluteLayout.SetLayoutFlags(pea, AbsoluteLayoutFlags.PositionProportional);
            abs.Children.Add(pea);
            //тело

            keha = new BoxView { Color = Color.Gold, CornerRadius = 100 };
            AbsoluteLayout.SetLayoutBounds(keha, new Rectangle(0.5, 0.4, 90, 90));
            AbsoluteLayout.SetLayoutFlags(keha, AbsoluteLayoutFlags.PositionProportional);
            abs.Children.Add(keha);

            keha2 = new BoxView { Color = Color.Gold, CornerRadius = 100 };
            AbsoluteLayout.SetLayoutBounds(keha2, new Rectangle(0.5, 0.5, 110, 110));
            AbsoluteLayout.SetLayoutFlags(keha2, AbsoluteLayoutFlags.PositionProportional);
            abs.Children.Add(keha2);

            keha3 = new BoxView { Color = Color.Red, CornerRadius = 0 };
            AbsoluteLayout.SetLayoutBounds(keha3, new Rectangle(0.5, 0.2, 50, 50));
            AbsoluteLayout.SetLayoutFlags(keha3, AbsoluteLayoutFlags.PositionProportional);
            abs.Children.Add(keha3);

            kamen = new BoxView { Color = Color.DarkBlue, CornerRadius = 0 };
            AbsoluteLayout.SetLayoutBounds(kamen, new Rectangle(0.5, 0.2, 10, 10));
            AbsoluteLayout.SetLayoutFlags(kamen, AbsoluteLayoutFlags.PositionProportional);
            abs.Children.Add(kamen);

            glaz1 = new BoxView { Color = Color.Red, CornerRadius = 90};
            AbsoluteLayout.SetLayoutBounds(glaz1, new Rectangle(0.45, 0.3, 10, 10));
            AbsoluteLayout.SetLayoutFlags(glaz1, AbsoluteLayoutFlags.PositionProportional);
            abs.Children.Add(glaz1);

            glaz2 = new BoxView { Color = Color.Red, CornerRadius = 90};
            AbsoluteLayout.SetLayoutBounds(glaz2, new Rectangle(0.55, 0.3, 10, 10));
            AbsoluteLayout.SetLayoutFlags(glaz2, AbsoluteLayoutFlags.PositionProportional);
            abs.Children.Add(glaz2);

            gl = new BoxView { Color = Color.Black, CornerRadius = 0};
            AbsoluteLayout.SetLayoutBounds(gl, new Rectangle(0.5, 0.35, 10, 10));
            AbsoluteLayout.SetLayoutFlags(gl, AbsoluteLayoutFlags.PositionProportional);
            abs.Children.Add(gl);

            sh = new BoxView { Color = Color.Red, CornerRadius = 30};
            AbsoluteLayout.SetLayoutBounds(sh, new Rectangle(0.5, 0.25, 60, 15));
            AbsoluteLayout.SetLayoutFlags(sh, AbsoluteLayoutFlags.PositionProportional);
            abs.Children.Add(sh);

            Content = abs;
        }
    }
}