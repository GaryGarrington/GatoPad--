using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;
using System.IO;

namespace text_editor
{
    class Text
    {

        /// <summary>
        /// Zarovná vybraný text
        /// </summary>
        /// <param name="algn">
        /// Kam se má text zarovnat
        /// </param>
        /// <param name="txb">
        /// Textbox který obsahuje vybraný text
        /// </param>
        public void zarovnat(HorizontalAlignment algn, RichTextBox txb)
        {
            txb.SelectionAlignment = algn;
        }
        /// <summary>
        /// Změní barvu vybraného textu
        /// </summary>
        /// <param name="clr">
        /// Barva, kterou se text obarví
        /// </param>
        /// <param name="txb">
        /// Textbox obsahující vybraný text
        /// </param>
        public void barva(Color clr, RichTextBox txb)
        {
            txb.SelectionColor = clr;
        }
        /// <summary>
        /// Změní font vybraného textu
        /// </summary>
        /// <param name="fnt">
        /// Font, na který se text změní
        /// </param>
        /// <param name="txb">
        /// Textbox obsahující vybraný text
        /// </param>
        public void font(Font fnt, RichTextBox txb)
        {
            txb.SelectionFont = fnt;
        }
        /// <summary>
        /// Zobrazí syntaxi jazyka C#
        /// </summary>
        /// <param name="txb">
        /// textbox, ve kterém se text upraví
        /// </param>
        public void csharp(RichTextBox txb)
        {
            List<string> fialova = new List<string>() // seznam slov upravovaných funkcí csharp
            {
                "if", "else", "switch", "case", "return", "break", "while", "for", "try", "catch"
            };

            List<string> modra = new List<string>() // seznam slov upravovaných funkcí csharp
            {
                "public", "static", "private", "string", "char", "int", "bool", "double", "float", "void"
            };

            List<string> znaky = new List<string> // list oddělovačů textu
            {
                " ", "\n", "\t", "(", ")", "{", "}", "[", "]"
            };

            int pozice = 0; // pozice kurzoru

            txb.SelectAll();
            txb.SelectionFont = new Font(txb.SelectionFont, FontStyle.Regular);
            txb.SelectionColor = Color.Black;
            txb.DeselectAll();
            pozice = 0; // kurzor je na začátku textu
            string[] slova = txb.Text.Split(' ', '\n', '\t', '(', ')', '{', '}', '[', ']'); // slova se rozdělí a zapíší do pole
            for(int i = 0; i < slova.Length; i++)
            {
                for(int j = 0; j < modra.Count; j++)
                {
                    if (slova[i] == modra[j])
                    {
                        txb.SelectionStart = pozice;
                        txb.SelectionLength = modra[j].Length;
                        txb.SelectionColor = Color.Blue;
                        txb.DeselectAll();
                    }
                }
                for (int j = 0; j < fialova.Count; j++)
                {
                    if (slova[i] == fialova[j])
                    {
                        txb.SelectionStart = pozice;
                        txb.SelectionLength = fialova[j].Length;
                        txb.SelectionColor = Color.Purple;
                        txb.DeselectAll();
                    }
                }
                pozice = pozice + slova[i].Length; // posune kurzor na konec slova
                txb.Select(pozice, 1); // označí další znak za aktuálním slovem
                for (int j = 0; j < znaky.Count; j++)
                {
                    if (txb.SelectedText == znaky[j]) // přičte k pozici 1 pokud další znak je oddělovač
                    {
                        pozice++;
                    }
                }
                txb.DeselectAll();
            }
        }
    }
}
