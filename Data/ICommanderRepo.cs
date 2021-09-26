using Commander.Models;
using System.Collections.Generic;

namespace Commander.Data
{
    public interface ICommanderRepo
    {
        // get all
        IEnumerable<Command> GetAllCommands();
        // get one
        Command GetCommandById(int id);
    }
}