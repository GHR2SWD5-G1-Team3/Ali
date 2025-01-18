using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq
{
    public static class Extension
    {
        public static void Ali(this List<int> list , Func<int ,bool> fun)
        {
            
            foreach (int x in list)
            {
                if (fun.Invoke(x))
                Console.WriteLine(x);
                
            }
        }
        }
    } 
