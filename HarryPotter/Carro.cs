using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HarryPotter
{
    class Carro
    {
        const double  DECUENTO_2_LIBROS = 0.05;
        const double DECUENTO_3_LIBROS = 0.10;
        const double DECUENTO_4_LIBROS = 0.15;
        const double DECUENTO_5_LIBROS = 0.20;
        const double DECUENTO_6_LIBROS = 0.30;
        const double DECUENTO_7_LIBROS = 0.45;
        const int PRECIO_LIBRO = 8;

        internal static double PrecioTotal(List<int> numLibros)
        {
            double precioTotal = 0; ;
           
            while (!EsVacioCarro(numLibros))
            {
                precioTotal = CalcularPrecioTotal(numLibros, precioTotal);        
            }
            
            return precioTotal;
        }

        private static double CalcularPrecioTotal(List<int> numLibros, double precioTotal)
        {
            for (int i = 0; i < numLibros.Count; i++)
            {
                int numLibrosDiferentes = 1;

                if (numLibros[i] > 0)
                {
                    precioTotal += CalcularDescuento(numLibros, i, ref numLibrosDiferentes);
                    break;
                }

                if (numLibrosDiferentes != 1)
                {
                    break;
                }
            }
            return precioTotal;
        }

        private static double CalcularDescuento(List<int> numLibros, int i, ref int numLibrosDiferentes)
        {
            for (int j = i + 1; j < numLibros.Count; j++)
            {
                if (numLibros[j] > 0)
                {
                    numLibrosDiferentes++;
                    numLibros[j]--;
                }
            }
            numLibros[i]--;
            return CalcularPrecio(numLibrosDiferentes);
        }

        private static double CalcularPrecio(int numLibrosDiferentes)
        {
            return PRECIO_LIBRO * numLibrosDiferentes * (1 - DescuentoAplicado(numLibrosDiferentes));
        }

        private static bool EsVacioCarro(List<int> numLibros)
        {
            foreach (var item in numLibros)
            {
                if (item > 0)
                {
                    return false;
                }
            }
            return true;
        }

        internal static double DescuentoAplicado(int numLibros) 
        {
            switch (numLibros)
            {
                case 2:
                    return DECUENTO_2_LIBROS;
                case 3:
                    return DECUENTO_3_LIBROS;
                case 4:
                    return DECUENTO_4_LIBROS;
                case 5:
                    return DECUENTO_5_LIBROS;
                case 6:
                    return DECUENTO_6_LIBROS;
                case 7:
                    return DECUENTO_7_LIBROS;
                default:
                    return 0;
            }
        }
    }
}
