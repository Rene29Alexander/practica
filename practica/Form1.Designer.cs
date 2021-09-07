
namespace practica
{
    partial class dgData
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
            this.button1 = new System.Windows.Forms.Button();
            this.dgData2 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgData2)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(3, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "GetStudent";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dgData2
            // 
            this.dgData2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgData2.Location = new System.Drawing.Point(12, 52);
            this.dgData2.Name = "dgData2";
            this.dgData2.Size = new System.Drawing.Size(658, 422);
            this.dgData2.TabIndex = 1;
            // 
            // dgData
            // 
            this.ClientSize = new System.Drawing.Size(682, 486);
            this.Controls.Add(this.dgData2);
            this.Controls.Add(this.button1);
            this.Name = "dgData";
            this.Load += new System.EventHandler(this.dgData_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgData2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button GetStudent;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dgData2;
    }
}

