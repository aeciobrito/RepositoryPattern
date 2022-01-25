using GenericProjectAPI.Data.EFCore;
using GenericProjectAPI.Models;

namespace GenericProjectAPI.Controllers
{
    public class AnotherModelController : GenericController<AnotherModel, AnotherModelRepository>
    {
        public AnotherModelController(AnotherModelRepository repository) : base(repository)
        {
        }
    }
}
