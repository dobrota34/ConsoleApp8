using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
{
    public class Choice : Container
    {
        int x;
        int[] nums;

        public Choice(int[] nums) : base(nums)
        {
            this.nums = nums;

        }
        public override void Sort()
        {
            

            for (int i = 0; i < nums.Length - 1; i++)
            {
                int xmin = nums[i];

                for (int j = i + 1; j < nums.Length; j++)
                {
                    if (xmin > nums[j])
                    {
                        nums[i] = nums[j];
                        
                    }
                }
            }
            System.Console.Write("Сортировка выбором: - ");
            base.Sort();
            // foreach (int i in nums)
            //  System.Console.Write(i + " ");
        }
    }
}

