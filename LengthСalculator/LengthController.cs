using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LengthСalculator
{
    internal class LengthController
    {
        public List<string> LengthUnit { get; set; } = new List<string>()
        {
             "метр" , "километр" , "сантиметр" , "миллиметр"
        };

        internal object MetematicCalc(string inUint, string outUint, double valueLength)
        {
             if (string.Compare(inUint, outUint) == 0)
                return valueLength;

            if (inUint == "метр" && outUint == "километр") // 1 
                return valueLength / (double) 1000;

            if (inUint == "метр" && outUint == "сантиметр") //2
                return valueLength * 100;


            if (inUint == "метр" && outUint == "миллиметр") //3
                return valueLength  * (double)1000;


            if (inUint == "километр" && outUint == "метр") //4
                return valueLength * (double)1000;



            if (inUint == "километр" && outUint == "сантиметр") //5
                return valueLength * (double)1000 * 100;


            if (inUint == "километр" && outUint == "миллиметр") //6
                return valueLength * (double)1000 * 100 *100;


            return -1;

        }
    }


}
