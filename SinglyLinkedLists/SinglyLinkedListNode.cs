﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

// Stretch Goals: Using Generics, which would include implementing GetType() http://msdn.microsoft.com/en-us/library/system.object.gettype(v=vs.110).aspx
namespace SinglyLinkedLists
{
    public class SinglyLinkedListNode : IComparable
    {
        // Used by the visualizer.  Do not change.
        public static List<SinglyLinkedListNode> allNodes = new List<SinglyLinkedListNode>();

        // READ: http://msdn.microsoft.com/en-us/library/aa287786(v=vs.71).aspx
        private SinglyLinkedListNode next;
        public SinglyLinkedListNode Next
        {
            get { return next; }
            set 
            {
                if (this == value)
                {
                    throw new ArgumentException();
                }
                next = value;
            }
        }

        private string value;
        public string Value 
        {
            get { return value; }
        }

        public static bool operator <(SinglyLinkedListNode node1, SinglyLinkedListNode node2)
        {
            // This implementation is provided for your convenience.
            return node1.CompareTo(node2) < 0;
        }

        public static bool operator >(SinglyLinkedListNode node1, SinglyLinkedListNode node2)
        {
            // This implementation is provided for your convenience.
            return node1.CompareTo(node2) > 0;
        }

        public SinglyLinkedListNode(string value)
        {
            this.value = value;

            // Used by the visualizer:
            allNodes.Add(this);
        }

        public override string ToString()
        {
            return value;
        }

        // READ: http://msdn.microsoft.com/en-us/library/system.icomparable.compareto.aspx
        public int CompareTo(Object obj)
        {

            SinglyLinkedListNode node = obj as SinglyLinkedListNode;
            if (obj != null)
            {
                return this.value.CompareTo(node.value);
            } 
            else
            {
                return 1;
            }

        }

        public bool IsLast()
        {
            /* Eliza's solution
            bool result = (Next == null);
            return result;
            --or-- */
            return Next == null;
            
            /*
            if (null == Next)
            {
                return true;
            }
            else
            {
                return false;
            }
            */
        }

        public override bool Equals(object obj)
        {
            
            SinglyLinkedListNode node = obj as SinglyLinkedListNode;
            if (node == null)
            {
                return false;
            }
            else
            {
                return value.Equals(node.value);
                //return (this.Value == other.Value);
            }
        }

        public override int GetHashCode()
        {
            return this.Value.GetHashCode();
        }
    }
}
