using System;
using System.Collections.Generic;
using System.Text;
using System.Net;
using ListaBrasil.Modelo;
using Newtonsoft.Json;

namespace ListaBrasil.Servicos
{
    public class Servico
    {
        private static string URL_ESTADO = "https://servicodados.ibge.gov.br/api/v1/localidades/estados";
        private static string URL_MUNICIPIO = "https://servicodados.ibge.gov.br/api/v1/localidades/estados/{0}/municipios";

        public List<Estado> GetEstados()
        {
            WebClient wc = new WebClient();
            string conteudo = wc.DownloadString(URL_ESTADO);

           return JsonConvert.DeserializeObject<List<Estado>>(conteudo);

        }

        public List<Municipio> GetMunicipios(string idMunicipio)
        {
            WebClient wc = new WebClient();
            string conteudo = wc.DownloadString(string.Format(URL_MUNICIPIO,idMunicipio));

            return JsonConvert.DeserializeObject<List<Municipio>>(conteudo);
        }
    }
}
