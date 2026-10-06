namespace TASK_3;

class Program
{
    static void Main(string[] args)
    {
        byte byteValue = 200;
        short shortValue = 32000;
        int intValue = 42;
        long longValue = 1234567890123L;
        float floatValue = 3.14f;
        double doubleValue = 2.71828;
        decimal decimalValue = 99.99m;
        char charValue = 'A';
        bool boolValue = true;

        string integerAsString = intValue.ToString();
        double stringAsDouble = double.Parse("3.14");

        Console.WriteLine($"byte: {byteValue}");
        Console.WriteLine($"short: {shortValue}");
        Console.WriteLine($"int: {intValue}");
        Console.WriteLine($"long: {longValue}");
        Console.WriteLine($"float: {floatValue}");
        Console.WriteLine($"double: {doubleValue}");
        Console.WriteLine($"decimal: {decimalValue}");
        Console.WriteLine($"char: {charValue}");
        Console.WriteLine($"bool: {boolValue}");
        Console.WriteLine($"int converted to string: {integerAsString}");
        Console.WriteLine($"string converted to double: {stringAsDouble}");
    }
}
