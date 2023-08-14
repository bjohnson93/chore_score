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

            internal List<Chore> GetChores()
            {
                List<Chore> chores = _choresRepository.GetChores();
                return chores;
            }

    }


    
}