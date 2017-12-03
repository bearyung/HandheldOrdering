using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;

namespace HandheldOrdering.ViewModels
{

    public class LoginPageViewModel : INotifyPropertyChanged, INavigationAware
    {

        public event PropertyChangedEventHandler PropertyChanged;

        private readonly INavigationService _navigationService;

        public DelegateCommand LoginCommand { get; set; }

        public LoginPageViewModel(INavigationService navigationService)
        {
            _navigationService = navigationService;

            LoginCommand = new DelegateCommand(async() =>
            {
                await _navigationService.NavigateAsync("ew:///NavigationPage/TableListPage");
            });

        }

        public void OnNavigatedFrom(NavigationParameters parameters)
        {

        }

        public void OnNavigatingTo(NavigationParameters parameters)
        {

        }

        public void OnNavigatedTo(NavigationParameters parameters)
        {

        }

    }

}
