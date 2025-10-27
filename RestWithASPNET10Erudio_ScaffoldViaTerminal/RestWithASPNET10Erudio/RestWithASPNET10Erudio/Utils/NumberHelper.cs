namespace RestWithASPNET10Erudio.Utils;

public class NumberHelper
{
    public static decimal ConvertToDecimal(string strNumber)
    {
        decimal decimalValue;
        if (
            decimal.TryParse(
                strNumber, 
                System.Globalization.NumberStyles.Any,
                System.Globalization.NumberFormatInfo.InvariantInfo,
                out decimalValue))
        {
            return decimalValue;
        }

        return 0;
    }

    public static bool IsNumeric(string strNumber)
    {
        decimal decimalValue = 0;
        bool isNumber = decimal.TryParse(
            strNumber,
            System.Globalization.NumberStyles.Any,
            System.Globalization.NumberFormatInfo.InvariantInfo,
            out decimalValue
        );
        return isNumber;
    }
}