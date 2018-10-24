using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Navigation;

namespace SoftwareStation
{
    class ValidInputs
    {
        public ValidInputs()
        {

        }

        public bool validate(String input)
        {
            if (IsDigitsOnly(input) == false || input.Length > 3)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        static bool IsDigitsOnly(String str)
        {
            foreach (char c in str)
            {
                if (c < '0' || c > '9')
                    return false;
            }

            return true;
        }
    }
}
