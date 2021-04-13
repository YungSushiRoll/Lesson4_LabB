using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Lesson4_LabB
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MeterPage : ContentPage
    {
        public MeterPage()
        {
            InitializeComponent();
        }

        private string journal = "";

        private void Button_Clicked(object sender, EventArgs e)
        {
            journal = theWhy.Text;
            theWhy.Text = "";
            theJournal.Text = journal;
        }
    }
}