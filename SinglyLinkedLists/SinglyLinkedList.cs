using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SinglyLinkedLists
{
    public class SinglyLinkedList
    {
        private SinglyLinkedListNode firstNode;

        public SinglyLinkedList()
        {
            // NOTE: This constructor isn't necessary, once you've implemented the constructor below.
        }

        // READ: http://msdn.microsoft.com/en-us/library/aa691335(v=vs.71).aspx
        public SinglyLinkedList(params object[] values)
        {
            throw new NotImplementedException();
        }

        // READ: http://msdn.microsoft.com/en-us/library/6x16t2tx.aspx
        public string this[int i]
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }

        public void AddAfter(string existingValue, string value)
        {
            throw new NotImplementedException();
        }

        public void AddFirst(string value)
        {
            throw new NotImplementedException();
        }

        public void AddLast(string value)
        {
            if ( firstNode == null)
            {
                firstNode = new SinglyLinkedListNode(value);
            }
            else
            {
                SinglyLinkedListNode current_node = firstNode;
                while (!current_node.IsLast())
                {
                    current_node = current_node.Next;
                }
                current_node.Next = new SinglyLinkedListNode(value);
            }
        }

        // NOTE: There is more than one way to accomplish this.  One is O(n).  The other is O(1).
        public int Count()
        {
            throw new NotImplementedException();
        }

        public string ElementAt(int index)
        {
            if (firstNode != null && index >=0)
            {
                SinglyLinkedListNode node = firstNode;
                for (int i = 0; i <= index; i++)
                {
                    if (index == i)
                    {
                        break;
                    }
                    if (node.Next == null)
                    {
                        throw new ArgumentOutOfRangeException();
                    }
                    node = node.Next;
                }

                return node.Value;
            } else if (index < 0)
            {
                //Count the nodes
                SinglyLinkedListNode node = firstNode;
                int length = 1;
                while(!node.IsLast())
                {
                    length++;
                    node = node.Next;
                }

                return this.ElementAt(length+index);
            }
            else
            {
                throw new ArgumentOutOfRangeException();
            }
        }

        public string First()
        {
            if (null == firstNode)
            {
                return null;
            }
            else
            {
                return firstNode.Value;
            }
            
        }

        public int IndexOf(string value)
        {
            throw new NotImplementedException();
        }

        public bool IsSorted()
        {
            throw new NotImplementedException();
        }

        // HINT 1: You can extract this functionality (finding the last item in the list) from a method you've already written!
        // HINT 2: I suggest writing a private helper method LastNode()
        // HINT 3: If you highlight code and right click, you can use the refactor menu to extract a method for you...
        public string Last()
        {
            if (firstNode == null)
            {
                return null;
            }
            else
            {
                return this.ElementAt(-1);
            }
        }

        public void Remove(string value)
        {
            throw new NotImplementedException();
        }

        public void Sort()
        {
            throw new NotImplementedException();
        }

        public string[] ToArray()
        {
            //string nextString = ToString();
            SinglyLinkedListNode node = firstNode;
            if (node != null) {
                int length = 1;
                while (!node.IsLast())
                {
                    length++;
                    node = node.Next;
                }
                string[] answer = new string[length];
                SinglyLinkedListNode node2 = firstNode;
                for (int i = 0; i < length; i++)
                {
                    answer[i] = ElementAt(i);
                }
                return answer;
            } 
            else
            {
                return new string[] { };
            }
        }

        public override string ToString()
        {
            string left = "{";
            string right = "}";
            string space = " ";
            string comma = ",";
            string quote = "\"";
            StringBuilder s = new StringBuilder(left);
            SinglyLinkedListNode current_node = firstNode;
            while (current_node != null )
            {
                s.Append(space);
                s.Append(quote);
                s.Append(current_node.Value);
                s.Append(quote);
                if (current_node.IsLast())
                {
                    break;
                }
                else
                {
                    s.Append(comma);
                }
                current_node = current_node.Next;
            }
            s.Append(space+right);
            return s.ToString();

            /*
            if (firstNode == null)
            {
                return "{ }";
            }
            else
            {
                StringBuilder s = new StringBuilder("{ "); //allows you to build strings without eating all your computers memory
                s.Append("\"" + firstNode.Value + "\"");
                s.Append(" }");
                return s.ToString();
            }
            */
        }
    }
}
