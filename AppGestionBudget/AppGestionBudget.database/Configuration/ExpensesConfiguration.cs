using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using AppGestionBudget.DataBase.DbEntities;

namespace AppGestionBudget.DataBase.Configuration
{
    public class ExpensesConfiguration : IEntityTypeConfiguration<ExpensesDb>
    {
        public void Configure(EntityTypeBuilder<ExpensesDb> builder)
        {
            builder.ToTable("Expenses");
            builder.HasKey(x => x.id);

            builder.HasOne(x => x.user)
                .WithMany(x => x.expenseList)
                .HasForeignKey(x => x.userId);
        }
    }
}
