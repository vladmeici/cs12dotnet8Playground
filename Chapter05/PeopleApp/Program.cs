using Packt.Shared; //To use Person.

ConfigureConsole(); // Sets current culture to US English.

// Alternatives:
// ConfigureConsole(useComputerCulture: true); // Use your culture.
// ConfigureConsole(culture: "fr-FR"); // Use French culture.

// Person bob = new Person(); C# 1 or later.
// var bob = new Person(); C# 3 or later.

Person bob = new(); // C# 9 or later.
WriteLine(bob); // Implicit call to ToString().
// WriteLine(bob.ToString()); // Does the same thing.

bob.Name = "Bob Smith";

bob.Born = new DateTimeOffset(1965, 12, 22, 16, 28, 0, TimeSpan.FromHours(-5)); // US Eastern Standard Time.
bob.FavoriteAncientWonder = WondersOfTheAncientWorld.StatueOfZeusAtOlympia;
bob.BucketList = WondersOfTheAncientWorld.HangingGardensOfBabylon | WondersOfTheAncientWorld.MausoleumAtHalicarnassus;

// bob.BucketList = (WondersOfTheAncientWorld)18;

WriteLine("{0} was born on {1:D}.", bob.Name, bob.Born);
WriteLine("{0}'s favorite wonder is {1}. Its integer is {2}.", bob.Name, bob.FavoriteAncientWonder, (int)bob.FavoriteAncientWonder);
WriteLine($"{bob.Name}'s bucket list is {bob.BucketList}");

Person alice = new()
{
    Name = "Alice Jones",
    Born = new(1998, 3, 7, 16, 28, 0,
    //This is an optional offset fomr UTC time zone.
    TimeSpan.Zero)
};

WriteLine("{0} was born on {1:d}.", alice.Name, alice.Born);

// Works with all versions of C#.
Person alfred = new Person();
alfred.Name = "Alfred";
bob.Children.Add(alfred);

// Works with C# 3 and later.
bob.Children.Add(new Person { Name = "Bella" });

// Works with C# 9 and later.
bob.Children.Add(new() { Name = "Zoe" });

WriteLine($"{bob.Name} has {bob.Children.Count} children:");
for (int childIndex = 0; childIndex < bob.Children.Count; childIndex++)
{
    WriteLine($"> {bob.Children[childIndex].Name}");
}

BankAccount.InterestRate = 0.012M; // Store a shared value in static field.

BankAccount jonesAccount = new();
jonesAccount.AccountName = "Mrs. Jones";
jonesAccount.Balance = 2400;
WriteLine("{0} earned {1:C} interest.", jonesAccount.AccountName, jonesAccount.Balance * BankAccount.InterestRate);

BankAccount gerrierAccount = new();
gerrierAccount.AccountName = "Mrs. Gerrier";
gerrierAccount.Balance = 98;
WriteLine("{0} earned {1:C} interest.", gerrierAccount.AccountName, gerrierAccount.Balance * BankAccount.InterestRate);

// Constant fields are accesible via the type.
WriteLine($"{bob.Name} is a {Person.Species}.");

// Read-only fields are accessible via the variable.
WriteLine($"{bob.Name} was born on {bob.HomePlanet}.");

/*
Book book = new()
{
    Isbn = "978-1803237800",
    Title = "C# 12 and .NET 8 - Modern Cross-Platform Development Fundamentals"
};
*/

Book book = new("978-1803237800", "C# 12 and .NET 8 - Modern Cross-Platform Development Fundamentals")
{
    Author = "Mark J. Price",
    PageCount = 821
};

WriteLine("{0}: {1} written by {2} has {3:N0} pages.", book.Isbn, book.Title, book.Author, book.PageCount);

Person blankPerson = new();

WriteLine("{0} of {1} was created at {2:hh:mm:ss} on a {2:dddd}.", blankPerson.Name, blankPerson.HomePlanet, blankPerson.Instantiated);

Person gunny = new("Guny", "Mars");

WriteLine("{0} of {1} was created at {2:hh.mm.ss} on a {2:dddd}", gunny.Name, gunny.HomePlanet, gunny.Instantiated);

bob.WriteToConsole();
WriteLine(bob.GetOrigin());

WriteLine(bob.SayHello());
WriteLine(bob.SayHelloTo("Emily"));
