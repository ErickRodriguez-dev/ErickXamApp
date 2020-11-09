using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ErickApps.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CalculatorView : ContentView
    {
        public CalculatorView()
        {
            InitializeComponent();
            buttonsListeners();
        }

        public void buttonsListeners()
        {
            BtnOne.Clicked += (sender, e) => txExpression.Text = "1";
            BtnTwo.Clicked += (sender, e) => txExpression.Text = "2";
            BtnThree.Clicked += (sender, e) => txExpression.Text = "3";
            BtnFour.Clicked += (sender, e) => txExpression.Text = "4";
            BtnFive.Clicked += (sender, e) => txExpression.Text = "5";
            BtnSix.Clicked += (sender, e) => txExpression.Text = "6";
            BtnSeven.Clicked += (sender, e) => txExpression.Text = "7";
            BtnEight.Clicked += (sender, e) => txExpression.Text = "8";
            BtnNine.Clicked += (sender, e) => txExpression.Text = "9";
            BtnBack.Clicked += (sender, e) => txExpression.Text = "";
            BtnPlus.Clicked += (sender, e) => txExpression.Text = "+";
            BtnTimes.Clicked += (sender, e) => txExpression.Text = "";
           
        }
    }
}