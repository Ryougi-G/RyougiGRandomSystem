using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace RyougiGRandomSystem
{
    class RyougiGRandom
    {
        public List<int> GetRandomRanks(int totalmembers)
        {
            List<int> result=new List<int>();
            Random random = new Random(System.DateTime.Now.Millisecond);
            for(int i = 1; i <= totalmembers; i++)
            {
                int t = random.Next(1, totalmembers+1);
                while (result.Contains(t))
                {
                    t = random.Next(1, totalmembers+1);
                }
                result.Add(t);
            }
            return result;
        } 
    }
}
