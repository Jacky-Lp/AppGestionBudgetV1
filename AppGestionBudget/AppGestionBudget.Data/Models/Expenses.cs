using AppGestionBudget.Enum;

namespace AppGestionBudget.Data.Models
{
    public class Expenses{
        public int sum {  get; set; }
        public string label { get; set; }
        public Category category { get; set; }
        public DateOnly date {  get; set; }

        public Expenses(int sum, string label, Category category, DateOnly date) {
            this.sum = sum;
            this.label = label;
            this.category = category;
            this.date = date;
        }

        public override string ToString()
        {
            return $"Exemses {sum} for {label} {category} on {date}";
        }

    }
}
