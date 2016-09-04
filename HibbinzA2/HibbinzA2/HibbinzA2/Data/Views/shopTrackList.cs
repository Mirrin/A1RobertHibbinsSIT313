
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace HibbinzA2.Data.Views
{
    public class shopTrackList : ContentPage
    {
        ListView listView;

        public shopTrackList()
        {
            Title = "List";

            NavigationPage.SetHasNavigationBar(this, true);

            listView = new ListView
            {
                RowHeight = 40,
                ItemTemplate = new DataTemplate(typeof(shopTrackCell))
            };



            listView.ItemSelected += (sender, e) => {
                var todoItem = (ShopTrack)e.SelectedItem;
                var todoPage = new shopTrackPage();
                todoPage.BindingContext = todoItem;
                Navigation.PushAsync(shopTrackPage);
            };

            var layout = new StackLayout();
            if (Device.OS == TargetPlatform.WinPhone)
            { // WinPhone doesn't have the title showing
                layout.Children.Add(new Label
                {
                    Text = "ShopTrack",
                    FontSize = Device.GetNamedSize(NamedSize.Large, typeof(Label)),
                    FontAttributes = FontAttributes.Bold
                });
            }
            layout.Children.Add(listView);
            layout.VerticalOptions = LayoutOptions.FillAndExpand;
            Content = layout;


            ToolbarItem tbi = null;
            if (Device.OS == TargetPlatform.iOS)
            {
                tbi = new ToolbarItem("+", null, () => {
                    var todoItem = new ShopTrack();
                    var todoPage = new shopTrackPage();
                    todoPage.BindingContext = todoItem;
                    Navigation.PushAsync(shopTrackPage);
                }, 0, 0);
            }
            if (Device.OS == TargetPlatform.Android)
            { // BUG: Android doesn't support the icon being null
                tbi = new ToolbarItem("+", "plus", () => {
                    var todoItem = new ShopTrack();
                    var todoPage = new shopTrackPage();
                    todoPage.BindingContext = todoItem;
                    Navigation.PushAsync(shopTrackPage);
                }, 0, 0);
            }

            if (Device.OS == TargetPlatform.WinPhone)
            {
                tbi = new ToolbarItem("Add", "add.png", () => {
                    var todoItem = new ShopTrack();
                    var todoPage = new shopTrackPage();
                    todoPage.BindingContext = todoItem;
                    Navigation.PushAsync(shopTrackPage);
                }, 0, 0);
            }

            ToolbarItems.Add(tbi);

            if (Device.OS == TargetPlatform.iOS)
            {
                var tbi2 = new ToolbarItem("?", null, () => {
                    var Shoptrackz = App.Database.GetItemsNotDone();
                    var tospeak = "";
                    foreach (var t in Shoptrackz)
                        tospeak += t.Name + " ";
                    if (tospeak == "")
                        tospeak = "there are no tasks to do";

                    DependencyService.Get<ITextToSpeech>().Speak(tospeak);
                }, 0, 0);
                ToolbarItems.Add(tbi2);
            }
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            listView.ItemsSource = App.Database.GetItems();
        }
    }
}

