using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FileHelpers;

namespace actualiza_presta
{
    //atributos del archivo CSV del proveedor
    //caracter delimitador de columnas
    [DelimitedRecord("|")]
    //ignorar la primera fila, que es utilizada para los títulos de columnas en el archivo CSV del proveedor
    [IgnoreFirst(1)] 
    
    class SupplierFile
    {
        
        public string id;
        public string title;
        public string description;
        public string link;
        public string image_link;
        [FieldConverter(typeof(StockConverterSupplier))]
        [FieldNullValue(typeof(Boolean), "false")]
        public bool active;
        [FieldConverter(typeof(PriceConverterSupplier))]
        public decimal price;
        public string brand;
        public string reference;
        public string category;

    }
    
    public class StockConverterSupplier : ConverterBase
    {
        /// <summary>
        /// Convierte el valor "En stock" de la columna Stock en valor boolean. "En stock" = 1 | "Otro valor" = 0
        /// </summary>
        /// <param name="from">Valor a modificar</param>
        /// <returns>Valor modificado</returns>
        public override object StringToField(string from)
        {
            if (from=="En stock")
            {
                return true;
            }else{
                return false;
            }
        }

        /// <summary>
        /// Convierte el valor "En stock" de la columna Stock en valor boolean (formato string). "En stock" = "true" | "Otro valor" = "false"
        /// </summary>
        /// <param name="fieldValue">Valor a modificar</param>
        /// <returns>Valor cambiado (formato string)</returns>
        public override string FieldToString(object fieldValue)
        {
            
            if (fieldValue == "En stock")
            {
                return true.ToString();
            }
            else
            {
                return false.ToString();
            }
        }

    }

    public class PriceConverterSupplier : ConverterBase
    {
        /// <summary>
        /// Adapta el precio aplicando un incremento y ajustando el caracter para números decimales
        /// </summary>
        /// <param name="from">Valor actual</param>
        /// <returns>Valor modificado</returns>
        public override object StringToField(string from)
        {
            //cambia el caracter utilizado para los números decimales
            from = from.Replace('.', ',');
            //aplica un incremento del 25% al precio del proveedor
            Decimal incremento = 0.25m; 
            Decimal value = Convert.ToDecimal(from) + (Convert.ToDecimal(from) * incremento);
            return value;
        }

    }
}
