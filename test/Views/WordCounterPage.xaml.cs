using System;
using System.Collections.Generic;

using Xamarin.Forms;
using test.ViewModels;
using Rg.Plugins.Popup.Services;

namespace test.Views
{
    public partial class WordCounterPage : ContentPage
    {
        public WordCounterPage()
        {
            InitializeComponent();

            BindingContext = new ViewModels.WordCounterViewModel();
        }

        private async void Button_Clicked(System.Object sender, System.EventArgs e)
        {
            await PopupNavigation.Instance.PushAsync(new popup.IntroductionPopup());
        }
    }
}
