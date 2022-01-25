using GenericProjectAPI.Models;

namespace GenericProjectAPI.Data.EFCore
{
    public class OneModelRepository : Repository<OneModel, AppDbContext>
    {
        public OneModelRepository(AppDbContext context) : base(context)
        {
        }
    }
}
