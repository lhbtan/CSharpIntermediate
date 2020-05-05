
using System;
using System.Collections.Generic;

namespace CSharpIntermediateLloyd
{
    public class Stack
    {
        private Stack<object> _stacklist = new Stack<object>();

        public Stack()
        {

        }
        public void Push(object obj)
        {            
            if(obj != null)
            {
                _stacklist.Push(obj);
            }
            else
            {
                throw new System.InvalidOperationException("null is not allowed");
            }
        }

        public object Pop()
        {
            
            if(_stacklist.Count != 0)
            {
                return _stacklist.Pop();
                
            }
            else
            {
                throw new InvalidOperationException("Stack is empty");
            }
        }

        public void Clear()
        {
            _stacklist.Clear();
        }
    }
}
