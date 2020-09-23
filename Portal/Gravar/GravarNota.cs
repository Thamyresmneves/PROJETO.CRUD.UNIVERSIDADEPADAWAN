using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;


namespace Portal
{
    class GravarNota
    {
        public List<Nota> Add(Nota nota)
        {
            try
            {
                var url = "http://localhost:53462/cadastro/adicionaNota";

                var httpClient = new HttpClient();
                var serializedObject = JsonConvert.SerializeObject(nota);
                var content = new StringContent(serializedObject, Encoding.UTF8, "application/json");
                var resultRequest = httpClient.PostAsync(url, content);
                resultRequest.Wait();
                if (resultRequest.Result.IsSuccessStatusCode)
                {
                    var result = resultRequest.Result.Content.ReadAsStringAsync();
                    result.Wait();
                    var resultado = JsonConvert.DeserializeObject<List<Nota>>(result.Result);
                    return resultado;
                }
            }
            catch
            {
            }
            List<Nota> listaNotas = new List<Nota>();
            return listaNotas;

        }

        public List<Nota> Deleta(string aluno)
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
                    var resultado = JsonConvert.DeserializeObject<List<Nota>>(result.Result);
                    return resultado;
                }
            }
            catch { }

            List<Nota> listaNotas = new List<Nota>();
            return listaNotas;
        }

        public List<Nota> Busca()
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
                    var resultado = JsonConvert.DeserializeObject<List<Nota>>(result.Result);
                    return resultado;
                }
            }
            catch { }

            List<Nota> listaNotas = new List<Nota>();
            return listaNotas;

        }
        public List<Nota> BuscaNotas(Nota notas)
        {


            var url = "http://localhost:53462/cadastro/mostraNotas";

            var httpClient = new HttpClient();
            var resultRequest = httpClient.GetAsync(url);
            resultRequest.Wait();           
            var result = resultRequest.Result.Content.ReadAsStringAsync();
            result.Wait();
            var resultado = JsonConvert.DeserializeObject<List<Nota>>(result.Result);
            return resultado;


        }
    }
}

