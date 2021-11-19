using Commander.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Commander.Data
{
    public class MockCommanderRepo : ICommanderRepo
    {
        public void CreateCommand(Command cmd)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Command> GetAllCommands()
        {
            var commands = new List<Command>
            {
            new Command{Id = 0, HowTo = "Boil and egg", Line = "Boil water", Platform = "Kettle" },
            new Command { Id = 1, HowTo = "Cut bread", Line = "Get a knife", Platform = "Knife" },
            new Command{Id = 2, HowTo = "Make cup of tea", Line = "Take teabag", Platform = "Cup" }
            };

            return commands;
        }

        public Command GetCommandById(int id)
        {
            return new Command { Id = 0, HowTo = "Boil and egg", Line = "Boil water", Platform = "Kettle" };
        }

        public bool SaveChanges()
        {
            throw new NotImplementedException();
        }
    }
}
