Write("Enter a number between 0 and 255:");
string? firstInput = ReadLine();

Write("Enter another number between 0 and 255:");
string? secondInput = ReadLine();

try
{
    byte x = Convert.ToByte(firstInput);
    byte y = Convert.ToByte(secondInput);
    WriteLine($"{x} divided by {y} is {x / y}");
}
catch (OverflowException ex)
{
    WriteLine($"Input string can be converted into a number but it exceeds the range [0, 255]");
}
catch (FormatException ex)
{
    WriteLine($"Input string cannot be converted into a number from the range [0, 255]");
}
catch (Exception ex)
{
    WriteLine($"{ex.GetType()} says {ex.Message}");
}
