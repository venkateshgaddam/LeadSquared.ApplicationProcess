using LeadSquared.ApplicationProcess.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LeadSquared.ApplicationProcess.Biz
{
    public interface IGameUnitBiz
    {
        Task<GameUnit> GetSuperiorUnit(int unitId1, int unitId2);
    }
}
