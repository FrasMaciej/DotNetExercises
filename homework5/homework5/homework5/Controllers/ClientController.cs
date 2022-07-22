using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using homework5.Interfaces;
using homework5.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace homework5.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClientController : ControllerBase
    {
        private IClientService _clientService;

        public ClientController(IClientService clientService)
        {
            _clientService = clientService;
        }

        [HttpGet("")]
        [Produces(typeof(List<Client>))]
        public IActionResult GetClients()
        {
            var client = _clientService.GetAll();
            return Ok(client);
        }

        [HttpGet("{id:int}")]
        [Produces(typeof(Client))]
        public IActionResult GetClientById([FromRoute] int id)
        {
            var client = _clientService.Get(id);

            if (client == null)
                return NotFound();

            return Ok(client);
        }

        [HttpPost("")]
        public IActionResult CreateClient([FromBody] Client client)
        {
            var id = _clientService.Create(client);

            return Created($"api/client/{id}", id);
        }

        [HttpPut("{id:int}")]
        public IActionResult Updateclient([FromRoute] int id, [FromBody] Client client)
        {
            bool isUpdated = _clientService.Update(id, client);
            if (isUpdated)
                return NoContent();

            return NotFound();
        }

        [HttpDelete("{id:int}")]
        public IActionResult DeleteClient([FromRoute] int id)
        {
            bool isDeleted = _clientService.Delete(id);
            if (isDeleted)
                return NoContent();
            return NotFound();
        }

    }
}
