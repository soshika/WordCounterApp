using System;
using System.Collections.Generic;

using Xamarin.Forms;
using test.ViewModels;

namespace test.Views
{
    public partial class WordCounterPage : ContentPage
    {
        public WordCounterPage()
        {
            InitializeComponent();

            BindingContext = new ViewModels.WordCounterViewModel();
        }
    }
}
