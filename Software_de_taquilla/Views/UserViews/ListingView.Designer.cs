namespace Software_de_taquilla.Views.UserViews
{
    partial class ListingView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ListingView));
            btnNotificacion = new Button();
            label2 = new Label();
            label1 = new Label();
            flow_container = new FlowLayoutPanel();
            combo_city = new ComboBox();
            combo_cine = new ComboBox();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // btnNotificacion
            // 
            btnNotificacion.FlatAppearance.BorderSize = 0;
            btnNotificacion.FlatStyle = FlatStyle.Flat;
            btnNotificacion.Image = (Image)resources.GetObject("btnNotificacion.Image");
            btnNotificacion.Location = new Point(737, 37);
            btnNotificacion.Name = "btnNotificacion";
            btnNotificacion.Size = new Size(38, 39);
            btnNotificacion.TabIndex = 25;
            btnNotificacion.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Bookman Old Style", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.FromArgb(12, 64, 76);
            label2.Location = new Point(32, 53);
            label2.Name = "label2";
            label2.Size = new Size(127, 28);
            label2.TabIndex = 17;
            label2.Text = "Cartelera";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(188, 188, 188);
            label1.Location = new Point(32, 27);
            label1.Name = "label1";
            label1.Size = new Size(79, 16);
            label1.TabIndex = 16;
            label1.Text = "Bienvenido";
            // 
            // flow_container
            // 
            flow_container.AutoScroll = true;
            flow_container.Location = new Point(32, 102);
            flow_container.Name = "flow_container";
            flow_container.Size = new Size(743, 319);
            flow_container.TabIndex = 26;
            // 
            // combo_city
            // 
            combo_city.DropDownStyle = ComboBoxStyle.DropDownList;
            combo_city.FormattingEnabled = true;
            combo_city.Location = new Point(407, 46);
            combo_city.Name = "combo_city";
            combo_city.Size = new Size(121, 23);
            combo_city.TabIndex = 27;
            // 
            // combo_cine
            // 
            combo_cine.DropDownStyle = ComboBoxStyle.DropDownList;
            combo_cine.FormattingEnabled = true;
            combo_cine.Location = new Point(582, 47);
            combo_cine.Name = "combo_cine";
            combo_cine.Size = new Size(121, 23);
            combo_cine.TabIndex = 28;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.FromArgb(188, 188, 188);
            label3.Location = new Point(407, 27);
            label3.Name = "label3";
            label3.Size = new Size(56, 16);
            label3.TabIndex = 29;
            label3.Text = "Ciudad";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.FromArgb(188, 188, 188);
            label4.Location = new Point(582, 27);
            label4.Name = "label4";
            label4.Size = new Size(37, 16);
            label4.TabIndex = 30;
            label4.Text = "Cine";
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.FromArgb(108, 84, 253);
            label5.Location = new Point(719, 444);
            label5.Name = "label5";
            label5.Size = new Size(31, 15);
            label5.TabIndex = 32;
            label5.Text = "Salir";
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            pictureBox1.Cursor = Cursors.Hand;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(756, 443);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(19, 16);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 31;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // ListingView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(806, 478);
            Controls.Add(label5);
            Controls.Add(pictureBox1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(combo_cine);
            Controls.Add(combo_city);
            Controls.Add(flow_container);
            Controls.Add(btnNotificacion);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "ListingView";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Listing";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btnNotificacion;
        private Label label2;
        private Label label1;
        public FlowLayoutPanel flow_container;
        public ComboBox combo_city;
        public ComboBox combo_cine;
        private Label label3;
        private Label label4;
        private Label label5;
        private PictureBox pictureBox1;
    }
}