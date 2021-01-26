using System;
using System.Collections.Generic;

namespace Generics
{
    class Program
    {
        private static object l;

        static void Main(string[] args)
        {
            List<string> musteriler = new List<string>();
            musteriler.Add("Ahmet");
            musteriler.Add("Ahmet");
            musteriler.Add("Ahmet");
            musteriler.Add("Ahmet");

            Console.WriteLine(musteriler.Count);


            MyList<string> musteriler2 = new MyList<string>();
            musteriler2.Add("Metin");
            musteriler2.Add("Metin");
            musteriler2.Add("Metin");
            musteriler2.Add("Metin");
            musteriler2.Add("Metin");
            musteriler2.Add("Metin");
            musteriler2.Add("Metin");
            musteriler2.Add("Metin");
            musteriler2.Add("Metin");
            musteriler2.Add("Metin");


            Console.WriteLine(musteriler2.Count);


            MyList<int> yas = new MyList<int>();
            yas.Add(22);
        }
    }

    class MyList<T>
    {
        T[] _array;
        T[] _tempArray;
        public MyList()
        {
            _array = new T[0];
        }
        public void Add(T item)
        {
            _tempArray = _array;
            _array = new T[_array.Length + 1];
            for (int i = 0; i < _tempArray.Length; i++)
            {
                _array[i] = _tempArray[i];
            }
            _array[_array.Length - 1] = item;
        }


        public int Count
        {
            get { return _array.Length; }
        }

    }
}
