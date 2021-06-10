using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Verein.ViewModels;
using Xamarin.Forms;

namespace Verein
{
    public partial class MainPage : ContentPage
    {
        MainPageViewModel viewModel;

        public MainPage()
        {
            InitializeComponent();
            this.BindingContext = viewModel = new MainPageViewModel();
        }
    }
}
