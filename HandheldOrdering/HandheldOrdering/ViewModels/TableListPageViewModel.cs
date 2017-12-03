using HandheldOrdering.Models;
using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace HandheldOrdering.ViewModels
{

    public class TableListPageViewModel : INotifyPropertyChanged, INavigationAware
    {
        public event PropertyChangedEventHandler PropertyChanged;

        private readonly INavigationService _navigationService;

        public ObservableCollection<TableDto> AvailableTableList { get; set; }
            = new ObservableCollection<TableDto>();

        public ObservableCollection<TableSectionDto> AvailableTableSectionList { get; set; }
            = new ObservableCollection<TableSectionDto>();

        public DelegateCommand TableTappedCommand { get; set; }

        public DelegateCommand LogoutCommand { get; set; }

        public DelegateCommand TableSectionChangedCommand { get; set; }



        public TableDto SelectedTable { get; set; }

        public TableSectionDto SelectedTableSection { get; set; }

        public TableListPageViewModel(INavigationService navigationService)
        {
            _navigationService = navigationService;

            TableTappedCommand = new DelegateCommand(async() =>
            {
                Console.WriteLine(SelectedTable.TableCode);
                SelectedTable.IsSelected = true;
                await _navigationService.NavigateAsync("OrderPage");
                SelectedTable.IsSelected = false;
            });

            TableSectionChangedCommand = new DelegateCommand(() =>
            {
                if(SelectedTableSection != null)
                {
                    AvailableTableList = Helpers.SampleDataHelper.GenSampleTableList(SelectedTableSection?.TableSectionId);
                }
            });

            LogoutCommand = new DelegateCommand(async () =>
            {
                try
                {
                    await _navigationService.NavigateAsync("xf:///NavigationPage/LoginPage");
                }
                catch(Exception ex)
                {

                }
                
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
            // generate the testing data
            AvailableTableSectionList = Helpers.SampleDataHelper.GenSampleTableSectionList();
            if (AvailableTableSectionList != null && AvailableTableSectionList.Count() > 0)
            {
                if (SelectedTableSection == null)
                {
                    SelectedTableSection = AvailableTableSectionList.First();
                }
            }
            
            AvailableTableList = Helpers.SampleDataHelper.GenSampleTableList(SelectedTableSection?.TableSectionId);
        }

    }

}
