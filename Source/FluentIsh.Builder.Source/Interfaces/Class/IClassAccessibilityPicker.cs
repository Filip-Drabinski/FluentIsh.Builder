namespace FluentIsh.Builder.Source.Interfaces.Class
{
    public interface IClassAccessibilityPicker
    {
        IClassStaticAndNamePicker Public();
        IClassStaticAndNamePicker Internal();
        IClassStaticAndNamePicker Private();
    }
}