namespace CapaPresentación
{
    partial class frmEspecificaciones
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEspecificaciones));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtIdEsp = new System.Windows.Forms.TextBox();
            this.txtMetros2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtAmb = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtBaños = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dgvEsp = new System.Windows.Forms.DataGridView();
            this.btnEliminarE = new System.Windows.Forms.Button();
            this.btnModificarE = new System.Windows.Forms.Button();
            this.btnAgregarE = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEsp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Roboto", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(212, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(182, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "ESPECIFICACIONES";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(461, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "idEsp";
            // 
            // txtIdEsp
            // 
            this.txtIdEsp.Location = new System.Drawing.Point(520, 63);
            this.txtIdEsp.Name = "txtIdEsp";
            this.txtIdEsp.Size = new System.Drawing.Size(100, 23);
            this.txtIdEsp.TabIndex = 2;
            // 
            // txtMetros2
            // 
            this.txtMetros2.Location = new System.Drawing.Point(520, 109);
            this.txtMetros2.Name = "txtMetros2";
            this.txtMetros2.Size = new System.Drawing.Size(100, 23);
            this.txtMetros2.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(441, 114);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 18);
            this.label3.TabIndex = 3;
            this.label3.Text = "Metros2";
            // 
            // txtAmb
            // 
            this.txtAmb.Location = new System.Drawing.Point(520, 162);
            this.txtAmb.Name = "txtAmb";
            this.txtAmb.Size = new System.Drawing.Size(100, 23);
            this.txtAmb.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(436, 163);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 18);
            this.label4.TabIndex = 5;
            this.label4.Text = "Cant. Amb";
            // 
            // txtBaños
            // 
            this.txtBaños.Location = new System.Drawing.Point(520, 202);
            this.txtBaños.Name = "txtBaños";
            this.txtBaños.Size = new System.Drawing.Size(100, 23);
            this.txtBaños.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(425, 207);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 18);
            this.label5.TabIndex = 7;
            this.label5.Text = "Cant. Baños";
            // 
            // dgvEsp
            // 
            this.dgvEsp.AllowUserToAddRows = false;
            this.dgvEsp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEsp.Location = new System.Drawing.Point(12, 64);
            this.dgvEsp.Name = "dgvEsp";
            this.dgvEsp.RowTemplate.Height = 25;
            this.dgvEsp.Size = new System.Drawing.Size(407, 224);
            this.dgvEsp.TabIndex = 9;
            this.dgvEsp.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvEsp_CellClick);
            // 
            // btnEliminarE
            // 
            this.btnEliminarE.BackColor = System.Drawing.SystemColors.Info;
            this.btnEliminarE.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnEliminarE.Location = new System.Drawing.Point(12, 309);
            this.btnEliminarE.Name = "btnEliminarE";
            this.btnEliminarE.Size = new System.Drawing.Size(126, 36);
            this.btnEliminarE.TabIndex = 10;
            this.btnEliminarE.Text = "Eliminar";
            this.btnEliminarE.UseVisualStyleBackColor = false;
            this.btnEliminarE.Click += new System.EventHandler(this.btnEliminarE_Click);
            // 
            // btnModificarE
            // 
            this.btnModificarE.BackColor = System.Drawing.SystemColors.Info;
            this.btnModificarE.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnModificarE.Location = new System.Drawing.Point(188, 309);
            this.btnModificarE.Name = "btnModificarE";
            this.btnModificarE.Size = new System.Drawing.Size(126, 36);
            this.btnModificarE.TabIndex = 11;
            this.btnModificarE.Text = "Modificar";
            this.btnModificarE.UseVisualStyleBackColor = false;
            this.btnModificarE.Click += new System.EventHandler(this.btnModificarE_Click);
            // 
            // btnAgregarE
            // 
            this.btnAgregarE.BackColor = System.Drawing.SystemColors.Info;
            this.btnAgregarE.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnAgregarE.Location = new System.Drawing.Point(346, 309);
            this.btnAgregarE.Name = "btnAgregarE";
            this.btnAgregarE.Size = new System.Drawing.Size(126, 36);
            this.btnAgregarE.TabIndex = 12;
            this.btnAgregarE.Text = "Agregar";
            this.btnAgregarE.UseVisualStyleBackColor = false;
            this.btnAgregarE.Click += new System.EventHandler(this.btnAgregarE_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.Info;
            this.button3.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button3.Location = new System.Drawing.Point(557, 246);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(63, 22);
            this.button3.TabIndex = 13;
            this.button3.Text = "Limpiar";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 8);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(139, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            // 
            // frmEspecificaciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(643, 357);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.btnAgregarE);
            this.Controls.Add(this.btnModificarE);
            this.Controls.Add(this.btnEliminarE);
            this.Controls.Add(this.dgvEsp);
            this.Controls.Add(this.txtBaños);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtAmb);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtMetros2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtIdEsp);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmEspecificaciones";
            this.Text = "Especificaciones";
            this.Load += new System.EventHandler(this.frmEspecificaciones_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEsp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtIdEsp;
        private TextBox txtMetros2;
        private Label label3;
        private TextBox txtAmb;
        private Label label4;
        private TextBox txtBaños;
        private Label label5;
        private DataGridView dgvEsp;
        private Button btnEliminarE;
        private Button btnModificarE;
        private Button btnAgregarE;
        private Button button3;
        private PictureBox pictureBox1;
    }
}