namespace FluentIsh.Builder.Source.Interfaces.Class.Field
{
    public interface IClassFieldAccessibilityPicker
    {
        IClassFieldConstStaticReadonlyTypePicker Public();
        IClassFieldConstStaticReadonlyTypePicker Internal();
        IClassFieldConstStaticReadonlyTypePicker Private();
    }
}