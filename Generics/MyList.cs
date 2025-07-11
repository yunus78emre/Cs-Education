﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsIntro
{
    class MyList<T>

    {
        T[] items;

        // Constructor to initialize the items array
        public MyList()
        {
            items = new T[0];
        }
        public void Add(T item)
        {
            T[]tempArray = items;
            items =new T[items.Length + 1];

            for (int i  = 0; i < tempArray.Length;  i++)
            {
                items[i] = tempArray[i];
            }

            items[items.Length - 1] = item;
        }

        public int Length
        {
            get { return items.Length; }
        }
    
        
        // önemli copilot yardımıyla yapıldı
        public T this[int index]
        {
            get { return items[index]; }
            set { items[index] = value; }
        }



    }
}
