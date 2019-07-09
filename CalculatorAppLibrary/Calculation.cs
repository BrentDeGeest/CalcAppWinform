using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;


namespace CalculatorAppLibrary
{
    public class Calculation
    {
        DataTable dataTable = new DataTable();


        public string Equals(string resultText, string calculationText)
        {

            try
            {
                calculationText = resultText;
                return resultText = dataTable.Compute(resultText, null).ToString();
            }
            catch (Exception)
            {

                Console.WriteLine("Error, resetting values.");
                return "";
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
