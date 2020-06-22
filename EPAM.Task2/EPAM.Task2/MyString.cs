using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EPAM.Task2
{
    public class MyString
    {
        private char[] chars = new char[0];

        public MyString()
        {
            this.chars = new char[16];
        }

        public MyString(int newlength)
        {
            this.chars = new char[newlength];
        }

        public MyString(char[] charmas)
        {
            this.chars = new char[charmas.Length];

            for (int i = 0; i < charmas.Length; i++)
            {
                this.chars[i] = charmas[i];
            }
        }

        public MyString(string str)
        {
            this.chars = new char[str.Length];

            for (int i = 0; i < str.Length; i++)
            {
                this.chars[i] = str[i];
            }
        }

        public int Length
        {
            get
            {
                return this.chars.Length;
            }
        }

        public char this[int id]
        {
            get
            {
                return this.chars[id];
            }

            set
            {
                this.chars[id] = value;
            }
        }

        public static int Compare(MyString a, MyString b)
        {
            int minLength = Math.Min(a.Length, b.Length);

            for (int i = 0; i < minLength; i++)
            {
                if (a[i] > b[i])
                {
                    return 1;
                }

                if (a[i] < b[i])
                {
                    return -1;
                }
            }

            if (a.Length < b.Length)
            {
                return -1;
            }

            if (a.Length > b.Length)
            {
                return 1;
            }

            return 0;
        }

        public static MyString Concat(MyString a, MyString b)
        {
            MyString temp = new MyString(a.Length + b.Length);

            for (int i = 0; i < a.Length; i++)
            {
                temp[i] = a[i];
            }

            for (int i = 0; i < b.Length; i++)
            {
                temp[i + a.Length] = b[i];
            }

            return temp;
        }

        public bool Contains(MyString b)
        {
            for (int i = 0; i < this.Length - b.Length + 1; i++)
            {
                bool result = true;
                for (int j = i; j < b.Length; j++)
                {
                    if (this.chars[j] != b[j - i])
                    {
                        result = false;
                        break;
                    }
                }

                if (result)
                {
                    return result;
                }
            }

            return false;
        }

        public bool StartsWith(MyString value)
        {
            if (value.Length > this.Length)
            {
                return false;
            }

            for (int i = 0; i < value.Length - 1; i++)
            {
                if (this.chars[i] != value[i])
                {
                    return false;
                }
            }

            return true;
        }

        public bool EndsWith(MyString value)
        {
            this.Reverse();
            value.Reverse();
            bool result = this.StartsWith(value);
            this.Reverse();
            value.Reverse();
            return result;
        }

        public int IndexOf(char value)
        {
            for (int i = 0; i < this.Length; i++)
            {
                if (this.chars[i] == value)
                {
                    return i;
                }
            }

            return -1;
        }

        public int LastIndexOf(char value)
        {
            for (int i = this.Length - 1; i >= 0; i--)
            {
                if (this.chars[i] == value)
                {
                    return i;
                }
            }

            return -1;
        }

        public int IndexOfAny(char[] value)
        {
            for (int i = 0; i < value.Length; i++)
            {
                if (this.IndexOf(value[i]) != -1)
                {
                    return this.IndexOf(value[i]);
                }
            }

            return -1;
        }

        public int LastIndexOfAny(char[] value)
        {
            for (int i = 0; i < value.Length; i++)
            {
                if (this.LastIndexOf(value[i]) != -1)
                {
                    return this.LastIndexOf(value[i]);
                }
            }

            return -1;
        }

        public bool Equals(MyString value)
        {
            if (MyString.Compare(this, value) == 0)
            {
                return true;
            }

            return false;
        }

        public char[] ToChar()
        {
            return this.chars;
        }

        public MyString Insert(int startID, MyString value)
        {
            MyString result = new MyString(this.Length + value.Length);
            for (int i = 0; i < startID; i++)
            {
                result[i] = this.chars[i];
            }

            for (int i = 0; i < value.Length; i++)
            {
                result[startID + i] = value[i];
            }

            int j = startID;
            for (int i = startID + value.Length; i < result.Length; i++)
            {
                result[i] = this.chars[j];
                j++;
            }

            return result;
        }

        public MyString Remove(int startID, int count)
        {
            MyString result = new MyString(this.Length - count);
            for (int i = 0; i < startID; i++)
            {
                result[i] = this.chars[i];
            }

            int j = startID;
            for (int i = startID + count; i < this.Length; i++)
            {
                result[j] = this.chars[i];
                j++;
            }

            return result;
        }

        public MyString SubMyString(int startID, int count)
        {
            MyString result = new MyString(count);
            for (int i = startID; i < startID + count; i++)
            {
                result[i - startID] = this.chars[i];
            }

            return result;
        }

        public void ToUpper()
        {
            for (int i = 0; i < this.Length; i++)
            {
                if (this.chars[i] > 96 && this.chars[i] < 123)
                {
                    this.chars[i] = (char)(this.chars[i] - 32);
                }
            }
        }

        public void ToLower()
        {
            for (int i = 0; i < this.Length; i++)
            {
                if (this.chars[i] > 64 && this.chars[i] < 91)
                {
                    this.chars[i] = (char)(this.chars[i] + 32);
                }
            }
        }

        public override string ToString()
        {
            var strbuild = new StringBuilder();
            for (int i = 0; i < this.Length; i++)
            {
                strbuild.Append(this.chars[i]);
            }

            return strbuild.ToString();
        }

        private void Reverse()
        {
            char[] temp = new char[this.Length];
            for (int i = 0; i < this.Length; i++)
            {
                temp[i] = this.chars[this.Length - i - 1];
            }

            this.chars = temp;
        }
    }
}
