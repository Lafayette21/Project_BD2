
using System;

namespace PrzetwarzanieDanychXML
{
    partial class XmlActionsForm
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
            System.Windows.Forms.Button buttonCheckState;
            System.Windows.Forms.Button buttonAddNodeForm;
            System.Windows.Forms.Button buttonModifyNodeForm;
            System.Windows.Forms.Button buttonSaveChanges;
            System.Windows.Forms.Button buttonChooseAnother;
            System.Windows.Forms.Button button1;
            this.labelMainOperations = new System.Windows.Forms.Label();
            this.buttonRemoveNode = new System.Windows.Forms.Button();
            buttonCheckState = new System.Windows.Forms.Button();
            buttonAddNodeForm = new System.Windows.Forms.Button();
            buttonModifyNodeForm = new System.Windows.Forms.Button();
            buttonSaveChanges = new System.Windows.Forms.Button();
            buttonChooseAnother = new System.Windows.Forms.Button();
            button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonCheckState
            // 
            buttonCheckState.BackColor = System.Drawing.Color.DarkSlateBlue;
            buttonCheckState.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            buttonCheckState.ForeColor = System.Drawing.Color.White;
            buttonCheckState.Location = new System.Drawing.Point(71, 183);
            buttonCheckState.Name = "buttonCheckState";
            buttonCheckState.Size = new System.Drawing.Size(152, 83);
            buttonCheckState.TabIndex = 1;
            buttonCheckState.Text = "Sprawdź zawartość pliku";
            buttonCheckState.UseVisualStyleBackColor = false;
            buttonCheckState.Click += new System.EventHandler(this.buttonCheckState_Click);
            // 
            // buttonAddNodeForm
            // 
            buttonAddNodeForm.BackColor = System.Drawing.Color.White;
            buttonAddNodeForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            buttonAddNodeForm.ForeColor = System.Drawing.Color.DarkSlateBlue;
            buttonAddNodeForm.Location = new System.Drawing.Point(245, 183);
            buttonAddNodeForm.Name = "buttonAddNodeForm";
            buttonAddNodeForm.Size = new System.Drawing.Size(152, 83);
            buttonAddNodeForm.TabIndex = 2;
            buttonAddNodeForm.Text = "Dodaj węzeł";
            buttonAddNodeForm.UseVisualStyleBackColor = false;
            buttonAddNodeForm.Click += new System.EventHandler(this.buttonAddNodeForm_Click);
            // 
            // buttonModifyNodeForm
            // 
            buttonModifyNodeForm.BackColor = System.Drawing.Color.DarkSlateBlue;
            buttonModifyNodeForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            buttonModifyNodeForm.ForeColor = System.Drawing.Color.White;
            buttonModifyNodeForm.Location = new System.Drawing.Point(431, 183);
            buttonModifyNodeForm.Name = "buttonModifyNodeForm";
            buttonModifyNodeForm.Size = new System.Drawing.Size(152, 83);
            buttonModifyNodeForm.TabIndex = 4;
            buttonModifyNodeForm.Text = "Modyfikuj węzeł";
            buttonModifyNodeForm.UseVisualStyleBackColor = false;
            buttonModifyNodeForm.Click += new System.EventHandler(this.buttonModifyNodeForm_Click);
            // 
            // buttonSaveChanges
            // 
            buttonSaveChanges.BackColor = System.Drawing.Color.DarkSlateBlue;
            buttonSaveChanges.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            buttonSaveChanges.ForeColor = System.Drawing.Color.White;
            buttonSaveChanges.Location = new System.Drawing.Point(157, 292);
            buttonSaveChanges.Name = "buttonSaveChanges";
            buttonSaveChanges.Size = new System.Drawing.Size(152, 83);
            buttonSaveChanges.TabIndex = 5;
            buttonSaveChanges.Text = "Zapisz zmiany w obecnym pliku";
            buttonSaveChanges.UseVisualStyleBackColor = false;
            buttonSaveChanges.Click += new System.EventHandler(this.buttonSaveChanges_Click);
            // 
            // buttonChooseAnother
            // 
            buttonChooseAnother.BackColor = System.Drawing.Color.DarkSlateBlue;
            buttonChooseAnother.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            buttonChooseAnother.ForeColor = System.Drawing.Color.White;
            buttonChooseAnother.Location = new System.Drawing.Point(536, 292);
            buttonChooseAnother.Name = "buttonChooseAnother";
            buttonChooseAnother.Size = new System.Drawing.Size(152, 83);
            buttonChooseAnother.TabIndex = 6;
            buttonChooseAnother.Text = "Wybierz inny plik";
            buttonChooseAnother.UseVisualStyleBackColor = false;
            buttonChooseAnother.Click += new System.EventHandler(this.buttonChooseAnother_Click);
            // 
            // button1
            // 
            button1.BackColor = System.Drawing.Color.White;
            button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            button1.ForeColor = System.Drawing.Color.DarkSlateBlue;
            button1.Location = new System.Drawing.Point(343, 292);
            button1.Name = "button1";
            button1.Size = new System.Drawing.Size(152, 83);
            button1.TabIndex = 8;
            button1.Text = "Wyszukiwanie węzłów";
            button1.UseVisualStyleBackColor = false;
            button1.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // labelMainOperations
            // 
            this.labelMainOperations.AutoSize = true;
            this.labelMainOperations.BackColor = System.Drawing.Color.Teal;
            this.labelMainOperations.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelMainOperations.ForeColor = System.Drawing.Color.Ivory;
            this.labelMainOperations.Location = new System.Drawing.Point(109, 73);
            this.labelMainOperations.Name = "labelMainOperations";
            this.labelMainOperations.Size = new System.Drawing.Size(603, 44);
            this.labelMainOperations.TabIndex = 0;
            this.labelMainOperations.Text = "Dostepne sa nastepujace operacje";
            this.labelMainOperations.Click += new System.EventHandler(this.labelMainOperations_Click);
            // 
            // buttonRemoveNode
            // 
            this.buttonRemoveNode.BackColor = System.Drawing.Color.White;
            this.buttonRemoveNode.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonRemoveNode.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.buttonRemoveNode.Location = new System.Drawing.Point(608, 183);
            this.buttonRemoveNode.Name = "buttonRemoveNode";
            this.buttonRemoveNode.Size = new System.Drawing.Size(152, 83);
            this.buttonRemoveNode.TabIndex = 3;
            this.buttonRemoveNode.Text = "Usuń węzeł";
            this.buttonRemoveNode.UseVisualStyleBackColor = false;
            this.buttonRemoveNode.Click += new System.EventHandler(this.buttonRemoveNode_Click);
            // 
            // XmlActionsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(button1);
            this.Controls.Add(buttonChooseAnother);
            this.Controls.Add(buttonSaveChanges);
            this.Controls.Add(buttonModifyNodeForm);
            this.Controls.Add(this.buttonRemoveNode);
            this.Controls.Add(buttonAddNodeForm);
            this.Controls.Add(buttonCheckState);
            this.Controls.Add(this.labelMainOperations);
            this.Name = "XmlActionsForm";
            this.Text = "Marcin Urbanowicz Projekt";
            this.Load += new System.EventHandler(this.XmlActions_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        

        #endregion

        private System.Windows.Forms.Label labelMainOperations;
        private System.Windows.Forms.Button buttonRemoveNode;
    }
}