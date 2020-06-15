using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContatcWriter
{
    public class ContactDebugDisplay
    {
        private readonly Contact _contact;

        public ContactDebugDisplay(Contact contact)
        {
            _contact = contact;
        }

        public string UpperName => _contact.Name.ToUpperInvariant();
        public string AgeInHex => _contact.AgeInYears.ToString("X");
    }
}
