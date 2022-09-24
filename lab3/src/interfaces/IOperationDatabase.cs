namespace lab3.src.interfaces
{
    interface IOperationDatabase
    {
        void fillDatabase();
        void updateDatabase();
        // Добавление только для таблиц акций и брокера
        void addEntryDatabase(string firm, int count, string courseOfBuy, string courseOfSell, bool withBroker);
        void closeConnectionDatabase();
    }
}