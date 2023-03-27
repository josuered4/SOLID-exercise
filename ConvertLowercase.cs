class ConvertLowercase : IConvertMethod
{
    public void ConvertMethod(string text)
    {
        Console.WriteLine("ConvertLowercase");
        Console.WriteLine(text.ToLower() + "\n");
    }
}