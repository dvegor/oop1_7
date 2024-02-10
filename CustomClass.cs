using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    [AttributeUsage(AttributeTargets.Field)]
    public class CustomNameAttribute : Attribute
    {
        public string Name { get; }

        public CustomNameAttribute(string name)
        {
            Name = name;
        }
    }
}
