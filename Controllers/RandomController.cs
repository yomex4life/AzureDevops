using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using colourapiaugtwentyone.Models;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace colourapiaugtwentyone.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class RandomController : Controller
    {
        [HttpPost]
        public IActionResult Index()
        {
            var posts = new List<Colour>()
            {
                new Colour{ Id=1, Hex="#321567", Rgb="256:256:256", Name="Blue"},
                new Colour{ Id=2, Hex="#676fgh", Rgb="256:256:256", Name="Pink"},
                new Colour{ Id=3, Hex="#093434", Rgb="256:256:256", Name="Yellow"},
                new Colour{ Id=4, Hex="#45678", Rgb="256:256:256", Name="Purple"},
                new Colour{ Id=5, Hex="#dsfs4", Rgb="256:256:256", Name="Green"}
            };

            return Ok(posts);
        }
    }
}
