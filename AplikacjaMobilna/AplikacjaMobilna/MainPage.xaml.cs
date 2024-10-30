using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace AplikacjaMobilna
{
    public partial class MainPage : ContentPage
    {
        string[] s = { "Dzień dobry", "Good morning", "Buenos dias" };
        int quoteIndex = 0;
        public MainPage()
        {
            InitializeComponent();
            quote.Text = s[quoteIndex];
        }

        private void ChangeQuoteClick(object sender, EventArgs e)
        {
            if(quoteIndex == 2)
            {
                quoteIndex = 0;
                quote.Text = s[quoteIndex];
            }
            else
            {
                quote.Text = s[++quoteIndex];
            }
        }
    }
}
