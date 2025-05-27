using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2List
{
    internal class NumList
    {
        public LinkedList<int> nums { get; set; }

        public NumList(LinkedList<int> entry) 
        { 
            this.nums = entry;
            return;
        }

        public NumList(int size, int min, int max) 
        {
            generate(size, min, max);
            return;
        }

        public NumList() { }

        public void generate(int size, int min, int max) 
        { 
            Random rnd = new Random();
            nums = new LinkedList<int>();
            for (int i = 0; i < size; i++)
            {
                this.nums.AddLast(rnd.Next(min, max)); 
            }
        }

        public void cleanse()
        {
            int divisor = this.nums.First();
            List<int> toDelete = new List<int>();
            foreach (int i in this.nums)
            {
                if (!(i % divisor == 0))
                {
                    toDelete.Add(i);
                }
            }
            foreach (int i in toDelete) { this.nums.Remove(i); }
        }

        public void divide()
        {
            LinkedListNode<int> current = this.nums.First;
            List<LinkedListNode<int>> marks = new List<LinkedListNode<int>>();
            foreach (int i in this.nums)
            {
                if (current != nums.Last)
                {
                    if (current.Value % 2 == current.Next.Value % 2)
                    {
                        marks.Add(current);
                    }
                    current = current.Next;
                }
            }
            foreach(LinkedListNode<int> mark in marks) { nums.AddAfter(mark, 0); }
        }
    }
}
