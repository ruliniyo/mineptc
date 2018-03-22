namespace MinePTC
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtbdireccion = new System.Windows.Forms.TextBox();
            this.btnback = new System.Windows.Forms.Button();
            this.btnrefresh = new System.Windows.Forms.Button();
            this.btnsend = new System.Windows.Forms.Button();
            this.webKitBrowser1 = new WebKit.WebKitBrowser();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtbdireccion);
            this.panel1.Controls.Add(this.btnback);
            this.panel1.Controls.Add(this.btnrefresh);
            this.panel1.Controls.Add(this.btnsend);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(973, 97);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // txtbdireccion
            // 
            this.txtbdireccion.Location = new System.Drawing.Point(142, 40);
            this.txtbdireccion.Name = "txtbdireccion";
            this.txtbdireccion.Size = new System.Drawing.Size(312, 20);
            this.txtbdireccion.TabIndex = 3;
            // 
            // btnback
            // 
            this.btnback.Location = new System.Drawing.Point(3, 4);
            this.btnback.Name = "btnback";
            this.btnback.Size = new System.Drawing.Size(122, 90);
            this.btnback.TabIndex = 2;
            this.btnback.Text = "Atras";
            this.btnback.UseVisualStyleBackColor = true;
            this.btnback.Click += new System.EventHandler(this.btnback_Click);
            // 
            // btnrefresh
            // 
            this.btnrefresh.Location = new System.Drawing.Point(581, 25);
            this.btnrefresh.Name = "btnrefresh";
            this.btnrefresh.Size = new System.Drawing.Size(75, 49);
            this.btnrefresh.TabIndex = 1;
            this.btnrefresh.Text = "Actualizar";
            this.btnrefresh.UseVisualStyleBackColor = true;
            this.btnrefresh.Click += new System.EventHandler(this.btnrefresh_Click);
            // 
            // btnsend
            // 
            this.btnsend.Location = new System.Drawing.Point(504, 24);
            this.btnsend.Name = "btnsend";
            this.btnsend.Size = new System.Drawing.Size(71, 50);
            this.btnsend.TabIndex = 0;
            this.btnsend.Text = "Ir";
            this.btnsend.UseVisualStyleBackColor = true;
            this.btnsend.Click += new System.EventHandler(this.btnsend_Click);
            // 
            // webKitBrowser1
            // 
            this.webKitBrowser1.BackColor = System.Drawing.Color.White;
            this.webKitBrowser1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webKitBrowser1.Location = new System.Drawing.Point(0, 97);
            this.webKitBrowser1.Name = "webKitBrowser1";
            this.webKitBrowser1.Size = new System.Drawing.Size(973, 423);
            this.webKitBrowser1.TabIndex = 1;
            this.webKitBrowser1.Url = null;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(973, 520);
            this.Controls.Add(this.webKitBrowser1);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "MinePTC";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnrefresh;
        private System.Windows.Forms.Button btnsend;
        private System.Windows.Forms.TextBox txtbdireccion;
        private System.Windows.Forms.Button btnback;
        private WebKit.WebKitBrowser webKitBrowser1;
    }
}

