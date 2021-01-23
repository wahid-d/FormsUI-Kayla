using System;
using System.Globalization;
using formsUI.Models;
using Xamarin.Forms;

namespace formsUI.Converters
{
    public class TransactionToIconConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            var transactionType = (TransactionType)value;

            switch (transactionType)
            {
                case TransactionType.Sent:
                    return "\uf062";
                case TransactionType.Received:
                    return "\uf063";
                case TransactionType.Loan:
                    return "\uf155";
                case TransactionType.Savings:
                    return "\uf382";
                default:
                    return "\uf31e";
            }
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return TransactionType.Sent;
        }
    }
}
