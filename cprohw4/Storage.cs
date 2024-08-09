using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cprohw4
{
    public class Storage<T>
    {
        public T Value { get; private set; }

        public void SetItem(T item) => Value = item;
        public T GetValue() => Value;

        public Storage() {}
        public Storage(T _Value)
        {
            Value = _Value;
        }
    }
}
