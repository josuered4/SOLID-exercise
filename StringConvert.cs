class StringConvert
{
    private readonly IConvertMethod ConvertMethod;
    public StringConvert(IConvertMethod ConvertMethod) => this.ConvertMethod = ConvertMethod;

    public void Transformation(string text)
    {
        ConvertMethod.ConvertMethod(text);
    }
}