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
	public partial class ImageCellPage : ContentPage
	{
		public ImageCellPage ()
		{
			InitializeComponent ();

            List<Funcionario> Lista = new List<Funcionario>();
            Lista.Add(new Funcionario() { Foto= "https://i0.wp.com/www.thedudes.com.br/wp-content/uploads/2018/06/Vitrine-Perfil-dos-Dudes-04.png", Nome = "Cid", Cargo = "Presidente" });
            Lista.Add(new Funcionario() {Foto= "https://i.pinimg.com/originals/cb/dd/87/cbdd8787eb4843466cec53c4e9002ef1.jpg", Nome = "Ludmilla", Cargo = "Jurídico" });
            Lista.Add(new Funcionario() { Foto= "https://pbs.twimg.com/profile_images/1008182135029628928/g2XibnXs_400x400.jpg", Nome = "Elisa", Cargo = "Design" });
            Lista.Add(new Funcionario() { Foto= "https://luisamell.com.br/wp-content/uploads/2016/01/maze1-300x300.jpg", Nome = "Hanna", Cargo = "Dog" });
            Lista.Add(new Funcionario() { Foto= "https://conteudo.imguol.com.br/c/entretenimento/61/2017/09/08/gatinha-com-colar-de-pano-1504884229810_v2_300x300.jpg6", Nome = "Nuttela", Cargo = "Cat" });

            ListaFuncionario.ItemsSource = Lista;

        }
    }
}