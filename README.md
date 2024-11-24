# MaskCardNumber
Package for masking a given card number

## Usage
### Masks the card number
string maskedCardNumber = CardNumber.MaskCardNumber("5555666677778884", 4, 8, '*');

"5555666677778884" => Card number to mask \n
4 => Start position of mask \n
8 => Length of the mask \n
'*' => Mask character to replace the card numbers \n
