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
            string outputFolderName = "Trekklister";
            string extension = ".pdf";
            string outputPdfFolder = System.IO.Path.Combine(txtSavePath.Text, outputFolderName);
            string outputPdfPath = string.Empty;
           
            // Create folder to contain pdf files
            if (txtSavePath.Text == "")
            {
                MessageBox.Show("Error: Velg lagringslokasjon.");

                // Enabled button
                btnStart.Enabled = true;
                btnCancel.Enabled = true;

                return;
            }
            else
            {
                System.IO.Directory.CreateDirectory(outputPdfFolder);
            }
            

            PdfReader reader = null;
            Document sourceDocument = null;
            PdfCopy pdfCopyProvider = null;
            PdfImportedPage importedPage = null;

            try
            {
                if (File.Exists(sourcePdfPath))
                {
                    // Starting page number
                    int startPage = 1;

                    // Intialize a new PdfReader instance with the contents of the source Pdf file
                    reader = new PdfReader(sourcePdfPath);

                    // Capture the correct size and orientation for the page
                    sourceDocument = new Document(reader.GetPageSizeWithRotation(startPage));

                    string currentPageText = string.Empty;
                    string leverandor = string.Empty;
                    int totalPageNumber = 0;
                    int lastPage = 0;
                    Tuple<int, bool> tuple = new Tuple<int, bool>(0, false);
                    
                    List<string> stringList = new List<string>();
                    for (int i = startPage; i < reader.NumberOfPages + 1; i++)
                    {
                        currentPageText = ReadPdfFile(sourcePdfPath, i);
                        tuple = GetLastLineIndex(currentPageText);
                        stringList = GetKeyText(currentPageText, tuple.Item1, tuple.Item2);
                        leverandor = stringList[0];
                        totalPageNumber = GetTotalPageNumber(stringList[1]);

                        outputPdfPath = System.IO.Path.Combine(outputPdfFolder, leverandor + extension);

                        // Initialize an instance of the PdfCopyClass with the source 
                        // document and an output file stream
                        pdfCopyProvider = new PdfCopy(sourceDocument, new System.IO.FileStream(outputPdfPath, System.IO.FileMode.Create));

                        sourceDocument.Open();

                        lastPage = i + totalPageNumber - 1;
                        for (int idx = i; idx < lastPage + 1; ++idx)
                        {
                            // Extract the desired page number
                            importedPage = pdfCopyProvider.GetImportedPage(reader, idx);
                            pdfCopyProvider.AddPage(importedPage);
                        }
                        

                        stringList.Clear();
                        i = i + (totalPageNumber - 1);
                    }
                    
                   
                   /*
                    List<string> stringList = new List<string>();
                    currentPageText = ReadPdfFile(sourcePdfPath, 1);
                    tuple = GetLastLineIndex(currentPageText);
                    stringList = GetKeyText(currentPageText, tuple.Item1, tuple.Item2);
                    leverandor = stringList[0];
                    totalPageNumber = GetTotalPageNumber(stringList[1]);

                    outputPdfPath = System.IO.Path.Combine(outputPdfFolder, leverandor + extension);

                    // Initialize an instance of the PdfCopyClass with the source 
                    // document and an output file stream
                    pdfCopyProvider = new PdfCopy(sourceDocument, new System.IO.FileStream(outputPdfPath, System.IO.FileMode.Create));

                    sourceDocument.Open();

                    lastPage = 1 + totalPageNumber - 1;
                    for (int idx = 1; idx < lastPage + 1; ++idx)
                    {
                        // Extract the desired page number
                        importedPage = pdfCopyProvider.GetImportedPage(reader, idx);
                        pdfCopyProvider.AddPage(importedPage);
                    }
                    */

                    

                    sourceDocument.Close();
                    reader.Close();
                    
                    //System.Windows.Forms.MessageBox.Show("Trekkliste ferdig splittet!!!");

                    // Enabled button
                    btnStart.Enabled = true;
                    btnCancel.Enabled = true;
                }
                else
                {
                    MessageBox.Show("Error: Trekkliste fil ikke gyldig.");

                    // Enabled button
                    btnStart.Enabled = true;
                    btnCancel.Enabled = true;

                    return;
                }
            }
            catch (Exception ex)
            {
                Console.Error.WriteLine(ex.Message);
                throw ex;
            }
        }
         
        public string ReadPdfFile(string sourceFileName, int pageIndex)
        {
            StringBuilder pageText = new StringBuilder();
            
            PdfReader pdfReader = new PdfReader(sourceFileName);
            ITextExtractionStrategy strategy = new SimpleTextExtractionStrategy();
            string currentPageText = PdfTextExtractor.GetTextFromPage(pdfReader, pageIndex, strategy);

            currentPageText = Encoding.UTF8.GetString(ASCIIEncoding.Convert(Encoding.Default, Encoding.UTF8, Encoding.Default.GetBytes(currentPageText)));
            pageText.Append(currentPageText);

            pdfReader.Close();
            
            return pageText.ToString();
        }

        public Tuple<int, bool> GetLastLineIndex(string sourceText)
        {
            using (StringReader stringReader = new StringReader(sourceText))
            {
                bool onlyOnePage = false;
                int lastLineIndex = 0;
                int markLine = 0;
                string line = string.Empty;

                while ((line = stringReader.ReadLine()) != null)
                {
                    lastLineIndex++;
                    if (line == ":")
                    {
                        markLine = lastLineIndex;
                    }
                        
                }
                
                if (lastLineIndex != markLine)
                {
                    onlyOnePage = true;
                }

                return Tuple.Create(lastLineIndex, onlyOnePage);
            }
        }
       
        public List<string> GetKeyText(string sourceText, int lastIndex, bool rerun)
        {
            using (StringReader stringReader = new StringReader(sourceText))
            {
                int count = 0;
                string line = string.Empty;
                int searchIndex1;
                int searchIndex2;

                if (!rerun)
                {
                    // Several pages source
                    searchIndex1 = lastIndex - 19; // Leverandør
                    searchIndex2 = lastIndex - 5; // Side
                }
                else
                {
                    // One page source
                    searchIndex1 = lastIndex - 24; // Leverandør
                    searchIndex2 = lastIndex - 10; // Side
                }
                
                List<string> strList = new List<string>();
                while ((line = stringReader.ReadLine()) != null)
                {         
                    count++;
                    if (count == searchIndex1 || count == searchIndex2)
                    {
                        strList.Add(line);
                    }
                }

                return strList;
            }
        }

        public int GetTotalPageNumber(string sourceString)
        {
            int totalPageNumber = 0;
            string strTotalPageNumber = string.Empty;
            string strStartPageNumber = string.Empty;
            var splitPage = sourceString.Split(' ', '/');

            strStartPageNumber = splitPage[1];
            strTotalPageNumber = splitPage[4];

            if (strStartPageNumber != "1")
            {
                MessageBox.Show("Error: Finner ikke start side 1 til leverandør.");
                Application.Exit();
            }

            if (!Int32.TryParse(strTotalPageNumber, out totalPageNumber))
            {
                MessageBox.Show("Error: Finner ikke antall sider til leverandør.");
                Application.Exit();
            }
           
            return totalPageNumber;
        }
    }
}
