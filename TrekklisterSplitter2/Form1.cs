using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using iTextSharp.text;
using iTextSharp.text.pdf;
using iTextSharp.text.pdf.parser;
using System.IO;
using System.Diagnostics;

namespace TrekklisterSplitter2
{
    public partial class frmMainWindow : Form
    {
        public frmMainWindow()
        {
            InitializeComponent();
        }

        private void frmMainWindow_Load(object sender, EventArgs e)
        {

        }

        private void btnBrowseFilePath_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.CheckFileExists = true;
            openFileDialog.CheckPathExists = true;
            openFileDialog.Filter = "PDF Files|*.pdf";
            openFileDialog.Title = "Velg en trekkliste";

            if (openFileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                txtSourceFile.Text = openFileDialog.FileName;
            }
        }

        private void btnBrowseSavePath_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();           
            if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                txtSavePath.Text = folderBrowserDialog.SelectedPath;
            }
        }

        private void txtSavePath_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            // Disable button
            btnStart.Enabled = false;
            btnCancel.Enabled = false;

            // Source file path
            string sourcePdfPath = txtSourceFile.Text;

            // Output file path
            //System.IO.Directory.CreateDirectory(txtSavePath.Text);
            string extension = ".pdf";
            string outputPdfPath = string.Empty;

            // Starting page number
            int pageNumber = 1;

            PdfReader reader = null;
            Document sourceDocument = null;
            PdfCopy pdfCopyProvider = null;
            PdfImportedPage importedPage = null;

            try
            {
                // Intialize a new PdfReader instance with the contents of the source Pdf file
                reader = new PdfReader(sourcePdfPath);

                // Capture the correct size and orientation for the page
                sourceDocument = new Document(reader.GetPageSizeWithRotation(pageNumber));

                string currentPageText;
                currentPageText = ReadPdfFile(sourcePdfPath, 1);

                string leverandor;
                List<string> stringList = new List<string>();
                stringList = GetKeyText(currentPageText, GetLastLineIndex(currentPageText));
                leverandor = stringList[0];

                string page = stringList[1];
                Debug.Print(GetTotalPageNumber(page).ToString());

                /*
                for (int i = pageNumber; i < reader.NumberOfPages + 1; i++)
                {

                }
                */

                sourceDocument.Close();
                reader.Close();

                //System.Windows.Forms.MessageBox.Show("Trekkliste ferdig splittet!!!");
            }
            catch (Exception ex)
            {
                Console.Error.WriteLine(ex.Message);
                throw ex;
            }

            // Enabled button
            btnStart.Enabled = true;
            btnCancel.Enabled = true;
        }

        public string ReadPdfFile(string sourceFileName, int pageIndex)
        {
            StringBuilder pageText = new StringBuilder();
            if (File.Exists(sourceFileName))
            { 
                PdfReader pdfReader = new PdfReader(sourceFileName);
                ITextExtractionStrategy strategy = new SimpleTextExtractionStrategy();
                string currentPageText = PdfTextExtractor.GetTextFromPage(pdfReader, pageIndex, strategy);

                currentPageText = Encoding.UTF8.GetString(ASCIIEncoding.Convert(Encoding.Default, Encoding.UTF8, Encoding.Default.GetBytes(currentPageText)));
                pageText.Append(currentPageText);

                pdfReader.Close();
            }

            return pageText.ToString();
        }

        public int GetLastLineIndex(string sourceText)
        {
            using (StringReader stringReader = new StringReader(sourceText))
            {
                int lastLineIndex = 0;
                string line;
                while ((line = stringReader.ReadLine()) != null)
                {
                    lastLineIndex++;
                }

                return lastLineIndex;
            }
        }

        public List<string> GetKeyText(string sourceText, int lastIndex)
        {
            using (StringReader stringReader = new StringReader(sourceText))
            {
                int count = 0;
                string line2;
                int searchIndex1 = lastIndex - 19; //Lønnart
                int searchIndex2 = lastIndex - 5; //Side
                List<string> strList = new List<string>();
                while ((line2 = stringReader.ReadLine()) != null)
                {         
                    count++;
                    if (count == searchIndex1 || count == searchIndex2)
                    {
                        strList.Add(line2);
                    }
                }

                return strList;
            }
        }

        public int GetTotalPageNumber(string sourceString)
        {
            int totalPageNumber = 0;
            string strTotalPageNumber;
            var splitPage = sourceString.Split('/');

            strTotalPageNumber = splitPage[1];

            if (!Int32.TryParse(strTotalPageNumber, out totalPageNumber))
            {
                MessageBox.Show("Error: Kunne ikke finne side nummer til leverandør.");
                Application.Exit();
            }
           

            return totalPageNumber;
        }
    }
}
