namespace text_editor
{
    partial class Form_main
    {
        /// <summary>
        /// Vyžaduje se proměnná návrháře.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Uvolněte všechny používané prostředky.
        /// </summary>
        /// <param name="disposing">hodnota true, když by se měl spravovaný prostředek odstranit; jinak false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kód generovaný Návrhářem Windows Form

        /// <summary>
        /// Metoda vyžadovaná pro podporu Návrháře - neupravovat
        /// obsah této metody v editoru kódu.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_main));
            this.txb = new System.Windows.Forms.RichTextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.souborToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.novýToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.otevřítToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.uložitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.uložitJakoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tiskToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.textToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zarovnáníToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dolevaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.naStředToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dopravaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.barvaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.černáToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bíláToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modráToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zelenáToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.žlutáToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.červenáToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vlastníBarvaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fontToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.calibriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.comicSansToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.papyrusToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.wingdingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vlastníToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.velikostToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem5 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem6 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripTextBox1 = new System.Windows.Forms.ToolStripTextBox();
            this.úpravaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_siroke = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_sikme = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_preskrtnute = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_podtrzene = new System.Windows.Forms.ToolStripMenuItem();
            this.prgSyntaxToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ostatníToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.infoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.colorDialog = new System.Windows.Forms.ColorDialog();
            this.fontDialog = new System.Windows.Forms.FontDialog();
            this.printDialog = new System.Windows.Forms.PrintDialog();
            this.printDocument = new System.Drawing.Printing.PrintDocument();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txb
            // 
            this.txb.AcceptsTab = true;
            this.txb.BackColor = System.Drawing.SystemColors.Window;
            this.txb.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txb.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txb.Location = new System.Drawing.Point(0, 24);
            this.txb.Name = "txb";
            this.txb.Size = new System.Drawing.Size(800, 426);
            this.txb.TabIndex = 0;
            this.txb.Text = "";
            this.txb.SelectionChanged += new System.EventHandler(this.txb_SelectionChanged);
            this.txb.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txb_KeyDown);
            this.txb.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txb_KeyPress);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.Control;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.souborToolStripMenuItem,
            this.textToolStripMenuItem,
            this.prgSyntaxToolStripMenuItem,
            this.ostatníToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // souborToolStripMenuItem
            // 
            this.souborToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.novýToolStripMenuItem,
            this.otevřítToolStripMenuItem,
            this.uložitToolStripMenuItem,
            this.uložitJakoToolStripMenuItem,
            this.tiskToolStripMenuItem});
            this.souborToolStripMenuItem.Name = "souborToolStripMenuItem";
            this.souborToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.souborToolStripMenuItem.Text = "Soubor";
            // 
            // novýToolStripMenuItem
            // 
            this.novýToolStripMenuItem.Name = "novýToolStripMenuItem";
            this.novýToolStripMenuItem.Size = new System.Drawing.Size(138, 22);
            this.novýToolStripMenuItem.Text = "Nový";
            this.novýToolStripMenuItem.Click += new System.EventHandler(this.soubor_novy_click);
            // 
            // otevřítToolStripMenuItem
            // 
            this.otevřítToolStripMenuItem.Name = "otevřítToolStripMenuItem";
            this.otevřítToolStripMenuItem.Size = new System.Drawing.Size(138, 22);
            this.otevřítToolStripMenuItem.Text = "Otevřít...";
            this.otevřítToolStripMenuItem.Click += new System.EventHandler(this.soubor_otevrit_click);
            // 
            // uložitToolStripMenuItem
            // 
            this.uložitToolStripMenuItem.Name = "uložitToolStripMenuItem";
            this.uložitToolStripMenuItem.Size = new System.Drawing.Size(138, 22);
            this.uložitToolStripMenuItem.Text = "Uložit";
            this.uložitToolStripMenuItem.Click += new System.EventHandler(this.soubor_ulozit_click);
            // 
            // uložitJakoToolStripMenuItem
            // 
            this.uložitJakoToolStripMenuItem.Name = "uložitJakoToolStripMenuItem";
            this.uložitJakoToolStripMenuItem.Size = new System.Drawing.Size(138, 22);
            this.uložitJakoToolStripMenuItem.Text = "Uložit jako...";
            this.uložitJakoToolStripMenuItem.Click += new System.EventHandler(this.soubor_ulozitjako_click);
            // 
            // tiskToolStripMenuItem
            // 
            this.tiskToolStripMenuItem.Name = "tiskToolStripMenuItem";
            this.tiskToolStripMenuItem.Size = new System.Drawing.Size(138, 22);
            this.tiskToolStripMenuItem.Text = "Tisk";
            this.tiskToolStripMenuItem.Click += new System.EventHandler(this.soubor_tisk_click);
            // 
            // textToolStripMenuItem
            // 
            this.textToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.zarovnáníToolStripMenuItem,
            this.barvaToolStripMenuItem,
            this.fontToolStripMenuItem,
            this.velikostToolStripMenuItem,
            this.úpravaToolStripMenuItem});
            this.textToolStripMenuItem.Name = "textToolStripMenuItem";
            this.textToolStripMenuItem.Size = new System.Drawing.Size(41, 20);
            this.textToolStripMenuItem.Text = "Text";
            // 
            // zarovnáníToolStripMenuItem
            // 
            this.zarovnáníToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dolevaToolStripMenuItem,
            this.naStředToolStripMenuItem,
            this.dopravaToolStripMenuItem});
            this.zarovnáníToolStripMenuItem.Name = "zarovnáníToolStripMenuItem";
            this.zarovnáníToolStripMenuItem.Size = new System.Drawing.Size(127, 22);
            this.zarovnáníToolStripMenuItem.Text = "Zarovnání";
            // 
            // dolevaToolStripMenuItem
            // 
            this.dolevaToolStripMenuItem.Name = "dolevaToolStripMenuItem";
            this.dolevaToolStripMenuItem.Size = new System.Drawing.Size(118, 22);
            this.dolevaToolStripMenuItem.Text = "Doleva";
            this.dolevaToolStripMenuItem.Click += new System.EventHandler(this.text_zarovnat_doleva);
            // 
            // naStředToolStripMenuItem
            // 
            this.naStředToolStripMenuItem.Name = "naStředToolStripMenuItem";
            this.naStředToolStripMenuItem.Size = new System.Drawing.Size(118, 22);
            this.naStředToolStripMenuItem.Text = "Na střed";
            this.naStředToolStripMenuItem.Click += new System.EventHandler(this.text_zarovnat_nastred);
            // 
            // dopravaToolStripMenuItem
            // 
            this.dopravaToolStripMenuItem.Name = "dopravaToolStripMenuItem";
            this.dopravaToolStripMenuItem.Size = new System.Drawing.Size(118, 22);
            this.dopravaToolStripMenuItem.Text = "Doprava";
            this.dopravaToolStripMenuItem.Click += new System.EventHandler(this.text_zarovnat_doprava);
            // 
            // barvaToolStripMenuItem
            // 
            this.barvaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.černáToolStripMenuItem,
            this.bíláToolStripMenuItem,
            this.modráToolStripMenuItem,
            this.zelenáToolStripMenuItem,
            this.žlutáToolStripMenuItem,
            this.červenáToolStripMenuItem,
            this.vlastníBarvaToolStripMenuItem});
            this.barvaToolStripMenuItem.Name = "barvaToolStripMenuItem";
            this.barvaToolStripMenuItem.Size = new System.Drawing.Size(127, 22);
            this.barvaToolStripMenuItem.Text = "Barva";
            // 
            // černáToolStripMenuItem
            // 
            this.černáToolStripMenuItem.Name = "černáToolStripMenuItem";
            this.černáToolStripMenuItem.Size = new System.Drawing.Size(117, 22);
            this.černáToolStripMenuItem.Text = "Černá";
            this.černáToolStripMenuItem.Click += new System.EventHandler(this.text_barva_cerna);
            // 
            // bíláToolStripMenuItem
            // 
            this.bíláToolStripMenuItem.Name = "bíláToolStripMenuItem";
            this.bíláToolStripMenuItem.Size = new System.Drawing.Size(117, 22);
            this.bíláToolStripMenuItem.Text = "Bílá";
            this.bíláToolStripMenuItem.Click += new System.EventHandler(this.text_barva_bila);
            // 
            // modráToolStripMenuItem
            // 
            this.modráToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlText;
            this.modráToolStripMenuItem.Name = "modráToolStripMenuItem";
            this.modráToolStripMenuItem.Size = new System.Drawing.Size(117, 22);
            this.modráToolStripMenuItem.Text = "Modrá";
            this.modráToolStripMenuItem.Click += new System.EventHandler(this.text_barva_modra);
            // 
            // zelenáToolStripMenuItem
            // 
            this.zelenáToolStripMenuItem.Name = "zelenáToolStripMenuItem";
            this.zelenáToolStripMenuItem.Size = new System.Drawing.Size(117, 22);
            this.zelenáToolStripMenuItem.Text = "Zelená";
            this.zelenáToolStripMenuItem.Click += new System.EventHandler(this.text_barva_zelena);
            // 
            // žlutáToolStripMenuItem
            // 
            this.žlutáToolStripMenuItem.Name = "žlutáToolStripMenuItem";
            this.žlutáToolStripMenuItem.Size = new System.Drawing.Size(117, 22);
            this.žlutáToolStripMenuItem.Text = "Žlutá";
            this.žlutáToolStripMenuItem.Click += new System.EventHandler(this.text_barva_zluta);
            // 
            // červenáToolStripMenuItem
            // 
            this.červenáToolStripMenuItem.Name = "červenáToolStripMenuItem";
            this.červenáToolStripMenuItem.Size = new System.Drawing.Size(117, 22);
            this.červenáToolStripMenuItem.Text = "Červená";
            this.červenáToolStripMenuItem.Click += new System.EventHandler(this.text_barva_cervena);
            // 
            // vlastníBarvaToolStripMenuItem
            // 
            this.vlastníBarvaToolStripMenuItem.Name = "vlastníBarvaToolStripMenuItem";
            this.vlastníBarvaToolStripMenuItem.Size = new System.Drawing.Size(117, 22);
            this.vlastníBarvaToolStripMenuItem.Text = "Vlastní";
            this.vlastníBarvaToolStripMenuItem.Click += new System.EventHandler(this.text_barva_vlastni);
            // 
            // fontToolStripMenuItem
            // 
            this.fontToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.calibriToolStripMenuItem,
            this.comicSansToolStripMenuItem,
            this.papyrusToolStripMenuItem,
            this.wingdingsToolStripMenuItem,
            this.vlastníToolStripMenuItem});
            this.fontToolStripMenuItem.Name = "fontToolStripMenuItem";
            this.fontToolStripMenuItem.Size = new System.Drawing.Size(127, 22);
            this.fontToolStripMenuItem.Text = "Font";
            // 
            // calibriToolStripMenuItem
            // 
            this.calibriToolStripMenuItem.Name = "calibriToolStripMenuItem";
            this.calibriToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.calibriToolStripMenuItem.Text = "Calibri";
            this.calibriToolStripMenuItem.Click += new System.EventHandler(this.text_font_calibri);
            // 
            // comicSansToolStripMenuItem
            // 
            this.comicSansToolStripMenuItem.Name = "comicSansToolStripMenuItem";
            this.comicSansToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.comicSansToolStripMenuItem.Text = "Comic Sans";
            this.comicSansToolStripMenuItem.Click += new System.EventHandler(this.text_font_comicsans);
            // 
            // papyrusToolStripMenuItem
            // 
            this.papyrusToolStripMenuItem.Name = "papyrusToolStripMenuItem";
            this.papyrusToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.papyrusToolStripMenuItem.Text = "Papyrus";
            this.papyrusToolStripMenuItem.Click += new System.EventHandler(this.text_font_papyrus);
            // 
            // wingdingsToolStripMenuItem
            // 
            this.wingdingsToolStripMenuItem.Name = "wingdingsToolStripMenuItem";
            this.wingdingsToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.wingdingsToolStripMenuItem.Text = "Wingdings";
            this.wingdingsToolStripMenuItem.Click += new System.EventHandler(this.text_font_wingdings);
            // 
            // vlastníToolStripMenuItem
            // 
            this.vlastníToolStripMenuItem.Name = "vlastníToolStripMenuItem";
            this.vlastníToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.vlastníToolStripMenuItem.Text = "Vlastní";
            this.vlastníToolStripMenuItem.Click += new System.EventHandler(this.font_text_vlastni);
            // 
            // velikostToolStripMenuItem
            // 
            this.velikostToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem2,
            this.toolStripMenuItem3,
            this.toolStripMenuItem4,
            this.toolStripMenuItem5,
            this.toolStripMenuItem6,
            this.toolStripTextBox1});
            this.velikostToolStripMenuItem.Name = "velikostToolStripMenuItem";
            this.velikostToolStripMenuItem.Size = new System.Drawing.Size(127, 22);
            this.velikostToolStripMenuItem.Text = "Velikost";
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(160, 22);
            this.toolStripMenuItem2.Text = "8";
            this.toolStripMenuItem2.Click += new System.EventHandler(this.text_velikost_8);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(160, 22);
            this.toolStripMenuItem3.Text = "12";
            this.toolStripMenuItem3.Click += new System.EventHandler(this.text_velikost_12);
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Size = new System.Drawing.Size(160, 22);
            this.toolStripMenuItem4.Text = "16";
            this.toolStripMenuItem4.Click += new System.EventHandler(this.text_velikost_16);
            // 
            // toolStripMenuItem5
            // 
            this.toolStripMenuItem5.Name = "toolStripMenuItem5";
            this.toolStripMenuItem5.Size = new System.Drawing.Size(160, 22);
            this.toolStripMenuItem5.Text = "20";
            this.toolStripMenuItem5.Click += new System.EventHandler(this.text_velikost_20);
            // 
            // toolStripMenuItem6
            // 
            this.toolStripMenuItem6.Name = "toolStripMenuItem6";
            this.toolStripMenuItem6.Size = new System.Drawing.Size(160, 22);
            this.toolStripMenuItem6.Text = "72";
            this.toolStripMenuItem6.Click += new System.EventHandler(this.text_velikost_72);
            // 
            // toolStripTextBox1
            // 
            this.toolStripTextBox1.Name = "toolStripTextBox1";
            this.toolStripTextBox1.Size = new System.Drawing.Size(100, 23);
            this.toolStripTextBox1.Text = "Vlastní";
            this.toolStripTextBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.text_velikost_vlastni);
            // 
            // úpravaToolStripMenuItem
            // 
            this.úpravaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menu_siroke,
            this.menu_sikme,
            this.menu_preskrtnute,
            this.menu_podtrzene});
            this.úpravaToolStripMenuItem.Name = "úpravaToolStripMenuItem";
            this.úpravaToolStripMenuItem.Size = new System.Drawing.Size(127, 22);
            this.úpravaToolStripMenuItem.Text = "Úprava";
            // 
            // menu_siroke
            // 
            this.menu_siroke.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.menu_siroke.Name = "menu_siroke";
            this.menu_siroke.Size = new System.Drawing.Size(134, 22);
            this.menu_siroke.Text = "Široké";
            this.menu_siroke.Click += new System.EventHandler(this.text_uprava_siroke);
            // 
            // menu_sikme
            // 
            this.menu_sikme.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic);
            this.menu_sikme.Name = "menu_sikme";
            this.menu_sikme.Size = new System.Drawing.Size(134, 22);
            this.menu_sikme.Text = "Šikmé";
            this.menu_sikme.Click += new System.EventHandler(this.text_uprava_sikme);
            // 
            // menu_preskrtnute
            // 
            this.menu_preskrtnute.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Strikeout);
            this.menu_preskrtnute.Name = "menu_preskrtnute";
            this.menu_preskrtnute.Size = new System.Drawing.Size(134, 22);
            this.menu_preskrtnute.Text = "Přeškrtnuté";
            this.menu_preskrtnute.Click += new System.EventHandler(this.text_uprava_preskrtnute);
            // 
            // menu_podtrzene
            // 
            this.menu_podtrzene.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Underline);
            this.menu_podtrzene.Name = "menu_podtrzene";
            this.menu_podtrzene.Size = new System.Drawing.Size(134, 22);
            this.menu_podtrzene.Text = "Podtržené";
            this.menu_podtrzene.Click += new System.EventHandler(this.text_uprava_podtrzene);
            // 
            // prgSyntaxToolStripMenuItem
            // 
            this.prgSyntaxToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cToolStripMenuItem});
            this.prgSyntaxToolStripMenuItem.Name = "prgSyntaxToolStripMenuItem";
            this.prgSyntaxToolStripMenuItem.Size = new System.Drawing.Size(74, 20);
            this.prgSyntaxToolStripMenuItem.Text = "Prg Syntax";
            // 
            // cToolStripMenuItem
            // 
            this.cToolStripMenuItem.BackColor = System.Drawing.SystemColors.Control;
            this.cToolStripMenuItem.CheckOnClick = true;
            this.cToolStripMenuItem.Name = "cToolStripMenuItem";
            this.cToolStripMenuItem.Size = new System.Drawing.Size(89, 22);
            this.cToolStripMenuItem.Text = "C#";
            this.cToolStripMenuItem.Click += new System.EventHandler(this.prg_csharp);
            // 
            // ostatníToolStripMenuItem
            // 
            this.ostatníToolStripMenuItem.BackColor = System.Drawing.SystemColors.Control;
            this.ostatníToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.infoToolStripMenuItem});
            this.ostatníToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlText;
            this.ostatníToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Transparent;
            this.ostatníToolStripMenuItem.Name = "ostatníToolStripMenuItem";
            this.ostatníToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.ostatníToolStripMenuItem.Text = "Ostatní";
            // 
            // infoToolStripMenuItem
            // 
            this.infoToolStripMenuItem.BackColor = System.Drawing.SystemColors.Control;
            this.infoToolStripMenuItem.Name = "infoToolStripMenuItem";
            this.infoToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.infoToolStripMenuItem.Text = "Info";
            this.infoToolStripMenuItem.Click += new System.EventHandler(this.ostatni_info);
            // 
            // openFileDialog
            // 
            this.openFileDialog.Filter = "text files (*.txt)|*.txt|rtf files (*.rtf)|*.rtf";
            // 
            // saveFileDialog
            // 
            this.saveFileDialog.DefaultExt = "txt";
            this.saveFileDialog.Filter = "text files (*.txt)|*.txt |rtf files (*.rtf)|*.rtf";
            // 
            // fontDialog
            // 
            this.fontDialog.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.fontDialog.ShowEffects = false;
            // 
            // printDialog
            // 
            this.printDialog.UseEXDialog = true;
            // 
            // printDocument
            // 
            this.printDocument.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument_PrintPage);
            // 
            // Form_main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txb);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form_main";
            this.Text = "GatoPad--";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.form_zavren);
            this.Load += new System.EventHandler(this.form_nacten);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox txb;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem souborToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem otevřítToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem uložitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem uložitJakoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem textToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem zarovnáníToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dolevaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem naStředToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dopravaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem barvaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fontToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem calibriToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem comicSansToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem papyrusToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem wingdingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem velikostToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem černáToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bíláToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modráToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem zelenáToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem žlutáToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem červenáToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vlastníBarvaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem4;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem5;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem6;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Windows.Forms.ToolStripMenuItem novýToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vlastníToolStripMenuItem;
        private System.Windows.Forms.ColorDialog colorDialog;
        private System.Windows.Forms.FontDialog fontDialog;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBox1;
        private System.Windows.Forms.ToolStripMenuItem úpravaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menu_siroke;
        private System.Windows.Forms.ToolStripMenuItem menu_sikme;
        private System.Windows.Forms.ToolStripMenuItem menu_preskrtnute;
        private System.Windows.Forms.ToolStripMenuItem menu_podtrzene;
        private System.Windows.Forms.ToolStripMenuItem prgSyntaxToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ostatníToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem infoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tiskToolStripMenuItem;
        private System.Windows.Forms.PrintDialog printDialog;
        private System.Drawing.Printing.PrintDocument printDocument;
    }
}

