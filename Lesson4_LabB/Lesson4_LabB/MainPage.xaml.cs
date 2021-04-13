using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Lesson4_LabB
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        async void ToNextPage(System.Object sender, System.EventArgs e)
        {
            await Navigation.PushAsync(new MeterPage());
        }
    }
}
