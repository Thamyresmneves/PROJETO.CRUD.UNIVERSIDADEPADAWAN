using Newtonsoft.Json;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Windows.Forms;
using System;

namespace Portal
{
    class GravarCurso
    {
        public List<Curso> Add(Curso curso)
        {
            try
            {
                var url = "http://localhost:53462/cadastro/adicionaCurso";

                var httpClient = new HttpClient();
                var serializedObject = JsonConvert.SerializeObject(curso);
                var content = new StringContent(serializedObject, Encoding.UTF8, "application/json");
                var resultRequest = httpClient.PostAsync(url, content);
                resultRequest.Wait();
                if (resultRequest.Result.IsSuccessStatusCode)
                {
                    var result = resultRequest.Result.Content.ReadAsStringAsync();
                    result.Wait();
                    var resultado = JsonConvert.DeserializeObject<List<Curso>>(result.Result);
                    return resultado;
                }

            }
            catch { }

            List<Curso> lista = new List<Curso>();
            return lista;


        }

        public List<Curso> Deleta(string nomeCurso)
        {
            try
            {
                var url = "http://localhost:53462/cadastro/deletaCurso";

                var httpClient = new HttpClient();
                var resultRequest = httpClient.DeleteAsync($"{url}?NomeCurso={nomeCurso}");
                resultRequest.Wait();

                if (resultRequest.Result.IsSuccessStatusCode)
                {
                    var result = resultRequest.Result.Content.ReadAsStringAsync();
                    result.Wait();
                    var resultado = JsonConvert.DeserializeObject<List<Curso>>(result.Result);
                    return resultado;
                }
            }
            catch { }
            // mostrar error
            List<Curso> listaCurso = new List<Curso>();
            return listaCurso;
            // DialogResult dialogResult = MessageBox.Show("Deu Erro");

        }

        public List<Curso> Busca(Curso curso)
        {
            var url = "http://localhost:53462/cadastro/buscaCurso";

            var httpClient = new HttpClient();
            var resultRequest = httpClient.GetAsync(url);
            resultRequest.Wait();
            var result = resultRequest.Result.Content.ReadAsStringAsync();
            result.Wait();
            var resultado = JsonConvert.DeserializeObject<List<Curso>>(result.Result);
            return resultado;
        }
    }
}
