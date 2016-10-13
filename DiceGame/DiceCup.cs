using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DiceGameArray
{
    class DiceCup
    {
      
        //private Die die1;
        //private Die die2;
        //private Die die3;
        Die[] numberOfDice;
    

        public DiceCup()
        {
            // VERY IMPORTANT! When we have instance fields of a class type,
            // we MUST remember to create actual objects in the constructor,
            // that the instance fields can then point to.
            //die1 = new Die(10);
            //die2 = new Die(4);
            //die3 = new Die(20);
            numberOfDice = new Die[5];
            numberOfDice[0] = new Die(6);
            numberOfDice[1] = new Die(6);
            numberOfDice[2] = new Die(10);
            numberOfDice[3] = new Die(10);
            numberOfDice[4] = new Die(10);

        }

        //public DiceCup(int [] terninger )
        //{

        //}

        /// <summary>
        /// Ruller alle terningerne i bægeret
        /// </summary>
        public void RollAllDiceInCup()
        {
            numberOfDice[0].RollDie();
            numberOfDice[1].RollDie();
            numberOfDice[2].RollDie();
            numberOfDice[3].RollDie();
            numberOfDice[4].RollDie(); 
            //die1.RollDie();
            //die2.RollDie();
            //die3.RollDie();
        }


        // You must create a method with the below header:
        /// <summary>
        /// returnerer værdierer fra de tre terninger
        /// </summary>
        /// <returns></returns>
         public int GetTotalValue()
        {
            return numberOfDice[0].GetValue() + numberOfDice[1].GetValue() + numberOfDice[2].GetValue() +
                numberOfDice[3].GetValue() + numberOfDice[4].GetValue();
            //return die1.GetValue() + die2.GetValue() + die3.GetValue();
        }
        
        public void ShowValues()
        {

            Console.WriteLine("Dice 1 = {0}, Dice 2 = {1}, Dice 3 = {2}, Dice 4 = {3}, Dice 5 = {4}", numberOfDice[0].GetValue(), 
                numberOfDice[1].GetValue(), numberOfDice[2].GetValue(), numberOfDice[3].GetValue(), numberOfDice[4].GetValue());       


        }

        // You must create a method with the below header:
         public bool IsTotalValueLargerThan(int value)
        {
            int terningeværdi;
            bool checker;
            terningeværdi = GetTotalValue();

            checker = terningeværdi > value;

            return checker;

        }


    }
}
