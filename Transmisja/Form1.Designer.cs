using System.IO;

namespace Transmisja
{
    partial class Form1
    {
        string nadana;
        string binary;
        string wiadomosc;
        string wulgar;
        string gwiazdki;
        System.IO.StreamReader slownik;

        
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
            this.odebranaTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.bitTextBox = new System.Windows.Forms.TextBox();
            this.nadanaTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.wyslijButton = new System.Windows.Forms.Button();
            this.odczytajButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // odebranaTextBox
            // 
            this.odebranaTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.odebranaTextBox.Location = new System.Drawing.Point(528, 48);
            this.odebranaTextBox.Multiline = true;
            this.odebranaTextBox.Name = "odebranaTextBox";
            this.odebranaTextBox.Size = new System.Drawing.Size(162, 190);
            this.odebranaTextBox.TabIndex = 4;
            this.odebranaTextBox.Text = "wiadomosc po konwersji";
            this.odebranaTextBox.TextChanged += new System.EventHandler(this.odebranaTextBox_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(581, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Odbiornik";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // bitTextBox
            // 
            this.bitTextBox.Enabled = false;
            this.bitTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.bitTextBox.Location = new System.Drawing.Point(270, 48);
            this.bitTextBox.Multiline = true;
            this.bitTextBox.Name = "bitTextBox";
            this.bitTextBox.Size = new System.Drawing.Size(162, 190);
            this.bitTextBox.TabIndex = 5;
            this.bitTextBox.Text = "ciag bitow";
            // 
            // nadanaTextBox
            // 
            this.nadanaTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.nadanaTextBox.Location = new System.Drawing.Point(12, 48);
            this.nadanaTextBox.Multiline = true;
            this.nadanaTextBox.Name = "nadanaTextBox";
            this.nadanaTextBox.Size = new System.Drawing.Size(162, 190);
            this.nadanaTextBox.TabIndex = 3;
            this.nadanaTextBox.Text = "wiadomosc";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(56, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nadajnik";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // wyslijButton
            // 
            this.wyslijButton.Location = new System.Drawing.Point(180, 48);
            this.wyslijButton.Name = "wyslijButton";
            this.wyslijButton.Size = new System.Drawing.Size(84, 190);
            this.wyslijButton.TabIndex = 4;
            this.wyslijButton.Text = "WYŚLIJ ->";
            this.wyslijButton.UseVisualStyleBackColor = true;
            this.wyslijButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // odczytajButton
            // 
            this.odczytajButton.Location = new System.Drawing.Point(438, 48);
            this.odczytajButton.Name = "odczytajButton";
            this.odczytajButton.Size = new System.Drawing.Size(84, 190);
            this.odczytajButton.TabIndex = 5;
            this.odczytajButton.Text = "ODCZYTAJ ->";
            this.odczytajButton.UseVisualStyleBackColor = true;
            this.odczytajButton.Click += new System.EventHandler(this.odczytajButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(713, 261);
            this.Controls.Add(this.odebranaTextBox);
            this.Controls.Add(this.bitTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.odczytajButton);
            this.Controls.Add(this.nadanaTextBox);
            this.Controls.Add(this.wyslijButton);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox odebranaTextBox;
        private System.Windows.Forms.TextBox bitTextBox;
        private System.Windows.Forms.TextBox nadanaTextBox;
        private System.Windows.Forms.Button wyslijButton;
        private System.Windows.Forms.Button odczytajButton;
    }
}

