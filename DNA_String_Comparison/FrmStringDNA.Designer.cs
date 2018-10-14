namespace DNA_String_Comparison
{
    partial class FrmStringDNA
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblDNA02 = new System.Windows.Forms.Label();
            this.lblDNA01 = new System.Windows.Forms.Label();
            this.btnDNASelect02 = new System.Windows.Forms.Button();
            this.btnDNASelect01 = new System.Windows.Forms.Button();
            this.rTxtComparisonResult1 = new System.Windows.Forms.RichTextBox();
            this.btnDNAComparison = new System.Windows.Forms.Button();
            this.rTxtComparisonResult2 = new System.Windows.Forms.RichTextBox();
            this.lblResult = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.lblDNA02);
            this.groupBox1.Controls.Add(this.lblDNA01);
            this.groupBox1.Controls.Add(this.btnDNASelect02);
            this.groupBox1.Controls.Add(this.btnDNASelect01);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1042, 98);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // lblDNA02
            // 
            this.lblDNA02.AutoSize = true;
            this.lblDNA02.Location = new System.Drawing.Point(262, 65);
            this.lblDNA02.Name = "lblDNA02";
            this.lblDNA02.Size = new System.Drawing.Size(117, 17);
            this.lblDNA02.TabIndex = 3;
            this.lblDNA02.Text = "Não selecionado!";
            // 
            // lblDNA01
            // 
            this.lblDNA01.AutoSize = true;
            this.lblDNA01.Location = new System.Drawing.Point(262, 29);
            this.lblDNA01.Name = "lblDNA01";
            this.lblDNA01.Size = new System.Drawing.Size(117, 17);
            this.lblDNA01.TabIndex = 2;
            this.lblDNA01.Text = "Não selecionado!";
            // 
            // btnDNASelect02
            // 
            this.btnDNASelect02.Location = new System.Drawing.Point(6, 58);
            this.btnDNASelect02.Name = "btnDNASelect02";
            this.btnDNASelect02.Size = new System.Drawing.Size(250, 30);
            this.btnDNASelect02.TabIndex = 1;
            this.btnDNASelect02.Text = "Selecione a Sequência de DNA 02";
            this.btnDNASelect02.UseVisualStyleBackColor = true;
            this.btnDNASelect02.Click += new System.EventHandler(this.btnDNASelect02_Click);
            // 
            // btnDNASelect01
            // 
            this.btnDNASelect01.Location = new System.Drawing.Point(6, 22);
            this.btnDNASelect01.Name = "btnDNASelect01";
            this.btnDNASelect01.Size = new System.Drawing.Size(250, 30);
            this.btnDNASelect01.TabIndex = 0;
            this.btnDNASelect01.Text = "Selecione a Sequência de DNA 01";
            this.btnDNASelect01.UseVisualStyleBackColor = true;
            this.btnDNASelect01.Click += new System.EventHandler(this.btnDNASelect01_Click);
            // 
            // rTxtComparisonResult1
            // 
            this.rTxtComparisonResult1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rTxtComparisonResult1.Font = new System.Drawing.Font("Courier New", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rTxtComparisonResult1.Location = new System.Drawing.Point(12, 117);
            this.rTxtComparisonResult1.Name = "rTxtComparisonResult1";
            this.rTxtComparisonResult1.ReadOnly = true;
            this.rTxtComparisonResult1.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedHorizontal;
            this.rTxtComparisonResult1.Size = new System.Drawing.Size(1043, 50);
            this.rTxtComparisonResult1.TabIndex = 2;
            this.rTxtComparisonResult1.Text = "";
            this.rTxtComparisonResult1.WordWrap = false;
            this.rTxtComparisonResult1.HScroll += new System.EventHandler(this.rTxtComparisonResult1_HScroll);
            // 
            // btnDNAComparison
            // 
            this.btnDNAComparison.Location = new System.Drawing.Point(825, 322);
            this.btnDNAComparison.Name = "btnDNAComparison";
            this.btnDNAComparison.Size = new System.Drawing.Size(230, 30);
            this.btnDNAComparison.TabIndex = 2;
            this.btnDNAComparison.Text = "Comparar Sequências";
            this.btnDNAComparison.UseVisualStyleBackColor = true;
            this.btnDNAComparison.Click += new System.EventHandler(this.btnDNAComparison_Click);
            // 
            // rTxtComparisonResult2
            // 
            this.rTxtComparisonResult2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rTxtComparisonResult2.Font = new System.Drawing.Font("Courier New", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rTxtComparisonResult2.Location = new System.Drawing.Point(12, 173);
            this.rTxtComparisonResult2.Name = "rTxtComparisonResult2";
            this.rTxtComparisonResult2.ReadOnly = true;
            this.rTxtComparisonResult2.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedHorizontal;
            this.rTxtComparisonResult2.Size = new System.Drawing.Size(1043, 50);
            this.rTxtComparisonResult2.TabIndex = 3;
            this.rTxtComparisonResult2.Text = "";
            this.rTxtComparisonResult2.WordWrap = false;
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Location = new System.Drawing.Point(13, 230);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(0, 17);
            this.lblResult.TabIndex = 4;
            // 
            // FrmStringDNA
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 364);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.rTxtComparisonResult2);
            this.Controls.Add(this.btnDNAComparison);
            this.Controls.Add(this.rTxtComparisonResult1);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmStringDNA";
            this.Text = "DNA String Comparison";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblDNA02;
        private System.Windows.Forms.Label lblDNA01;
        private System.Windows.Forms.Button btnDNASelect02;
        private System.Windows.Forms.Button btnDNASelect01;
        private System.Windows.Forms.RichTextBox rTxtComparisonResult1;
        private System.Windows.Forms.Button btnDNAComparison;
        private System.Windows.Forms.RichTextBox rTxtComparisonResult2;
        private System.Windows.Forms.Label lblResult;
    }
}

