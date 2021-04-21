using LeadSquared.ApplicationProcess.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace LeadSquared.ApplicationProcess.Service
{
    public class IntegrationService : IIntegrationService
    {
        public async Task<GameUnit> GetPlayerData(int id)
        {
            try
            {
                string Url = string.Format(CultureInfo.InvariantCulture, GlobalConstants.URL, id);
                var request = new HttpRequestMessage(HttpMethod.Get, Url);
                var client = new HttpClient();

                HttpResponseMessage httpResponseMessage = await client.SendAsync(request).ConfigureAwait(false);

                var playerData = await httpResponseMessage.Content.ReadAsStringAsync();

                if (httpResponseMessage.StatusCode == System.Net.HttpStatusCode.OK)
                {
                    return JsonConvert.DeserializeObject<GameUnit>(playerData);
                }
                else return null;
            }
            catch (HttpRequestException ex)
            {
                throw new Exception(ex.Message, ex.InnerException);
            }
        }
    }
}
