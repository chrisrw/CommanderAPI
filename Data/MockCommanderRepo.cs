using System.Collections.Generic;
using Commander.Models;

namespace Commander.Data
{
    public class MockCommanderRepo : ICommanderRepo
    {
        public IEnumerable<Command> GetAllCommands()
        {
            var commands = new List<Command>
            {
                new Command{Id=0, HowTo="Boil an egg", Line="Boil Water", Platform="Kettle and Pan"},
                new Command{Id=0, HowTo="Cut bread", Line="get knife", Platform="knife"},
                new Command{Id=0, HowTo="Make cup of tea", Line="Place Teabag in cup", Platform="Kettle and cup"}
            };
            return commands;
        }

        public Command GetCommandById(int id)
        {
            return new Command{Id=0, HowTo="Boil an egg", Line="Boil Water", Platform="Kettle and Pan"};
        }
    }
}