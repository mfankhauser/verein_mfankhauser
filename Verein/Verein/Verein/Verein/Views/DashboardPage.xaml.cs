using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Verein.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Verein.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class DashboardPage : ContentPage
    {
        DashboardPageViewModel viewModel;

        public DashboardPage()
        {
            InitializeComponent();
            this.BindingContext = viewModel =
                new DashboardPageViewModel();
        }
    }
}