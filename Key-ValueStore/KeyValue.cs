using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Key_ValueStore
{
    struct KeyValue
    {
        public string key { get; }
        public object value { get; }

        public KeyValue(string key, object value)
        {
            this.key = key;
            this.value = value;
        }
    }
}
