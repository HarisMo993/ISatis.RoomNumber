using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace ISatis.RoomNumber
{
    public class RoomNumber
    {
        public int numberOfSets(int roomNumber)
        {
            int[] digits = roomNumber.ToString().Select(x => int.Parse(x.ToString())).ToArray();
            int sets = 0;
            for (int i = 0; i <= 9; i++)
            {

                int count = digits.Count(x => x == i);
                bool areAllNumbersDistinct = digits.GroupBy(x => x).All(q => q.Count() == 1);
                if (i == 6 || i == 9)
                {
                    sets += (count + 1) / 2;
                }
                else if (i == count)
                {
                    sets += (count + 1) / 2;
                }
                else if(areAllNumbersDistinct == true)
                {
                    sets = 1;
                }
                else
                {
                    sets += count;
                }
            }
            return sets;
        }
    }
}
