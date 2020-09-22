using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Portal

{
    class GravarAluno
    {
        public List<Aluno> Add(Aluno alunos)
        {
           try
            { var url = "http://localhost:53462/cadastro/adicionaAluno";

            HttpClient httpClient = new HttpClient();
            string serializedObject = JsonConvert.SerializeObject(alunos);
            var content = new StringContent(serializedObject, Encoding.UTF8, "application/json");
            var resultRequest = httpClient.PostAsync(url, content);
            resultRequest.Wait();
            var result = resultRequest.Result.Content.ReadAsStringAsync();
            result.Wait();
            var resultado = JsonConvert.DeserializeObject<List<Aluno>>(result.Result);
            return resultado;
        } catch ( Exception erro)
            {
               
            }
                List<Aluno> listaAluno = new List<Aluno>();
                return listaAluno;
        }

        public List<Aluno> Deleta(string cpf)
        {
            try
            {

                var url = "http://localhost:53462/cadastro/deletaAluno";
                var httpClient = new HttpClient();
                var resultRequest = httpClient.DeleteAsync(url + $"?cpf={cpf}");
                if (resultRequest.Result.IsSuccessStatusCode)
                {
                    resultRequest.Wait();
                    var result = resultRequest.Result.Content.ReadAsStringAsync();
                    result.Wait();
                    var resultado = JsonConvert.DeserializeObject<List<Aluno>>(result.Result);
                    return resultado;
                }
            } catch { }
                List<Aluno> listaAluno = new List<Aluno>();
                return listaAluno;
            
        }

        public Aluno BuscaAluno(Aluno alunos)
        {
            var url = "http://localhost:53462/cadastro/buscaAluno";

            var httpClient = new HttpClient();
            var resultRequest = httpClient.GetAsync(url);
            resultRequest.Wait();
            var result = resultRequest.Result.Content.ReadAsStringAsync();
            result.Wait();
            var resultado = JsonConvert.DeserializeObject<Aluno>(result.Result);
            return resultado;
        }

        public List<Aluno> Busca()
        {
            var url = "http://localhost:53462/cadastro/mostraAluno";

            var httpClient = new HttpClient();
            var resultRequest = httpClient.GetAsync(url);
            resultRequest.Wait();
            var result = resultRequest.Result.Content.ReadAsStringAsync();
            result.Wait();
            var resultado = JsonConvert.DeserializeObject<List<Aluno>>(result.Result);
            return resultado;
        }
    }
}
