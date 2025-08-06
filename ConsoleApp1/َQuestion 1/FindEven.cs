using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1._َQuestion_1
{
    public class FindEven
    {
        public static List<int>  getEven(List<int> num) 
        {
            return num.Where(n => n % 2 == 0).ToList();
        }
    }
}
