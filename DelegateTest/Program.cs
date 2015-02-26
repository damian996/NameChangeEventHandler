using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateTest
{
    class Program
    {
        static void Main(string[] args)
        {
            var name = new Name("Damian");

            name.NameChanged += OnNameChanged;

            name.FirstName = "Kaminski";

            Console.ReadKey();
        }

        public static void OnNameChanged(object sender, NameChangedEventArgs args)
        {
            Console.WriteLine("Name has changed from {0} to {1}.", args.OldValue, args.NewValue);
        }
    }
}
