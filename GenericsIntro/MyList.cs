using System;
using System.Collections.Generic;
using System.Text;

namespace GenericsIntro
{
    class MyList<T> //kendi listemizde string int vs olsun diye T diyoruz
    {
        T[] items;

        public MyList()     //ctor komutu ile kendi listemizdeki sıfır elemanlı listeyi tanımlama anında oluştururuz.
        {
            items = new T[0];
        }
        public void Add(T item)
        {
            T[] tempArray = items;  //ikinci new komutunda ilk kodların silinmemesi için.
            items = new T[items.Length + 1];
            for (int i = 0; i < tempArray.Length; i++)
            {
                items[i] = tempArray[i];
            }

            items[items.Length - 1] = item;
        }
    }
}
