using ScriptableObjectArchitecture;

namespace SO_Architecture.Variables.Custom
{
    public abstract class ClassVariable<T> : Variable<T>, INullableVariable
        where T : class
    {
        public bool IsNull() => Value == null;
    }
}