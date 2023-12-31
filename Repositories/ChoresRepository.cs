using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace chore_score.Repositories
{
    public class ChoresRepository
    {
        private List<Chore> dbChores;

        public ChoresRepository()
        {
            dbChores = new List<Chore>();
            dbChores.Add(new Chore("Mop", 20, false, 3));
            dbChores.Add(new Chore("Vacuum", 12, false, 5.5));
            dbChores.Add(new Chore("Windows", 10, false, 4));
            dbChores.Add(new Chore("Mow", 30, false, 1));
        }

        internal Chore CreateChore(Chore choreData)
        {
            dbChores.Add(choreData);
            return choreData;
        }

        internal Chore GetChoreByName(string choreName)
        {
            Chore foundChore = dbChores.Find(chore => chore.Name == choreName);
            return foundChore;
        }

        internal List<Chore> GetChores()
        {
            return dbChores;
        }

        internal Chore RemoveChore(string choreName)
        {
            Chore choreToBeRemoved = GetChoreByName(choreName);
            dbChores.Remove(choreToBeRemoved);
            return choreToBeRemoved;
        }

    }
}