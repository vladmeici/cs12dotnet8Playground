int x = 0;
while (x < 10)
{
    WriteLine(x);
    x++;
}

string? actualPassword = "Pa$$w0rd";
string? password;
const uint maxAttemps = 3;
uint currentAttemp = 0;

do
{
    currentAttemp++;
    Write("Enter your password: ");
    password = ReadLine();
}
while (password != actualPassword && currentAttemp < maxAttemps);

if (password == actualPassword)
{
    WriteLine("Correct!");
}
else
{
    WriteLine($"Incorrect! Max {maxAttemps} attempts reached!");
}

for (int y = 1; y <= 10; y++)
{
    WriteLine(y);
}

for (int y = 0; y <= 10; y += 3)
{
    WriteLine(y);
}

string[] names = { "Adam", "Barry", "Charlie" };

foreach (string name in names)
{
    WriteLine($"{name} has {name.Length} characters.");
}