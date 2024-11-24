using Packt.Shared; // To use Address.

int thisCannotBeNull = 4;
//thisCannotBeNull = null; // CS0037 compile error!
WriteLine(thisCannotBeNull);

int? thisCouldBeNull = null;

WriteLine(thisCouldBeNull);
WriteLine(thisCouldBeNull.GetValueOrDefault());

thisCouldBeNull = 7;

WriteLine(thisCouldBeNull);
WriteLine(thisCouldBeNull.GetValueOrDefault());

// The actual type of int? isNUllable<int>.
Nullable<int> thisCouldAlsoBeNull = null;
thisCouldBeNull = 9;
WriteLine(thisCouldBeNull);

Address address = new(city: "London")
{
    Building = null,
    Street = null!, // null-forgiving operator
    Region = "UK"
};

WriteLine(address.Building?.Length);
if( address.Street is not null)
{
    WriteLine(address.Street.Length);
}

WriteLine(address.City);
