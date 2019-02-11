using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Estilo.Menu
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Master : MasterDetailPage
	{
		public Master ()
		{
			InitializeComponent ();
		}

        private void Button_Clicked(object sender, EventArgs e)
        {
            Detail = new NavigationPage(  new Pagina.ImplicitStylePage());
            IsPresented = false;
        }

        private void Button_Clicked_1(object sender, EventArgs e)
        {
            Detail = new NavigationPage(new Pagina.ExplicitStylePage());
            IsPresented = false;
        }

        private void Button_Clicked_2(object sender, EventArgs e)
        {
            Detail = new NavigationPage(new Pagina.GlobalStylePage());
            IsPresented = false;
        }

        private void Button_Clicked_3(object sender, EventArgs e)
        {
            Detail = new NavigationPage(new Pagina.HerancaStylePage());
            IsPresented = false;
        }

        private void Button_Clicked_4(object sender, EventArgs e)
        {
            Detail = new NavigationPage(new Pagina.DynamicStylePage());
            IsPresented = false;
        }
    }
}