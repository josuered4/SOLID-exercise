// See https://aka.ms/new-console-template for more information
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World! \n");

        ConvertUppercase convertUppercase = new();
        StringConvert stringConvertU = new(convertUppercase);
        stringConvertU.Transformation("Hello, World!!!");

        ConvertLowercase convertLowercase = new();
        StringConvert stringConvertL = new(convertLowercase);
        stringConvertL.Transformation("Hello, World!!!");
    }
}