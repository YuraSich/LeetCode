 public class MyHashSet
    {

        private readonly LinkedList<int> _list;

        public MyHashSet()
        {
            _list = new();
        }

        public void Add(int key)
        {
            if (!Contains(key))
            {
                _list.AddLast(key);
            }
        }

        public void Remove(int key)
        {
            if (Contains(key))
            {
                _list.Remove(key);
            }
        }

        public bool Contains(int key)
        {
            foreach (var i in _list)
            {
                if (i == key)
                {
                    return true;
                }
            }
            return false;
        }
    }