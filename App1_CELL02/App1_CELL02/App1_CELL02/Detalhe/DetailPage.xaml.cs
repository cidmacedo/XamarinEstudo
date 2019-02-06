using App1_CELL02.Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App1_CELL02.Detalhe
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class DetailPage : ContentPage
	{
		

        public DetailPage(Funcionario f)
        {
            InitializeComponent();

            txtNome.Text = f.Nome;
        }
    }
}