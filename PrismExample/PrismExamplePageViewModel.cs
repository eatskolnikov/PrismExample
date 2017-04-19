using System;
using Prism.Mvvm;
using Prism.Navigation;

namespace PrismExample
{
    public class PrismExamplePageViewModel : BindableBase, INavigationAware
    {
        private INavigationService _navigationService;

        private string _title;
        public string Title
        {
            get { return _title; }
            set { SetProperty(ref _title, value); }
        }

        public PrismExamplePageViewModel(INavigationService navigationService) 
        {
            _navigationService = navigationService;
        }

        public void OnNavigatedFrom(NavigationParameters parameters) { }

        public void OnNavigatedTo(NavigationParameters parameters)
        {
            Title = parameters.GetValue<string>("title");
        }

        public void OnNavigatingTo(NavigationParameters parameters) { }
    }
}
