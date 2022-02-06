namespace FluentIsh.Builder.Source.Interfaces.Delegate
{
    public interface IDelegateAccessibilityPicker
    {
         IDelegateNamePicker Public();
         IDelegateNamePicker Internal();
         IDelegateNamePicker Private();
    }
}