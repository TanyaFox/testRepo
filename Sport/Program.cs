using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data;

namespace Sport
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var c = new Context())
            {
                c.Players.ToList();
            }
        }
    }
}
