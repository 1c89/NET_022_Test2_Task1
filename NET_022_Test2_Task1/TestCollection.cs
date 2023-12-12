using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NET_022_Test2_Task1
{
    internal class TestCollection<T> where T:struct 
    {
        private List<T> _list;

        public int Count => _list.Count;
        public TestCollection()
        {
            _list = new List<T>();
        }

        public void AddItem(T item) => _list.Add(item);

        public T GetItem(int id)
        { 
            if (id < 0 || id >= _list.Count) throw new ArgumentOutOfRangeException("id");

            return _list[id];
        }

        public List<T> GetDescSorted()  
        {
            return _list.OrderByDescending(item => item).ToList();
        }
           


        
        
    }
}
