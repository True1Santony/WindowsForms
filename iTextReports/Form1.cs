using iTextSharp.text;
using iTextSharp.text.pdf;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace iTextReports
{
    public partial class Form1 : Form
    {
        private OleDbConnection oleConection;
        private DataSet dataSet;
        private const String DATA_BASE_PATH = "Data Source=Z:\\DAM\\2 Desarrollo de interfaces\\TEMA 2\\2.1\\Nwind.mdb";
        public Form1()
        {
            InitializeComponent();
            this.FormClosing += Form1_FormClosing;//antes de finalizar el programa lanza FormClosing
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           oleConection = ConnectDataBase(DATA_BASE_PATH);

            String sql = "SELECT p.ProductName, p.QuantityPerUnit, p.UnitPrice, p.UnitsInStock, c.CategoryName " +
                                        "FROM Products p " +
                                        "INNER JOIN Categories c ON p.CategoryID = c.CategoryID; ";

            dataGridView1.DataSource = ReturnDataTable(sql);
            
        }


        /// <summary>
        /// Crea una conexion a ddbb a partir de un string path
        /// </summary>
        /// <param name="path"></param>
        /// <returns>OleDbConnection</returns>
        public OleDbConnection ConnectDataBase(String path)
        {
            OleDbConnection oleDbConnection = new OleDbConnection();
            oleDbConnection.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0; " + path;
            oleDbConnection.Open();

            toolStripStatusLabel1.Text = "Base de datos abierta";

            return oleDbConnection;
        }

        /// <summary>
        /// Método que devuelve un data table de una consulta sql
        /// </summary>
        /// <param name="sql"></param>
        /// <returns>DataTable</returns>
        public DataTable ReturnDataTable(String sql)
        {

            OleDbCommand oleDbCommand = new OleDbCommand();
            oleDbCommand.Connection = oleConection;
            oleDbCommand.CommandText = sql;

            OleDbDataAdapter oleDbDataAdapter = new OleDbDataAdapter();
            OleDbCommandBuilder oleDbCommandBuilder = new OleDbCommandBuilder(oleDbDataAdapter);
            oleDbDataAdapter.SelectCommand = oleDbCommand;
            oleDbDataAdapter.FillSchema(dataSet = new DataSet(), SchemaType.Mapped, "productos");
            oleDbDataAdapter.Fill(dataSet, "productos");

            DataTable dataTable = dataSet.Tables["productos"];
            return dataTable;
        }

        /// <summary>
        /// Metodo Click del boton Informe, recoge los datos del DataGridView y los transforma en pdf exportable
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnGeneraInforme_Click(object sender, EventArgs e)
        {

            if (dataGridView1.Rows.Count > 0)
            {
                SaveFileDialog sfd = new SaveFileDialog();
                sfd.Filter = "PDF (*.pdf)|*.pdf";
                sfd.FileName = "Output.pdf";
                bool fileError = false;
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    if (File.Exists(sfd.FileName))
                    {
                        try
                        {
                            File.Delete(sfd.FileName);
                        }
                        catch (IOException ex)
                        {
                            fileError = true;
                            MessageBox.Show("It wasn't possible to write the data to the disk." + ex.Message);
                        }
                    }
                    if (!fileError)
                    {
                        try
                        {
                            PdfPTable pdfTable = new PdfPTable(dataGridView1.Columns.Count);
                            pdfTable.DefaultCell.Padding = 3;
                            pdfTable.WidthPercentage = 100;
                            pdfTable.HorizontalAlignment = Element.ALIGN_LEFT;

                            foreach (DataGridViewColumn column in dataGridView1.Columns)
                            {
                                PdfPCell cell = new PdfPCell(new Phrase(column.HeaderText));
                                pdfTable.AddCell(cell);
                            }

                            foreach (DataGridViewRow row in dataGridView1.Rows)
                            {
                                foreach (DataGridViewCell cell in row.Cells)
                                {
                                    if (cell.Value != null) pdfTable.AddCell(cell.Value.ToString());
                                }
                            }

                            using (FileStream stream = new FileStream(sfd.FileName, FileMode.Create))
                            {
                                Document pdfDoc = new Document(PageSize.A4, 10f, 20f, 20f, 10f);
                                PdfWriter.GetInstance(pdfDoc, stream);
                                pdfDoc.Open();
                                pdfDoc.Add(pdfTable);
                                pdfDoc.Close();
                                stream.Close();
                            }

                            toolStripStatusLabel1.Text = "Informe generado!!!";
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Error :" + ex.Message);
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("No Record To Export !!!", "Info");
            }

           
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {

            if (oleConection != null && oleConection.State == ConnectionState.Open)
            {
                oleConection.Close();
                
            }

        }
    }
}
