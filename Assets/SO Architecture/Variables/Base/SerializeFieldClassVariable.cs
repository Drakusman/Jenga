using UnityEngine;

namespace SO_Architecture.Variables.Custom
{
    public abstract class SerializeFieldClassVariable<T> : ClassVariable<T>
        where T : class
    {
        [SerializeField] private T startValue = null;

        protected override T Init()
        {
            if (startValue == null)
                return null;

            if (typeof(T).IsSubclassOf(typeof(Object)))
                return startValue;

            return (T)System.Activator.CreateInstance(typeof(T), new object[] { startValue });
        }
    }
}