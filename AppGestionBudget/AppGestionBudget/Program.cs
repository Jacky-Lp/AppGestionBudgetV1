using AppGestionBudget.Data.Models;
using AppGestionBudget.DataBase.DbEntities;
using AppGestionBudget.Enum;
using AppGestionBudget.Service;
using Microsoft.Data.Sqlite;
public class Program {
    static GestionService service = new GestionService();
    public static void Main(string[] args) {

        var theo = service.GetUser().First(x => x.id == 1);
        var leo = service.GetUser().First(x => x.id == 2);
        var fred = service.GetUser().First(x => x.id == 3);

        // --------------------------------------------------------- \\
        Console.WriteLine("Lancement de l'application de gestion d'argent");
        Console.WriteLine(" ");

        ini();

        Console.WriteLine(" ");

        ShowExpenses();

        Console.WriteLine(" ");

        CheckCategoryUser(theo, Category.Informatique);

        Console.WriteLine(" ");

        CheckCategoryUser(leo, Category.Auto);

        Console.WriteLine(" ");

        GetExpenseByMounth(theo, Month.Mai); 

        Console.WriteLine(" ");

        GetMuchCategoryByUser(theo);

        Console.WriteLine(" ");

        MuchCategory();


        Console.WriteLine("  ");

        //add user in Bdd whith expenses
        //User fred = new User("Fred", "prad", 950, 3);

        //Expenses velo = new Expenses(250, "vélo", Category.Loisir, DateOnly.Parse("2022-8-14"));
        //fred.AddExpense(velo);

        //AddUserInDb(fred);


    }

    public static void ShowExpenses() {
        Console.WriteLine("------------Show Expenses----------------------");
        foreach (var ele in service.GetExpenses()) { 
            Console.WriteLine(ele); 
        }
    }
    public static void CheckCategoryUser(User user, Category category) {
        Console.WriteLine($"------------User {user.name} {user.username} in category {category}------------");

        foreach (var ele in service.checkCategory(user, category)) { Console.WriteLine(ele); }
    }
    public static void AddUserInDb(User user) {
        GestionContext Db = new GestionContext();
        var userDb = new UserDb();

        userDb.expenseList = new List<ExpensesDb>();
        userDb.budget = user.budget;
        userDb.name = user.name;
        userDb.budget = user.budget;
        userDb.useMoney = user.useMoney;
        userDb.username = user.username;
        userDb.id = user.id;
        userDb.expenseList = new List<ExpensesDb>();

        foreach (var expense in user.expenseList.ToList())
        {

            var expensesDb = new ExpensesDb();
            expensesDb.date = expense.date;
            expensesDb.sum = expense.sum;
            expensesDb.label = expense.label;
            expensesDb.category = expense.category;
            userDb.expenseList.Add(expensesDb);
        }
        try{
            Db.Add(userDb);
            Db.SaveChanges();
        }catch(SqliteException ex) { Console.WriteLine(ex.SqliteErrorCode); }
    }

    public static void GetExpenseByMounth(User user, Month month) {
        Console.WriteLine($"----------------Check Much Expenses for {user.name} {user.username} in {month}------------------------");

        Console.WriteLine(service.GetExpense(month, user)); 
    }

    public static void GetMuchCategoryByUser(User user) {
        Console.WriteLine($"----------------Check Much Category cost one {user.name} {user.username}------------------------");
        Console.WriteLine(service.GetMuchCategoryUser(user));
    }

    public static void MuchCategory() {
        Console.WriteLine("----------------Check Much Category cost Everybody------------------------");
        Console.WriteLine(service.GetMuchCategory());
    }

    public static void ini() {
        Console.WriteLine($"He as {service.GetUser().Count} User creat");

        foreach(var ele in service.GetUser()) {
            Console.WriteLine(ele.ToString());
        }

    }



}

