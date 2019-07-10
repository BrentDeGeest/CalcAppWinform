using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Diagnostics;

namespace CalculatorAppLibrary
{
    public class Calculation
    {
        public void ConvertNumbers(ref double num1, ref double num2, string num)
        {
            if (num != null && num != "")
            {
                if (num1 == 0)
                {
                    num1 = Convert.ToDouble(num);

                }
                else
                {
                    num2 = Convert.ToDouble(num);
                }
                Debug.WriteLine("nummer 1(GetNumber): " + num1);
                Debug.WriteLine("nummer 2(GetNumber): " + num2);

            }
        }

        public string PosNeg( string resultaat)
        {
            try
            {
                double numSwitch = Convert.ToDouble(resultaat);
                numSwitch *= -1;
                return resultaat = numSwitch.ToString();
            }
            catch (Exception)
            {
                return  "";
            }
        }
    }
}
