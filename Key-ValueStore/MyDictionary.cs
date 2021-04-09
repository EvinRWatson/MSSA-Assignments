using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Key_ValueStore
{
    public class MyDictionary
    {
        KeyValue[] Dict = new KeyValue[10];
        int index = 0;
        public object this[string key]
        {
            get
            {
                for (int i = 0; i < Dict.Length; i++)
                    if (key == Dict[i].key)
                        return Dict[i].value;
                throw new Exception("KeyNotFoundException");
            }
            set
            {
                for (int i = 0; i < Dict.Length; i++)
                    if (key == Dict[i].key)
                    {
                        Dict[i] = new KeyValue(key, value);     
                        return;
                    }
                Dict[index] = new KeyValue(key, value);
                index++;
            }
        }
    }
}
