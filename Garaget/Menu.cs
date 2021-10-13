﻿namespace Garaget
{
    public abstract class Menu
    {
        public abstract Menu ShowMenu();
        public abstract bool HandleInput();

        public bool cont = true;

        /// <summary>
        /// Returns the integer based on amountOfMenuOptions. Assumes a 0-based menu system.
        /// </summary>
        /// <param name="value"></param>
        /// <param name="amountOfMenuOptions"></param>
        /// <returns>If not an integer, return -1, if integer higher than maxValue return int.MaxValue</returns>
        public int ParseInput(string value, int amountOfMenuOptions)
        {
            int returnValue;
            if(!int.TryParse(value, out returnValue))
            {
                return -1;
            }
            if(returnValue > amountOfMenuOptions)
            {
                return int.MaxValue;
            }
            return returnValue;
        }
    }
}
