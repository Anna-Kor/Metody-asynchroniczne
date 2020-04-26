namespace Metody_asynchroniczne
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.adres_tb = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.downloadButton = new System.Windows.Forms.Button();
            this.pobranyPlik_rtb = new System.Windows.Forms.RichTextBox();
            this.adresy_lb = new System.Windows.Forms.ListBox();
            this.downloadAll_btn = new System.Windows.Forms.Button();
            this.dodaj_btn = new System.Windows.Forms.Button();
            this.pobierz100_btn = new System.Windows.Forms.Button();
            this.rozmiar_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // adres_tb
            // 
            this.adres_tb.Location = new System.Drawing.Point(52, 12);
            this.adres_tb.Name = "adres_tb";
            this.adres_tb.Size = new System.Drawing.Size(315, 22);
            this.adres_tb.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Plik";
            // 
            // downloadButton
            // 
            this.downloadButton.Location = new System.Drawing.Point(52, 40);
            this.downloadButton.Name = "downloadButton";
            this.downloadButton.Size = new System.Drawing.Size(75, 26);
            this.downloadButton.TabIndex = 6;
            this.downloadButton.Text = "Pobierz";
            this.downloadButton.UseVisualStyleBackColor = true;
            this.downloadButton.Click += new System.EventHandler(this.downloadButton_Click);
            // 
            // pobranyPlik_rtb
            // 
            this.pobranyPlik_rtb.Location = new System.Drawing.Point(52, 72);
            this.pobranyPlik_rtb.Name = "pobranyPlik_rtb";
            this.pobranyPlik_rtb.Size = new System.Drawing.Size(315, 366);
            this.pobranyPlik_rtb.TabIndex = 7;
            this.pobranyPlik_rtb.Text = "";
            // 
            // adresy_lb
            // 
            this.adresy_lb.FormattingEnabled = true;
            this.adresy_lb.ItemHeight = 16;
            this.adresy_lb.Location = new System.Drawing.Point(454, 10);
            this.adresy_lb.Name = "adresy_lb";
            this.adresy_lb.Size = new System.Drawing.Size(196, 212);
            this.adresy_lb.TabIndex = 8;
            // 
            // downloadAll_btn
            // 
            this.downloadAll_btn.Location = new System.Drawing.Point(454, 228);
            this.downloadAll_btn.Name = "downloadAll_btn";
            this.downloadAll_btn.Size = new System.Drawing.Size(75, 26);
            this.downloadAll_btn.TabIndex = 9;
            this.downloadAll_btn.Text = "Pobierz";
            this.downloadAll_btn.UseVisualStyleBackColor = true;
            this.downloadAll_btn.Click += new System.EventHandler(this.downloadAll_btn_Click);
            // 
            // dodaj_btn
            // 
            this.dodaj_btn.Location = new System.Drawing.Point(373, 10);
            this.dodaj_btn.Name = "dodaj_btn";
            this.dodaj_btn.Size = new System.Drawing.Size(75, 26);
            this.dodaj_btn.TabIndex = 10;
            this.dodaj_btn.Text = "Dodaj";
            this.dodaj_btn.UseVisualStyleBackColor = true;
            this.dodaj_btn.Click += new System.EventHandler(this.dodaj_btn_Click);
            // 
            // pobierz100_btn
            // 
            this.pobierz100_btn.Location = new System.Drawing.Point(133, 38);
            this.pobierz100_btn.Name = "pobierz100_btn";
            this.pobierz100_btn.Size = new System.Drawing.Size(99, 28);
            this.pobierz100_btn.TabIndex = 11;
            this.pobierz100_btn.Text = "Pobierz 100";
            this.pobierz100_btn.UseVisualStyleBackColor = true;
            this.pobierz100_btn.Click += new System.EventHandler(this.pobierz100_btn_Click);
            // 
            // rozmiar_btn
            // 
            this.rozmiar_btn.Location = new System.Drawing.Point(245, 38);
            this.rozmiar_btn.Name = "rozmiar_btn";
            this.rozmiar_btn.Size = new System.Drawing.Size(122, 28);
            this.rozmiar_btn.TabIndex = 12;
            this.rozmiar_btn.Text = "Rozmiar strony";
            this.rozmiar_btn.UseVisualStyleBackColor = true;
            this.rozmiar_btn.Click += new System.EventHandler(this.rozmiar_btn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.rozmiar_btn);
            this.Controls.Add(this.pobierz100_btn);
            this.Controls.Add(this.dodaj_btn);
            this.Controls.Add(this.downloadAll_btn);
            this.Controls.Add(this.adresy_lb);
            this.Controls.Add(this.pobranyPlik_rtb);
            this.Controls.Add(this.downloadButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.adres_tb);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox adres_tb;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button downloadButton;
        private System.Windows.Forms.RichTextBox pobranyPlik_rtb;
        private System.Windows.Forms.ListBox adresy_lb;
        private System.Windows.Forms.Button downloadAll_btn;
        private System.Windows.Forms.Button dodaj_btn;
        private System.Windows.Forms.Button pobierz100_btn;
        private System.Windows.Forms.Button rozmiar_btn;
    }
}

