using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Text;

namespace ContatcWriter
{
    public class ContactConsoleWriter
    {
        private readonly Contact _contact;
        private ConsoleColor _color;

        public ContactConsoleWriter(Contact contact)
        {
            _contact = contact;
        }

        //[Obsolete("This will be removed in V2", error:true)]
        //it gives warning that the method is Obsolete. So developer can think that it will be some changes about that
        public void Write()
        {
            UseDefaultColor();
            WriteFirstName();

            WriteAge();
        }

        private void UseDefaultColor()
        {
            var contactAttribute = Attribute.GetCustomAttribute(typeof(Contact), typeof(DefaultColorAttribute)) as DefaultColorAttribute;
            if (contactAttribute != null)
            {
                Console.ForegroundColor = contactAttribute.Color;
            }
        }

        private void WriteAge()
        {
            OutputDebugInfo();
            OutputExtraInfo();
            Console.WriteLine(_contact.AgeInYears);
        }

        [Conditional("DEBUG")] //only runs on debug mode but it will be compiled to assembly
        private void OutputDebugInfo()
        {
            Console.WriteLine("**DEBUG MORE***");
        }

        [Conditional("EXTRA")]
        private void OutputExtraInfo()
        {
            Console.WriteLine("**Extra MORE***");
        }

        private void WriteFirstName()
        {
            PropertyInfo propertyInfo = typeof(Contact).GetProperty(nameof(Contact.Name));
            var firstNameDisplayAttribute = Attribute.GetCustomAttribute(propertyInfo, typeof(DisplayAttribute)) as DisplayAttribute;

            var indentationAttributes = Attribute.GetCustomAttributes(propertyInfo, typeof(IndentAttribute)) as IEnumerable<IndentAttribute>;


            PreserveForegroundColor();

            var sb = new StringBuilder();

            if (indentationAttributes.Any())
            {
                foreach (var indentationAttribute in indentationAttributes)
                {
                    sb.Append(new string(' ', 4));
                }
            }

            if (firstNameDisplayAttribute!=null)
            {
                Console.ForegroundColor=firstNameDisplayAttribute.Color;
                sb.Append(firstNameDisplayAttribute.Label);
            }

            if (_contact.Name!=null)
            {
                sb.Append(_contact.Name);
            }

            Console.WriteLine(sb);
            RestoreForegroundColor();

            //Console.WriteLine(_contact.Name);
        }

        private void PreserveForegroundColor()
        {
            _color = Console.ForegroundColor;
        }

        private void RestoreForegroundColor()
        {
            Console.ForegroundColor = _color;
        }
    }
}
