namespace AppGestionBudget.DataBase.Models
{
    public class UserDb {

        public string name { get; set; }
        public string username { get; set; }
        public int budget { get; set; }
        public int useMoney { get; set; }

        public List<ExpensesDb> expenseList { get; }

        public UserDb(string name, string username, int budget)
        {
            this.name = name;
            this.username = username;
            this.budget = budget;
            expenseList = new List<ExpensesDb>();
        }


    }
}
