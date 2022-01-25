#nullable disable
using Microsoft.AspNetCore.Mvc;
using GenericProjectAPI.Models;
using GenericProjectAPI.Data.EFCore;

namespace GenericProjectAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OneModelController : GenericController<OneModel, OneModelRepository>
    {
        public OneModelController(OneModelRepository repository) : base(repository)
        {
        }
    }
}
