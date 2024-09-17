using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ConsoleApp8
{
    public class Bubble : Container
    {
        int x;
        int[] nums;
        int[] nums2;
        
        public Bubble(int[] nums) : base(nums)
        {
            this.nums = nums;
            
        }
        public override void Sort()
        {
            
            for (int i = 0; i < nums.Length - 1; i++)
            {
                for (int j = i + 1; j < nums.Length; j++)
                {
                    if (nums[i] > nums[j])
                    {
                        x = nums[i];
                        nums[i] = nums[j];
                        nums[j] = x;
                    }
                }
            }
            System.Console.Write("Сортировка пузырьком: - ");
            base.Sort();

        }
    } 
}

