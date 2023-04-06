using CommunityToolkit.Maui.Converters;
using System.Globalization;


namespace BreakfastApp.Converters
{
    internal class DateTimeToTimeConverter : BaseConverter<object, string>
    {
        public override string DefaultConvertReturnValue { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public override object DefaultConvertBackReturnValue { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public override object ConvertBackTo(string value, CultureInfo culture)
        {
            throw new NotImplementedException();
        }

        public override string ConvertFrom(object value, CultureInfo culture)
        {
            DateTime  dateTime = (DateTime)value;

            return TimeOnly.FromDateTime(dateTime).ToShortTimeString();  // is defined in the styles reource dictionary
        }
    }
}
