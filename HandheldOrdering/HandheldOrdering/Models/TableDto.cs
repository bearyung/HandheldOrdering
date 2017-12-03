using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using Xamarin.Forms;

namespace HandheldOrdering.Models
{
    public class TableDto : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        public int TableId { get; set; }
        public string TableCode { get; set; }
        public int TableSectionId { get; set; }
        public string DisplayColorCode { get; set; } = "#F0F0F0";
        public bool IsDarkTheme { get; set; }

        // visual element prop
        public bool IsSelected { get; set; }
        public String FontColor
        {
            get
            {
                if (IsSelected)
                {
                    return "#F0F0F0";
                }
                else
                {
                    if(IsDarkTheme)
                    {
                        return "#F0F0F0";
                    }
                    else
                    {
                        return "#222222";
                    }
                }
                    
            }
        }
        public String BackgroundColor
        {
            get
            {
                if (!IsSelected)
                    return DisplayColorCode;
                else
                    return "#232323";
            }
        }
    }
}
