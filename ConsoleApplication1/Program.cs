using ConsoleApplication1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoCodeFirst
{
    class Program
    {
        static void Main(string[] args)
        {
            using (MCS db = new MCS())
            {
                foreach (var item in db.AccessTab)
                {
                    Console.WriteLine(item.intTabID + "\t" + item.strTabName);//code first automatic
                }
            }
        }
    }
}
