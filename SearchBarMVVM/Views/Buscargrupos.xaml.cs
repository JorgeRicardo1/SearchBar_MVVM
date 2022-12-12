using SearchBarMVVM.ViewsModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SearchBarMVVM.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Buscargrupos : ContentPage
    {
        public Buscargrupos()
        {
            InitializeComponent();
            BindingContext=  new VMbuscargrupos();
        }

        private void SearchBar_TextChanged(object sender, TextChangedEventArgs e)
        {
            var _container = BindingContext as VMbuscargrupos;
            if (string.IsNullOrEmpty(e.NewTextValue))
            {
                CollectionViewName.ItemsSource = _container.MarticuloList;
            }
            else
            {
                CollectionViewName.ItemsSource= _container.MarticuloList.Where(i => i.grupo.Contains(e.NewTextValue));
            }
        }
    }
}