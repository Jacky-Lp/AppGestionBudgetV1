namespace AppGestionBudget.DataBase.Service
{
    public class DbService {
        public GestionContext gestioncontext { get; set; }

        public DbService() {
            GestionContext gestionContext = new GestionContext();
        }
    }
}
