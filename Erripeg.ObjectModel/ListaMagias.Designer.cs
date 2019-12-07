﻿namespace Erripeg.ObjectModel
{
    partial class ListaMagias
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
            this.characterUpdateButton = new System.Windows.Forms.Button();
            this.spellCreateButton = new System.Windows.Forms.Button();
            this.spellDeleteButton = new System.Windows.Forms.Button();
            this.spellListLabel = new System.Windows.Forms.Label();
            this.selectSpellDataGridView = new System.Windows.Forms.DataGridView();
            this.updateTableButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.selectSpellDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // characterUpdateButton
            // 
            this.characterUpdateButton.Location = new System.Drawing.Point(358, 371);
            this.characterUpdateButton.Name = "characterUpdateButton";
            this.characterUpdateButton.Size = new System.Drawing.Size(100, 23);
            this.characterUpdateButton.TabIndex = 90;
            this.characterUpdateButton.Text = "Update spell";
            this.characterUpdateButton.UseVisualStyleBackColor = true;
            // 
            // spellCreateButton
            // 
            this.spellCreateButton.Location = new System.Drawing.Point(207, 371);
            this.spellCreateButton.Name = "spellCreateButton";
            this.spellCreateButton.Size = new System.Drawing.Size(100, 23);
            this.spellCreateButton.TabIndex = 89;
            this.spellCreateButton.Text = "Create spell";
            this.spellCreateButton.UseVisualStyleBackColor = true;
            this.spellCreateButton.Click += new System.EventHandler(this.spellCreateButton_Click);
            // 
            // spellDeleteButton
            // 
            this.spellDeleteButton.Location = new System.Drawing.Point(207, 407);
            this.spellDeleteButton.Name = "spellDeleteButton";
            this.spellDeleteButton.Size = new System.Drawing.Size(100, 23);
            this.spellDeleteButton.TabIndex = 87;
            this.spellDeleteButton.Text = "Delete spell";
            this.spellDeleteButton.UseVisualStyleBackColor = true;
            // 
            // spellListLabel
            // 
            this.spellListLabel.AutoSize = true;
            this.spellListLabel.Location = new System.Drawing.Point(12, 23);
            this.spellListLabel.Name = "spellListLabel";
            this.spellListLabel.Size = new System.Drawing.Size(49, 13);
            this.spellListLabel.TabIndex = 86;
            this.spellListLabel.Text = "Spell List";
            // 
            // selectSpellDataGridView
            // 
            this.selectSpellDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.selectSpellDataGridView.Location = new System.Drawing.Point(15, 39);
            this.selectSpellDataGridView.Name = "selectSpellDataGridView";
            this.selectSpellDataGridView.Size = new System.Drawing.Size(647, 326);
            this.selectSpellDataGridView.TabIndex = 91;
            this.selectSpellDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // updateTableButton
            // 
            this.updateTableButton.Location = new System.Drawing.Point(358, 407);
            this.updateTableButton.Name = "updateTableButton";
            this.updateTableButton.Size = new System.Drawing.Size(100, 23);
            this.updateTableButton.TabIndex = 92;
            this.updateTableButton.Text = "Update Table";
            this.updateTableButton.UseVisualStyleBackColor = true;
            this.updateTableButton.Click += new System.EventHandler(this.updateTableButton_Click);
            // 
            // ListaMagias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(674, 450);
            this.Controls.Add(this.updateTableButton);
            this.Controls.Add(this.selectSpellDataGridView);
            this.Controls.Add(this.characterUpdateButton);
            this.Controls.Add(this.spellCreateButton);
            this.Controls.Add(this.spellDeleteButton);
            this.Controls.Add(this.spellListLabel);
            this.Name = "ListaMagias";
            this.Text = "ListaMagias";
            this.Load += new System.EventHandler(this.ListaMagias_Load);
            ((System.ComponentModel.ISupportInitialize)(this.selectSpellDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button characterUpdateButton;
        private System.Windows.Forms.Button spellCreateButton;
        private System.Windows.Forms.Button spellDeleteButton;
        private System.Windows.Forms.Label spellListLabel;
        private System.Windows.Forms.Button updateTableButton;
        public System.Windows.Forms.DataGridView selectSpellDataGridView;
    }
}