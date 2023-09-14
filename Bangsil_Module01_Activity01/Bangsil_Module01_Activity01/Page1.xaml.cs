using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Bangsil_Module01_Activity01
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Page1 : ContentPage
    {
        public Page1()
        {
            InitializeComponent();
        }
        private void OpenMainPage(object sender, EventArgs e)
        {
            Navigation.PopAsync();
        }
        private async void OpenPage2(object sender, EventArgs e)
        {
            Navigation.PopAsync();
            await Navigation.PushAsync(new Page2());
        }
    }
}