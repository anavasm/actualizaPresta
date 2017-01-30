using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FileHelpers;

namespace actualiza_presta
{
    //atributos del archivo CSV con nuevos artículos para importar en Prestashop
    //caracter delimitador de columnas
    [DelimitedRecord(";")]
    //ignorar la primera fila, que es utilizada para los títulos de columnas en el archivo CSV del proveedor
    [IgnoreFirst(1)] 
    class SupplierNew
    {
        public string nombre;
        public string descripcion;
        public string descripcion_larga;
        public string imagen;
        public int stock;
        public decimal precio;
        public int impuestos;
        public string marca;
        public string referencia;
        public string subcategoria_final;
        public  int proveedor;

    }
}
