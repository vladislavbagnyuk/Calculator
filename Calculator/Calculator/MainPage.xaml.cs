using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace Calculator
{
    public partial class MainPage : ContentPage
    {

        public MainPage()
        {
            InitializeComponent();
        }

        private void onNumberButtonClicked(object sender, EventArgs args)
        {
            Button button = (Button)sender;
            if (inputEditor.Text == "0")
            {
                inputEditor.Text = button.Text;
            }
            inputEditor.Text += button.Text;
        }

        private void onBackspaceButtonClicked(object sender, EventArgs args)
        {
            string s = inputEditor.Text;
            if (s.Length > 1)
            {
                s = s.Substring(0, s.Length - 1);
            }
            else
            {
                s = "0";
            }
            inputEditor.Text = s;
        }

        private void onBackspaceLongPress()
        {
            inputEditor.Text = "0";
        }
    }
}
