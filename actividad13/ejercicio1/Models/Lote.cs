using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio1.Models
{
    class Lote
    {
        int numero;
        double[] medidas = new double[100];
        int cantidad = 0;

        public Lote() { }
        
        public double VerMedida(int idx)
        {
            if (idx >= 0 && idx < cantidad)
            {
                return medidas[idx];
            }
            return 0;
        }

        public void RegistrarMedida(double medida)
        {
            if (cantidad <= medidas.Length)
            {
                medidas[cantidad] = medida;
                cantidad++;
            }
        }

        public int VerCantidad()
        {
            return cantidad;
        }

        public int VerNumeroLote()
        {
            return numero;
        }

        public void AsignarNumeroLote(int valor)
        {
            this.numero = valor;
        }
    }
}
