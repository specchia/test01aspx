using System.Data.Entity;

namespace MvcApplication2.Models
{
    public class PersonContext : DbContext
    {
        // È possibile aggiungere codice personalizzato a questo file. Le modifiche non verranno sovrascritte.
        // 
        // Per utilizzare Entity Framework per rimuovere e rigenerare il database
        // automaticamente ogni volta che si modifica lo schema di modello, aggiungere il seguente
        // codice al metodo Application_Start nel file Global.asax.
        // Nota: il database verrà eliminato in modo permanente e ricreato a ogni modifica del modello.
        // 
        // System.Data.Entity.Database.SetInitializer(new System.Data.Entity.DropCreateDatabaseIfModelChanges<MvcApplication2.Models.PersonContext>());

        public PersonContext() : base("name=PersonContext")
        {
        }

        public DbSet<Person> People { get; set; }
    }
}
