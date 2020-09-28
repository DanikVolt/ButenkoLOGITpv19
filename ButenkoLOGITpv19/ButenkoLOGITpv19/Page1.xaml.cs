using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ButenkoLOGITpv19
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Page1 : ContentPage
    {
        BoxView pea, keha, keha2, keha3, kamen, glaz1, glaz2, gl, sh, r, r1;
        Button b1, b2;
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

            r = new BoxView { Color = Color.Black, CornerRadius = 10 };
            AbsoluteLayout.SetLayoutBounds(r, new Rectangle(0.25, 0.4, 65, 10));
            AbsoluteLayout.SetLayoutFlags(r, AbsoluteLayoutFlags.PositionProportional);
            abs.Children.Add(r);

            r1 = new BoxView { Color = Color.Black, CornerRadius = 10 };
            AbsoluteLayout.SetLayoutBounds(r1, new Rectangle(0.75, 0.4, 65, 10));
            AbsoluteLayout.SetLayoutFlags(r1, AbsoluteLayoutFlags.PositionProportional);
            abs.Children.Add(r1);

            b1 = new Button {Text="Холоп"};
            b1.Clicked += B1_Clicked;
            AbsoluteLayout.SetLayoutBounds(b1, new Rectangle(0.3, 0.8, 70, 50));
            AbsoluteLayout.SetLayoutFlags(b1, AbsoluteLayoutFlags.PositionProportional);
            abs.Children.Add(b1);
            b2 = new Button { Text = "Таять" };
            b2.Clicked += B2_Clicked;
            AbsoluteLayout.SetLayoutBounds(b2, new Rectangle(0.7, 0.8, 70, 50));
            AbsoluteLayout.SetLayoutFlags(b2, AbsoluteLayoutFlags.PositionProportional);
            abs.Children.Add(b2);

            Content = abs;
        }

        private async void B2_Clicked(object sender, EventArgs e)

        {
            if (flag)
            {
                pea.Opacity = 0;
                glaz1.Opacity = 0;
                glaz2.Opacity = 0;
                gl.Opacity = 0;
                keha3.Opacity = 0;
                kamen.Opacity = 0;
                sh.Opacity = 0;
                keha.BackgroundColor = Color.Gold;
                keha2.BackgroundColor = Color.Gold;
                await Task.Run(() => System.Threading.Thread.Sleep(300));
                r1.Opacity = 0;
                r.Opacity = 0;
                pea.Opacity = 0;
                keha.Opacity = 0;
                keha2.BackgroundColor = Color.Gold;
                await Task.Run(() => System.Threading.Thread.Sleep(300));
                pea.Opacity = 0;
                keha.Opacity = 0;
                keha2.Opacity = 0;
                await Task.Run(() => System.Threading.Thread.Sleep(300));


            }

        }

        bool flag = true;
        private void B1_Clicked(object sender, EventArgs e)

        {
            if (flag)
            {
                pea.Color = Color.White;
                keha.Color = Color.White;
                keha2.Color = Color.White;
                sh.Color = Color.Black;
                keha3.Color = Color.Black;
                kamen.Color = Color.Black;
                glaz1.Color = Color.Black;
                glaz2.Color = Color.Black;
                flag = false;

            }

            else
            {
                pea.Color = Color.Gold;
                keha.Color = Color.Gold;
                keha2.Color = Color.Gold;
                sh.Color = Color.Red;
                keha3.Color = Color.Red;
                kamen.Color = Color.DarkBlue;
                glaz1.Color = Color.Red;
                glaz2.Color = Color.Red;
                flag = true;

            }

        }

 

        



    }

}