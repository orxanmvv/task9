using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp22
{

        internal class Lists<T>
        {
            public T[] lists;
            public Lists()
            {
                lists = new T[0];
            }
            public void Add(T obj)
            {
                Array.Resize(ref lists, lists.Length + 1);


                lists[lists.Length - 1] = obj;
               


            }

        public T find(T OBJ)
        {
           
            
            foreach (var item in lists)
            {
               // if (OBJ == lists[item]) return item;

            }
            throw new Exception("tapilmadi");
           
        }

    }
}

