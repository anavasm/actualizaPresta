using FileHelpers;
using FileHelpers.Dynamic;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace actualiza_presta
{
    public partial class Form1 : Form
    {
        //declaración de objetos
        FileHelperEngine<PrestaFile> engineShop;
        DataTable dtShop;
        FileHelperEngine<SupplierFile> engineSupplier;
        DataTable dtSup, dtSup2;
        DataTable result;
        DataView newRecords;
        Boolean generateNew = false;

        public Form1()
        {
            InitializeComponent();
            
        }

        /// <summary>
        /// Abre un dialogo para seleccionar el archivo CSV de la tienda online
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string ruta = "";
                ruta = openFileDialog1.FileName;
                txtPathShop.Text = ruta;
                btnShopLoad.Enabled = true;
            }

        }

        /// <summary>
        /// Lee el archivo seleccionado de la tienda guardando los datos en un DataTable y mostrándolos en un DataGridView
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button2_Click(object sender, EventArgs e)
        {

            engineShop = new FileHelperEngine<PrestaFile>();
            try
            {
                dtShop = engineShop.ReadFileAsDT(txtPathShop.Text);
                //establece la clave primaria
                //dtShop.PrimaryKey = new DataColumn[] { dtShop.Columns["reference"] };
                gvShop.Columns.Clear();
                gvShop.DataSource = dtShop;
                toolStripStatusLabelShop.Text = Convert.ToString(dtShop.Rows.Count);
                btnSupFile.Enabled = true;
            }
            catch (FileHelpers.FileHelpersException efh)
            {
                showMessage("Archivo CSV no válido.");
                Console.WriteLine(efh);
            }
            catch (System.IO.IOException eio)
            {
                showMessage("No se ha podido leer el archivo");
                Console.WriteLine(eio);
            }
           
        }

        /// <summary>
        /// Elimina las filas duplicadas, según el nombre de columna especificada.
        /// </summary>
        /// <param name="dTable">Datatable</param>
        /// <param name="colName">Columna que debe tener valores únicos</param>
        /// <returns>Datatable sin filas duplicadas</returns>
        public DataTable RemoveDuplicateRows(DataTable dTable, string colName)
        {
            Hashtable hTable = new Hashtable();
            ArrayList duplicateList = new ArrayList();

            //Add list of all the unique item value to hashtable, which stores combination of key, value pair.
            //And add duplicate item value in arraylist.
            foreach (DataRow drow in dTable.Rows)
            {
                if (hTable.Contains(drow[colName]))
                    duplicateList.Add(drow);
                else
                    hTable.Add(drow[colName], string.Empty);
            }

            Console.WriteLine("filas duplicadas: "+duplicateList.Count);

            //Removing a list of duplicate items from datatable.
            foreach (DataRow dRow in duplicateList)
                dTable.Rows.Remove(dRow);

            //Datatable which contains unique records will be return as output.
            return dTable;
        }

        /// <summary>
        /// Lee el archivo seleccionado del proveedor guardando los datos en un DataTable y mostrándolos en un DataGridView
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSupLoad_Click(object sender, EventArgs e)
        {

            engineSupplier = new FileHelperEngine<SupplierFile>();
            try
            {
                dtSup2 = engineSupplier.ReadFileAsDT(txtPathSup.Text);
                dtSup = RemoveDuplicateRows(dtSup2, "reference");
                //establece la clave primaria
                dtSup.PrimaryKey = new DataColumn[] { dtSup.Columns["reference"] };
                gvSup.Columns.Clear();
                gvSup.DataSource = dtSup;
                toolStripStatusLabelSup.Text = Convert.ToString(dtSup.Rows.Count);
                //habilitar botones
                btnUpdate.Enabled = true;
                btnDeleted.Enabled = true;
                btnNew.Enabled = true;
            }
            catch(FileHelpers.FileHelpersException efh)
            {
                showMessage("Archivo CSV no válido para el proveedor seleccionado.");
                Console.WriteLine(efh);
            }
            catch (System.IO.IOException eio)
            {
                showMessage("No se ha podido leer el archivo");
                Console.WriteLine(eio);
            }catch(System.ArgumentException esys)
            {
                showMessage("No se ha podido leer el archivo, existen claves duplicadas");
                Console.WriteLine(esys);
            }

        }

        /// <summary>
        /// Abre un diálogo para seleccionar el archivo CSV de los proveedores
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSupFile_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string ruta = "";
                ruta = openFileDialog1.FileName;
                txtPathSup.Text = ruta;
                btnSupLoad.Enabled = true;

            }
        }

        /// <summary>
        /// Obtiene la lista de artículos nuevos que hay en el CSV del proveedor y los prepara para generar un CSV y agregarlo a la tienda. 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button3_Click(object sender, EventArgs e)
        {
            pBar.Visible = true;
            pBar.Value = 0;
            //obtiene una lista con los artículos que hay tanto en la tienda como en el proveedor.
            var results = from table1 in dtSup.AsEnumerable()
                          join table2 in dtShop.AsEnumerable() on table1.Field<string>("reference") equals table2.Field<string>("reference")
                          select table1;
            pBar.Value += 20;
            //compara la lista de artículos del proveedor con la lista combinada obtenida en el paso anterior. Obteniendo así los nuevos artículos
            var missing = from table1 in dtSup.AsEnumerable()
                          where !results.Contains(table1)
                          select table1;
            pBar.Value += 20;
            var recents = from table1 in missing
                          where table1.Field<bool>("active")==true
                          select table1;
            pBar.Value += 20;
            
            //se almacena en un DataView
            newRecords = new DataView();
            newRecords=recents.AsDataView();
            //se muenstra en el DataGridView los resultados
            gvResults.Columns.Clear();
            pBar.Value += 20;
            gvResults.DataSource = recents.AsDataView();

            //se muestra el mensaje correspondiente en la barra de estado
            if (recents.Count()==1)
            {
                toolStripStatusLabelResult.Text = Convert.ToString(recents.Count()) + " articulo nuevo";
            }
            else
            {
                toolStripStatusLabelResult.Text = Convert.ToString(recents.Count()) + " articulos nuevos";
            }
            pBar.Value = 100;
            generateNew = true;
            btnGenerate.Enabled = true;
        }

        /// <summary>
        /// Obtiene la lista de artículos descatalogados y que hay que eliminar
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDeleted_Click(object sender, EventArgs e)
        {
            btnGenerate.Enabled = false;
            pBar.Visible = true;
            pBar.Value = 0;
            //obtiene una lista con los artículos que hay tanto en la tienda como en el proveedor.
            var results = from table1 in dtShop.AsEnumerable()
                              join table2 in dtSup.AsEnumerable() on table1.Field<string>("reference") equals table2.Field<string>("reference")
                              select table1;
            pBar.Value += 20;
            
            //compara la lista de artículos de la tienda con la lista combinada obtenida en el paso anterior. Obteniendo así los artículos descatalogados
            var missing = from table1 in dtShop.AsEnumerable()
                          where !results.Contains(table1)
                          select table1;
            
            pBar.Value += 20;

           
            //se muestra en el DataGridView los resultados
            gvResults.Columns.Clear();
            pBar.Value += 20;
            
            gvResults.DataSource = missing.AsDataView();
            
            pBar.Value += 30;
            //se muestra el mensaje correspondiente en la barra de estado
            if (missing.Count()==1)
            {
                toolStripStatusLabelResult.Text = Convert.ToString(missing.Count()) + " articulo para eliminar";
            }
            else
            {
                toolStripStatusLabelResult.Text = Convert.ToString(missing.Count()) + " articulos para eliminar";
            }
            pBar.Value = 100;
            btnGenerate.Enabled = false;
        }

        /// <summary>
        /// Se obtiene la lista de artículos de la tienda con el precio y el stock actualizados
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            
            //se recorre la lista de artículos de la tienda modificando el precio y el stock por el valor del CSV del proveedor
            var rows = from table1 in dtShop.AsEnumerable()
                          join table2 in dtSup.AsEnumerable() on table1.Field<string>("reference") equals table2.Field<string>("reference")
                          select new 
                            {
                                id_product=table1.Field<string>("id_product"),
                                price=table2.Field<decimal>("price"),
                                reference=table1.Field<string>("reference"),
                                active = table2.Field<bool>("active"),
                                title = table2.Field<string>("title")
                            };

            //se clona el DataTable de la tienda
            result = dtShop.Clone();
            result.Columns.Add("title", typeof(String));
            //se carga el DataTable con los datos modificados
            rows.ToList().ForEach(q => result.Rows.Add(q.id_product, q.price, q.reference, q.active, q.title));

            //se muestra en el DtaGridView los resultados
            gvResults.Columns.Clear();
            gvResults.DataSource = result;

            //se muestra el mensaje correspondiente en la barra de estado
            if (result.Rows.Count == 1)
            {
                toolStripStatusLabelResult.Text = Convert.ToString(result.Rows.Count) + " articulos actualizados";
            }
            else
            {
                toolStripStatusLabelResult.Text = Convert.ToString(result.Rows.Count) + " articulos actualizados";
            }

            generateNew = false;
            //activar boton
            btnGenerate.Enabled = true;
        }

        /// <summary>
        /// Se genera un archivo CSV con los datos actualizados (precio y stock) o con los nuevos artículos
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnGenerate_Click(object sender, EventArgs e)
        {
            
            if (generateNew)
            {
                //generar csv de nuevos artítulos
                newCsv();
            }
            else
            {
                //generar csv para actualizar artículos
                updateCsv();
            }
            
            

        }


       /// <summary>
       /// Obtiene la subcategoría de la categoría principal del proveedor
       /// </summary>
       /// <param name="category">Categoría</param>
       /// <returns></returns>
        public string getSubCategory(string category)
        {
            string result;
            //se busca el caracter >
            int index = category.IndexOf('>');
            //se obtiene el texto a partir del caracter >
            result = category.Substring(index + 1);
            //se eliminan los espacios en blanco antes del nombre de la categoría
            result = result.TrimStart(' ');
            return result;
        }

        /// <summary>
        /// Función que obtiene solo las categorías únicas, eliminando l as repetidas.
        /// </summary>
        /// <param name="dTable"> DataTable que contiene los datos</param>
        /// <param name="columnName">Nombre de la columna que contiene los datos</param>
        /// <returns>Datatable sin duplicados </returns>
        public DataTable removeDuplicates(DataTable dTable, string columnName)
        {
            Hashtable hTable = new Hashtable();
            ArrayList duplicateList = new ArrayList();

            foreach (DataRow drow in dTable.Rows)
            {
                if (hTable.Contains(drow[columnName]))
                    duplicateList.Add(drow);
                else
                    hTable.Add(drow[columnName], string.Empty);
            }

            //Removing a list of duplicate items from datatable.
            foreach (DataRow dRow in duplicateList)
            {
                dTable.Rows.Remove(dRow);
            }

            return dTable;
        }

        /// <summary>
        /// Muestra un mensaje de error en pantalla
        /// </summary>
        /// <param name="message">Texto del mensaje</param>
        public void showMessage(string message)
        {
            MessageBox.Show(message, "Se ha producido un error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        /// <summary>
        /// Función que genera un archivo CSV con el precio y el stock actualizado
        /// </summary>
        public void updateCsv()
        {
            //se configura el nombre y la ruta del archivo por defecto
            string today = DateTime.Today.ToShortDateString();
            today = today.Replace('/', '-');
            string supplierName = "Supplier";
            saveFileDialog1.FileName = supplierName + " actualizado " + today;
            saveFileDialog1.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            //se abre el diálogo para guardar
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                //se crea una lista de artículos de la tienda
                List<PrestaFileUpdated> myCsv = new List<PrestaFileUpdated>();

                //se recorre el DataTable, creando y agregando objetos a la lista
                foreach (DataRow row in result.AsEnumerable())
                {
                    PrestaFileUpdated record = new PrestaFileUpdated();
                    record.id_product = row.Field<string>("id_product");
                    record.price = row.Field<decimal>("price");
                    record.reference = row.Field<string>("reference");
                    record.active = row.Field<bool>("active");
                    record.title = row.Field<string>("title");
                    myCsv.Add(record);
                }
                //se guarda el fichero como CSV
                //se crea un nuevo engine para guardar las actualizaciones
                FileHelperEngine<PrestaFileUpdated> engineUpdate = new FileHelperEngine<PrestaFileUpdated>();
                //se especifican las cabeceras
                engineUpdate.HeaderText = engineUpdate.GetFileHeader();
                //se guarda el fichero CSV
                engineUpdate.WriteFile(saveFileDialog1.FileName, myCsv);
                
            }
        }

        /// <summary>
        /// Función que genera un CSV con los nuevos artículos
        /// </summary>
        public void newCsv()
        {
            //se configura el nombre y la ruta del archivo por defecto
            string today = DateTime.Today.ToShortDateString();
            today = today.Replace('/', '-');
            string supplierName = "Supplier";
            saveFileDialog1.FileName = supplierName + " nuevos " + today;
            saveFileDialog1.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            //se abre el diálogo para guardar
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                //se crea una lista de artículos del proveedor seleccionado
                List<SupplierNew> news = new List<SupplierNew>();

                //se recorre el DataView, creando y agregando objetos a la lista
                foreach (DataRowView row in newRecords)
                {
                    SupplierNew record = new SupplierNew();
                    record.nombre = row.Row.Field<string>("title");
                    record.descripcion = row.Row.Field<string>("description");
                    record.descripcion_larga = row.Row.Field<string>("description");
                    record.imagen = row.Row.Field<string>("image_link");
                    record.stock = Convert.ToInt32(row.Row.Field<bool>("active"));
                    record.precio = row.Row.Field<decimal>("price");
                    record.impuestos = 59; //constante
                    record.marca = row.Row.Field<string>("brand");
                    record.referencia = row.Row.Field<string>("reference");
                    record.subcategoria_final = getSubCategory(row.Row.Field<string>("category")); //categoría resumida
                    record.proveedor = 5; //constante
                    news.Add(record);
                }

                //se crea un nuevo engine según el proveedor
                FileHelperEngine<SupplierNew> engineNews = new FileHelperEngine<SupplierNew>();
                //se especifican las cabeceras
                engineNews.HeaderText = engineNews.GetFileHeader();
                //se guarda el fichero CSV
                engineNews.WriteFile(saveFileDialog1.FileName, news);
                

            }                   
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
        }


    }
}
