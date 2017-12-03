using HandheldOrdering.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace HandheldOrdering.Helpers
{
    public static class SampleDataHelper
    {
        public static ObservableCollection<TableDto> GenSampleTableList(int? inputTableSectionId)
        {
            ObservableCollection<TableDto> resultList = new ObservableCollection<TableDto>();
            if (resultList == null)
            {
                resultList = new ObservableCollection<TableDto>();
            }
            else
            {
                resultList.Clear();

                List<TableDto> allTableList = new List<TableDto>();

                // gen the sample data
                allTableList.Add(new TableDto { TableSectionId = 1, TableId = 1, TableCode = "01" });
                allTableList.Add(new TableDto { TableSectionId = 1, TableId = 2, TableCode = "02" });
                allTableList.Add(new TableDto { TableSectionId = 1, TableId = 3, TableCode = "03" });
                allTableList.Add(new TableDto { TableSectionId = 1, TableId = 4, TableCode = "04" });
                allTableList.Add(new TableDto { TableSectionId = 1, TableId = 5, TableCode = "05" });
                allTableList.Add(new TableDto { TableSectionId = 1, TableId = 6, TableCode = "06" });
                allTableList.Add(new TableDto { TableSectionId = 1, TableId = 7, TableCode = "07" });
                allTableList.Add(new TableDto { TableSectionId = 1, TableId = 8, TableCode = "08" });
                allTableList.Add(new TableDto { TableSectionId = 1, TableId = 9, TableCode = "09" });
                allTableList.Add(new TableDto { TableSectionId = 1, TableId = 10, TableCode = "10", DisplayColorCode = "#006699", IsDarkTheme = true });
                allTableList.Add(new TableDto { TableSectionId = 1, TableId = 11, TableCode = "11" });
                allTableList.Add(new TableDto { TableSectionId = 1, TableId = 12, TableCode = "12" });
                allTableList.Add(new TableDto { TableSectionId = 1, TableId = 13, TableCode = "13", DisplayColorCode = "#006699", IsDarkTheme = true });
                allTableList.Add(new TableDto { TableSectionId = 1, TableId = 14, TableCode = "14", DisplayColorCode = "#006699", IsDarkTheme = true });
                allTableList.Add(new TableDto { TableSectionId = 1, TableId = 15, TableCode = "15", DisplayColorCode = "#006699", IsDarkTheme = true });
                allTableList.Add(new TableDto { TableSectionId = 1, TableId = 16, TableCode = "16" });
                allTableList.Add(new TableDto { TableSectionId = 1, TableId = 17, TableCode = "17" });
                allTableList.Add(new TableDto { TableSectionId = 1, TableId = 18, TableCode = "18" });
                allTableList.Add(new TableDto { TableSectionId = 1, TableId = 19, TableCode = "19" });
                allTableList.Add(new TableDto { TableSectionId = 1, TableId = 20, TableCode = "20" });
                allTableList.Add(new TableDto { TableSectionId = 1, TableId = 21, TableCode = "21" });
                allTableList.Add(new TableDto { TableSectionId = 1, TableId = 22, TableCode = "22" });
                allTableList.Add(new TableDto { TableSectionId = 1, TableId = 23, TableCode = "23", DisplayColorCode = "#006699", IsDarkTheme = true });
                allTableList.Add(new TableDto { TableSectionId = 1, TableId = 24, TableCode = "24", DisplayColorCode = "#006699", IsDarkTheme = true });
                allTableList.Add(new TableDto { TableSectionId = 1, TableId = 25, TableCode = "25", DisplayColorCode = "#006699", IsDarkTheme = true });
                allTableList.Add(new TableDto { TableSectionId = 1, TableId = 26, TableCode = "26" });
                allTableList.Add(new TableDto { TableSectionId = 1, TableId = 27, TableCode = "27" });
                allTableList.Add(new TableDto { TableSectionId = 1, TableId = 28, TableCode = "28" });
                allTableList.Add(new TableDto { TableSectionId = 1, TableId = 29, TableCode = "29" });
                allTableList.Add(new TableDto { TableSectionId = 1, TableId = 30, TableCode = "30" });
                allTableList.Add(new TableDto { TableSectionId = 1, TableId = 31, TableCode = "31" });
                allTableList.Add(new TableDto { TableSectionId = 1, TableId = 32, TableCode = "32" });
                allTableList.Add(new TableDto { TableSectionId = 1, TableId = 33, TableCode = "33", DisplayColorCode = "#006699", IsDarkTheme = true });
                allTableList.Add(new TableDto { TableSectionId = 1, TableId = 34, TableCode = "34", DisplayColorCode = "#006699", IsDarkTheme = true });
                allTableList.Add(new TableDto { TableSectionId = 1, TableId = 35, TableCode = "35", DisplayColorCode = "#006699", IsDarkTheme = true });
                allTableList.Add(new TableDto { TableSectionId = 1, TableId = 36, TableCode = "36" });
                allTableList.Add(new TableDto { TableSectionId = 1, TableId = 37, TableCode = "37" });
                allTableList.Add(new TableDto { TableSectionId = 1, TableId = 38, TableCode = "38" });
                allTableList.Add(new TableDto { TableSectionId = 1, TableId = 39, TableCode = "39" });
                allTableList.Add(new TableDto { TableSectionId = 1, TableId = 40, TableCode = "40" });
                allTableList.Add(new TableDto { TableSectionId = 1, TableId = 41, TableCode = "41" });
                allTableList.Add(new TableDto { TableSectionId = 1, TableId = 42, TableCode = "42" });
                allTableList.Add(new TableDto { TableSectionId = 1, TableId = 43, TableCode = "43", DisplayColorCode = "#006699", IsDarkTheme = true });
                allTableList.Add(new TableDto { TableSectionId = 1, TableId = 44, TableCode = "44", DisplayColorCode = "#006699", IsDarkTheme = true });
                allTableList.Add(new TableDto { TableSectionId = 1, TableId = 45, TableCode = "45", DisplayColorCode = "#006699", IsDarkTheme = true });
                allTableList.Add(new TableDto { TableSectionId = 1, TableId = 46, TableCode = "46" });
                allTableList.Add(new TableDto { TableSectionId = 1, TableId = 47, TableCode = "47" });
                allTableList.Add(new TableDto { TableSectionId = 1, TableId = 48, TableCode = "48" });
                allTableList.Add(new TableDto { TableSectionId = 1, TableId = 49, TableCode = "49" });
                allTableList.Add(new TableDto { TableSectionId = 2, TableId = 40, TableCode = "50" });
                allTableList.Add(new TableDto { TableSectionId = 2, TableId = 41, TableCode = "51" });
                allTableList.Add(new TableDto { TableSectionId = 2, TableId = 42, TableCode = "52" });
                allTableList.Add(new TableDto { TableSectionId = 2, TableId = 43, TableCode = "53", DisplayColorCode = "#006699", IsDarkTheme = true });
                allTableList.Add(new TableDto { TableSectionId = 2, TableId = 44, TableCode = "54", DisplayColorCode = "#006699", IsDarkTheme = true });
                allTableList.Add(new TableDto { TableSectionId = 2, TableId = 45, TableCode = "55", DisplayColorCode = "#006699", IsDarkTheme = true });
                allTableList.Add(new TableDto { TableSectionId = 2, TableId = 46, TableCode = "56" });
                allTableList.Add(new TableDto { TableSectionId = 2, TableId = 47, TableCode = "57" });
                allTableList.Add(new TableDto { TableSectionId = 2, TableId = 48, TableCode = "58" });
                allTableList.Add(new TableDto { TableSectionId = 2, TableId = 49, TableCode = "59" });
                allTableList.Add(new TableDto { TableSectionId = 3, TableId = 40, TableCode = "60" });
                allTableList.Add(new TableDto { TableSectionId = 3, TableId = 41, TableCode = "61" });
                allTableList.Add(new TableDto { TableSectionId = 3, TableId = 42, TableCode = "62" });
                allTableList.Add(new TableDto { TableSectionId = 3, TableId = 43, TableCode = "63", DisplayColorCode = "#006699", IsDarkTheme = true });
                allTableList.Add(new TableDto { TableSectionId = 3, TableId = 44, TableCode = "64", DisplayColorCode = "#006699", IsDarkTheme = true });
                allTableList.Add(new TableDto { TableSectionId = 3, TableId = 45, TableCode = "65", DisplayColorCode = "#006699", IsDarkTheme = true });
                allTableList.Add(new TableDto { TableSectionId = 3, TableId = 46, TableCode = "66" });
                allTableList.Add(new TableDto { TableSectionId = 3, TableId = 47, TableCode = "67" });
                allTableList.Add(new TableDto { TableSectionId = 3, TableId = 48, TableCode = "68" });
                allTableList.Add(new TableDto { TableSectionId = 3, TableId = 49, TableCode = "69" });

                if(inputTableSectionId != null)
                {
                    resultList = new ObservableCollection<TableDto>( allTableList.FindAll(x => x.TableSectionId == (inputTableSectionId ?? 0)));
                }
                else
                {
                    resultList = new ObservableCollection<TableDto>(allTableList);
                }
            }

            return resultList;
        }

        public static ObservableCollection<TableSectionDto> GenSampleTableSectionList()
        {
            ObservableCollection<TableSectionDto> resultList = new ObservableCollection<TableSectionDto>();

            resultList.Add(new TableSectionDto { TableSectionId = 1, TableSectionName = "地下" });
            resultList.Add(new TableSectionDto { TableSectionId = 2, TableSectionName = "一樓" });
            resultList.Add(new TableSectionDto { TableSectionId = 3, TableSectionName = "戶外" });

            return resultList;
        }

        public static ObservableCollection<ItemCategory> GenSampleItemCategoryList(int? inputParentCategoryId)
        {
            ObservableCollection<ItemCategory> AllCategoryList = new ObservableCollection<ItemCategory>();
            ObservableCollection<ItemCategory> resultList = new ObservableCollection<ItemCategory>();
            AllCategoryList.Add(new ItemCategory { CategoryId = 1, CategoryName = "早餐", DisplayIndex = 1, IsTerminal = true });
            AllCategoryList.Add(new ItemCategory { CategoryId = 2, CategoryName = "午餐", DisplayIndex = 1, IsTerminal = true });
            AllCategoryList.Add(new ItemCategory { CategoryId = 3, CategoryName = "常餐", DisplayIndex = 1, IsTerminal = true });
            AllCategoryList.Add(new ItemCategory { CategoryId = 4, CategoryName = "下午茶餐", DisplayIndex = 1, IsTerminal = true });
            AllCategoryList.Add(new ItemCategory { CategoryId = 5, CategoryName = "特餐", DisplayIndex = 1, IsTerminal = true });
            AllCategoryList.Add(new ItemCategory { CategoryId = 6, CategoryName = "晚餐", DisplayIndex = 1, IsTerminal = true });
            AllCategoryList.Add(new ItemCategory { CategoryId = 7, CategoryName = "飲品", DisplayIndex = 1, IsTerminal = true });
            AllCategoryList.Add(new ItemCategory { CategoryId = 8, CategoryName = "冷餐", DisplayIndex = 1, IsTerminal = true });
            AllCategoryList.Add(new ItemCategory { CategoryId = 9, CategoryName = "熱餐", DisplayIndex = 1, IsTerminal = true });
            AllCategoryList.Add(new ItemCategory { CategoryId = 10, CategoryName = "特餐", DisplayIndex = 1, IsTerminal = true });
            AllCategoryList.Add(new ItemCategory { CategoryId = 11, CategoryName = "中式炒粉麵飯", DisplayIndex = 1, IsTerminal = true });
            AllCategoryList.Add(new ItemCategory { CategoryId = 12, CategoryName = "鑊氣小炒", DisplayIndex = 1, IsTerminal = true });
            AllCategoryList.Add(new ItemCategory { CategoryId = 13, CategoryName = "馳名咖哩", DisplayIndex = 1, IsTerminal = true });
            AllCategoryList.Add(new ItemCategory { CategoryId = 14, CategoryName = "即叫即蒸", DisplayIndex = 1, IsTerminal = true });
            AllCategoryList.Add(new ItemCategory { CategoryId = 15, CategoryName = "晚市套餐", DisplayIndex = 1, IsTerminal = true });

            return resultList;
        }
    }
}
