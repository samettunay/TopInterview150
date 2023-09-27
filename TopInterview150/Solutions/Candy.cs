using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TopInterview150.Solutions
{
    public class Candy
    {
        public int Generate(int[] ratings)
        {
            int n = ratings.Length;
            int[] candies = new int[n];

            for (int i = 0; i < n; i++)
            {
                candies[i] = 1;
            }

            for (int i = 1; i < n; i++)
            {
                if (ratings[i] > ratings[i - 1])
                {
                    candies[i] = candies[i - 1] + 1;
                }
            }

            for (int i = n - 2; i >= 0; i--)
            {
                if (ratings[i] > ratings[i + 1] && candies[i] <= candies[i + 1])
                {
                    candies[i] = candies[i + 1] + 1;
                }
            }

            int totalCandies = 0;
            foreach (int candy in candies)
            {
                totalCandies += candy;
            }

            return totalCandies;
        }
    }
}
