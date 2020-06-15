using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContatcWriter
{
    [AttributeUsage(AttributeTargets.Property, AllowMultiple = true)]
    public class IndentAttribute : Attribute
    {
        
    }
}
