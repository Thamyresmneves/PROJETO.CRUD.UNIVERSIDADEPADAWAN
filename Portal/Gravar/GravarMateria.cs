using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Portal
{
    class GravarMateria
    {
        public List<Materia> Add(Materia materia)
        {
            try
            {
                var url = "http://localhost:53462/cadastro/adicionaMateria";
                var httpClient = new HttpClient();
                var serializedObject = JsonConvert.SerializeObject(materia);
                var content = new StringContent(serializedObject, Encoding.UTF8, "application/json");
                var resultRequest = httpClient.PostAsync(url, content);
                resultRequest.Wait();
                if (resultRequest.Result.IsSuccessStatusCode)
                {
                    var result = resultRequest.Result.Content.ReadAsStringAsync();
                    result.Wait();
                    var resultado = JsonConvert.DeserializeObject<List<Materia>>(result.Result);
                    return resultado;
                }
            } catch { }

            List<Materia> listaMateria = new List<Materia>();
            return listaMateria;

        }

        public List<Materia> Deleta(String materia)
        {
            try
            {
                var url = "http://localhost:53462/cadastro/deletaMateria";

                var httpClient = new HttpClient();
                var resultRequest = httpClient.DeleteAsync(url);

                if (resultRequest.Result.IsSuccessStatusCode)
                {
                    resultRequest.Wait();
                    var result = resultRequest.Result.Content.ReadAsStringAsync();
                    result.Wait();
                    var resultado = JsonConvert.DeserializeObject<List<Materia>>(result.Result);
                    return resultado;
                }

            }
            catch { }

            List<Materia> listaMateria = new List<Materia>();
            return listaMateria;

        }


        public List<Materia> BuscaMateria (Materia materia)
        {
            var url = "http://localhost:53462/cadastro/mostraMateria";

            var httpClient = new HttpClient();
            var resultRequest = httpClient.GetAsync(url);
            resultRequest.Wait();
            var result = resultRequest.Result.Content.ReadAsStringAsync();
            result.Wait();
            var resultado = JsonConvert.DeserializeObject<List<Materia>>(result.Result);
            return resultado;
        }
        public List<Materia> Busca()
        {
            var url = "http://localhost:53462/cadastro/mostraMateria";

            var httpClient = new HttpClient();
            var resultRequest = httpClient.GetAsync(url);
            resultRequest.Wait();
            var result = resultRequest.Result.Content.ReadAsStringAsync();
            result.Wait();
            var resultado = JsonConvert.DeserializeObject<List<Materia>>(result.Result);
            return resultado;
        }
    }
}
