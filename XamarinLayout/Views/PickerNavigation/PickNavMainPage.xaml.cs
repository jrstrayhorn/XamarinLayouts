using System;
using System.Collections.Generic;

using Xamarin.Forms;
using XamarinLayout.Models;

namespace XamarinLayout.Views.PickerNavigation
{
    public partial class PickNavMainPage : ContentPage
    {
        public PickNavMainPage()
        {
            InitializeComponent();
        }

        void Handle_Tapped(object sender, System.EventArgs e)
        {
            var page = new ContactMethodsPage();
            page.ContactMethods.ItemSelected += (source, args) =>
            {
                var selectedMethod = ((ContactMethod)args.SelectedItem);
                contactMethodId.Text = selectedMethod.Id.ToString();
                contactMethod.Text = selectedMethod.Name;   // $"{selectedMethod.Id} - {selectedMethod.Name}";
                Navigation.PopAsync();
            };

            Navigation.PushAsync(page);
        }

        void Handle_Clicked(object sender, System.EventArgs e)
        {
            DisplayAlert("Form Data", $"Id: {contactMethodId.Text} Name: {contactMethod.Text}", "OK");
        }
    }
}
