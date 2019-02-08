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
	public partial class EstadosPage : ContentPage
	{
		public EstadosPage ()
		{
			InitializeComponent ();

            List<Estado> lista = new Servico().GetEstados();

            lista = lista.OrderBy(x => x.nome).ToList<Estado>();

            ListaEstados.ItemsSource = lista;
		}

        private void ListaEstados_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            Estado uf = (Estado) e.SelectedItem;

            Navigation.PushAsync(new MinicipiosPage(uf));
        }
    }
}