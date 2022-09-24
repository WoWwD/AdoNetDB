namespace lab3.src
{
    public static class SQLCommands
    {
        public static string calcCommand = "SELECT * FROM Акции WHERE (Курс_продажи - Курс_покупки)/ Курс_покупки > 0.05";
        public static string avgCommand = "SELECT AVG(Количество) AS [Среднее количество акций фирм] FROM Акции";
        public static string defaultCommand = "SELECT * FROM Акции";
        public static string sortCourseOfBuyASCCommand = "SELECT * FROM Акции ORDER BY Курс_покупки ASC";
        public static string sortCourseOfBuyDESCCommand = "SELECT * FROM Акции ORDER BY Курс_покупки DESC";
        public static string sortCourseOfSellASCCommand = "SELECT * FROM Акции ORDER BY Курс_продажи ASC";
        public static string sortCourseOfSellDESCCommand = "SELECT * FROM Акции ORDER BY Курс_продажи DESC";
        public static string sortFirmASCCommand = "SELECT * FROM Акции ORDER BY Фирма ASC";
        public static string sortFirmDESCCommand = "SELECT * FROM Акции ORDER BY Фирма DESC";
        public static string sortCountASCCommand = "SELECT * FROM Акции ORDER BY Количество ASC";
        public static string sortCountDESCCommand = "SELECT * FROM Акции ORDER BY Количество DESC";
    }
}