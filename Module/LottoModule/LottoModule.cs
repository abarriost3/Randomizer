using System;
using System.Collections.Generic;
using System.Text;

namespace Randomizer
{
    class LottoModule : ModuleTemplate
    {

        /// <summary>
        /// Where all the calculated Lotto numbers will be stored
        /// </summary>
        private List<int> lottoNumbers;

        /// <summary>
        /// Sets up: how many numbers (excluding extras) the Lotto will have
        /// </summary>
        private int numbers;
        /// <summary>
        /// Min value of a number in this Lotto
        /// </summary>
        private int minValue;
        /// <summary>
        /// Max value of a number in this Lotto
        /// </summary>
        private int maxValue;

        /// <summary>
        /// Indicates if the Lotto uses a complementary number or not
        /// </summary>
        private bool hasComplementary;
        /// <summary>
        /// Indicates if the lotto uses a reinteger number or not
        /// </summary>
        private bool hasReinteger;

        /// <summary>
        /// Constructs the Lotto module from outside
        /// </summary>
        /// <param name="name"></param>
        /// <param name="description"></param>
        /// <param name="numbers"></param>
        /// <param name="minValue"></param>
        /// <param name="maxValue"></param>
        /// <param name="hasComplementary"></param>
        /// <param name="hasReinteger"></param>
        public LottoModule(string name, string description, int numbers, int minValue, int maxValue, bool hasComplementary, bool hasReinteger)
        {
            this.name = name;
            this.description = description;
            this.numbers = numbers;
            this.minValue = minValue;
            this.maxValue = maxValue;
            this.hasComplementary = hasComplementary;
            this.hasReinteger = hasReinteger;

            lottoNumbers = new List<int>();
        }

        /// <summary>
        /// "Plays" a new lotto
        /// </summary>
        public void generateNumbers()
        {
            calculateNumbers();
        }

        /// <summary>
        /// Generates all the things of the lotto
        /// </summary>
        private void calculateNumbers()
        {
            lottoNumbers = new List<int>();

            int generatedNumbers = 0;
            int totalToGenerate = numbers;

            if (hasComplementary) totalToGenerate++;
            if (hasReinteger) totalToGenerate++;

            while (generatedNumbers < totalToGenerate)
            {
                //Tries to generate a number
                int number = SimpleEngine.rng.Next(minValue, maxValue);

                //Checks if its repeated or not
                if(checkRepeatedNumber(number) == false)
                {
                    generatedNumbers++;
                    lottoNumbers.Add(number);
                }
            }
        }

        /// <summary>
        /// Shows in string format, the results of this lotto
        /// </summary>
        /// <returns></returns>
        public string lottoNumbersToString()
        {
            string output = "\nNumbers: ";
            int i = 0;

            while(i<numbers)
            {
                 output = output + "[" + lottoNumbers[i] + "] ";  
                 i++;
            }
            i--;

            if (hasComplementary)
            {
                i++;
                output = output + "\nComplementary: " + lottoNumbers[i] + "   ";
            }
            if (hasReinteger)
            {
                i++;
                output = output + "\nReinteger: " + lottoNumbers[i] + "   ";
            }

            return output + "\n";
        }

        /// <summary>
        /// Checks if a certain number is repeated in the lotto
        /// </summary>
        /// <param name="number"></param>
        /// <returns></returns>
        private bool checkRepeatedNumber(int number)
        {
            bool rep = false;

            if (lottoNumbers.Contains(number))
            {
                rep = true;
            }

            return rep;
        }
    }
}
