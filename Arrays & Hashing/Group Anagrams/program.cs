using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class program
    {
        public IList<IList<string>> GroupAnagrams(string[] strs)
        {
            var dict = new Dictionary<string, IList<string>>();
            foreach (var str in strs)
            {
                var key = GetKey(str);
                if (dict.ContainsKey(key))
                {
                    dict[key].Add(str);
                }
                else
                {
                    dict.Add(key, new List<string> { str });
                }
            }

            return new List<IList<string>>(dict.Values);

        }

        private string GetKey(string str)
        {
            var array = str.ToCharArray();
            Array.Sort(array);
            return new string(array);
        }
    }
}
