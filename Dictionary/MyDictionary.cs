using System;
using System.Collections.Generic;
using System.Text;

namespace Dictionary
{
    class MyDictionary<O>
    {
        O[] items;

     public MyDictionary()
        {
            items = new O[0];
        }
        public void Add(O item)
        {
            O[] tempArray = items;
            items = new O[items.Length+1];
            for (int i = 0; i < tempArray.Length; i++)
            {
                items[i] = tempArray[i];
            }
            items[items.Length - 1] = item;
        }
        public int Length
        {
            get { return items.Length; }
        }
        public O[] Items
        {
            get { return items; }
        }

    }
}
