using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace ButenkoLOGITpv19
{
    public partial class MainPage : ContentPage
    {
        private object isVisible;

        public MainPage()
        {
            InitializeComponent();
        }

        public object Yellow { get; private set; }
        public object Green { get; private set; }

        private async void On_Clicked(object sender, EventArgs e)
        {
            bool vkl = true;
            while (vkl != false)
            {
                h.BackgroundColor = Color.Red;
                b.BackgroundColor = Color.Aqua;
                f.BackgroundColor = Color.Aqua;
                await Task.Run(() => System.Threading.Thread.Sleep(15));
                for (int i = 0; i < 3; i++)
                {
                    h.BackgroundColor = Color.Black;
                    b.BackgroundColor = Color.Red;
                    f.BackgroundColor = Color.Aqua;
                    await Task.Run(() => System.Threading.Thread.Sleep(15));
                }

                h.BackgroundColor = Color.Black;
                b.BackgroundColor = Color.Aqua;
                f.BackgroundColor = Color.Red;
                await Task.Run(() => System.Threading.Thread.Sleep(15));
            }

            private void off_Clicked(object sender, EventArgs e)
            {
                h.BackgroundColor = isVisible;
                b.BackgroundColor = isVisible;
                fBackgroundColor = isVisible;
                vkl = false;


            }
        }
    }
}



