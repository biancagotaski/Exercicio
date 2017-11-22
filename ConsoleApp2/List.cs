using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public class List
    {
        public ListNode First { get; set; }
        public int Count { get; set; }
        public List()
        {
            First = null;
            Count = 0;
        }

        public void Add(int value)
        {
            ListNode newNode = new ListNode() { Data = value, Next = null };

            Add(newNode);
        }

        private void Add(ListNode node)
        {
            node.Next = First;
            First = node;
            Count++;
        }

        public void Remove(int value)
        {
            Remove(new ListNode() { Data = value, Next = null });
        }

        private void Remove(ListNode node)
        {
            if (First == null)
            {
                return;
            }

            ListNode toRemove;
            if (node.Data == First.Data)
            {
                toRemove = First;
                First = First.Next;
                toRemove.Next = null;
            }
            else
            {
                ListNode previous = FindPrevious(node);
                toRemove = previous.Next;

                if(toRemove != null)
                {
                    previous.Next = toRemove.Next;
                    toRemove.Next = null;
                }
            }

            
        }

        private ListNode FindPrevious(ListNode node)
        {
            bool found = false;
            ListNode atual = First;
            ListNode previous = null;
            while(atual != null && !found)
            {
                if (atual.Data == node.Data)
                {
                    found = true;
                }
                else
                {
                    previous = atual;
                    atual = atual.Next;
                }
            }

            if (!found)
            {
                previous = null;
            }

            return previous;
        }

        public override string ToString()
        {
            string str = "";

            for(var node = First; node != null; node = node.Next)
            {
                str += node.Data;
                str += ", ";
            }

            return str;
        }
    }
}
