using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContatcWriter
{
    [AttributeUsage(AttributeTargets.Class)]
    public class DefaultColorAttribute : Attribute
    {
        public ConsoleColor Color { get; set; } = ConsoleColor.Yellow;
    }
}
