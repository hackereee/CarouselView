using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Diagnostics;
using System.Windows.Input;
using FFImageLoading.Forms;
using Xamarin.Forms;

namespace Demo
{
    public class MainViewModel
    {


        public interface ListItem { }

        public class ListImage : ListItem {
            public ObservableCollection<string> ImageUrls { get; set; }
        }

        public class ListLabel : ListItem
        {
           public string LabelText { get; set; }
        }

        public ObservableCollection<ListItem> ListItems { get;set; } = new ObservableCollection<ListItem>();

        public MainViewModel()
        {
            List<ListItem> items = new List<ListItem>();
            ListImage listImage = new ListImage();
            listImage.ImageUrls = new ObservableCollection<string>();
            listImage.ImageUrls.Add("file://c1.jpg");
            listImage.ImageUrls.Add("file://c2.jpg");
            listImage.ImageUrls.Add("file://c3.jpg");
            items.Add(listImage);
            initLabelText(20, items);
            ListItems = new ObservableCollection<ListItem>(items);

        }


        private void initLabelText(int containItemCount, List<ListItem> pendingItems) {
            for (int index = 0; index < containItemCount;  ++index) {
                ListLabel listLabel = new ListLabel();
                listLabel.LabelText = "this is label:" + index;
                pendingItems.Add(listLabel);
            }
        }



    }
}
