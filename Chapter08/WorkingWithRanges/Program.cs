string name = "Samantha Jones";

// Getting the Lengths of the first and Last names.
int lengthOfFirst = name.IndexOf(' ');
int lengthOfLast = name.Length - lengthOfFirst - 1;

// Using Substring.
string firstName = name.Substring(0, lengthOfFirst);

string lastName = name.Substring(name.Length - lengthOfLast, lengthOfLast);

WriteLine($"First: {firstName}, Last: {lastName}");

// Using spans.
ReadOnlySpan<char> nameSpan = name.AsSpan();
ReadOnlySpan<char> firstNameSpan = nameSpan[0..lengthOfFirst];
ReadOnlySpan<char> lastNameSpan = nameSpan[^lengthOfLast..];

WriteLine($"First: {firstNameSpan}, Last: {lastNameSpan}");