using System;
using System.Collections.Generic;

namespace Exercicio1_Secao4
{
    class Stack
    {
        private List<object> _stack;

        public Stack()
        {
            _stack = new List<object>();
        }

        public void Push(object obj)
        {
            if (obj == null)
                throw new InvalidOperationException("push - null");

            _stack.Add(obj);
        }

        public object Pop()
        {
            var count = _stack.Count - 1;
           
            if (count < 0)
                return "nothing to pop.";

            var itemStack = _stack[count];
            _stack.RemoveAt(count);
            return itemStack;
        }

        public void Clear()
        {
            _stack.RemoveRange(0, _stack.Count);
        }
    }
}
