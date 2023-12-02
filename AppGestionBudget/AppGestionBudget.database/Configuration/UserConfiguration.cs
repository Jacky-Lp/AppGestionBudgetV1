using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using AppGestionBudget.DataBase.DbEntities;

namespace AppGestionBudget.DataBase.Configuration
{
    public class UserConfiguration : IEntityTypeConfiguration<UserDb>
    {
        public void Configure(EntityTypeBuilder<UserDb> builder)
        {
            builder.HasKey(x => x.id);
        }
    }
}
