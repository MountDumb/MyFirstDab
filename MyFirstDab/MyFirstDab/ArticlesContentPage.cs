using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace MyFirstDab
{
    class ArticlesContentPage : ContentPage
    {
        private WebView _webView;

        public Model.Article Article { get; set; }

        public ArticlesContentPage()
        {
            Content = _webView = new WebView();
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            Title = Article.Title;
            _webView.Source = new UrlWebViewSource()
            {
                Url = Article.URL
            };
            
            
        }

        protected override void OnDisappearing()
        {
            _webView.Source = "";
            base.OnDisappearing();
        }


    }
}
