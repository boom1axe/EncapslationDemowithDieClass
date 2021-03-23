using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EncapslationDemowithDieClass
{
    /// <summary>
    /// A six sided die made from random int.
    /// </summary>
    class Die
    {
        // static fields are shared across
        // all instances of a class
        static Random rand;
        byte minValue;
        byte maxValue;

        //Static Constructers are called once for all instances
        static Die()
        {
            rand = new Random();
        }

        /// <summary>
        /// Default dice is standard six sided dice
        /// with value range of 1-6
        /// </summary>
        public Die():this(1, 6)
        {
            //minValue 1;
            //minValue 6;
            //Roll(); // Roll Die on creation to avoid default
        }

        /// <summary>
        /// Creates a die with the numbers between the minimum
        /// and maxmum values
        /// </summary>
        /// <param name="minValue">The inclusive lower bound</param>
        /// <param name="maxvalue">the inclusive max bound</param>
        public Die(byte minValue, byte maxValue)
        {
            this.minValue = minValue;
            this.maxValue = maxValue;
        }


        /// <summary>
        /// side of die
        /// </summary>
        public byte Value { get; private set; }

        public bool IsHeld { get; set; }

        /// <summary>
        /// Roll a new random byte value
        /// for a standard six sided die.
        /// If the die is held, the currentvalue will be returned
        /// and no new value generated
        /// </summary>
        /// <returns> a byte value betwwen 1-6 </returns>
        public byte Roll()
        {
            // random use exclusive max value
            // meaning true max value is offset by +1.
            const int offSetExclusiveMax = 1;
            if (!IsHeld) // if die is not held
            {
                Value = (byte)rand.Next(minValue, maxValue + offSetExclusiveMax);
            }
            
            return Value;
        }
    }
}
