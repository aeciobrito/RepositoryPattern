using GenericProjectAPI.Models;

namespace GenericProjectAPI.Data.EFCore
{
    public class AnotherModelRepository : Repository<AnotherModel, AppDbContext>
    {
        public AnotherModelRepository(AppDbContext context) : base(context)
        {
        }
    }
}
