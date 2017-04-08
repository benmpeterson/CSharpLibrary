using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._12_Collections_Lists_PluralsightCourse
{
    //Uses System.Collections.ObjectModel
    //Uses Collection<t> to add .IsNullOrEmpty catch methods to ensure added elements 
    //are not blank or null... SUPER COOL!
    class NonBlankStringList : Collection<string>
    {
        protected override void InsertItem(int index, string item)
        {
            if (string.IsNullOrEmpty(item))
                throw new ArgumentException("Elements of NonblankStringList must not be null or whitespace");
            base.InsertItem(index, item);
        }

        protected override void SetItem(int index, string item)
        {
            if (string.IsNullOrEmpty(item))
                throw new ArgumentException("Elements of NonblankStringList must not be null or whitespace");
            base.SetItem(index, item);
        }

    }
}
