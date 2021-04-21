using LeadSquared.ApplicationProcess.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LeadSquared.ApplicationProcess.Service
{
    public interface IIntegrationService
    {

        Task<GameUnit> GetPlayerData(int id);
    }
}
