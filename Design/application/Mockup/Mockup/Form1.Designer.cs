namespace Mockup
{
    partial class frmPhones
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPhones));
            this.grpBoxSearch = new System.Windows.Forms.GroupBox();
            this.lblNamePhone = new System.Windows.Forms.Label();
            this.txtBoxSearchPhoneName = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.lblSort = new System.Windows.Forms.Label();
            this.radBtnPriceEvolution = new System.Windows.Forms.RadioButton();
            this.radBtnOS = new System.Windows.Forms.RadioButton();
            this.radBtnScreenSize = new System.Windows.Forms.RadioButton();
            this.radBtnBuilder = new System.Windows.Forms.RadioButton();
            this.lblTop = new System.Windows.Forms.Label();
            this.radBtnBestAutonomy = new System.Windows.Forms.RadioButton();
            this.radBtnMoreExpensive = new System.Windows.Forms.RadioButton();
            this.radBtnBestCpu = new System.Windows.Forms.RadioButton();
            this.radBtnBestPhones = new System.Windows.Forms.RadioButton();
            this.radBtnCheapest = new System.Windows.Forms.RadioButton();
            this.btnApplySearch = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.pnlPhones = new System.Windows.Forms.Panel();
            this.grpBoxSearch.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpBoxSearch
            // 
            this.grpBoxSearch.Controls.Add(this.btnApplySearch);
            this.grpBoxSearch.Controls.Add(this.radBtnCheapest);
            this.grpBoxSearch.Controls.Add(this.radBtnBestPhones);
            this.grpBoxSearch.Controls.Add(this.radBtnBestCpu);
            this.grpBoxSearch.Controls.Add(this.radBtnMoreExpensive);
            this.grpBoxSearch.Controls.Add(this.radBtnBestAutonomy);
            this.grpBoxSearch.Controls.Add(this.lblTop);
            this.grpBoxSearch.Controls.Add(this.radBtnBuilder);
            this.grpBoxSearch.Controls.Add(this.radBtnScreenSize);
            this.grpBoxSearch.Controls.Add(this.radBtnOS);
            this.grpBoxSearch.Controls.Add(this.radBtnPriceEvolution);
            this.grpBoxSearch.Controls.Add(this.lblSort);
            this.grpBoxSearch.Controls.Add(this.btnSearch);
            this.grpBoxSearch.Controls.Add(this.txtBoxSearchPhoneName);
            this.grpBoxSearch.Controls.Add(this.lblNamePhone);
            this.grpBoxSearch.Font = new System.Drawing.Font("Lucida Bright", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpBoxSearch.Location = new System.Drawing.Point(12, 12);
            this.grpBoxSearch.Name = "grpBoxSearch";
            this.grpBoxSearch.Size = new System.Drawing.Size(315, 537);
            this.grpBoxSearch.TabIndex = 0;
            this.grpBoxSearch.TabStop = false;
            this.grpBoxSearch.Text = "Recherches";
            // 
            // lblNamePhone
            // 
            this.lblNamePhone.AutoSize = true;
            this.lblNamePhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNamePhone.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblNamePhone.Location = new System.Drawing.Point(6, 31);
            this.lblNamePhone.Name = "lblNamePhone";
            this.lblNamePhone.Size = new System.Drawing.Size(212, 29);
            this.lblNamePhone.TabIndex = 0;
            this.lblNamePhone.Text = "Nom du téléphone";
            // 
            // txtBoxSearchPhoneName
            // 
            this.txtBoxSearchPhoneName.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxSearchPhoneName.Location = new System.Drawing.Point(10, 72);
            this.txtBoxSearchPhoneName.Name = "txtBoxSearchPhoneName";
            this.txtBoxSearchPhoneName.Size = new System.Drawing.Size(194, 32);
            this.txtBoxSearchPhoneName.TabIndex = 2;
            // 
            // btnSearch
            // 
            this.btnSearch.Font = new System.Drawing.Font("Lucida Bright", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.Location = new System.Drawing.Point(210, 72);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(90, 32);
            this.btnSearch.TabIndex = 3;
            this.btnSearch.Text = "Chercher";
            this.btnSearch.UseVisualStyleBackColor = true;
            // 
            // lblSort
            // 
            this.lblSort.AutoSize = true;
            this.lblSort.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSort.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblSort.Location = new System.Drawing.Point(17, 118);
            this.lblSort.Name = "lblSort";
            this.lblSort.Size = new System.Drawing.Size(118, 29);
            this.lblSort.TabIndex = 4;
            this.lblSort.Text = "Trier par :";
            // 
            // radBtnPriceEvolution
            // 
            this.radBtnPriceEvolution.AutoSize = true;
            this.radBtnPriceEvolution.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radBtnPriceEvolution.Location = new System.Drawing.Point(42, 150);
            this.radBtnPriceEvolution.Name = "radBtnPriceEvolution";
            this.radBtnPriceEvolution.Size = new System.Drawing.Size(131, 24);
            this.radBtnPriceEvolution.TabIndex = 5;
            this.radBtnPriceEvolution.TabStop = true;
            this.radBtnPriceEvolution.Text = "Prix d\'évolution";
            this.radBtnPriceEvolution.UseVisualStyleBackColor = true;
            // 
            // radBtnOS
            // 
            this.radBtnOS.AutoSize = true;
            this.radBtnOS.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radBtnOS.Location = new System.Drawing.Point(42, 180);
            this.radBtnOS.Name = "radBtnOS";
            this.radBtnOS.Size = new System.Drawing.Size(167, 24);
            this.radBtnOS.TabIndex = 6;
            this.radBtnOS.TabStop = true;
            this.radBtnOS.Text = "OS (Android et iOS)";
            this.radBtnOS.UseVisualStyleBackColor = true;
            // 
            // radBtnScreenSize
            // 
            this.radBtnScreenSize.AutoSize = true;
            this.radBtnScreenSize.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radBtnScreenSize.Location = new System.Drawing.Point(42, 210);
            this.radBtnScreenSize.Name = "radBtnScreenSize";
            this.radBtnScreenSize.Size = new System.Drawing.Size(222, 24);
            this.radBtnScreenSize.TabIndex = 7;
            this.radBtnScreenSize.TabStop = true;
            this.radBtnScreenSize.Text = "Taille d\'écran (grand à petit)";
            this.radBtnScreenSize.UseVisualStyleBackColor = true;
            // 
            // radBtnBuilder
            // 
            this.radBtnBuilder.AutoSize = true;
            this.radBtnBuilder.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radBtnBuilder.Location = new System.Drawing.Point(42, 240);
            this.radBtnBuilder.Name = "radBtnBuilder";
            this.radBtnBuilder.Size = new System.Drawing.Size(119, 24);
            this.radBtnBuilder.TabIndex = 8;
            this.radBtnBuilder.TabStop = true;
            this.radBtnBuilder.Text = "Constructeur";
            this.radBtnBuilder.UseVisualStyleBackColor = true;
            // 
            // lblTop
            // 
            this.lblTop.AutoSize = true;
            this.lblTop.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTop.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblTop.Location = new System.Drawing.Point(17, 276);
            this.lblTop.Name = "lblTop";
            this.lblTop.Size = new System.Drawing.Size(57, 29);
            this.lblTop.TabIndex = 9;
            this.lblTop.Text = "Top";
            // 
            // radBtnBestAutonomy
            // 
            this.radBtnBestAutonomy.AutoSize = true;
            this.radBtnBestAutonomy.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radBtnBestAutonomy.Location = new System.Drawing.Point(42, 308);
            this.radBtnBestAutonomy.Name = "radBtnBestAutonomy";
            this.radBtnBestAutonomy.Size = new System.Drawing.Size(150, 24);
            this.radBtnBestAutonomy.TabIndex = 10;
            this.radBtnBestAutonomy.TabStop = true;
            this.radBtnBestAutonomy.Text = "5 best autonomie";
            this.radBtnBestAutonomy.UseVisualStyleBackColor = true;
            // 
            // radBtnMoreExpensive
            // 
            this.radBtnMoreExpensive.AutoSize = true;
            this.radBtnMoreExpensive.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radBtnMoreExpensive.Location = new System.Drawing.Point(42, 338);
            this.radBtnMoreExpensive.Name = "radBtnMoreExpensive";
            this.radBtnMoreExpensive.Size = new System.Drawing.Size(112, 24);
            this.radBtnMoreExpensive.TabIndex = 11;
            this.radBtnMoreExpensive.TabStop = true;
            this.radBtnMoreExpensive.Text = "3 plus chers";
            this.radBtnMoreExpensive.UseVisualStyleBackColor = true;
            // 
            // radBtnBestCpu
            // 
            this.radBtnBestCpu.AutoSize = true;
            this.radBtnBestCpu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radBtnBestCpu.Location = new System.Drawing.Point(42, 368);
            this.radBtnBestCpu.Name = "radBtnBestCpu";
            this.radBtnBestCpu.Size = new System.Drawing.Size(117, 24);
            this.radBtnBestCpu.TabIndex = 12;
            this.radBtnBestCpu.TabStop = true;
            this.radBtnBestCpu.Text = "10 best CPU";
            this.radBtnBestCpu.UseVisualStyleBackColor = true;
            // 
            // radBtnBestPhones
            // 
            this.radBtnBestPhones.AutoSize = true;
            this.radBtnBestPhones.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radBtnBestPhones.Location = new System.Drawing.Point(42, 398);
            this.radBtnBestPhones.Name = "radBtnBestPhones";
            this.radBtnBestPhones.Size = new System.Drawing.Size(128, 24);
            this.radBtnBestPhones.TabIndex = 13;
            this.radBtnBestPhones.TabStop = true;
            this.radBtnBestPhones.Text = "5 best phones";
            this.radBtnBestPhones.UseVisualStyleBackColor = true;
            // 
            // radBtnCheapest
            // 
            this.radBtnCheapest.AutoSize = true;
            this.radBtnCheapest.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radBtnCheapest.Location = new System.Drawing.Point(42, 428);
            this.radBtnCheapest.Name = "radBtnCheapest";
            this.radBtnCheapest.Size = new System.Drawing.Size(239, 24);
            this.radBtnCheapest.TabIndex = 14;
            this.radBtnCheapest.TabStop = true;
            this.radBtnCheapest.Text = "Le moins cher (OS et marque)";
            this.radBtnCheapest.UseVisualStyleBackColor = true;
            // 
            // btnApplySearch
            // 
            this.btnApplySearch.Font = new System.Drawing.Font("Lucida Bright", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnApplySearch.Location = new System.Drawing.Point(10, 476);
            this.btnApplySearch.Name = "btnApplySearch";
            this.btnApplySearch.Size = new System.Drawing.Size(290, 46);
            this.btnApplySearch.TabIndex = 4;
            this.btnApplySearch.Text = "Appliquer la recherche";
            this.btnApplySearch.UseVisualStyleBackColor = true;
            // 
            // btnBack
            // 
            this.btnBack.Font = new System.Drawing.Font("Lucida Bright", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Location = new System.Drawing.Point(358, 506);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(90, 43);
            this.btnBack.TabIndex = 4;
            this.btnBack.Text = "Arrière";
            this.btnBack.UseVisualStyleBackColor = true;
            // 
            // btnNext
            // 
            this.btnNext.Font = new System.Drawing.Font("Lucida Bright", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNext.Location = new System.Drawing.Point(1069, 506);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(90, 43);
            this.btnNext.TabIndex = 5;
            this.btnNext.Text = "Suivante";
            this.btnNext.UseVisualStyleBackColor = true;
            // 
            // pnlPhones
            // 
            this.pnlPhones.Location = new System.Drawing.Point(358, 16);
            this.pnlPhones.Name = "pnlPhones";
            this.pnlPhones.Size = new System.Drawing.Size(801, 484);
            this.pnlPhones.TabIndex = 6;
            // 
            // frmPhones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 561);
            this.Controls.Add(this.pnlPhones);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.grpBoxSearch);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmPhones";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Liste des téléphones";
            this.grpBoxSearch.ResumeLayout(false);
            this.grpBoxSearch.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpBoxSearch;
        private System.Windows.Forms.TextBox txtBoxSearchPhoneName;
        private System.Windows.Forms.Label lblNamePhone;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnApplySearch;
        private System.Windows.Forms.RadioButton radBtnCheapest;
        private System.Windows.Forms.RadioButton radBtnBestPhones;
        private System.Windows.Forms.RadioButton radBtnBestCpu;
        private System.Windows.Forms.RadioButton radBtnMoreExpensive;
        private System.Windows.Forms.RadioButton radBtnBestAutonomy;
        private System.Windows.Forms.Label lblTop;
        private System.Windows.Forms.RadioButton radBtnBuilder;
        private System.Windows.Forms.RadioButton radBtnScreenSize;
        private System.Windows.Forms.RadioButton radBtnOS;
        private System.Windows.Forms.RadioButton radBtnPriceEvolution;
        private System.Windows.Forms.Label lblSort;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Panel pnlPhones;
    }
}

