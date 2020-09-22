using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Portal
{
    class GravarNota
    {
        public List<Notas> Add(Notas nota)
        {
          
                var url = "http://localhost:53462/cadastro/adicionaNotas";

                var httpClient = new HttpClient();
                var serializedObject = JsonConvert.SerializeObject(nota);
                var content = new StringContent(serializedObject, Encoding.UTF8, "application/json");
                var resultRequest = httpClient.PostAsync(url, content);
                resultRequest.Wait();
               
                    var result = resultRequest.Result.Content.ReadAsStringAsync();
                    result.Wait();
                    var resultado = JsonConvert.DeserializeObject<List<Notas>>(result.Result);
                    return resultado;
           

           // List<Notas> listaNotas = new List<Notas>();
           // return listaNotas;
        }

        public List<Notas> Deleta(string aluno)
        {
            try
            {
                var url = "http://localhost:53462/cadastro/deletaNotas";

                var httpClient = new HttpClient();
                var resultRequest = httpClient.DeleteAsync(url + $"?aluno={aluno}");
                resultRequest.Wait();
                if (resultRequest.Result.IsSuccessStatusCode)
                {
                    var result = resultRequest.Result.Content.ReadAsStringAsync();
                    result.Wait();
                    var resultado = JsonConvert.DeserializeObject<List<Notas>>(result.Result);
                    return resultado;
                }
            }
            catch { }

            List<Notas> listaNotas = new List<Notas>();
            return listaNotas;
        }

        public List<Notas> Busca(Notas nota)
        {
            try
            {
                var url = "http://localhost:53462/cadastro/mostraNotas";

                var httpClient = new HttpClient();
                var resultRequest = httpClient.GetAsync(url);
                resultRequest.Wait();
                if (resultRequest.Result.IsSuccessStatusCode)
                {
                    var result = resultRequest.Result.Content.ReadAsStringAsync();
                    result.Wait();
                    var resultado = JsonConvert.DeserializeObject<List<Notas>>(result.Result);
                    return resultado;
                }
            } catch { }

            List<Notas> listaNotas = new List<Notas>();
            return listaNotas;
            
        }
    }
}

