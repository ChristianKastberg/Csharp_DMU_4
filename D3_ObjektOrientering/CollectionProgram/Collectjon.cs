using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionProgram
{
    class Collectjon<Tkey, TValue> {
        private readonly Dictionary<Tkey, TValue> _collection; //= new Dictionary<TKey, TValue>();

        public bool AddElement(Tkey key, TValue value)
        {

            return true;

        }
        public Tkey GetElement(Tkey k)
        {
            return k;
        }
        



    
}
}
