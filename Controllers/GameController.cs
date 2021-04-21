using LeadSquared.ApplicationProcess.Biz;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LeadSquared.ApplicationProcess.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GameController : BaseController
    {
        private readonly IGameUnitBiz gameUnitBiz;

        public GameController(IGameUnitBiz gameUnitBiz)
        {
            this.gameUnitBiz = gameUnitBiz;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="unitid1"></param>
        /// <param name="unitid2"></param>
        /// <returns></returns>
        [HttpGet("{unitid1}/{unitid2}")]
        public async Task<IActionResult> FetchSuperiorUnit(int unitid1, int unitid2)
        {
            if (unitid1 < 1 || unitid1 > 100 || unitid2 < 1 || unitid2 > 100)
            {
                ModelState.AddModelError("InValid", $"InValid Inputs {unitid1} , {unitid2}. Inputs should be in range of 1-100");
                return BadRequest(ModelState);
            }

            var unitData = await gameUnitBiz.GetSuperiorUnit(unitid1, unitid2);

            return PackageData(unitData, System.Net.HttpStatusCode.OK);
        }

    }
}
