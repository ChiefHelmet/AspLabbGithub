using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Lab21.Models
{
    public class Game
    {
        public int number;
        public string result;
        public void SetNumber(int num)
        {
            result = "";

            //om nummer är 0 = datorn börjar spela
            if (num == 0)
            {
                number = Random();
                result = number.ToString();
            }
            else if (num == 1 || num == 2)
            {
                //Spelaren sätter ett värde
                number += num;

                //Kolla om spelaren är vinnare
                if (number == 21 || number > 21)
                {
                    //Avsluta spelet
                    result = "Spelaren är vinnare";
                }
                else
                {
                    //Data skall spela
                    number += Random();

                    //Kolla om datan är vinnare
                    if (number == 21 | number > 21)
                    {
                        //Avsluta
                        result = "Datan är vinnare";
                    }
                    else
                    {
                        result = number.ToString();
                    }
                }
            }

        }
        private int Random()
        {
            return new Random().Next(1, 3);
        }
    }
}