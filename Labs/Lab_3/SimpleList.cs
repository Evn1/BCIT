using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_3
{
    public class SimpleList<T>
    {
        protected SimpleListItem<T> first = null;
        protected SimpleListItem<T> last = null;

        public int Count
        {
            get { return count; }
            protected set { count = value; }
        }
        int count;
        public void Add(T element)
        {
            var newItem = new SimpleListItem<T>(element);
            this.Count++;

            if (last == null)
            {
                this.first = newItem;
                this.last = newItem;
            }
            
            else
            {
                this.last.next = newItem;
                this.last = newItem;
            }
        }

        public SimpleListItem<T> GetItem(int number)
        {
            if ((number < 0) || (number >= this.Count))
            {
                throw new Exception("Выход за границу индекса");
            }

            SimpleListItem<T> current = this.first;
            int i = 0;

            while (i < number)
            {
                current = current.next;
                i++;
            }
            return current;
        }
    }
}
