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