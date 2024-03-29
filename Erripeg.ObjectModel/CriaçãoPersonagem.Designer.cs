﻿namespace Erripeg.ObjectModel
{
    partial class CriaçãoPersonagem
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
            this.characterCreateButton = new System.Windows.Forms.Button();
            this.characterSearchLabel = new System.Windows.Forms.Label();
            this.characterSearchTextBox = new System.Windows.Forms.TextBox();
            this.characterBackgroundLabel = new System.Windows.Forms.Label();
            this.characterXpTextBox = new System.Windows.Forms.TextBox();
            this.characterLvlTextBox = new System.Windows.Forms.TextBox();
            this.characterLvlLabel = new System.Windows.Forms.Label();
            this.characterNameTextBox = new System.Windows.Forms.TextBox();
            this.characterHeightTextBox = new System.Windows.Forms.TextBox();
            this.characterWeightTextBox = new System.Windows.Forms.TextBox();
            this.characterInfoLabel = new System.Windows.Forms.Label();
            this.characterManaTextBox = new System.Windows.Forms.TextBox();
            this.characterLifeTextBox = new System.Windows.Forms.TextBox();
            this.characterBackgroundRichTextBox = new System.Windows.Forms.RichTextBox();
            this.characterXpLabel = new System.Windows.Forms.Label();
            this.characterHeightLabel = new System.Windows.Forms.Label();
            this.characterWeightLabel = new System.Windows.Forms.Label();
            this.characterManaLabel = new System.Windows.Forms.Label();
            this.characterLifeLabel = new System.Windows.Forms.Label();
            this.characterNameLabel = new System.Windows.Forms.Label();
            this.characterImagePictureBox = new System.Windows.Forms.PictureBox();
            this.button2 = new System.Windows.Forms.Button();
            this.teste = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.characterImagePictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // characterCreateButton
            // 
            this.characterCreateButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.characterCreateButton.ForeColor = System.Drawing.Color.Black;
            this.characterCreateButton.Location = new System.Drawing.Point(297, 398);
            this.characterCreateButton.Name = "characterCreateButton";
            this.characterCreateButton.Size = new System.Drawing.Size(171, 40);
            this.characterCreateButton.TabIndex = 118;
            this.characterCreateButton.Text = "Criar";
            this.characterCreateButton.UseVisualStyleBackColor = true;
            this.characterCreateButton.Click += new System.EventHandler(this.CharacterCreateButton_Click);
            // 
            // characterSearchLabel
            // 
            this.characterSearchLabel.AutoSize = true;
            this.characterSearchLabel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.characterSearchLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.characterSearchLabel.ForeColor = System.Drawing.Color.Black;
            this.characterSearchLabel.Location = new System.Drawing.Point(252, 246);
            this.characterSearchLabel.Name = "characterSearchLabel";
            this.characterSearchLabel.Size = new System.Drawing.Size(247, 24);
            this.characterSearchLabel.TabIndex = 117;
            this.characterSearchLabel.Text = "Procurar personagem por id";
            this.characterSearchLabel.Click += new System.EventHandler(this.characterSearchLabel_Click);
            // 
            // characterSearchTextBox
            // 
            this.characterSearchTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.characterSearchTextBox.Location = new System.Drawing.Point(252, 273);
            this.characterSearchTextBox.Name = "characterSearchTextBox";
            this.characterSearchTextBox.Size = new System.Drawing.Size(248, 29);
            this.characterSearchTextBox.TabIndex = 115;
            this.characterSearchTextBox.TextChanged += new System.EventHandler(this.characterSearchTextBox_TextChanged);
            this.characterSearchTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CharacterSearchTextBox_KeyPress);
            // 
            // characterBackgroundLabel
            // 
            this.characterBackgroundLabel.AutoSize = true;
            this.characterBackgroundLabel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.characterBackgroundLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.characterBackgroundLabel.ForeColor = System.Drawing.Color.Black;
            this.characterBackgroundLabel.Location = new System.Drawing.Point(530, 16);
            this.characterBackgroundLabel.Name = "characterBackgroundLabel";
            this.characterBackgroundLabel.Size = new System.Drawing.Size(77, 24);
            this.characterBackgroundLabel.TabIndex = 107;
            this.characterBackgroundLabel.Text = "História:";
            this.characterBackgroundLabel.Click += new System.EventHandler(this.characterBackgroundLabel_Click);
            // 
            // characterXpTextBox
            // 
            this.characterXpTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.characterXpTextBox.Location = new System.Drawing.Point(323, 70);
            this.characterXpTextBox.Name = "characterXpTextBox";
            this.characterXpTextBox.Size = new System.Drawing.Size(100, 29);
            this.characterXpTextBox.TabIndex = 106;
            this.characterXpTextBox.TextChanged += new System.EventHandler(this.characterXpTextBox_TextChanged);
            this.characterXpTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CharacterXpTextBox_KeyPress);
            // 
            // characterLvlTextBox
            // 
            this.characterLvlTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.characterLvlTextBox.Location = new System.Drawing.Point(128, 43);
            this.characterLvlTextBox.Name = "characterLvlTextBox";
            this.characterLvlTextBox.Size = new System.Drawing.Size(100, 29);
            this.characterLvlTextBox.TabIndex = 105;
            this.characterLvlTextBox.TextChanged += new System.EventHandler(this.characterLvlTextBox_TextChanged);
            this.characterLvlTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CharacterLvlTextBox_KeyPress);
            // 
            // characterLvlLabel
            // 
            this.characterLvlLabel.AutoSize = true;
            this.characterLvlLabel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.characterLvlLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.characterLvlLabel.ForeColor = System.Drawing.Color.Black;
            this.characterLvlLabel.Location = new System.Drawing.Point(124, 16);
            this.characterLvlLabel.Name = "characterLvlLabel";
            this.characterLvlLabel.Size = new System.Drawing.Size(57, 24);
            this.characterLvlLabel.TabIndex = 104;
            this.characterLvlLabel.Text = "Nível:";
            this.characterLvlLabel.Click += new System.EventHandler(this.characterLvlLabel_Click);
            // 
            // characterNameTextBox
            // 
            this.characterNameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.characterNameTextBox.Location = new System.Drawing.Point(18, 43);
            this.characterNameTextBox.Name = "characterNameTextBox";
            this.characterNameTextBox.Size = new System.Drawing.Size(100, 29);
            this.characterNameTextBox.TabIndex = 103;
            this.characterNameTextBox.TextChanged += new System.EventHandler(this.characterNameTextBox_TextChanged);
            // 
            // characterHeightTextBox
            // 
            this.characterHeightTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.characterHeightTextBox.Location = new System.Drawing.Point(399, 129);
            this.characterHeightTextBox.Name = "characterHeightTextBox";
            this.characterHeightTextBox.Size = new System.Drawing.Size(100, 29);
            this.characterHeightTextBox.TabIndex = 102;
            this.characterHeightTextBox.TextChanged += new System.EventHandler(this.characterHeightTextBox_TextChanged);
            this.characterHeightTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CharacterHeightTextBox_KeyPress);
            // 
            // characterWeightTextBox
            // 
            this.characterWeightTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.characterWeightTextBox.Location = new System.Drawing.Point(399, 188);
            this.characterWeightTextBox.Name = "characterWeightTextBox";
            this.characterWeightTextBox.Size = new System.Drawing.Size(100, 29);
            this.characterWeightTextBox.TabIndex = 101;
            this.characterWeightTextBox.TextChanged += new System.EventHandler(this.characterWeightTextBox_TextChanged);
            this.characterWeightTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CharacterWeightTextBox_KeyPress);
            // 
            // characterInfoLabel
            // 
            this.characterInfoLabel.AutoSize = true;
            this.characterInfoLabel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.characterInfoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.characterInfoLabel.ForeColor = System.Drawing.Color.Black;
            this.characterInfoLabel.Location = new System.Drawing.Point(247, 9);
            this.characterInfoLabel.Name = "characterInfoLabel";
            this.characterInfoLabel.Size = new System.Drawing.Size(113, 24);
            this.characterInfoLabel.TabIndex = 100;
            this.characterInfoLabel.Text = "Informações";
            this.characterInfoLabel.Click += new System.EventHandler(this.characterInfoLabel_Click);
            // 
            // characterManaTextBox
            // 
            this.characterManaTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.characterManaTextBox.Location = new System.Drawing.Point(251, 188);
            this.characterManaTextBox.Name = "characterManaTextBox";
            this.characterManaTextBox.Size = new System.Drawing.Size(100, 29);
            this.characterManaTextBox.TabIndex = 99;
            this.characterManaTextBox.TextChanged += new System.EventHandler(this.characterManaTextBox_TextChanged);
            this.characterManaTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CharacterManaTextBox_KeyPress);
            // 
            // characterLifeTextBox
            // 
            this.characterLifeTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.characterLifeTextBox.Location = new System.Drawing.Point(251, 127);
            this.characterLifeTextBox.Name = "characterLifeTextBox";
            this.characterLifeTextBox.Size = new System.Drawing.Size(100, 29);
            this.characterLifeTextBox.TabIndex = 98;
            this.characterLifeTextBox.TextChanged += new System.EventHandler(this.CharacterLifeTextBox_TextChanged);
            this.characterLifeTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CharacterLifeTextBox_KeyPress);
            // 
            // characterBackgroundRichTextBox
            // 
            this.characterBackgroundRichTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.characterBackgroundRichTextBox.Location = new System.Drawing.Point(534, 59);
            this.characterBackgroundRichTextBox.Name = "characterBackgroundRichTextBox";
            this.characterBackgroundRichTextBox.Size = new System.Drawing.Size(286, 359);
            this.characterBackgroundRichTextBox.TabIndex = 95;
            this.characterBackgroundRichTextBox.Text = "";
            this.characterBackgroundRichTextBox.TextChanged += new System.EventHandler(this.characterBackgroundRichTextBox_TextChanged);
            // 
            // characterXpLabel
            // 
            this.characterXpLabel.AutoSize = true;
            this.characterXpLabel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.characterXpLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.characterXpLabel.ForeColor = System.Drawing.Color.Black;
            this.characterXpLabel.Location = new System.Drawing.Point(319, 43);
            this.characterXpLabel.Name = "characterXpLabel";
            this.characterXpLabel.Size = new System.Drawing.Size(41, 24);
            this.characterXpLabel.TabIndex = 87;
            this.characterXpLabel.Text = "XP:";
            this.characterXpLabel.Click += new System.EventHandler(this.characterXpLabel_Click);
            // 
            // characterHeightLabel
            // 
            this.characterHeightLabel.AutoSize = true;
            this.characterHeightLabel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.characterHeightLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.characterHeightLabel.ForeColor = System.Drawing.Color.Black;
            this.characterHeightLabel.Location = new System.Drawing.Point(395, 102);
            this.characterHeightLabel.Name = "characterHeightLabel";
            this.characterHeightLabel.Size = new System.Drawing.Size(63, 24);
            this.characterHeightLabel.TabIndex = 86;
            this.characterHeightLabel.Text = "Altura:";
            this.characterHeightLabel.Click += new System.EventHandler(this.characterHeightLabel_Click);
            // 
            // characterWeightLabel
            // 
            this.characterWeightLabel.AutoSize = true;
            this.characterWeightLabel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.characterWeightLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.characterWeightLabel.ForeColor = System.Drawing.Color.Black;
            this.characterWeightLabel.Location = new System.Drawing.Point(395, 161);
            this.characterWeightLabel.Name = "characterWeightLabel";
            this.characterWeightLabel.Size = new System.Drawing.Size(58, 24);
            this.characterWeightLabel.TabIndex = 85;
            this.characterWeightLabel.Text = "Peso:";
            this.characterWeightLabel.Click += new System.EventHandler(this.characterWeightLabel_Click);
            // 
            // characterManaLabel
            // 
            this.characterManaLabel.AutoSize = true;
            this.characterManaLabel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.characterManaLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.characterManaLabel.ForeColor = System.Drawing.Color.Black;
            this.characterManaLabel.Location = new System.Drawing.Point(248, 161);
            this.characterManaLabel.Name = "characterManaLabel";
            this.characterManaLabel.Size = new System.Drawing.Size(62, 24);
            this.characterManaLabel.TabIndex = 84;
            this.characterManaLabel.Text = "Mana:";
            this.characterManaLabel.Click += new System.EventHandler(this.characterManaLabel_Click);
            // 
            // characterLifeLabel
            // 
            this.characterLifeLabel.AutoSize = true;
            this.characterLifeLabel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.characterLifeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.characterLifeLabel.ForeColor = System.Drawing.Color.Black;
            this.characterLifeLabel.Location = new System.Drawing.Point(248, 102);
            this.characterLifeLabel.Name = "characterLifeLabel";
            this.characterLifeLabel.Size = new System.Drawing.Size(53, 24);
            this.characterLifeLabel.TabIndex = 83;
            this.characterLifeLabel.Text = "Vida:";
            this.characterLifeLabel.Click += new System.EventHandler(this.characterLifeLabel_Click);
            // 
            // characterNameLabel
            // 
            this.characterNameLabel.AutoSize = true;
            this.characterNameLabel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.characterNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.characterNameLabel.ForeColor = System.Drawing.Color.Black;
            this.characterNameLabel.Location = new System.Drawing.Point(14, 16);
            this.characterNameLabel.Name = "characterNameLabel";
            this.characterNameLabel.Size = new System.Drawing.Size(67, 24);
            this.characterNameLabel.TabIndex = 82;
            this.characterNameLabel.Text = "Nome:";
            this.characterNameLabel.Click += new System.EventHandler(this.characterNameLabel_Click);
            // 
            // characterImagePictureBox
            // 
            this.characterImagePictureBox.InitialImage = global::Erripeg.ObjectModel.Properties.Resources.pngtree_vector_edit_profile_icon_png_image_758006;
            this.characterImagePictureBox.Location = new System.Drawing.Point(18, 85);
            this.characterImagePictureBox.Name = "characterImagePictureBox";
            this.characterImagePictureBox.Size = new System.Drawing.Size(210, 333);
            this.characterImagePictureBox.TabIndex = 81;
            this.characterImagePictureBox.TabStop = false;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.Black;
            this.button2.Location = new System.Drawing.Point(297, 355);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(171, 37);
            this.button2.TabIndex = 120;
            this.button2.Text = "Atualizar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // teste
            // 
            this.teste.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.teste.ForeColor = System.Drawing.Color.Black;
            this.teste.Location = new System.Drawing.Point(297, 308);
            this.teste.Name = "teste";
            this.teste.Size = new System.Drawing.Size(171, 37);
            this.teste.TabIndex = 121;
            this.teste.Text = "Pesquisar";
            this.teste.UseVisualStyleBackColor = true;
            this.teste.Click += new System.EventHandler(this.Button1_Click);
            // 
            // CriaçãoPersonagem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Erripeg.ObjectModel.Properties.Resources.vector_textured_grunge_background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(832, 450);
            this.Controls.Add(this.teste);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.characterCreateButton);
            this.Controls.Add(this.characterSearchLabel);
            this.Controls.Add(this.characterSearchTextBox);
            this.Controls.Add(this.characterBackgroundLabel);
            this.Controls.Add(this.characterXpTextBox);
            this.Controls.Add(this.characterLvlTextBox);
            this.Controls.Add(this.characterLvlLabel);
            this.Controls.Add(this.characterNameTextBox);
            this.Controls.Add(this.characterHeightTextBox);
            this.Controls.Add(this.characterWeightTextBox);
            this.Controls.Add(this.characterInfoLabel);
            this.Controls.Add(this.characterManaTextBox);
            this.Controls.Add(this.characterLifeTextBox);
            this.Controls.Add(this.characterBackgroundRichTextBox);
            this.Controls.Add(this.characterXpLabel);
            this.Controls.Add(this.characterHeightLabel);
            this.Controls.Add(this.characterWeightLabel);
            this.Controls.Add(this.characterManaLabel);
            this.Controls.Add(this.characterLifeLabel);
            this.Controls.Add(this.characterNameLabel);
            this.Controls.Add(this.characterImagePictureBox);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.Name = "CriaçãoPersonagem";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CriaçãoPersonagem";
            ((System.ComponentModel.ISupportInitialize)(this.characterImagePictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button characterCreateButton;
        private System.Windows.Forms.Label characterSearchLabel;
        private System.Windows.Forms.TextBox characterSearchTextBox;
        private System.Windows.Forms.Label characterBackgroundLabel;
        private System.Windows.Forms.TextBox characterXpTextBox;
        private System.Windows.Forms.TextBox characterLvlTextBox;
        private System.Windows.Forms.Label characterLvlLabel;
        private System.Windows.Forms.TextBox characterNameTextBox;
        private System.Windows.Forms.TextBox characterHeightTextBox;
        private System.Windows.Forms.TextBox characterWeightTextBox;
        private System.Windows.Forms.Label characterInfoLabel;
        private System.Windows.Forms.TextBox characterManaTextBox;
        private System.Windows.Forms.TextBox characterLifeTextBox;
        private System.Windows.Forms.RichTextBox characterBackgroundRichTextBox;
        private System.Windows.Forms.Label characterXpLabel;
        private System.Windows.Forms.Label characterHeightLabel;
        private System.Windows.Forms.Label characterWeightLabel;
        private System.Windows.Forms.Label characterManaLabel;
        private System.Windows.Forms.Label characterLifeLabel;
        private System.Windows.Forms.Label characterNameLabel;
        private System.Windows.Forms.PictureBox characterImagePictureBox;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button teste;
    }
}