using System;

namespace Stack
{
    class Stack<T>
    {
        private T[] _stack;
        private int index = 0;
        readonly int n = 1000;

        public Stack()
        {
            _stack = new T[n];
        }

        public void Push(T data)
        {
            if (index + 1 >= _stack.Length)
            {
                Array.Resize(ref _stack, (_stack.Length + 1) * 2);
            }

            _stack[index] = data;
            index++;
        }

        public T Pop()
        {
            if (index == 0)
            {
                throw new IndexOutOfRangeException("Stack is empty");
            }

            index--;
            
            return _stack[index];
        }

        public void Peek()
        {
            if (index < 0)
            {
                throw new IndexOutOfRangeException("Stack is empty");
            }

            index--;

            Console.WriteLine(_stack[index]);

            index++;
        }
    }
}
