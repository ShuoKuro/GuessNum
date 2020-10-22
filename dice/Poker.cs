using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dice
{
    public class Poker
    {
        public List<int> GetPoker(int count)
        {
            List<int> result = new List<int>();

            try
            {
                for (int i = 0; i < count; i++)
                {
                    result.Add(i);
                }

                for (int i = count - 2; i >= 0; i--)
                {
                    int lastindex = i + 1;
                    int randomIndex = (new Random()).Next(i);

                    int temp = result[lastindex];
                    result[lastindex] = result[randomIndex];
                    result[randomIndex] = temp;
                }
            }
            catch (Exception exp)
            {
                Console.WriteLine(exp.ToString());
                throw;
            }

            return result;
        }
    }
}
