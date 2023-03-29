using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace text_editor
{
    class Soubor
    {
        /// <summary>
        /// Otevře textový soubor a vypíše jeho obsah do textboxu
        /// </summary>
        /// <param name="filepath">
        /// Cesta ke zvolenému souboru
        /// </param>
        /// <param name="txb">
        /// Textbox do kterého se obsah souboru vypíše
        /// </param>
        public void otevrittxt(string filepath, RichTextBox txb)
        {
            StreamReader nactiSoubor;
            string text;
            nactiSoubor = new StreamReader(filepath);
            while ((text = nactiSoubor.ReadLine()) != null)
            {
                txb.Text += text + Environment.NewLine;
            }
            nactiSoubor.Close();
        }
        /// <summary>
        /// Otevře soubor typu a vypíše jeho obsah do textboxu
        /// </summary>
        /// <param name="filepath">
        /// Cesta ke zvolenému souboru
        /// </param>
        /// <param name="txb">
        /// Textbox do kterého se obsah souboru vypíše
        /// </param>
        public void otevritrtf(string filepath, RichTextBox txb)
        {
            txb.LoadFile(filepath);
        }

        /// <summary>
        /// Uloží obsah textboxu do vybraného souboru
        /// </summary>
        /// <param name="filepath">
        /// Cesta k souboru
        /// </param>
        /// <param name="txb">
        /// Textbox, jehož text se zapisuje do souboru
        /// </param>
        public void ulozittxt(string filepath, RichTextBox txb)
        {
            StreamWriter ulozsoubor;
            ulozsoubor = new StreamWriter(filepath);
            ulozsoubor.Write(txb.Text);
            ulozsoubor.Close();
        }
        /// <summary>
        /// Uloží obsah textboxu do vybraného souboru jako typ rtf
        /// </summary>
        /// <param name="filepath">
        /// Cesta k souboru
        /// </param>
        /// <param name="txb">
        /// Textbox, jehož text se zapisuje do souboru
        /// </param>
        public void ulozitrtf(string filepath, RichTextBox txb)
        {
            txb.SaveFile(filepath);
        }
    }
}
