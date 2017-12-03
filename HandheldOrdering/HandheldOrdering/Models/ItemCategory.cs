using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace HandheldOrdering.Models
{
    public class ItemCategory : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
        public int DisplayIndex { get; set; }
        public bool IsTerminal { get; set; }
        public string DisplayColorCode { get; set; }
        public int? ParentCategoryId { get; set; }
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
                    if (IsDarkTheme)
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
