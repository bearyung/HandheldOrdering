using HandheldOrdering.ViewModels;
using System;
using Xamarin.Forms;

namespace HandheldOrdering.Views
{
    public partial class TableListPage : ContentPage
    {
        public TableListPage()
        {
            InitializeComponent();
        }

        protected override bool OnBackButtonPressed()
        {
            return true;
        }

        private void OnTableSectionPickerSelectedIndexChanged(object sender, EventArgs args)
        {
            (BindingContext as TableListPageViewModel).TableSectionChangedCommand.Execute();
        }
    }
}
