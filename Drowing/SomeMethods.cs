using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Drowing
{
    static class SomeMethods
    {
        public static T[] GetTupe<T>(object[] inpArr)
        {
            List<T> outArr = new List<T>();
            foreach (object obj in inpArr)
            {
                if (obj is T)
                {
                    outArr.Add((T)obj);
                }
            }
            return outArr.ToArray();
        }
    }
}
