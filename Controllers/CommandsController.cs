using System.Collections.Generic;
using Commander.Data;
using Commander.Models;
using Microsoft.AspNetCore.Mvc;

namespace Commander.Controllers
{
    
    [Route("api/commands")]
    // Gives us out of the box behaviors
    [ApiController]
    public class CommandsController : ControllerBase
    {
        private readonly ICommanderRepo _repository;

        //add constructor so dependency can be injected
        //Whatever is injected (repository), we want to assign it to _repository
        public CommandsController(ICommanderRepo repository)
        {
            _repository = repository;
        }
        // private readonly MockCommanderRepo _repository = new MockCommanderRepo();
        
        [HttpGet]       
        public ActionResult <IEnumerable<Command>> GetaAllCommands()
        {
            var commandItems = _repository.GetAllCommands();

            return Ok(commandItems);
        }
        //GET api/commands/{id}
        [HttpGet("{id}")]
        public ActionResult <Command> GetCommandById(int id)
        {
            var commandItem = _repository.GetCommandById(id);
            return Ok(commandItem);
        }
    }
}