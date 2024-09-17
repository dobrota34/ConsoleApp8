using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
{
    public abstract class Container
    {
        private readonly int[] nums;

        public Container(int[] nums)
        {
            this.nums = nums;
        }
        public virtual void Sort()
        {
            
            foreach (int i in nums)
            {
                System.Console.Write(i + " ");
            }
            System.Console.Write("\n");

        }
    }
}
