using System;
using System.Collections.Generic;
using Rg.Plugins.Popup.Pages;
using Rg.Plugins.Popup.Services;
using Xamarin.Forms;

namespace test.Views.popup
{
    public partial class IntroductionPopup : PopupPage
    {
        public IntroductionPopup()
        {
            InitializeComponent();
        }

        private async void Button_Clicked(System.Object sender, System.EventArgs e)
        {
            await PopupNavigation.Instance.PopAllAsync(true);
        }
    }
}
