using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructure.LinkedList
{
    public class SinglyLinkedListNode<T>
    {
        public T Data { get; set; }
        public SinglyLinkedListNode<T> Next { get; set; }
        
        public SinglyLinkedListNode(T data)
        {
            this.Data = data;
            this.Next = null;
        }
    }
}
