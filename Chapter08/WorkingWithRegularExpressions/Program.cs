﻿using System.Text.RegularExpressions; // To use Regex.

Write("Enter your age: ");
string input = ReadLine()!; // Null-forgiving operator.
Regex ageChecker = DigitsOnly();
WriteLine(ageChecker.IsMatch(input) ? "Thank you!" : $"This is not a valid age: {input}");

// C# 1 to 10: Use escaped double-quotes characters \"
// string films = "\"Monsters, Inc.\",\"I, Tonya\",\"Lock, Stock and Two Smoking Barrels\"";

// C# 11 or later: Use """ to start and end a raw string literal
string films = """
"Monsters, Inc.","I, Tonya","Lock, Stock and Two Smoking Barrels"
""";

WriteLine($"Films to split: {films}");

string[] filmsDumb = films.Split(',');

WriteLine("Splitting with string.Split method:");
foreach (string film in filmsDumb)
{
    WriteLine($"    {film}");
}

Regex csv = CommaSeparator();

MatchCollection filmSmart = csv.Matches(films);

WriteLine("Splitting with regular expression:");
foreach (Match film in filmSmart)
{
    WriteLine($"    {film.Groups[2].Value}");
}