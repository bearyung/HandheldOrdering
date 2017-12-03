using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace HandheldOrdering.Models
{
    public class TableSectionDto : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        public int TableSectionId { get; set; }
        public String TableSectionName { get; set; }

    }
}
