using System;
using System.Collections.Generic;

using Xamarin.Forms;
using XamarinLayout.Models;

namespace XamarinLayout.Views.PickerNavigation
{
    public partial class ContactMethodsPage : ContentPage
    {
        public ContactMethodsPage()
        {
            InitializeComponent();

            listView.ItemsSource = new List<ContactMethod>()
            {
                new ContactMethod() {
                    Id = 1,
                    Name = "None"
                },
                new ContactMethod() {
                    Id = 2,
                    Name = "Email"
                },
                new ContactMethod() {
                    Id = 3,
                    Name = "SMS"
                }
            };
        }

        public ListView ContactMethods { get { return listView; }}
    }
}
