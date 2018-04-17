using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dz_15
{
    class Program
    {
        static void Main(string[] args)
        {
            using (CompanyModel context = new CompanyModel())
            {
                context.Associates.ToArray();
            }
        }
    }
}
