using LeadSquared.ApplicationProcess.Models;
using LeadSquared.ApplicationProcess.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LeadSquared.ApplicationProcess.Biz
{
    public class GameUnitBiz : IGameUnitBiz
    {
        private readonly IIntegrationService integrationService;

        public GameUnitBiz(IIntegrationService integrationService)
        {
            this.integrationService = integrationService;
        }

        public async Task<GameUnit> GetSuperiorUnit(int unitId1, int unitId2)
        {
            try
            {
                GameUnit unitData = await this.integrationService.GetPlayerData(unitId1);
                GameUnit unitData2 = await this.integrationService.GetPlayerData(unitId2);

                if (unitData != null && unitData2 != null)
                {
                    if (unitData2.hit_points < unitData.attack) { return unitData; }
                    if (unitData.hit_points < unitData2.attack) { return unitData2; }
                    int hits_for_Unit1 = unitData2.hit_points / unitData.attack;
                    int hits_for_Unit2 = unitData.hit_points / unitData2.attack;
 
                    if (hits_for_Unit1 > hits_for_Unit2)
                    {
                        return unitData2;
                    }
                    else
                    {
                        return unitData;
                    }
                }

                throw new Exception($"Unable to Fetch Unit Data from the API for the Inputs: {unitId1} , {unitId2}");
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
