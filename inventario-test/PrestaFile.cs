using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FileHelpers;

namespace actualiza_presta
{
    //atributos del archivo CSV de Prestashop
    //caracter delimitador de columnas
    [DelimitedRecord(";")]
    //ignorar la primera fila, que es utilizada para los títulos de columnas en el archivo CSV del proveedor
    [IgnoreFirst(1)] 
    class PrestaFile
    {
        [FieldQuoted]
        public string id_product;

        [FieldQuoted]
        [FieldConverter(typeof(PriceShopConverter))]
        public decimal price;
        
        [FieldQuoted]
        public string reference;

        [FieldQuoted]
        [FieldConverter(ConverterKind.Boolean, "1", "0")]
        public bool active;

    }

    public class PriceShopConverter : ConverterBase
    {
        public override object StringToField(string from)
        {
            from = from.Replace('.', ',');

            return Convert.ToDecimal(from);
        }

    }
}
