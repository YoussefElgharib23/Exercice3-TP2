
namespace Exercice3_TP2
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxStagiaire = new System.Windows.Forms.ComboBox();
            this.textBoxNote = new System.Windows.Forms.TextBox();
            this.btnModifierNote = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBoxExamen = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(51, 12);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Stagiaire:";
            // 
            // comboBoxStagiaire
            // 
            this.comboBoxStagiaire.FormattingEnabled = true;
            this.comboBoxStagiaire.Location = new System.Drawing.Point(112, 10);
            this.comboBoxStagiaire.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.comboBoxStagiaire.Name = "comboBoxStagiaire";
            this.comboBoxStagiaire.Size = new System.Drawing.Size(142, 21);
            this.comboBoxStagiaire.TabIndex = 1;
            this.comboBoxStagiaire.DropDownClosed += new System.EventHandler(this.dropDownClosedEvent);
            // 
            // textBoxNote
            // 
            this.textBoxNote.Location = new System.Drawing.Point(112, 77);
            this.textBoxNote.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxNote.Name = "textBoxNote";
            this.textBoxNote.Size = new System.Drawing.Size(142, 20);
            this.textBoxNote.TabIndex = 2;
            // 
            // btnModifierNote
            // 
            this.btnModifierNote.Location = new System.Drawing.Point(136, 109);
            this.btnModifierNote.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnModifierNote.Name = "btnModifierNote";
            this.btnModifierNote.Size = new System.Drawing.Size(91, 21);
            this.btnModifierNote.TabIndex = 3;
            this.btnModifierNote.Text = "Modifier la note";
            this.btnModifierNote.UseVisualStyleBackColor = true;
            this.btnModifierNote.Click += new System.EventHandler(this.btnModifierClickEvent);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(51, 46);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Examen:";
            // 
            // comboBoxExamen
            // 
            this.comboBoxExamen.FormattingEnabled = true;
            this.comboBoxExamen.Location = new System.Drawing.Point(112, 44);
            this.comboBoxExamen.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.comboBoxExamen.Name = "comboBoxExamen";
            this.comboBoxExamen.Size = new System.Drawing.Size(142, 21);
            this.comboBoxExamen.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(51, 80);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Note:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(317, 146);
            this.Controls.Add(this.btnModifierNote);
            this.Controls.Add(this.textBoxNote);
            this.Controls.Add(this.comboBoxExamen);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBoxStagiaire);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "Exercice 3";
            this.Load += new System.EventHandler(this.formLoadEvent);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxStagiaire;
        private System.Windows.Forms.TextBox textBoxNote;
        private System.Windows.Forms.Button btnModifierNote;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBoxExamen;
        private System.Windows.Forms.Label label3;
    }
}

