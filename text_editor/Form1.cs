using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace text_editor
{
    public partial class Form_main : Form
    {
        Soubor soubor = new Soubor();
        Text text = new Text();
        Form_ulozit form_ulozit = new Form_ulozit();
        Form_exeption form_exception = new Form_exeption();
        Form_notimplemented form_notimplemented = new Form_notimplemented();
        Form_info form_info = new Form_info();
        public string filepath = ""; // cesta k aktuálně otevřenému souboru
        bool saved = true; // Je soubor uložen?

        public Form_main(string path)
        {
            InitializeComponent();

            if (path != string.Empty) filepath = path;
        }

        private void soubor_otevrit_click(object sender, EventArgs e)
        {
            if (!saved)
            {
                form_ulozit.ShowDialog(); // zeptá se uživatele jestli chce uložit aktuální soubor
                switch (form_ulozit.result)
                {
                    case "save":
                        {
                            if (filepath == "") // Pokud uživatel doposud soubor neukládal, program se zeptá kam má být obsah uložen
                            {
                                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                                {
                                    filepath = saveFileDialog.FileName;
                                    if (filepath.Contains(".txt") == true)
                                    {
                                        soubor.ulozittxt(filepath, txb);
                                    }
                                    if (filepath.Contains(".rtf") == true)
                                        soubor.ulozitrtf(filepath, txb);
                                }
                                else return;
                            }
                            if (filepath.Contains(".txt") == true) // pokavaď uživatel ukládá soubor jako .txt, uloží se pouze čistě text, což zajistí kompatibilitu s jinými programy
                            {
                                soubor.ulozittxt(filepath, txb);
                            }
                            if (filepath.Contains(".rtf") == true) // pokavaď uživatel ukládá soubor jako .rtf, uloží text včetně všech jeho úprav
                                soubor.ulozitrtf(filepath, txb);
                            saved = true;
                            break;
                        }
                    case "cancel":
                        {
                            return;
                        }
                }
            }
            txb.Text = "";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                filepath = openFileDialog.FileName;
                if (filepath.Contains(".txt") == true) // pokavaď je soubor .txt, načte pouze čistý text
                {
                    soubor.otevrittxt(filepath, txb);
                }
                if (filepath.Contains(".rtf") == true) // pokavaď je soubor .rtf, načte text i s úpravami
                    soubor.otevritrtf(filepath, txb);
            }
            else return;
            this.Text = filepath + " - GatoPad--";
            saved = true;
        }

        private void soubor_novy_click(object sender, EventArgs e)
        {
            if (!saved)
            {
                form_ulozit.ShowDialog(); // zeptá se uživatele jestli chce uložit aktuální soubor
                switch (form_ulozit.result)
                {
                    case "save":
                        {
                            if (filepath == "") // Pokud uživatel doposud soubor neukládal, program se zeptá kam má být obsah uložen
                            {
                                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                                {
                                    filepath = saveFileDialog.FileName;
                                    if (filepath.Contains(".txt") == true) // pokavaď uživatel ukládá soubor jako .txt, uloží se pouze čistě text, což zajistí kompatibilitu s jinými programy
                                    {
                                        soubor.ulozittxt(filepath, txb);
                                    }
                                    if (filepath.Contains(".rtf") == true) // pokavaď uživatel ukládá soubor jako .rtf, uloží text včetně všech jeho úprav
                                        soubor.ulozitrtf(filepath, txb);
                                    saved = true;
                                }
                                else return;
                            }
                            break;
                        }
                    case "notsave":
                        {
                            break;
                        }
                    case "cancel":
                        {
                            return;
                        }
                }
            }
            txb.Text = "";
            filepath = ""; // Vytváří se nový soubor, který se bude ukládat jinam
            this.Text = "GatoPad--";
            saved = true;
        }

        private void soubor_ulozit_click(object sender, EventArgs e)
        {
            if (filepath == "") // Pokud uživatel doposud soubor neukládal, program se zeptá kam má být obsah uložen
            {
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    filepath = saveFileDialog.FileName;
                    if (filepath.Contains(".txt") == true) // pokavaď uživatel ukládá soubor jako .txt, uloží se pouze čistě text, což zajistí kompatibilitu s jinými programy
                    {
                        soubor.ulozittxt(filepath, txb);
                    }
                    if (filepath.Contains(".rtf") == true) // pokavaď uživatel ukládá soubor jako .rtf, uloží text včetně všech jeho úprav
                        soubor.ulozitrtf(filepath, txb);
                }
                else return;
            }
            if (filepath.Contains(".txt") == true) // pokavaď uživatel ukládá soubor jako .txt, uloží se pouze čistě text, což zajistí kompatibilitu s jinými programy
            {
                soubor.ulozittxt(filepath, txb);
            }
            if (filepath.Contains(".rtf") == true) // pokavaď uživatel ukládá soubor jako .rtf, uloží text včetně všech jeho úprav
                soubor.ulozitrtf(filepath, txb);
            this.Text = filepath + " - GatoPad--";
            saved = true;
        }

        private void soubor_ulozitjako_click(object sender, EventArgs e)
        {
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                filepath = saveFileDialog.FileName;
                if (filepath.Contains(".txt") == true) // pokavaď uživatel ukládá soubor jako .txt, uloží se pouze čistě text, což zajistí kompatibilitu s jinými programy
                {
                    soubor.ulozittxt(filepath, txb);
                }
                if (filepath.Contains(".rtf") == true) // pokavaď uživatel ukládá soubor jako .rtf, uloží text včetně všech jeho úprav
                    soubor.ulozitrtf(filepath, txb);
            }
            else return;
            this.Text = filepath + " - GatoPad--";
            saved = true;
        }

        private void form_zavren(object sender, FormClosingEventArgs e)
        {
            if (!saved)
            {
                form_ulozit.ShowDialog();
                switch (form_ulozit.result)
                {
                    case "save": // zeptá se uživatele jestli chce uložit aktuální soubor
                        {
                            if (filepath == "") // Pokud uživatel doposud soubor neukládal, program se zeptá kam má být obsah uložen
                            {
                                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                                {
                                    filepath = saveFileDialog.FileName;
                                    if (filepath.Contains(".txt") == true) // pokavaď uživatel ukládá soubor jako .txt, uloží se pouze čistě text, což zajistí kompatibilitu s jinými programy
                                    {
                                        soubor.ulozittxt(filepath, txb);
                                    }
                                    if (filepath.Contains(".rtf") == true) // pokavaď uživatel ukládá soubor jako .rtf, uloží text včetně všech jeho úprav
                                        soubor.ulozitrtf(filepath, txb);
                                }
                                else return;
                            }
                            if (filepath.Contains(".txt") == true) // pokavaď uživatel ukládá soubor jako .txt, uloží se pouze čistě text, což zajistí kompatibilitu s jinými programy
                            {
                                soubor.ulozittxt(filepath, txb);
                            }
                            if (filepath.Contains(".rtf") == true) // pokavaď uživatel ukládá soubor jako .rtf, uloží text včetně všech jeho úprav
                                soubor.ulozitrtf(filepath, txb);
                            break;
                        }
                    case "notsave":
                        {
                            return;
                        }
                    case "cancel":
                        {
                            e.Cancel = true;
                            return;
                        }
                }
            } 
        }

        private void text_zarovnat_doleva(object sender, EventArgs e)
        {
            text.zarovnat(HorizontalAlignment.Left, txb);
        }

        private void text_zarovnat_nastred(object sender, EventArgs e)
        {
            text.zarovnat(HorizontalAlignment.Center, txb);
        }

        private void text_zarovnat_doprava(object sender, EventArgs e)
        {
            text.zarovnat(HorizontalAlignment.Right, txb);
        }

        private void text_barva_cerna(object sender, EventArgs e)
        {
            text.barva(Color.Black, txb);
        }

        private void text_barva_bila(object sender, EventArgs e)
        {
            text.barva(Color.White, txb);
        }

        private void text_barva_modra(object sender, EventArgs e)
        {
            text.barva(Color.Blue, txb);
        }

        private void text_barva_zelena(object sender, EventArgs e)
        {
            text.barva(Color.Green, txb);
        }

        private void text_barva_zluta(object sender, EventArgs e)
        {
            text.barva(Color.Yellow, txb);
        }

        private void text_barva_cervena(object sender, EventArgs e)
        {
            text.barva(Color.Red, txb);
        }

        private void text_barva_vlastni(object sender, EventArgs e)
        {
            if (colorDialog.ShowDialog() == DialogResult.OK)

            text.barva(colorDialog.Color, txb);
        }

        private void text_font_calibri(object sender, EventArgs e)
        {
            Font fnt = new Font("Calibri", txb.SelectionFont.Size);
            text.font(fnt, txb);
        }

        private void text_font_comicsans(object sender, EventArgs e)
        {
            Font fnt = new Font("Comic Sans MS", txb.SelectionFont.Size);
            text.font(fnt, txb);
        }

        private void text_font_papyrus(object sender, EventArgs e)
        {
            Font fnt = new Font("Papyrus", txb.SelectionFont.Size);
            text.font(fnt, txb);
        }

        private void text_font_wingdings(object sender, EventArgs e)
        {
            Font fnt = new Font("Wingdings", txb.SelectionFont.Size);
            text.font(fnt, txb);
        }

        private void font_text_vlastni(object sender, EventArgs e)
        {
            if (fontDialog.ShowDialog() == DialogResult.OK)
            {
                Font fnt = fontDialog.Font;
                text.font(fnt, txb);
            }
        }

        private void text_velikost_8(object sender, EventArgs e)
        {
            Font fnt = new Font(txb.SelectionFont.FontFamily, 8);
            text.font(fnt, txb);
        }

        private void text_velikost_12(object sender, EventArgs e)
        {
            Font fnt = new Font(txb.SelectionFont.FontFamily, 12);
            text.font(fnt, txb);
        }

        private void text_velikost_16(object sender, EventArgs e)
        {
            Font fnt = new Font(txb.SelectionFont.FontFamily, 16);
            text.font(fnt, txb);
        }

        private void text_velikost_20(object sender, EventArgs e)
        {
            Font fnt = new Font(txb.SelectionFont.FontFamily, 20);
            text.font(fnt, txb);
        }

        private void text_velikost_72(object sender, EventArgs e)
        {
            Font fnt = new Font(txb.SelectionFont.FontFamily, 72);
            text.font(fnt, txb);
        }

        private void text_velikost_vlastni(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == (char)Keys.Enter)
            {
                try
                {
                    Font fnt = new Font(txb.SelectionFont.FontFamily, Convert.ToInt32(toolStripTextBox1.Text));
                    text.font(fnt, txb);
                }
                catch
                {
                    form_exception.ShowDialog(); // pokud se uživatel pokusí zadat něco jiného než číslo, program ho upozorní
                }
            }
        }

        private void text_uprava_siroke(object sender, EventArgs e)
        {
            Font fnt;
            FontStyle stl = txb.SelectionFont.Style;
            fnt = new Font(txb.SelectionFont, stl ^ FontStyle.Bold);
            text.font(fnt, txb);
            /* if (txb.SelectionFont.Bold == true) menu_siroke.Checked = true;
            else menu_siroke.Checked = false; */
        }

        private void text_uprava_sikme(object sender, EventArgs e)
        {
            Font fnt;
            FontStyle stl = txb.SelectionFont.Style;
            fnt = new Font(txb.SelectionFont, stl ^ FontStyle.Italic);
            text.font(fnt, txb);
            /* if (txb.SelectionFont.Italic == true) menu_sikme.Checked = true;
            else menu_sikme.Checked = false; */
        }

        private void text_uprava_preskrtnute(object sender, EventArgs e)
        {
            Font fnt;
            FontStyle stl = txb.SelectionFont.Style;
            fnt = new Font(txb.SelectionFont, stl ^ FontStyle.Strikeout);
            text.font(fnt, txb);
            /* if (txb.SelectionFont.Strikeout == true) menu_preskrtnute.Checked = true;
            else menu_preskrtnute.Checked = false; */
        }

        private void text_uprava_podtrzene(object sender, EventArgs e)
        {
            Font fnt;
            FontStyle stl = txb.SelectionFont.Style;
            fnt = new Font(txb.SelectionFont, stl ^ FontStyle.Underline);
            text.font(fnt, txb);
            /* if (txb.SelectionFont.Underline == true) menu_podtrzene.Checked = true;
            else menu_podtrzene.Checked = false; */
        }

        private void txb_SelectionChanged(object sender, EventArgs e)
        {
            /* if (txb.SelectionFont.Bold == true) menu_siroke.Checked = true;
            else menu_siroke.Checked = false;
            if (txb.SelectionFont.Italic == true) menu_sikme.Checked = true;
            else menu_sikme.Checked = false;
            if (txb.SelectionFont.Strikeout == true) menu_preskrtnute.Checked = true;
            else menu_preskrtnute.Checked = false;
            if (txb.SelectionFont.Underline == true) menu_podtrzene.Checked = true;
            else menu_podtrzene.Checked = false; */

            // Yeah don't work and just lay there see if I care
        }

        private void prg_csharp(object sender, EventArgs e)
        {
            int startpozice = txb.SelectionStart; // zapamatuje si aktuální pozici kurzoru
            if (cToolStripMenuItem.Checked == true)
            {
                text.csharp(txb);
                txb.SelectionColor = Color.Black; // Po přebarvení textu funkcí csharp změní barvu zpět na černou
                txb.SelectionStart = startpozice; // vrátí kurzor do původní pozice
            }
            else
            {
                txb.SelectAll();
                txb.SelectionColor = Color.Black; // přebarví veškerý text na černou pokud si uživatel vypne syntaxi
                txb.DeselectAll();
                txb.SelectionStart = startpozice; // vrátí kurzor do původní pozice
            }
        }

        private void ostatni_info(object sender, EventArgs e)
        {
            form_info.ShowDialog();
        }

        private void txb_KeyPress(object sender, KeyPressEventArgs e)
        {
            List<char> znaky = new List<char> // list znaků, po kterých se provede aktualizace
            {
                ' ', '(', '[', '{', '\n', '\t'
            };
            if (cToolStripMenuItem.Checked)
            {
                for (int i = 0; i < znaky.Count; i++)
                {
                    if (e.KeyChar == znaky[i]) // syntaxe kódu se aktualizuje pouze po stisknutí jednoho z definovaných znaků
                    {
                        text.csharp(txb);
                        txb.SelectionColor = Color.Black;
                    }
                }
            }
        }

        private void form_nacten(object sender, EventArgs e)
        {
            if (filepath != "")
            {
                if (filepath.Contains(".txt") == true)
                {
                    soubor.otevrittxt(filepath, txb);
                    this.Text = filepath + " - GatoPad--";
                }
                else if (filepath.Contains(".rtf") == true)
                {
                    soubor.otevritrtf(filepath, txb);
                    this.Text = filepath + " - GatoPad--";
                }
                else
                {
                    filepath = "";
                    MessageBox.Show("Nepodporovaný typ souboru");
                }
            }
        }

        private void soubor_tisk_click(object sender, EventArgs e)
        {
            printDialog.Document = printDocument;
            if(printDialog.ShowDialog() == DialogResult.OK)
            {
                printDocument.Print();
            }
        }

        private void printDocument_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawString(txb.Text,txb.SelectionFont,Brushes.Black,0,0);
        }

        private void txb_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Modifiers == Keys.Control)
            {
                if (e.KeyCode == Keys.S)
                {
                    if (filepath == "") // Pokud uživatel doposud soubor neukládal, program se zeptá kam má být obsah uložen
                    {
                        if (saveFileDialog.ShowDialog() == DialogResult.OK)
                        {
                            filepath = saveFileDialog.FileName;
                            if (filepath.Contains(".txt") == true) // pokavaď uživatel ukládá soubor jako .txt, uloží se pouze čistě text, což zajistí kompatibilitu s jinými programy
                            {
                                soubor.ulozittxt(filepath, txb);
                            }
                            if (filepath.Contains(".rtf") == true) // pokavaď uživatel ukládá soubor jako .rtf, uloží text včetně všech jeho úprav
                                soubor.ulozitrtf(filepath, txb);
                        }
                        else return;
                    }
                    if (filepath.Contains(".txt") == true) // pokavaď uživatel ukládá soubor jako .txt, uloží se pouze čistě text, což zajistí kompatibilitu s jinými programy
                    {
                        soubor.ulozittxt(filepath, txb);
                    }
                    if (filepath.Contains(".rtf") == true) // pokavaď uživatel ukládá soubor jako .rtf, uloží text včetně všech jeho úprav
                        soubor.ulozitrtf(filepath, txb);
                    saved = true;
                }
                else saved = false;
                if (e.KeyCode == Keys.B)
                {
                    Font fnt;
                    FontStyle stl = txb.SelectionFont.Style;
                    fnt = new Font(txb.SelectionFont, stl ^ FontStyle.Bold);
                    text.font(fnt, txb);
                }
                if (e.KeyCode == Keys.U)
                {
                    Font fnt;
                    FontStyle stl = txb.SelectionFont.Style;
                    fnt = new Font(txb.SelectionFont, stl ^ FontStyle.Underline);
                    text.font(fnt, txb);
                }
                if (e.KeyCode == Keys.I)
                {
                    Font fnt;
                    FontStyle stl = txb.SelectionFont.Style;
                    fnt = new Font(txb.SelectionFont, stl ^ FontStyle.Italic);
                    text.font(fnt, txb);
                    e.SuppressKeyPress = true;
                }
            }
            else saved = false;
        }
    }
}
