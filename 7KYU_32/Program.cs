//Description:

//ATM machines allow 4 or 6 digit PIN codes and PIN codes cannot contain anything but exactly 4 digits or exactly 6 digits.

//If the function is passed a valid PIN string, return true, else return false.
//Examples (Input --> Output)

//"1234"   -->  true
//"12345"  -->  false
//"a234"   -->  false

using System.Text.RegularExpressions;

Console.WriteLine(ValidatePin("1234"));
Console.WriteLine(ValidatePin("123456"));
Console.WriteLine(ValidatePin("12345"));

static bool ValidatePin(string pin)
{
    var newPin= Regex.Escape(pin);
    return Regex.IsMatch(newPin, @"^\d{4}$|^\d{6}$");
}

Console.ReadLine();