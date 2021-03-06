﻿using System;
using System.Data;
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
            if (inputEditor.Text == "0" || resultEditor.Text != "")
            {
                inputEditor.Text = button.Text;
                if (resultEditor.Text != "")
                {
                    resultEditor.Text = "";
                }
            } else { 
                inputEditor.Text += button.Text;
            }
        }

        private void onSymbolButtonClicked(object sender, EventArgs args)
        {
            Button button = (Button)sender;
            
            if (button.Text == ",")
            {
                inputEditor.Text += ".";
            }
            else
            {
                inputEditor.Text += button.Text;
            }
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

        private void onClearButtonClicked(object sender, EventArgs args)
        {
            inputEditor.Text = "0";
            resultEditor.Text = "";
        }

        private void onResultButtonClicked(object sender, EventArgs args)
        {   
            try
            {
                decimal result = Convert.ToDecimal(new DataTable().Compute(inputEditor.Text, null));
                resultEditor.Text = Math.Round(result, 4).ToString();
            } catch {
                resultEditor.Text = "Syntax Error";
            }
        }
    }
}
