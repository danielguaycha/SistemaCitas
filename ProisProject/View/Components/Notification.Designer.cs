namespace ProisProject.View.Components
{
    partial class Notification
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

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            BunifuAnimatorNS.Animation animation1 = new BunifuAnimatorNS.Animation();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Notification));
            this.iconNotify = new System.Windows.Forms.PictureBox();
            this.notifyMsg = new System.Windows.Forms.Label();
            this.bunifuImageButton1 = new Bunifu.Framework.UI.BunifuImageButton();
            this.timeoutNotification = new System.Windows.Forms.Timer(this.components);
            this.imgList = new System.Windows.Forms.ImageList(this.components);
            this.animateNotify = new BunifuAnimatorNS.BunifuTransition(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.iconNotify)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).BeginInit();
            this.SuspendLayout();
            // 
            // iconNotify
            // 
            this.animateNotify.SetDecoration(this.iconNotify, BunifuAnimatorNS.DecorationType.None);
            this.iconNotify.Image = ((System.Drawing.Image)(resources.GetObject("iconNotify.Image")));
            this.iconNotify.InitialImage = null;
            this.iconNotify.Location = new System.Drawing.Point(19, 3);
            this.iconNotify.Name = "iconNotify";
            this.iconNotify.Size = new System.Drawing.Size(31, 28);
            this.iconNotify.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.iconNotify.TabIndex = 0;
            this.iconNotify.TabStop = false;
            // 
            // notifyMsg
            // 
            this.animateNotify.SetDecoration(this.notifyMsg, BunifuAnimatorNS.DecorationType.None);
            this.notifyMsg.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.notifyMsg.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.notifyMsg.Location = new System.Drawing.Point(56, 0);
            this.notifyMsg.Name = "notifyMsg";
            this.notifyMsg.Size = new System.Drawing.Size(645, 35);
            this.notifyMsg.TabIndex = 1;
            this.notifyMsg.Text = "Mensaje de la notificacion";
            this.notifyMsg.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // bunifuImageButton1
            // 
            this.bunifuImageButton1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bunifuImageButton1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuImageButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.animateNotify.SetDecoration(this.bunifuImageButton1, BunifuAnimatorNS.DecorationType.None);
            this.bunifuImageButton1.Image = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton1.Image")));
            this.bunifuImageButton1.ImageActive = null;
            this.bunifuImageButton1.Location = new System.Drawing.Point(721, 5);
            this.bunifuImageButton1.Name = "bunifuImageButton1";
            this.bunifuImageButton1.Size = new System.Drawing.Size(14, 26);
            this.bunifuImageButton1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButton1.TabIndex = 2;
            this.bunifuImageButton1.TabStop = false;
            this.bunifuImageButton1.Zoom = 10;
            this.bunifuImageButton1.Click += new System.EventHandler(this.bunifuImageButton1_Click);
            // 
            // timeoutNotification
            // 
            this.timeoutNotification.Enabled = true;
            this.timeoutNotification.Interval = 5000;
            this.timeoutNotification.Tick += new System.EventHandler(this.timeoutNotification_Tick);
            // 
            // imgList
            // 
            this.imgList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imgList.ImageStream")));
            this.imgList.TransparentColor = System.Drawing.Color.Transparent;
            this.imgList.Images.SetKeyName(0, "ok.png");
            this.imgList.Images.SetKeyName(1, "error.png");
            this.imgList.Images.SetKeyName(2, "info.png");
            this.imgList.Images.SetKeyName(3, "warm.png");
            // 
            // animateNotify
            // 
            this.animateNotify.AnimationType = BunifuAnimatorNS.AnimationType.Transparent;
            this.animateNotify.Cursor = null;
            animation1.AnimateOnlyDifferences = true;
            animation1.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.BlindCoeff")));
            animation1.LeafCoeff = 0F;
            animation1.MaxTime = 1F;
            animation1.MinTime = 0F;
            animation1.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicCoeff")));
            animation1.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicShift")));
            animation1.MosaicSize = 0;
            animation1.Padding = new System.Windows.Forms.Padding(0, 0, 0, 0);
            animation1.RotateCoeff = 0F;
            animation1.RotateLimit = 0F;
            animation1.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.ScaleCoeff")));
            animation1.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.SlideCoeff")));
            animation1.TimeCoeff = 0F;
            animation1.TransparencyCoeff = 1F;
            this.animateNotify.DefaultAnimation = animation1;
            // 
            // Notification
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.Controls.Add(this.bunifuImageButton1);
            this.Controls.Add(this.notifyMsg);
            this.Controls.Add(this.iconNotify);
            this.animateNotify.SetDecoration(this, BunifuAnimatorNS.DecorationType.None);
            this.Name = "Notification";
            this.Size = new System.Drawing.Size(748, 35);
            ((System.ComponentModel.ISupportInitialize)(this.iconNotify)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox iconNotify;
        private System.Windows.Forms.Label notifyMsg;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton1;
        private System.Windows.Forms.Timer timeoutNotification;
        private System.Windows.Forms.ImageList imgList;
        private BunifuAnimatorNS.BunifuTransition animateNotify;
    }
}
