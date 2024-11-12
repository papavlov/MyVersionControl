using Microsoft.AspNetCore.Mvc;
using MyVersionControl.Models;
using System;

namespace MyVersionControl.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class RepositoryController
    {
        [HttpGet]
        public IActionResult GetRepositories()
        {
            throw new NotImplementedException("This endpoint has not been implemented yet.");
        }

        [HttpGet("{id}")]
        public IActionResult GetRepository(int id)
        {
            throw new NotImplementedException("This endpoint has not been implemented yet.");
        }

        [HttpPost]
        public IActionResult CreateRepository([FromBody] Repository model)
        {
            throw new NotImplementedException("This endpoint has not been implemented yet.");
        }

        [HttpPut]
        public IActionResult UpdateRepository(int id, [FromBody] Repository model)
        {
            throw new NotImplementedException("This endpoint has not been implemented yet.");
        }

        [HttpDelete]
        public IActionResult DeleteRepository(int id)
        {
            throw new NotImplementedException("This endpoint has not been implemented yet.");
        }
    }
}
