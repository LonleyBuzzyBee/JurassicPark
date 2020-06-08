using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using JurassicPark.Models;

namespace JurassicPark.Controllers
{
  [Route("api/[controller]")]
  [ApiController]
  public class AnimalsController : ControllerBase
  {
    private JurassicParkContext _db;

    public AnimalsController(JurassicParkContext db)
    {
      _db = db;
    }

    // GET api/animals
    [HttpGet]
    public ActionResult<IEnumerable<Animal>> Get()
    {
      return _db.Animals.ToList();
    }

    // POST api/animals
    [HttpPost]
    public void Post([FromBody] Animal animal)
    {
      _db.Animals.Add(animal);
      _db.SaveChanges();
    }
  }
}