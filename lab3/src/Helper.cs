using System;

namespace lab3.src
{
    class Helper
    {
        public bool isEmpty(string str)
        {
            if (str == null || str == "" || str == " ") return true;
            return false;
        }
        public bool isAllEquals(
            string oldValue1,
            int oldValue2,
            decimal oldValue3,
            decimal oldValue4,
            string newValue1,
            int newValue2,
            decimal newValue3,
            decimal newValue4
        )
        {
            if (oldValue1 == newValue1 && oldValue2 == newValue2 && oldValue3 == newValue3 && oldValue4 == newValue4)
            {
                return true;
            }
            return false;
        }

        public bool isAllEquals(DateTime oldValue1, int oldValue2, DateTime newValue1, int newValue2)
        {
            if (oldValue1 == newValue1 && oldValue2 == newValue2)
            {
                return true;
            }
            return false;
        }
    }
}