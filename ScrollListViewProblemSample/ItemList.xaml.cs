using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using Xamarin.Forms;
using ScrollListViewProblemSample.Model;

namespace ScrollListViewProblemSample
{
    public partial class ItemList : ContentPage
    {
        ObservableCollection<ItemListModel> Items = new ObservableCollection<ItemListModel>();

        public ItemList()
        {
            InitializeComponent();

            // ListViewのバインディング
            itemList.ItemsSource = Items;
            for (var i = 0; i < 30; i++)
            {
                var item = new ItemListModel
                {
                    itemName = "item-" + i.ToString()
                };

                Items.Add(item);
            }
        }
    }
}
