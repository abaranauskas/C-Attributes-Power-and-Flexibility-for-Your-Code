using System.Diagnostics;

namespace ContatcWriter
{
    [DebuggerDisplay("First Name={Name} and Age in Years={AgeInYears}")]
    [DebuggerTypeProxy(typeof(ContactDebugDisplay))]
    [DefaultColor(Color =System.ConsoleColor.Magenta)]
    public class Contact
    {
        //[DefaultColor] compile time error cuz just for class
        [Display("bla bla bla: ", System.ConsoleColor.Cyan)]
        [Indent]
        [Indent]
        [Indent]
        [Indent]
        [Indent]
        public string Name { get; set; }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public int AgeInYears { get; set; }
    }
}
