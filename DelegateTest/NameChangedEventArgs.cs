using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateTest
{
    public class NameChangedEventArgs : EventArgs
    {
        public NameChangedEventArgs(string oldValue, string newValue)
        {
            OldValue = oldValue;
            NewValue = newValue;
        }
        public string OldValue { get; set; }
        public string NewValue { get; set; }
    }
}
