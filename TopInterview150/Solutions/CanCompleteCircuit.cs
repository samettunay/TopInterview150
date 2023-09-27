using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TopInterview150.Solutions
{
    public class CanCompleteCircuit
    {
        public int Generate(int[] gas, int[] cost)
        {
            int n = gas.Length;
            int totalGas = 0;
            int totalCost = 0;
            int currentGas = 0;
            int startStation = 0;

            for (int i = 0; i < n; i++)
            {
                totalGas += gas[i];
                totalCost += cost[i];
                currentGas += gas[i] - cost[i];

                if (currentGas < 0)
                {
                    currentGas = 0;
                    startStation = i + 1;
                }
            }

            if (totalGas < totalCost)
            {
                return -1;
            }

            return startStation;
        }
    }
}
