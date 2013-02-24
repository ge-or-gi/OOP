using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    public class ItemList<T>
    {

        private T[] _items;
        private int _count = 0;
        private const int DEFAULT_CAPACITY = 20;

        public ItemList(int capacity = DEFAULT_CAPACITY)
        {
            _items = new T[capacity];
        }


        public int Count
        {
            get { return this._count; }
        }

        #region Add's elements and if it's needed makes the Array two-times Bigger
        public void Add(T item)
        {
            if (Count >= _items.Length)
            {
                T[] newList = new T[_items.Length * 2];

                for (int i = 0; i < _items.Length; i++)
                {
                    newList[i] = _items[i];
                }

                _items = newList;
                _items[Count] = item;
                _count++;


                // throw new IndexOutOfRangeException("Index OUT OF RANGE");
            }
            else
            {
                _items[Count] = item;
                _count++;
            }

        } 
        #endregion

        #region Get and Set elements in the Array
        public T this[int index]
        {
            get
            {
                if (index >= _items.Length || index < 0)
                {
                    throw new IndexOutOfRangeException("Index OUT OF RANGE - Missing data");
                }
                else
                {
                    T result = _items[index];
                    return result;
                }
            }

            set
            {
                if (index >= _items.Length || index < 0)
                {
                    throw new IndexOutOfRangeException("Index OUT OF RANGE - Cant set data");
                }
                else
                {
                    _items[index] = value;
                }

            }

        } 
        #endregion

        #region Clear element at INDEX using the DEFAULT(T), sets the element to DEFAULT for his TYPE
        public void ClearAtIndex(int index)
        {
            if (index >= _items.Length || index < 0)
            {
                throw new IndexOutOfRangeException("Index OUT OF RANGE");
            }
            else
            {
                _items[index] = default(T);
            }

        } 
        #endregion

        #region Set's all elements in the array to DEFAULTS for his TYPE
        public void ClearAll()
        {
            for (int i = 0; i < _items.Length; i++)
            {
                _items[i] = default(T);
            }

        } 
        #endregion

        public int Find(T item)
        {
            int index = 0;

            //itemToFind = new T toFind;

            for (int i = 0; i < _items.Length; i++)
            {
                if (_items[i].Equals(item))
                {
                    index = i;
                    break;
                }
            }

            return index;
        
        }

        public void InsertElement(int index, T item)
        {
            #region Sets the Element and the state of the BOOL Var
            bool elemntInserted = true;
            var elementToRemember = _items[index];
            #endregion

            #region If in Range then start
            if (index < _items.Length)
            {
                #region Loops over all elemts int the Array minus ONE :)
                for (int i = 0; i < _items.Length - 1; i++)
                {
                    #region If the index is right Set's the elemet to the input, then change the state of elementInserted to FALSE
                    if (index == i)
                    {
                        elemntInserted = false;
                        _items[i] = item;
                        //continue;
                    }
                    #endregion

                    #region If not TRUE takes next element, insert the first element to new index, copies the value of the next element to the curent
                    if (!elemntInserted)
                    {
                        var elementToRemember2 = _items[i + 1];
                        _items[i + 1] = elementToRemember;
                        elementToRemember = elementToRemember2;
                    }
                    #endregion
                }
                #endregion
            }
            #endregion 
            
        
        }

        public void RemoveElement(int index)
        {
            bool elemntRemoved = true;
            var elementToRemove = _items[index];

            if (index < _items.Length)
            {
                for (int i = 0; i < _items.Length - 1; i++)
                {
                    if (index == i)
                    {
                        elemntRemoved = false;
                        _items[i] = _items[i + 1]; 
                        //continue;
                    }
                    if (!elemntRemoved)
                    {
                        var elementToRemember2 = _items[i + 1];
                        _items[i] = elementToRemember2;
                        elementToRemove = elementToRemember2;
                    }
                }
            }

        }

        public static T Min<T>(T first, T second)   where T: IComparable<T>
        {
            T result = default(T);


            if (first.CompareTo(second) <= 0)
            {
                result = first;
            }
            else
            {
                result = second;
            }
                return result;
        }

        public static T Max<T>(T first, T second) where T : IComparable<T>
        {
            T result = default(T);
            
            if (first.CompareTo(second) >= 0)
            {
                result = first;
            }
            else
            {
                result = second;
            }
            return result;
        }
    }
}
