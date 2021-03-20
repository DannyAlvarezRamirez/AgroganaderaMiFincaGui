namespace AgroganaderaMiFincaGui
{
    partial class FRMClasificacionAnimales
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
            this.buttonIrAlMenuPrincipal = new System.Windows.Forms.Button();
            this.buttonClasificacion = new System.Windows.Forms.Button();
            this.dataGridViewAnimales = new System.Windows.Forms.DataGridView();
            this.dataGridViewHembras = new System.Windows.Forms.DataGridView();
            this.dataGridViewMachos = new System.Windows.Forms.DataGridView();
            this.labelMachos = new System.Windows.Forms.Label();
            this.labelHembras = new System.Windows.Forms.Label();
            this.labelListaAnimales = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAnimales)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewHembras)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMachos)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonIrAlMenuPrincipal
            // 
            this.buttonIrAlMenuPrincipal.Location = new System.Drawing.Point(1070, 916);
            this.buttonIrAlMenuPrincipal.Name = "buttonIrAlMenuPrincipal";
            this.buttonIrAlMenuPrincipal.Size = new System.Drawing.Size(150, 58);
            this.buttonIrAlMenuPrincipal.TabIndex = 0;
            this.buttonIrAlMenuPrincipal.Text = "Ir al Menu Principal";
            this.buttonIrAlMenuPrincipal.UseVisualStyleBackColor = true;
            this.buttonIrAlMenuPrincipal.Click += new System.EventHandler(this.buttonIrAlMenuPrincipal_Click);
            // 
            // buttonClasificacion
            // 
            this.buttonClasificacion.Location = new System.Drawing.Point(514, 313);
            this.buttonClasificacion.Name = "buttonClasificacion";
            this.buttonClasificacion.Size = new System.Drawing.Size(151, 53);
            this.buttonClasificacion.TabIndex = 1;
            this.buttonClasificacion.Text = "Clasificacion";
            this.buttonClasificacion.UseVisualStyleBackColor = true;
            this.buttonClasificacion.Click += new System.EventHandler(this.buttonClasificacion_Click);
            // 
            // dataGridViewAnimales
            // 
            this.dataGridViewAnimales.AllowDrop = true;
            this.dataGridViewAnimales.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAnimales.Location = new System.Drawing.Point(12, 64);
            this.dataGridViewAnimales.Name = "dataGridViewAnimales";
            this.dataGridViewAnimales.RowHeadersWidth = 62;
            this.dataGridViewAnimales.RowTemplate.Height = 28;
            this.dataGridViewAnimales.Size = new System.Drawing.Size(1123, 233);
            this.dataGridViewAnimales.TabIndex = 2;
            // 
            // dataGridViewHembras
            // 
            this.dataGridViewHembras.AllowDrop = true;
            this.dataGridViewHembras.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewHembras.Location = new System.Drawing.Point(608, 384);
            this.dataGridViewHembras.Name = "dataGridViewHembras";
            this.dataGridViewHembras.RowHeadersWidth = 62;
            this.dataGridViewHembras.RowTemplate.Height = 28;
            this.dataGridViewHembras.Size = new System.Drawing.Size(527, 338);
            this.dataGridViewHembras.TabIndex = 3;
            // 
            // dataGridViewMachos
            // 
            this.dataGridViewMachos.AllowDrop = true;
            this.dataGridViewMachos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewMachos.Location = new System.Drawing.Point(12, 384);
            this.dataGridViewMachos.Name = "dataGridViewMachos";
            this.dataGridViewMachos.RowHeadersWidth = 62;
            this.dataGridViewMachos.RowTemplate.Height = 28;
            this.dataGridViewMachos.Size = new System.Drawing.Size(567, 338);
            this.dataGridViewMachos.TabIndex = 4;
            // 
            // labelMachos
            // 
            this.labelMachos.AutoSize = true;
            this.labelMachos.Location = new System.Drawing.Point(240, 346);
            this.labelMachos.Name = "labelMachos";
            this.labelMachos.Size = new System.Drawing.Size(65, 20);
            this.labelMachos.TabIndex = 5;
            this.labelMachos.Text = "Machos";
            // 
            // labelHembras
            // 
            this.labelHembras.AutoSize = true;
            this.labelHembras.Location = new System.Drawing.Point(839, 346);
            this.labelHembras.Name = "labelHembras";
            this.labelHembras.Size = new System.Drawing.Size(74, 20);
            this.labelHembras.TabIndex = 6;
            this.labelHembras.Text = "Hembras";
            // 
            // labelListaAnimales
            // 
            this.labelListaAnimales.AutoSize = true;
            this.labelListaAnimales.Location = new System.Drawing.Point(510, 9);
            this.labelListaAnimales.Name = "labelListaAnimales";
            this.labelListaAnimales.Size = new System.Drawing.Size(134, 20);
            this.labelListaAnimales.TabIndex = 7;
            this.labelListaAnimales.Text = "Lista de Animales";
            // 
            // FRMClasificacionAnimales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1274, 1046);
            this.Controls.Add(this.labelListaAnimales);
            this.Controls.Add(this.labelHembras);
            this.Controls.Add(this.labelMachos);
            this.Controls.Add(this.dataGridViewMachos);
            this.Controls.Add(this.dataGridViewHembras);
            this.Controls.Add(this.dataGridViewAnimales);
            this.Controls.Add(this.buttonClasificacion);
            this.Controls.Add(this.buttonIrAlMenuPrincipal);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "FRMClasificacionAnimales";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Modulo Clasificacion de Animales";
            this.Load += new System.EventHandler(this.FRMClasificacionAnimales_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAnimales)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewHembras)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMachos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonIrAlMenuPrincipal;
        private System.Windows.Forms.Button buttonClasificacion;
        private System.Windows.Forms.DataGridView dataGridViewAnimales;
        private System.Windows.Forms.DataGridView dataGridViewHembras;
        private System.Windows.Forms.DataGridView dataGridViewMachos;
        private System.Windows.Forms.Label labelMachos;
        private System.Windows.Forms.Label labelHembras;
        private System.Windows.Forms.Label labelListaAnimales;
    }
}