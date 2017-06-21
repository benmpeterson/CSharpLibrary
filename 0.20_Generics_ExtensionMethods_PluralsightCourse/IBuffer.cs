using System.Collections.Generic;

namespace _0._20_Generics_ExtenstionMethods_PluralsightCourse
{
    public interface IBuffer<T> : IEnumerable<T>
    {
        bool IsEmpty { get; }
        void Write(T value);
        T Read();
    }
}
