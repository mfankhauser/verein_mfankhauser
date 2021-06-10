using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace Verein.ViewModels
{
    public class MainPageViewModel : BaseViewModel
    {

        private string _title = "Title";

        public string Title
        {
            get => _title; 
            set => SetProperty(ref _title, value); 
        }

        private Command _changeTitleCommand = null;
        public Command ChangeTitleCommand
        {
            get
            {
                return _changeTitleCommand ?? 
                    (_changeTitleCommand = new Command (() =>
                    {
                        this.Title = "Tester";
                    }
                ));
            }
        }


    }
}
