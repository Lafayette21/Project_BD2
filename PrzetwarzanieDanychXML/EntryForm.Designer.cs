
namespace PrzetwarzanieDanychXML
{
    partial class EntryForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonChooseXml = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonCreateForm = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonChooseXml
            // 
            this.buttonChooseXml.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.buttonChooseXml.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonChooseXml.ForeColor = System.Drawing.Color.White;
            this.buttonChooseXml.Location = new System.Drawing.Point(439, 210);
            this.buttonChooseXml.Name = "buttonChooseXml";
            this.buttonChooseXml.Size = new System.Drawing.Size(233, 93);
            this.buttonChooseXml.TabIndex = 0;
            this.buttonChooseXml.Text = "Wybierz plik do przetworzenia";
            this.buttonChooseXml.UseVisualStyleBackColor = false;
            this.buttonChooseXml.Click += new System.EventHandler(this.buttonChooseXml_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.Color.Ivory;
            this.label1.Location = new System.Drawing.Point(74, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(505, 46);
            this.label1.TabIndex = 1;
            this.label1.Text = "Przetwarzanie danych XML";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.ForeColor = System.Drawing.Color.Ivory;
            this.label2.Location = new System.Drawing.Point(80, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(296, 38);
            this.label2.TabIndex = 2;
            this.label2.Text = "Marcin Urbanowicz";
            // 
            // buttonCreateForm
            // 
            this.buttonCreateForm.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.buttonCreateForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonCreateForm.ForeColor = System.Drawing.Color.White;
            this.buttonCreateForm.Location = new System.Drawing.Point(143, 210);
            this.buttonCreateForm.Name = "buttonCreateForm";
            this.buttonCreateForm.Size = new System.Drawing.Size(233, 93);
            this.buttonCreateForm.TabIndex = 3;
            this.buttonCreateForm.Text = "Stwórz nowy dokument";
            this.buttonCreateForm.UseVisualStyleBackColor = false;
            this.buttonCreateForm.Click += new System.EventHandler(this.buttonCreateForm_Click);
            // 
            // EntryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(837, 439);
            this.Controls.Add(this.buttonCreateForm);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonChooseXml);
            this.Name = "EntryForm";
            this.Text = "Projekt Marcin Urbanowicz";
            this.Load += new System.EventHandler(this.EntryForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonChooseXml;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonCreateForm;
    }
}

