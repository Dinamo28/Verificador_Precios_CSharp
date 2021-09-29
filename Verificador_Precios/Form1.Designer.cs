
namespace Verificador_Precios
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
            this.Logo = new System.Windows.Forms.PictureBox();
            this.Aviso = new System.Windows.Forms.Label();
            this.Lector = new System.Windows.Forms.PictureBox();
            this.Datos = new System.Windows.Forms.Label();
            this.ImagenP = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.Cargar = new System.Windows.Forms.PictureBox();
            this.Demo = new System.Windows.Forms.PictureBox();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.ErrorImg = new System.Windows.Forms.PictureBox();
            this.AvisoError = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Lector)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ImagenP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Cargar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Demo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorImg)).BeginInit();
            this.SuspendLayout();
            // 
            // fileSystemWatcher1
            // 
            this.fileSystemWatcher1.EnableRaisingEvents = true;
            this.fileSystemWatcher1.SynchronizingObject = this;
            // 
            // Logo
            // 
            this.Logo.BackColor = System.Drawing.Color.Transparent;
            this.Logo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Logo.BackgroundImage")));
            this.Logo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Logo.Location = new System.Drawing.Point(39, 31);
            this.Logo.Name = "Logo";
            this.Logo.Size = new System.Drawing.Size(474, 285);
            this.Logo.TabIndex = 0;
            this.Logo.TabStop = false;
            // 
            // Aviso
            // 
            this.Aviso.AutoSize = true;
            this.Aviso.BackColor = System.Drawing.Color.Transparent;
            this.Aviso.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Aviso.Location = new System.Drawing.Point(157, 205);
            this.Aviso.Name = "Aviso";
            this.Aviso.Size = new System.Drawing.Size(332, 33);
            this.Aviso.TabIndex = 1;
            this.Aviso.Text = "Esperando por articulo...";
            this.Aviso.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Lector
            // 
            this.Lector.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Lector.BackgroundImage")));
            this.Lector.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Lector.Image = ((System.Drawing.Image)(resources.GetObject("Lector.Image")));
            this.Lector.Location = new System.Drawing.Point(331, 278);
            this.Lector.Name = "Lector";
            this.Lector.Size = new System.Drawing.Size(214, 139);
            this.Lector.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Lector.TabIndex = 2;
            this.Lector.TabStop = false;
            // 
            // Datos
            // 
            this.Datos.AutoSize = true;
            this.Datos.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Datos.Location = new System.Drawing.Point(186, 283);
            this.Datos.Name = "Datos";
            this.Datos.Size = new System.Drawing.Size(99, 33);
            this.Datos.TabIndex = 3;
            this.Datos.Text = "label2";
            this.Datos.Visible = false;
            this.Datos.Click += new System.EventHandler(this.Datos_Click);
            // 
            // ImagenP
            // 
            this.ImagenP.BackColor = System.Drawing.Color.Transparent;
            this.ImagenP.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ImagenP.Location = new System.Drawing.Point(636, 294);
            this.ImagenP.Margin = new System.Windows.Forms.Padding(2);
            this.ImagenP.Name = "ImagenP";
            this.ImagenP.Size = new System.Drawing.Size(400, 400);
            this.ImagenP.TabIndex = 4;
            this.ImagenP.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Cargar
            // 
            this.Cargar.BackColor = System.Drawing.Color.Transparent;
            this.Cargar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Cargar.InitialImage = null;
            this.Cargar.Location = new System.Drawing.Point(291, 94);
            this.Cargar.Name = "Cargar";
            this.Cargar.Size = new System.Drawing.Size(200, 200);
            this.Cargar.TabIndex = 5;
            this.Cargar.TabStop = false;
            this.Cargar.Click += new System.EventHandler(this.Cargar_Click);
            // 
            // Demo
            // 
            this.Demo.BackColor = System.Drawing.Color.Transparent;
            this.Demo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Demo.InitialImage = null;
            this.Demo.Location = new System.Drawing.Point(535, 31);
            this.Demo.Name = "Demo";
            this.Demo.Size = new System.Drawing.Size(400, 300);
            this.Demo.TabIndex = 6;
            this.Demo.TabStop = false;
            // 
            // timer2
            // 
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // ErrorImg
            // 
            this.ErrorImg.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ErrorImg.BackgroundImage")));
            this.ErrorImg.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ErrorImg.Location = new System.Drawing.Point(39, 342);
            this.ErrorImg.Name = "ErrorImg";
            this.ErrorImg.Size = new System.Drawing.Size(400, 400);
            this.ErrorImg.TabIndex = 7;
            this.ErrorImg.TabStop = false;
            // 
            // AvisoError
            // 
            this.AvisoError.AutoSize = true;
            this.AvisoError.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold);
            this.AvisoError.Location = new System.Drawing.Point(68, 330);
            this.AvisoError.Name = "AvisoError";
            this.AvisoError.Size = new System.Drawing.Size(99, 33);
            this.AvisoError.TabIndex = 8;
            this.AvisoError.Text = "label1";
            this.AvisoError.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.AvisoError);
            this.Controls.Add(this.ErrorImg);
            this.Controls.Add(this.Demo);
            this.Controls.Add(this.Cargar);
            this.Controls.Add(this.ImagenP);
            this.Controls.Add(this.Datos);
            this.Controls.Add(this.Lector);
            this.Controls.Add(this.Aviso);
            this.Controls.Add(this.Logo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Form1_KeyPress);
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Lector)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ImagenP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Cargar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Demo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorImg)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.IO.FileSystemWatcher fileSystemWatcher1;
        private System.Windows.Forms.PictureBox Logo;
        private System.Windows.Forms.Label Aviso;
        private System.Windows.Forms.PictureBox Lector;
        private System.Windows.Forms.Label Datos;
        private System.Windows.Forms.PictureBox ImagenP;
		private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox Demo;
        private System.Windows.Forms.PictureBox Cargar;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.PictureBox ErrorImg;
        private System.Windows.Forms.Label AvisoError;
    }
}

