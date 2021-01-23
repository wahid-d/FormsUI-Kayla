using System;
using System.Collections.Generic;
using formsUI.Models;
using Xamarin.Forms;

namespace formsUI.Views
{
    public partial class Home : ContentPage
    {
        public Home()
        {
            InitializeComponent();
        }

        void TapGestureRecognizer_Tapped(System.Object sender, System.EventArgs e)
        {
            Navigation.PushAsync(new Cards());

        }
        protected override void OnAppearing()
        {
            base.OnAppearing();

            var transactionList = new List<Transaction>()
            {
                new Transaction() { Type = TransactionType.Sent, Amount = 25, Note = "This money was sent to charity." },
                new Transaction() { Type = TransactionType.Loan, Amount = 125, Note = "This money was sent to charity." },
                new Transaction() { Type = TransactionType.Received, Amount = 45.3799, Note = "This money was sent to charity." },
                new Transaction() { Type = TransactionType.Sent, Amount = 25, Note = "This money was sent to charity." },
                new Transaction() { Type = TransactionType.Savings, Amount = 25, Note = "This money was sent to charity." },
                new Transaction() { Type = TransactionType.Received, Amount = 25, Note = "This money was sent to charity." }
            };

            transactions.ItemsSource = transactionList;
        }
    }
}
