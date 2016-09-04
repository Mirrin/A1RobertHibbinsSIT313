﻿
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace HibbinzA2.Data.Views
{
    public class shopTrackPage : ContentPage
    {
        public shopTrackPage()
        {
            this.SetBinding(ContentPage.TitleProperty, "Name");

            NavigationPage.SetHasNavigationBar(this, true);
            var nameLabel = new Label { Text = "Name" };
            var nameEntry = new Entry();

            nameEntry.SetBinding(Entry.TextProperty, "Name");

            var notesLabel = new Label { Text = "Notes" };
            var notesEntry = new Entry();
            notesEntry.SetBinding(Entry.TextProperty, "Notes");

            var doneLabel = new Label { Text = "Done" };
            var doneEntry = new Xamarin.Forms.Switch();
            doneEntry.SetBinding(Xamarin.Forms.Switch.IsToggledProperty, "Done");

            var saveButton = new Button { Text = "Save" };
            saveButton.Clicked += (sender, e) => {
                var todoItem = (shopTrackPage)BindingContext;
                App.Database.SaveItem(todoItem);
                Navigation.PopAsync();
            };

            var deleteButton = new Button { Text = "Delete" };
            deleteButton.Clicked += (sender, e) => {
                var todoItem = (shopTrackPage)BindingContext;
                App.Database.DeleteItem(todoItem.ID);
                Navigation.PopAsync();
            };

            var cancelButton = new Button { Text = "Cancel" };
            cancelButton.Clicked += (sender, e) => {
                var todoItem = (shopTrackPage)BindingContext;
                Navigation.PopAsync();
            };


            var speakButton = new Button { Text = "Speak" };
            speakButton.Clicked += (sender, e) => {
                var todoItem = (shopTrackPage)BindingContext;
                DependencyService.Get<ITextToSpeech>().Speak(todoItem.Name + " " + todoItem.Notes);
            };

            Content = new StackLayout
            {
                VerticalOptions = LayoutOptions.StartAndExpand,
                Padding = new Thickness(20),
                Children = {
                    nameLabel, nameEntry,
                    notesLabel, notesEntry,
                    doneLabel, doneEntry,
                    saveButton, deleteButton, cancelButton,
                    speakButton
                }
            };
        }
    }
}