class ConvertUppercase : IConvertMethod
{
    public void ConvertMethod(string text)
    {
        Console.WriteLine("ConvertUppercase");
        Console.WriteLine(text.ToUpper()+ "\n");
    }
}