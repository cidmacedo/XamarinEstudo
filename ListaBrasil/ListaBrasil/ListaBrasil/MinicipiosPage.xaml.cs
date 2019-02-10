using ListaBrasil.Modelo;
using ListaBrasil.Servicos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ListaBrasil
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MinicipiosPage : ContentPage
    {
        private List<Municipio> ListaCompleta { get; set; }
        private List<Municipio> ListaFiltrada { get; set; }

        public MinicipiosPage(Estado uf)
        {
            InitializeComponent();
            ListaCompleta = new Servico().GetMunicipios(uf.id.ToString());
            ListaCompleta = ListaCompleta.OrderBy(x => x.nome).ToList<Municipio>();
            ListaMunicipios.ItemsSource = ListaCompleta;
        }

        private void TxtNome_TextChanged(object sender, TextChangedEventArgs e)
        {
            ListaFiltrada = ListaCompleta.Where(a => a.nome.ToUpper().Contains(e.NewTextValue.ToUpper())).ToList<Municipio>();
            ListaFiltrada = ListaFiltrada.OrderBy(x => x.nome).ToList<Municipio>();
            ListaMunicipios.ItemsSource = ListaFiltrada;
        }
                
    }
}