using System.IO;

namespace Transmisja
{
    partial class Form1
    {
        string nadana;
        FileStream plik = new FileStream("E://wiadomosc.txt", FileMode.Create, FileAccess.Write, FileShare.Write);
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
            this.odbiornikPanel = new System.Windows.Forms.Panel();
            this.odebranaTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.nadajnikPanel = new System.Windows.Forms.Panel();
            this.bitTextBox = new System.Windows.Forms.TextBox();
            this.nadanaTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.wyslijButton = new System.Windows.Forms.Button();
            this.odbiornikPanel.SuspendLayout();
            this.nadajnikPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // odbiornikPanel
            // 
            this.odbiornikPanel.Controls.Add(this.odebranaTextBox);
            this.odbiornikPanel.Controls.Add(this.label2);
            this.odbiornikPanel.Location = new System.Drawing.Point(447, 11);
            this.odbiornikPanel.Name = "odbiornikPanel";
            this.odbiornikPanel.Size = new System.Drawing.Size(234, 227);
            this.odbiornikPanel.TabIndex = 0;
            // 
            // odebranaTextBox
            // 
            this.odebranaTextBox.Location = new System.Drawing.Point(47, 72);
            this.odebranaTextBox.Name = "odebranaTextBox";
            this.odebranaTextBox.Size = new System.Drawing.Size(162, 20);
            this.odebranaTextBox.TabIndex = 4;
            this.odebranaTextBox.Text = "wiadomosc po konwersji";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(99, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Odbiornik";
            // 
            // nadajnikPanel
            // 
            this.nadajnikPanel.Controls.Add(this.bitTextBox);
            this.nadajnikPanel.Controls.Add(this.nadanaTextBox);
            this.nadajnikPanel.Controls.Add(this.label1);
            this.nadajnikPanel.Location = new System.Drawing.Point(12, 11);
            this.nadajnikPanel.Name = "nadajnikPanel";
            this.nadajnikPanel.Size = new System.Drawing.Size(234, 227);
            this.nadajnikPanel.TabIndex = 1;
            // 
            // bitTextBox
            // 
            this.bitTextBox.Location = new System.Drawing.Point(29, 115);
            this.bitTextBox.Multiline = true;
            this.bitTextBox.Name = "bitTextBox";
            this.bitTextBox.Size = new System.Drawing.Size(162, 55);
            this.bitTextBox.TabIndex = 5;
            this.bitTextBox.Text = "ciag bitow";
            // 
            // nadanaTextBox
            // 
            this.nadanaTextBox.Location = new System.Drawing.Point(29, 52);
            this.nadanaTextBox.Name = "nadanaTextBox";
            this.nadanaTextBox.Size = new System.Drawing.Size(162, 20);
            this.nadanaTextBox.TabIndex = 3;
            this.nadanaTextBox.Text = "wiadomosc";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(83, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nadajnik";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // wyslijButton
            // 
            this.wyslijButton.Location = new System.Drawing.Point(307, 108);
            this.wyslijButton.Name = "wyslijButton";
            this.wyslijButton.Size = new System.Drawing.Size(75, 23);
            this.wyslijButton.TabIndex = 4;
            this.wyslijButton.Text = "WYŚLIJ ->";
            this.wyslijButton.UseVisualStyleBackColor = true;
            this.wyslijButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(713, 261);
            this.Controls.Add(this.wyslijButton);
            this.Controls.Add(this.nadajnikPanel);
            this.Controls.Add(this.odbiornikPanel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.odbiornikPanel.ResumeLayout(false);
            this.odbiornikPanel.PerformLayout();
            this.nadajnikPanel.ResumeLayout(false);
            this.nadajnikPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel odbiornikPanel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel nadajnikPanel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox odebranaTextBox;
        private System.Windows.Forms.TextBox bitTextBox;
        private System.Windows.Forms.TextBox nadanaTextBox;
        private System.Windows.Forms.Button wyslijButton;
    }
}

