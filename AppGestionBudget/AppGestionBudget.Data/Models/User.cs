using AppGestionBudget.Data.Models;
using AppGestionBudget.Enum;

namespace AppGestionBudget.Data.Models
{
    public class User {
        public int id { get; set; }
        public string name { get; set; }
        public string username { get; set; }
        public int budget { get; set; }
        public int useMoney { get; set; }

        public List<Expenses> expenseList;

        public User(string name, string username, int budget, int id){
            this.name = name;
            this.username = username;
            this.budget = budget;
            this.id = id;
            expenseList = new List<Expenses>();
        }
        public bool AddExpense(Expenses expenses) {

            expenseList.Add(expenses);
            return true;
        }
        public override string ToString() { return $"User name {name} {username} {id} : as {budget} budget."; }





    }
}
