using App1_CELL02.Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App1_CELL02.Pagina
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class ListViewPage : ContentPage
	{
		public ListViewPage ()
		{
			InitializeComponent ();

            List<Funcionario> Lista = new List<Funcionario>();
            Lista.Add(new Funcionario() { Nome = "Cid", Cargo = "Presidente" });
            Lista.Add(new Funcionario() { Nome = "Ludmilla", Cargo = "Jurídico" });
            Lista.Add(new Funcionario() { Nome = "Elisa", Cargo = "Design" });
            Lista.Add(new Funcionario() { Nome = "Hanna", Cargo = "Dog" });
            Lista.Add(new Funcionario() { Nome = "Nuttela", Cargo = "Cat" });

            ListaFuncionario.ItemsSource = Lista;
        }

        private void ListaFuncionario_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            Funcionario f =  (Funcionario) e.SelectedItem;
            Navigation.PushAsync(new Detalhe.DetailPage(f));

        }

        private void MenuItem_Clicked(object sender, EventArgs e)
        {
            MenuItem botao = (MenuItem) sender;
            Funcionario f = (Funcionario) botao.CommandParameter;

            DisplayAlert("Atenção", string.Format("Funcionário {0} está de férias",f.Nome), "ok");
        }

        private void MenuItem_Clicked_1(object sender, EventArgs e)
        {

        }
    }
}