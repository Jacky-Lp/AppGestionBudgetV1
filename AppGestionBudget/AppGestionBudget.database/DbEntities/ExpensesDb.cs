using AppGestionBudget.Enum;

namespace AppGestionBudget.DataBase.DbEntities
{
    public class ExpensesDb {
        public int sum { get; set; }
        public int id { get; set; }
        public string label { get; set; }
        public Category category { get; set; }
        public DateOnly date { get; set; }
        public int userId { get; set; }
        public UserDb user { get; set; }
    }
}
