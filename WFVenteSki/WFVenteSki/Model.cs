using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WFVenteSki
{
    class Model<T>
    {
        //Fields
        List<T> lst;

        //Properties
        private List<T> Lst { get => lst; set => lst = value; }

        //Constructors
        public Model(List<T> lst)
        {
            Lst = lst;
        }

        //Methods
        /// <summary>
        /// Get the ammount of elements you have in the list.
        /// </summary>
        /// <returns>Returns the ammount of elements you have in the list.</returns>
        public int GetSize()
        {
            return Lst.Count;
        }

        /// <summary>
        /// Add an item to the list.
        /// </summary>
        /// <param name="item">Item you wanna add to the list.</param>
        /// <returns>Returns the ammount of elements you have in the list.</returns>
        public int Add(T item)
        {
            if (!Contains(item))
            {
                Lst.Add(item);
            }
            return Lst.Count;
        }

        /// <summary>
        /// Get the item that's in the specified position.
        /// </summary>
        /// <param name="pos">Position of the item you want.</param>
        /// <returns>Return the item that's in the specified position.</returns>
        public T GetItem(int pos)
        {
            return Lst[pos];
        }

        /// <summary>
        /// Check if the given item is in the list.
        /// </summary>
        /// <param name="item">Item you want to check the existance in the list.</param>
        /// <returns>True if the item is in the list, false otherwise.</returns>
        public bool Contains(T item)
        {
            bool isInTheList = false;
            foreach (T obj in Lst)
            {
                if (obj.Equals(item))
                {
                    isInTheList = true;
                }
            }

            return isInTheList;
        }

        /// <summary>
        /// Get the index of the specified item.
        /// </summary>
        /// <param name="item">Item you wanna get the index of.</param>
        /// <returns>Return the index of the specified item.</returns>
        public int IndexOf(T item)
        {
            int index = 0;
            for (int i = 0; i < Lst.Count; i++)
            {
                if (item.Equals(Lst[i]))
                {
                    index = i;
                }
            }

            return index;
        }

        /// <summary>
        /// Delete the item in the specified position.
        /// </summary>
        /// <param name="pos">Position of the item you want to delete.</param>
        /// <returns>The ammount of items in the list.</returns>
        public int Del(int pos)
        {
            T item = GetItem(pos);
            bool delete = false;
            if (item is Order)
            {
                Order orderItem = item as Order;
                (item as Order).IncrementQuantity(-1);
                if (orderItem.GetQuantity() <= 0)
                {
                    delete = true;
                }
            }
            else
            {
                delete = true;
            }

            if (delete)
            {
                Lst.RemoveAt(pos);
            }

            return Lst.Count;
        }

        /// <summary>
        /// Delete all items in the list.
        /// </summary>
        public void DelAll()
        {
            Lst.RemoveAll(item => item.GetType() == typeof(T));
        }
    }
}
