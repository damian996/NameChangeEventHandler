using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateTest
{
    public class Name
    {
        public Name(string firstName)
        {
            _firstName = firstName;
        }

        private string _firstName;

        public string FirstName
        {
            get { return _firstName; }
            set
            {
                var oldValue = _firstName;
                _firstName = value;
                if (NameChanged != null)
                    NameChanged(this, new NameChangedEventArgs(oldValue, value));
            }
        }

        public event NameChangedDelegate NameChanged;
    }
}
