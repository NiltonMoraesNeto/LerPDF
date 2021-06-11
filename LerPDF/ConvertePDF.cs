using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using iTextSharp.text.pdf;
using iTextSharp.text.pdf.parser;

namespace LerPDF
{
    public class ConvertePDF
    {
        public string ExtrairTexto_PDF(string caminho)
        {
            using (PdfReader leitor = new PdfReader(caminho))
            {
                StringBuilder texto = new StringBuilder();
                for (int i = 1; i <= leitor.NumberOfPages; i++)
                {
                    texto.Append(PdfTextExtractor.GetTextFromPage(leitor, i));
                }
                return texto.ToString();
            }
        }

        public string TestePDF(string caminho)
        {

            byte[] buffer = null;
            FileStream fs = new FileStream(caminho, FileMode.Open, FileAccess.Read);
            BinaryReader br = new BinaryReader(fs);
            long numBytes = new FileInfo(caminho).Length;
            //buffer = br.ReadBytes((int)numBytes);
            buffer = br.ReadBytes(5);

            var enc = new ASCIIEncoding();
            var header = enc.GetString(buffer);

            if (buffer[0] == 0x25 && buffer[1] == 0x50
            && buffer[2] == 0x44 && buffer[3] == 0x46)
            {
                return header.ToString() + "__" + header.StartsWith("%PDF-").ToString();
            }
            return header.ToString();
        }

        public string ReadPdfFile(object Filename)
        {

            string strText = string.Empty;
            try
            {
                PdfReader reader = new PdfReader((string)Filename);

                for (int page = 1; page <= reader.NumberOfPages; page++)
                {
                    ITextExtractionStrategy its = new iTextSharp.text.pdf.parser.SimpleTextExtractionStrategy();
                    String s = PdfTextExtractor.GetTextFromPage(reader, page, its);

                    s = Encoding.UTF8.GetString(ASCIIEncoding.Convert(Encoding.Default, Encoding.UTF8, Encoding.Default.GetBytes(s)));
                    strText = strText + s;

                }
                reader.Close();
            }
            catch (Exception ex)
            {
                
            }
            return strText;
        }
    }
}