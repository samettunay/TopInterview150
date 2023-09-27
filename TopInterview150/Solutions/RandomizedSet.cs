using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TopInterview150.Solutions
{
    public class RandomizedSet
    {
        private Dictionary<int, int> valToIndex;
        private List<int> values;

        public RandomizedSet()
        {
            valToIndex = new Dictionary<int, int>();
            values = new List<int>();
        }

        public bool Insert(int val)
        {
            if (valToIndex.ContainsKey(val))
                return false;

            valToIndex[val] = values.Count;
            values.Add(val);
            return true;
        }

        public bool Remove(int val)
        {
            if (!valToIndex.ContainsKey(val))
                return false;

            int indexToRemove = valToIndex[val];

            int lastValue = values[values.Count - 1];
            values[indexToRemove] = lastValue;
            valToIndex[lastValue] = indexToRemove;

            values.RemoveAt(values.Count - 1);
            valToIndex.Remove(val);

            return true;
        }

        public int GetRandom()
        {
            Random random = new Random();
            int randomIndex = random.Next(0, values.Count);
            return values[randomIndex];
        }
    }
}
