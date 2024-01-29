    public class MyQueue
    {
        List<int> _queue;
        int _first;
        int _last;

        public MyQueue()
        {
            _queue = new List<int>(Enumerable.Repeat(0, 64));
            _first = _last = 0;
        }

        public void Push(int x)
        {
            _queue[_last++] = x;
        }

        public int Pop()
        {
            return _queue[_first++];
        }

        public int Peek()
        {
            return _queue[_first];
        }

        public bool Empty()
        {
            return _first == _last;
        }
    }