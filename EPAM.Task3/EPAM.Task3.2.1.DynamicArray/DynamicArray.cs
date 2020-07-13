using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EPAM.Task3._2._1.DynamicArray
{
    public class DynamicArray<T> : IEnumerable, IEnumerable<T>
    {
        private T[] storage;
        private int length = 0;

        public DynamicArray()
        {
            this.storage = new T[8];
        }

        public DynamicArray(int length)
        {
            this.storage = new T[length];
        }

        public DynamicArray(IEnumerable<T> mas)
        {
            this.storage = new T[mas.Count()];
            foreach (var item in mas)
            {
                this.storage[this.length] = item;
                this.length++;
            }

            this.length++;
        }

        public int Length
        {
            get
            {
                return this.length - 1;
            }
        }

        public int Capacity
        {
            get
            {
                return this.storage.Count();
            }
        }

        public T this[int id]
        {
            get
            {
                if (id < 0 || id > this.length)
                {
                    throw new ArgumentOutOfRangeException();
                }

                return this.storage[id];
            }

            set
            {
                if (id < 0 || id > this.length)
                {
                    throw new ArgumentOutOfRangeException();
                }

                this.storage[id] = value;
            }
        }

        public void Add(T val)
        {
            if (this.length == this.storage.Count())
            {
                this.ExpandMas(this.length * 2);
            }

            this.storage[this.length] = val;
            this.length++;
        }

        public void AddRange(IEnumerable<T> mas)
        {
            if (mas.Count() > this.storage.Count() - this.length + 1)
            {
                this.ExpandMas(this.length + mas.Count() + 1);
            }

            foreach (var item in mas)
            {
                this.storage[this.length] = item;
                this.length++;
            }

            this.length++;
        }

        public bool Remove(int pos)
        {
            if (pos >= this.length || pos < 0)
            {
                return false;
            }

            for (int i = pos; i + 1 < this.length - 1; i++)
            {
                this.storage[i] = this.storage[i + 1];
            }

            this.length--;
            return true;
        }

        public bool Insert(int pos, T value)
        {
            if (pos >= this.length)
            {
                throw new Exception("ArgumentOutOfRangeException");
            }
            else if (pos < 0)
            {
                return false;
            }

            if (this.length + 1 >= this.storage.Count())
            {
                this.ExpandMas(this.length * 2);
            }

            for (int i = this.length; i > pos; i--)
            {
                this.storage[i] = this.storage[i - 1];
            }

            this.length++;
            this.storage[pos] = value;
            return true;
        }

        public IEnumerator GetEnumerator()
        {
            return (IEnumerator)this.GetEnumerator();
        }

        IEnumerator<T> IEnumerable<T>.GetEnumerator()
        {
            return (IEnumerator<T>)this.GetEnumerator();
        }

        private void ExpandMas(int val)
        {
            T[] temp = this.storage;
            this.storage = new T[val];
            for (int i = 0; i < temp.Count(); i++)
            {
                this.storage[i] = temp[i];
            }
        }
    }
}
