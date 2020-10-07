using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class Convertidor
    {

        public double Convertir(int monedaOrigen, int monedaDestino, double cantidadConvertir)
        {
            double cantidadConvertida = 0;

            switch (monedaOrigen)
            {
                case (int)EnumMoneda.DOLAR:
                    switch (monedaDestino)
                    {
                        case (int)EnumMoneda.PESOS:
                            cantidadConvertida = cantidadConvertir * 58.44;
                            break;
                        case (int)EnumMoneda.EURO:
                            cantidadConvertida = cantidadConvertir * 0.85;
                            break;
                        case (int)EnumMoneda.DOLAR:
                            cantidadConvertida = cantidadConvertir * 1;
                            break;
                    }
                    break;

                case (int)EnumMoneda.EURO:
                    switch (monedaDestino)
                    {
                        case (int)EnumMoneda.PESOS:
                            cantidadConvertida = cantidadConvertir * 68.76;
                            break;
                        case (int)EnumMoneda.EURO:
                            cantidadConvertida = cantidadConvertir * 1;
                            break;
                        case (int)EnumMoneda.DOLAR:
                            cantidadConvertida = cantidadConvertir * 1.18;
                            break;
                    }
                    break;
                case (int)EnumMoneda.PESOS:
                    switch (monedaDestino)
                    {
                        case (int)EnumMoneda.PESOS:
                            cantidadConvertida = cantidadConvertir * 1;
                            break;
                        case (int)EnumMoneda.EURO:
                            cantidadConvertida = cantidadConvertir * 0.015;
                            break;
                        case (int)EnumMoneda.DOLAR:
                            cantidadConvertida = cantidadConvertir * 0.017;
                            break;
                    }
                    break;
            }

            return cantidadConvertida;
        }

    }
}
