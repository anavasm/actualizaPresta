using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FileHelpers;

namespace actualiza_presta
{
    [DelimitedRecord(";")]
    [IgnoreFirst(1)] 
    class PrestaFileUpdated
    {
        [FieldQuoted]
        public string id_product;

        [FieldQuoted]
        [FieldConverter(typeof(PriceShopConverter))]
        public decimal price;
        
        [FieldQuoted]
        public string reference;

        [FieldQuoted]
        public string title;

        [FieldQuoted]
        [FieldConverter(ConverterKind.Boolean, "1", "0")]
        public bool active;

    }

}
