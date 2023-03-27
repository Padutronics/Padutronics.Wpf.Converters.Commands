using Padutronics.Commands;
using Padutronics.Commands.Adapters.System.Windows.Input;
using System;
using System.Globalization;
using System.Windows.Data;

namespace Padutronics.Wpf.Converters.Commands;

[ValueConversion(sourceType: typeof(ICommand), targetType: typeof(System.Windows.Input.ICommand))]
public sealed class CommandConverter : IValueConverter
{
    public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
    {
        return new CommandToCommandAdapter((ICommand)value);
    }

    public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
    {
        return Binding.DoNothing;
    }
}