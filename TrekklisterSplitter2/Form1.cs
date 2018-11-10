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

namespace TrekklisterSplitter2
{
    public partial class frmMainWindow : Form
    {
        public frmMainWindow()
        {
            InitializeComponent();
        }

        private void FrmMainWindow_Load(object sender, EventArgs e)
        {

        }

        private void BtnBrowseFilePath_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.CheckFileExists = true;
            openFileDialog.CheckPathExists = true;
            openFileDialog.Filter = "PDF Files|*.pdf";
            openFileDialog.Title = "Velg en trekkliste";

            if (openFileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                TxtSourceFile.Text = openFileDialog.FileName;
            }
        }

        private void BtnBrowseSavePath_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();           
            if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                TxtSavePath.Text = folderBrowserDialog.SelectedPath;
            }
        }

        private void TxtSavePath_TextChanged(object sender, EventArgs e)
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
            string sourcePdfPath = TxtSourceFile.Text;

            // Output file path
            System.IO.Directory.CreateDirectory(TxtSavePath.Text);
            string extension = ".pdf";
            string outputPdfPath = string.Empty;

            // Starting page number
            int pageNumber = 1;

            
            
        }

        public List<String> ReadPdfFile(string sourceFileName, int pageIndex)
        {
            string searchText1 = "Side";
            String searchText2 = "Lønnart";    

            List<string> searches = new List<string>();
            if (File.Exists(sourceFileName))
            { 
                PdfReader pdfReader = new PdfReader(sourceFileName);
                ITextExtractionStrategy strategy = new SimpleTextExtractionStrategy();
                string currentPageText = PdfTextExtractor.GetTextFromPage(pdfReader, pageIndex, strategy);
                if (currentPageText.Contains(searchText1))
                {
                        
                }
                else if(currentPageText.Contains(searchText2))
                {

                }

                pdfReader.Close();
            }

            return searches;
        }

        
    }
}
