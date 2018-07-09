using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;

namespace Randomizer
{
    public class SuperRandom
    {
        /// <summary>
        /// Random Number Generator variable
        /// </summary>
        private static RandomNumberGenerator rn;

        public SuperRandom()
        {
            //Defines the random number
            rn = RandomNumberGenerator.Create();
        }

        ///<summary>
        /// Returns a random number within the specified range
        ///</summary>
        ///<param name=”minValue”>The inclusive minimum number returned.</param>
        ///<param name=”maxValue”>The exclusive maximum random number returned. maxValue must be greater or equal than minValue.</param>
        public int Next(int minValue, int maxValue)
        {
            return (int)Math.Round(NextDouble() * (maxValue - minValue - 1)) + minValue;
        }

        ///<summary>
        /// Returns a positive random number, or 0.
        ///</summary>
        public int Next()
        {
            return Next(0, Int32.MaxValue);
        }

        /// <summary>
        /// Returns a random boolean
        /// </summary>
        /// <returns></returns>
        public bool NextBoolean()
        {
            if ((this.Next() % 2 == 1))
                return true;
            else
                return false;
        }

        /// <summary>
        /// Returns a number from 0.0 to 1.0
        /// </summary>
        /// <returns></returns>
        private double NextDouble()
        {
            byte[] b = new byte[4];
            rn.GetBytes(b);
            return (double)BitConverter.ToUInt32(b, 0) / UInt32.MaxValue;
        }
    }
}
