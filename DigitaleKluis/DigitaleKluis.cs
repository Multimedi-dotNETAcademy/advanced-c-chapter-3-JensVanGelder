using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DigitaleKluis
{
    class DigitaleKluis
    {
        private int code;
        private bool canShowCode;

        public bool CanShowCode
        {
            get { return canShowCode; }
            set { canShowCode = value; }
        }

        public int Code
        {
            get 
            {
                if (canShowCode)
                {
                    return code;
                }
                else
                {
                    return -666;
                }
            }
            private set { code = value; }
        }

        public int CodeLevel
        {
            get { return code / 1000; }
        }


        public DigitaleKluis(int getal)
        {
            code = getal;
        }

        public string TryCode(int number)
        {
            CanShowCode = false;
            if (number == -666)
            {
                return "You dirty cheater!";
            }
            else if (number == code)
            {
                CanShowCode = true;
                return $"Correct! It was {Code}";
            }
            else
            {
                return $"Wrong!";
            }
        }
    }
}
