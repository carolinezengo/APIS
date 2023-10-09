using Newtonsoft.Json;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsAPI
{

    public class UnidadeMedida
    {
        public string sigla { get; set; }
        public string descricao { get; set; }
        public bool casasDecimais { get; set; }
        public string ativa { get; set; }
        public int cadastradoUsuario { get; set; }
        public DateTime cadastradoData { get; set; }
        public int alteradoUsuario { get; set; }
        public DateTime alteradoData { get; set; }
        public object[] produtos { get; set; }


        public async Task<List<UnidadeMedida>> ObterUnidadeMedidasAsync()
        {
            var client = new RestClient();
            var request = new RestRequest("https://localhost:7024/api/UnidadesMedidas",
                Method.Get);
            RestResponse response = await client.ExecuteAsync(request);
            if (response.StatusCode == System.Net.HttpStatusCode.OK)
                return JsonConvert.DeserializeObject<List<UnidadeMedida>>(response.Content);
            else
                return null;

        }

    }

}
