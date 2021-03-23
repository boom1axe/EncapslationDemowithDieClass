using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EncapslationDemowithDieClass
{
    class Program
    {
        /// <summary>
        /// Desplays value of five dice (Yahtzee)
        /// using console.
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {

            Die[] dice = new Die[5];
            for(int i = 0; i < dice.Length; i++)
            {
                dice[i] = new Die();
                Console.WriteLine(dice[i].Value);
            }

            // Value cant be change becuse
            // set is private in die class
            //Die.Value = 6;
        }
    }
}
