string rowSeparator = new string('-', count: 104);

WriteLine(rowSeparator);

WriteLine("Type    {0,-4} {1,32} {2,45}", "Byte(s) of memory", "Min", "Max");

WriteLine(rowSeparator);

WriteLine("sbyte   {0,-4} {1,45} {2,45}", sizeof(sbyte), sbyte.MinValue, sbyte.MaxValue);
WriteLine("byte    {0,-4} {1,45} {2,45}", sizeof(byte), byte.MinValue, byte.MaxValue);
WriteLine("short   {0,-4} {1,45} {2,45}", sizeof(short), short.MinValue, short.MaxValue);
WriteLine("ushort  {0,-4} {1,45} {2,45}", sizeof(ushort), ushort.MinValue, ushort.MaxValue);
WriteLine("int     {0,-4} {1,45} {2,45}", sizeof(int), int.MinValue, int.MaxValue);
WriteLine("uint    {0,-4} {1,45} {2,45}", sizeof(uint), uint.MinValue, uint.MaxValue);
WriteLine("long    {0,-4} {1,45} {2,45}", sizeof(long), long.MinValue, long.MaxValue);
WriteLine("ulong   {0,-4} {1,45} {2,45}", sizeof(ulong), ulong.MinValue, ulong.MaxValue);
unsafe
{
    WriteLine("Int128  {0,-4} {1,45} {2,45}", sizeof(Int128), Int128.MinValue, Int128.MaxValue);
    WriteLine("UInt128 {0,-4} {1,45} {2,45}", sizeof(UInt128), UInt128.MinValue, UInt128.MaxValue);
    WriteLine("Half    {0,-4} {1,45} {2,45}", sizeof(Half), Half.MinValue, Half.MaxValue);
}
WriteLine("float   {0,-4} {1,45} {2,45}", sizeof(float), float.MinValue, float.MaxValue);
WriteLine("double  {0,-4} {1,45} {2,45}", sizeof(double), double.MinValue, double.MaxValue);
WriteLine("decimal {0,-4} {1,45} {2,45}", sizeof(decimal), decimal.MinValue, decimal.MaxValue);