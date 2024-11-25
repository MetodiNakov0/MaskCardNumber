namespace CardNumber;

public static class CardNumber
{
    private const string ArgumentExceptionStartPositionError = "Start position is greater than string length";
    private const string ArgumentExceptionMaskLengthError = "Mask length is greater than string length";
    private const string ArgumentExceptionTooManyCharactersError = "Start position and mask length imply more characters than are present";

    /// <summary>
    /// Masks the card number.
    /// </summary>
    /// <param name="source">Card number to mask</param>
    /// <param name="start">Start position of mask</param>
    /// <param name="maskLength">Length of the mask</param>
    /// <param name="maskCharacter">Mask character to replace the card numbers</param>
    /// <returns>Masked card number</returns>
    public static string MaskCardNumber(string? source, int start, int maskLength, char maskCharacter)
    {
        if (source == null || string.IsNullOrWhiteSpace(source))
        {
            return string.Empty;
        }
        if (start > source.Length - 1)
        {
            throw new ArgumentException(ArgumentExceptionStartPositionError);
        }
        if (maskLength > source.Length)
        {
            throw new ArgumentException(ArgumentExceptionMaskLengthError);
        }
        if (start + maskLength > source.Length)
        {
            throw new ArgumentException(ArgumentExceptionTooManyCharactersError);
        }
        
        string mask = new string(maskCharacter, maskLength);
        string unMaskStart = source.Substring(0, start);
        string unMaskEnd = source.Substring(start + maskLength);
        return unMaskStart + mask + unMaskEnd;
    }
}