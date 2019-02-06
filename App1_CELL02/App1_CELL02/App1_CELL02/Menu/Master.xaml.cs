using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App1_CELL02.Menu
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Master : MasterDetailPage
    {
        public Master()
        {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            Detail = new NavigationPage(new Pagina.TextCellPage());
            IsPresented = false;
        }

        private void Button_Clicked_1(object sender, EventArgs e)
        {
            Detail = new NavigationPage(new Pagina.ImageCellPage());
            IsPresented = false;
        }

        private void Button_Clicked_2(object sender, EventArgs e)
        {
            Detail = new NavigationPage(new Pagina.EntryCellPage());
            IsPresented = false;
        }

        private void Button_Clicked_3(object sender, EventArgs e)
        {
            Detail = new NavigationPage(new Pagina.SwitchCellPage());
            IsPresented = false;

        }

        private void Button_Clicked_4(object sender, EventArgs e)
        {
            Detail = new NavigationPage(new Pagina.ViewCellPage());
            IsPresented = false;
        }

        private void Button_Clicked_5(object sender, EventArgs e)
        {
            Detail = new NavigationPage(new Pagina.ListViewPage());
            IsPresented = false;
        }
    }
}