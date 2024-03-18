using System.Globalization; // To use CultureInfo.

// TimesTable(7, 20);

ConfigureConsole();

decimal taxToPay = CalculateTax(149, "fr-FR");
// WriteLine($"You must pay {taxToPay:C} in tax.");

// Alternatively, call the function in the interpolated string.
// WriteLine($"You must pay {CalculateTax(149, "FR"):C} in tax.");

// RunCardinalToOrdinal();

// RunFactorial();

// RunFibImperative();

RunFibFunctional();