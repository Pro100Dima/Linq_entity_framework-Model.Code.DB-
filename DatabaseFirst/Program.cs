using DatabaseFirst.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseFirst
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var db = new MCSEntities1())
            {
                foreach (var stopReason in db.AccessTabs)
                {
                    Console.WriteLine(stopReason.AccessTab + "\t" + stopReason.AccessTabName);
                }
            }
        }
    }
}
