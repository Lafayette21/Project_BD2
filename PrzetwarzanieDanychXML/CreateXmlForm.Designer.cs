
namespace PrzetwarzanieDanychXML
{
    partial class CreateXmlForm
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
            this.textBoxContent = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonCreateDocument = new System.Windows.Forms.Button();
            this.buttonEntryReturn = new System.Windows.Forms.Button();
            this.textBoxTitle = new System.Windows.Forms.TextBox();
            this.labelContent = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBoxContent
            // 
            this.textBoxContent.Location = new System.Drawing.Point(12, 159);
            this.textBoxContent.Multiline = true;
            this.textBoxContent.Name = "textBoxContent";
            this.textBoxContent.Size = new System.Drawing.Size(317, 375);
            this.textBoxContent.TabIndex = 0;
            this.textBoxContent.Text = "<?xml version=\"1.0\" encoding=\"utf-8\"?>";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.Color.Ivory;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(384, 38);
            this.label1.TabIndex = 1;
            this.label1.Text = "Wprowadź dokument xml";
            // 
            // buttonCreateDocument
            // 
            this.buttonCreateDocument.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.buttonCreateDocument.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonCreateDocument.ForeColor = System.Drawing.Color.White;
            this.buttonCreateDocument.Location = new System.Drawing.Point(356, 85);
            this.buttonCreateDocument.Name = "buttonCreateDocument";
            this.buttonCreateDocument.Size = new System.Drawing.Size(155, 82);
            this.buttonCreateDocument.TabIndex = 2;
            this.buttonCreateDocument.Text = "Stwórz dokument";
            this.buttonCreateDocument.UseVisualStyleBackColor = false;
            this.buttonCreateDocument.Click += new System.EventHandler(this.buttonCreateDocument_Click);
            // 
            // buttonEntryReturn
            // 
            this.buttonEntryReturn.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.buttonEntryReturn.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonEntryReturn.ForeColor = System.Drawing.Color.White;
            this.buttonEntryReturn.Location = new System.Drawing.Point(356, 198);
            this.buttonEntryReturn.Name = "buttonEntryReturn";
            this.buttonEntryReturn.Size = new System.Drawing.Size(155, 82);
            this.buttonEntryReturn.TabIndex = 3;
            this.buttonEntryReturn.Text = "Powrót";
            this.buttonEntryReturn.UseVisualStyleBackColor = false;
            this.buttonEntryReturn.Click += new System.EventHandler(this.buttonEntryReturn_Click);
            // 
            // textBoxTitle
            // 
            this.textBoxTitle.Location = new System.Drawing.Point(12, 102);
            this.textBoxTitle.Name = "textBoxTitle";
            this.textBoxTitle.Size = new System.Drawing.Size(317, 22);
            this.textBoxTitle.TabIndex = 4;
            // 
            // labelContent
            // 
            this.labelContent.AutoSize = true;
            this.labelContent.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelContent.ForeColor = System.Drawing.Color.Ivory;
            this.labelContent.Location = new System.Drawing.Point(15, 127);
            this.labelContent.Name = "labelContent";
            this.labelContent.Size = new System.Drawing.Size(123, 29);
            this.labelContent.TabIndex = 5;
            this.labelContent.Text = "Zawartość";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.ForeColor = System.Drawing.Color.Ivory;
            this.label2.Location = new System.Drawing.Point(12, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(143, 29);
            this.label2.TabIndex = 6;
            this.label2.Text = "Nazwa pliku";
            // 
            // CreateXmlForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(560, 546);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.labelContent);
            this.Controls.Add(this.textBoxTitle);
            this.Controls.Add(this.buttonEntryReturn);
            this.Controls.Add(this.buttonCreateDocument);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxContent);
            this.Name = "CreateXmlForm";
            this.Text = "CreateXmlForm";
            this.Load += new System.EventHandler(this.CreateXmlForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxContent;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonCreateDocument;
        private System.Windows.Forms.Button buttonEntryReturn;
        private System.Windows.Forms.TextBox textBoxTitle;
        private System.Windows.Forms.Label labelContent;
        private System.Windows.Forms.Label label2;
    }
}