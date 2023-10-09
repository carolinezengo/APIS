using Newtonsoft.Json;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsAPI
{

    public class Produto
      {
        public int id { get; set; }
        public string codigo { get; set; }
        public string descricao { get; set; }
        public string un { get; set; }
        public int idCategoria { get; set; }
        public Decimal precoCusto { get; set; }
        public Decimal precoVenda { get; set; }
        public int estoqueMinimo { get; set; }
        public int estoqueMaximo { get; set; }
        public int estoqueSaldoInicial { get; set; }
        public object estoqueSaldoInicialData { get; set; }
        public string ativo { get; set; }
        public int cadastradoUsuario { get; set; }
        public DateTime cadastradoData { get; set; }
        public int alteradoUsuario { get; set; }
        public object alteradoData { get; set; }
        public object idCategoriaNavigation { get; set; }
        public object unNavigation { get; set; }
      
        public async Task<List<Produto>> ObterProdutosAsync()
        {
            var client = new RestClient();
            var request = new RestRequest("https://localhost:7024/api/Produtos",
                Method.Get);
            RestResponse response = await client.ExecuteAsync(request);
            if (response.StatusCode == System.Net.HttpStatusCode.OK)
                return JsonConvert.DeserializeObject<List<Produto>>(response.Content);
            else
                return null;

        }

        public async Task<Produto> ObterProdutoAsync(int id)
        {
            var client = new RestClient();
            var request = new RestRequest("https://localhost:7024/api/Produtos/" + id,
                Method.Get);
            RestResponse response = await client.ExecuteAsync(request);
            if (response.StatusCode == System.Net.HttpStatusCode.OK)
                return JsonConvert.DeserializeObject<Produto>(response.Content);
            else
                return null;

        }

        public async Task<bool> AtualizarProdutoAsync(int id, Produto produto)
        {
            var client = new RestClient();
            var request = new RestRequest("https://localhost:7024/api/Produtos/" + id,
                Method.Put);
            request.RequestFormat = DataFormat.Json;
            request.AddJsonBody(produto);
            RestResponse response = await client.ExecuteAsync(request);
            if (response.IsSuccessStatusCode)
                return true;
            else
                return false;

        }

        public async Task<bool> AdicionarProdutoAsync(Produto produto)
        {
            var client = new RestClient();
            var request = new RestRequest("https://localhost:7024/api/Produtos/" + id,
                Method.Post);
            request.RequestFormat = DataFormat.Json;
            request.AddJsonBody(produto);
            RestResponse response = await client.ExecuteAsync(request);
            if (response.IsSuccessStatusCode)
                return true;
            else
                return false;

        }
        public async Task<bool>EcluirProdutoAsync(int id)
        {
            var client = new RestClient();
            var request = new RestRequest("https://localhost:7024/api/Produtos/" + id,
                Method.Delete);
           
            RestResponse response = await client.ExecuteAsync(request);
            if (response.IsSuccessStatusCode)
                return true;
            else
                return false;

        }

    }

}
