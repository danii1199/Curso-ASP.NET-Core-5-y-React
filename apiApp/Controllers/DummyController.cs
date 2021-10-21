using System;
using apiApp.Context;
using Microsoft.AspNetCore.Mvc;

namespace apiApp.Controllers
{
    [ApiController]
    [Route("api/testdatabase")]
    public class DummyController : ControllerBase
    {
        private MovieInfoContext _context;

        public DummyController(MovieInfoContext context)
        {
            _context = context ?? throw new ArgumentNullException(nameof(context));
        }

        public IActionResult TestDatabase()
        {
            return Ok();
        }
    }
}