namespace FluentIsh.Builder.Source.Interfaces.Struct
{
    public interface IStructAccessibilityPicker
    {
        IStructNamePicker Public();
        IStructNamePicker Internal();
        IStructNamePicker Private();
    }
}