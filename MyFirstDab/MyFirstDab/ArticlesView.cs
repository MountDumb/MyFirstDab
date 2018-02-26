using MyFirstDab.Model;
using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace MyFirstDab
{
    class ArticlesView : ContentPage
    {
        public ArticlesView()
        {
            Title = "EAL Mobile";
            var ListView = new ListView();

            var textCell = new DataTemplate(typeof(TextCell));
            textCell.SetBinding(TextCell.TextProperty, "Title");
            textCell.SetBinding(TextCell.DetailProperty, "Author");
            ListView.ItemTemplate = textCell;
            ListView.ItemsSource = DataService.GetArticles();

            ListView.ItemSelected += ListView_ItemSelected;
            Content = ListView;
        }

        private void ListView_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            if (e.SelectedItem == null) return;
            var page = new ArticlesContentPage() { Article = e.SelectedItem as Article };
            Navigation.PushAsync(page, true);

            var listView = sender as ListView;
            listView.SelectedItem = null;
        }
    }
}
