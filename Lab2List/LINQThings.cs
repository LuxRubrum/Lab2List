using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2List
{
    internal class LINQThings
    {
        public LINQThings() { }

        public static int WithFor()
        {
            int result = 0;
            for (int i = 1; i <= 10; i++)
            {
                if (i % 2 == 0)
                {
                    result = result + (int)Math.Pow(i, 2);
                }
            }
            return result;
        }

        public static int WithForeach()
        {
            int result = 0;
            int[] nums = {1, 2, 3, 4, 5, 6, 7, 8, 9, 10};
            foreach (int i in nums) {
                if (i % 2 == 0)
                {
                    result = result + (i * i);
                }
            }
            return result;
        }

        public static int WithLINQOps()
        {
            int result = 0;
            int[] nums = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            var select = from x in nums
                         where x % 2 == 0
                         select x * x;
            result = select.Sum();
            return result;
        }

        public static int WithLINQMets()
        {
            int result = 0;
            int[] nums = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            result = nums.Where(x => x % 2 == 0).Sum(x => x = x*x);
            return result;
        }
    }
}
