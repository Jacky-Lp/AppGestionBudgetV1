namespace AppGestionBudget.DataBase.DbEntities
{
    public class UserDb {
        public int id { get; set; }
        public string name { get; set; }
        public string username { get; set; }
        public int budget { get; set; }
        public int useMoney { get; set; }

        public List<ExpensesDb> expenseList;
    }
}
