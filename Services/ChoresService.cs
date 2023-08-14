using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace chore_score.Services
{
    public class ChoresService
    {
        private readonly ChoresRepository _choresRepository;

        public ChoresService(ChoresRepository choresRepository)
        {
            _choresRepository = choresRepository;
        }

        internal Chore CreateChore(Chore choreData)
        {
            Chore chore = _choresRepository.CreateChore(choreData);
            return chore;
        }

        internal Chore GetChoreByName(string choreName)
        {
            Chore chore = _choresRepository.GetChoreByName(choreName);

            if (chore == null)
            {
                throw new Exception($"No chore with the name of {choreName}");
            }
            return chore;
        }

        internal List<Chore> GetChores()
        {
            List<Chore> chores = _choresRepository.GetChores();
            return chores;
        }

        internal Chore RemoveChore(string choreName)
        {
            Chore chore = _choresRepository.RemoveChore(choreName);
            return chore;
        }

        internal Chore UpdateChore(string choreName, Chore choreData)
        {
            Chore originalChore = GetChoreByName(choreName);
            originalChore.Name = choreData.Name.Length > 0 ? choreData.Name : originalChore.Name;
            originalChore.MinutesToComplete = choreData.MinutesToComplete >= 0 ? choreData.MinutesToComplete : originalChore.MinutesToComplete;
            originalChore.Finished = choreData.Finished == null ? originalChore.Finished : choreData.Finished;
            originalChore.Rooms = choreData.Rooms >= 0 ? choreData.Rooms : originalChore.Rooms;
            return choreData;
        }
    }



}