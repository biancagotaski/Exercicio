using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public class ListNode: IComparable<ListNode>
    {
        public int Data { get; set; }
        public ListNode Next { get; set; }

        public int CompareTo(ListNode other)
        {
            return Data.CompareTo(other.Data);
        }
    }
}
