using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._21_Generics_BestPractices_PluralsightCourse
{
    public class OperationResult<T>
    {
        public OperationResult()
        {

        }

        public OperationResult(T result, string message) : this()
        {
            this.Result = result;
            this.Message = message;
        }

        public string Message { get; set; }
        public T Result { get; set; }

        //Generic Method
        public B PrintParameter<B>(B defaultValue) where B : class
        {
            B value = defaultValue;
            return value;
        }

        
    }
}
