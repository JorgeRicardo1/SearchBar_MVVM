using SearchBarMVVM.Datos;
using SearchBarMVVM.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace SearchBarMVVM.ViewsModels
{
    internal class VMbuscargrupos : BaseViewModel
    {
        #region VARIABLES
        string _Nit;
        List<Marticulo> _MarticuloList;
        
        #endregion
        #region CONSTRUCTOR
        public VMbuscargrupos()
        {
            Mostrar();
        }
        #endregion
        #region OBJETOS
        public string Nit
        {
            get { return _Nit; }
            set { SetValue(ref _Nit, value); }
        }
        public List<Marticulo> MarticuloList
        {
            get { return _MarticuloList; }
            set { SetValue(ref _MarticuloList, value); }
        }
        #endregion
        #region PROCESPS
        public async Task obtenerCliente()
        {
            
        }

        public void Mostrar()
        {
            var f = new Darticulo();
            _MarticuloList= f.Mostrar();
        }
        public void Buscar()
        {
            Console.WriteLine("Ejecutando");
        }
        #endregion
        #region COMANDOS
        public ICommand obtenerClientecommand => new Command(async () => await obtenerCliente());
        public ICommand Mostrarcommand => new Command(Mostrar);
        public ICommand Buscarcommand => new Command(Buscar);
        #endregion
    }
}
