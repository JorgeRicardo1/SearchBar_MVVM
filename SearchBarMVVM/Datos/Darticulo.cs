using SearchBarMVVM.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace SearchBarMVVM.Datos
{
    public class Darticulo
    {
        public List<Marticulo> Mostrar()
        {
            return new List<Marticulo>()
            {
                new Marticulo
                {
                    descripcion= "Casco rojo",
                    id= 1,
                    grupo= "casco"
                },
                new Marticulo
                {
                    descripcion="Casco azul",
                    id= 2,
                    grupo= "casco"
                },
                new Marticulo
                {
                    descripcion= "Tornillo cruz",
                    id= 3,
                    grupo= "tornillo"
                },
                new Marticulo
                {
                    descripcion= "Tornillo sencillo",
                    id= 3,
                    grupo= "tornillo"
                }
            };
        }
    }
}
