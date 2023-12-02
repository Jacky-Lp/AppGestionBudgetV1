using AppGestionBudget.Enum;

namespace AppGestionBudget.DataBase.Models {
    public class ExpensesDb {
        public int sum { get; set; }
        public string label { get; set; }
        public Category category { get; set; }
        public DateOnly date { get; set; }

        public ExpensesDb(int sum, string label, Category category, DateOnly date)
        {
            this.sum = sum;
            this.label = label;
            this.category = category;
            this.date = date;
        }
    }
}
