namespace WisGalery.UserControls
{
    partial class UC_Home
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

        #region Código gerado pelo Designer de Componentes

        /// <summary> 
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_Home));
            this.label1 = new System.Windows.Forms.Label();
            this.textoMensagem = new System.Windows.Forms.RichTextBox();
            this.btnEnviarMensagem = new Guna.UI2.WinForms.Guna2CircleButton();
            this.txbFriend1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.txbFriend2 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.friendAvatar2 = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.friendAvatar = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.MyAvatar = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.picBox = new Guna.UI2.WinForms.Guna2PictureBox();
            this.rb0 = new Guna.UI2.WinForms.Guna2RadioButton();
            this.rb1 = new Guna.UI2.WinForms.Guna2RadioButton();
            this.rb2 = new Guna.UI2.WinForms.Guna2RadioButton();
            this.rb3 = new Guna.UI2.WinForms.Guna2RadioButton();
            this.rb4 = new Guna.UI2.WinForms.Guna2RadioButton();
            this.rb5 = new Guna.UI2.WinForms.Guna2RadioButton();
            this.rb6 = new Guna.UI2.WinForms.Guna2RadioButton();
            this.rb7 = new Guna.UI2.WinForms.Guna2RadioButton();
            this.myAvatarMessage = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.txbMy = new System.Windows.Forms.TextBox();
            this.imagensHome = new System.Windows.Forms.ImageList(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.friendAvatar2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.friendAvatar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MyAvatar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.myAvatarMessage)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(318, 40);
            this.label1.TabIndex = 1;
            this.label1.Text = "Bem Vindo Ao Wis";
            // 
            // textoMensagem
            // 
            this.textoMensagem.Location = new System.Drawing.Point(492, 356);
            this.textoMensagem.Name = "textoMensagem";
            this.textoMensagem.Size = new System.Drawing.Size(229, 24);
            this.textoMensagem.TabIndex = 2;
            this.textoMensagem.Text = "";
            this.textoMensagem.TextChanged += new System.EventHandler(this.textoMensagem_TextChanged);
            // 
            // btnEnviarMensagem
            // 
            this.btnEnviarMensagem.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnEnviarMensagem.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnEnviarMensagem.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnEnviarMensagem.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnEnviarMensagem.FillColor = System.Drawing.Color.WhiteSmoke;
            this.btnEnviarMensagem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnEnviarMensagem.ForeColor = System.Drawing.Color.Black;
            this.btnEnviarMensagem.Location = new System.Drawing.Point(727, 347);
            this.btnEnviarMensagem.Name = "btnEnviarMensagem";
            this.btnEnviarMensagem.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.btnEnviarMensagem.Size = new System.Drawing.Size(60, 42);
            this.btnEnviarMensagem.TabIndex = 3;
            this.btnEnviarMensagem.Text = "Send";
            this.btnEnviarMensagem.Click += new System.EventHandler(this.btnEnviarMensagem_Click);
            // 
            // txbFriend1
            // 
            this.txbFriend1.BackColor = System.Drawing.Color.Transparent;
            this.txbFriend1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txbFriend1.Location = new System.Drawing.Point(541, 314);
            this.txbFriend1.Name = "txbFriend1";
            this.txbFriend1.Size = new System.Drawing.Size(22, 15);
            this.txbFriend1.TabIndex = 4;
            this.txbFriend1.Text = "Hey";
            // 
            // txbFriend2
            // 
            this.txbFriend2.BackColor = System.Drawing.Color.Transparent;
            this.txbFriend2.Location = new System.Drawing.Point(541, 259);
            this.txbFriend2.Name = "txbFriend2";
            this.txbFriend2.Size = new System.Drawing.Size(27, 15);
            this.txbFriend2.TabIndex = 7;
            this.txbFriend2.Text = "Hello";
            // 
            // friendAvatar2
            // 
            this.friendAvatar2.Image = global::WisGalery.Properties.Resources.relief__1_;
            this.friendAvatar2.ImageRotate = 0F;
            this.friendAvatar2.Location = new System.Drawing.Point(491, 239);
            this.friendAvatar2.Name = "friendAvatar2";
            this.friendAvatar2.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.friendAvatar2.Size = new System.Drawing.Size(44, 42);
            this.friendAvatar2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.friendAvatar2.TabIndex = 8;
            this.friendAvatar2.TabStop = false;
            // 
            // friendAvatar
            // 
            this.friendAvatar.Image = global::WisGalery.Properties.Resources.relief;
            this.friendAvatar.ImageRotate = 0F;
            this.friendAvatar.Location = new System.Drawing.Point(492, 295);
            this.friendAvatar.Name = "friendAvatar";
            this.friendAvatar.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.friendAvatar.Size = new System.Drawing.Size(44, 42);
            this.friendAvatar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.friendAvatar.TabIndex = 6;
            this.friendAvatar.TabStop = false;
            // 
            // MyAvatar
            // 
            this.MyAvatar.Image = global::WisGalery.Properties.Resources.relief__1_;
            this.MyAvatar.ImageRotate = 0F;
            this.MyAvatar.Location = new System.Drawing.Point(442, 347);
            this.MyAvatar.Name = "MyAvatar";
            this.MyAvatar.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.MyAvatar.Size = new System.Drawing.Size(44, 42);
            this.MyAvatar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.MyAvatar.TabIndex = 5;
            this.MyAvatar.TabStop = false;
            // 
            // guna2PictureBox1
            // 
            this.guna2PictureBox1.Image = global::WisGalery.Properties.Resources.meditation;
            this.guna2PictureBox1.ImageRotate = 0F;
            this.guna2PictureBox1.Location = new System.Drawing.Point(36, 202);
            this.guna2PictureBox1.Name = "guna2PictureBox1";
            this.guna2PictureBox1.Size = new System.Drawing.Size(255, 200);
            this.guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.guna2PictureBox1.TabIndex = 0;
            this.guna2PictureBox1.TabStop = false;
            // 
            // picBox
            // 
            this.picBox.BackColor = System.Drawing.Color.Transparent;
            this.picBox.ImageRotate = 0F;
            this.picBox.Location = new System.Drawing.Point(472, 16);
            this.picBox.Name = "picBox";
            this.picBox.Size = new System.Drawing.Size(286, 161);
            this.picBox.TabIndex = 9;
            this.picBox.TabStop = false;
            // 
            // rb0
            // 
            this.rb0.AutoSize = true;
            this.rb0.BackColor = System.Drawing.Color.Transparent;
            this.rb0.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.rb0.CheckedState.BorderThickness = 0;
            this.rb0.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.rb0.CheckedState.InnerColor = System.Drawing.Color.White;
            this.rb0.CheckedState.InnerOffset = -4;
            this.rb0.Location = new System.Drawing.Point(532, 164);
            this.rb0.Name = "rb0";
            this.rb0.Size = new System.Drawing.Size(14, 13);
            this.rb0.TabIndex = 10;
            this.rb0.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.rb0.UncheckedState.BorderThickness = 2;
            this.rb0.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.rb0.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            this.rb0.UseVisualStyleBackColor = false;
            this.rb0.CheckedChanged += new System.EventHandler(this.rb0_CheckedChanged);
            // 
            // rb1
            // 
            this.rb1.AutoSize = true;
            this.rb1.BackColor = System.Drawing.Color.Transparent;
            this.rb1.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.rb1.CheckedState.BorderThickness = 0;
            this.rb1.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.rb1.CheckedState.InnerColor = System.Drawing.Color.White;
            this.rb1.CheckedState.InnerOffset = -4;
            this.rb1.Location = new System.Drawing.Point(552, 164);
            this.rb1.Name = "rb1";
            this.rb1.Size = new System.Drawing.Size(14, 13);
            this.rb1.TabIndex = 11;
            this.rb1.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.rb1.UncheckedState.BorderThickness = 2;
            this.rb1.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.rb1.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            this.rb1.UseVisualStyleBackColor = false;
            this.rb1.CheckedChanged += new System.EventHandler(this.rb1_CheckedChanged);
            // 
            // rb2
            // 
            this.rb2.AutoSize = true;
            this.rb2.BackColor = System.Drawing.Color.Transparent;
            this.rb2.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.rb2.CheckedState.BorderThickness = 0;
            this.rb2.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.rb2.CheckedState.InnerColor = System.Drawing.Color.White;
            this.rb2.CheckedState.InnerOffset = -4;
            this.rb2.Location = new System.Drawing.Point(572, 164);
            this.rb2.Name = "rb2";
            this.rb2.Size = new System.Drawing.Size(14, 13);
            this.rb2.TabIndex = 12;
            this.rb2.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.rb2.UncheckedState.BorderThickness = 2;
            this.rb2.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.rb2.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            this.rb2.UseVisualStyleBackColor = false;
            this.rb2.CheckedChanged += new System.EventHandler(this.rb2_CheckedChanged);
            // 
            // rb3
            // 
            this.rb3.AutoSize = true;
            this.rb3.BackColor = System.Drawing.Color.Transparent;
            this.rb3.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.rb3.CheckedState.BorderThickness = 0;
            this.rb3.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.rb3.CheckedState.InnerColor = System.Drawing.Color.White;
            this.rb3.CheckedState.InnerOffset = -4;
            this.rb3.Location = new System.Drawing.Point(592, 164);
            this.rb3.Name = "rb3";
            this.rb3.Size = new System.Drawing.Size(14, 13);
            this.rb3.TabIndex = 13;
            this.rb3.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.rb3.UncheckedState.BorderThickness = 2;
            this.rb3.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.rb3.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            this.rb3.UseVisualStyleBackColor = false;
            this.rb3.CheckedChanged += new System.EventHandler(this.rb3_CheckedChanged);
            // 
            // rb4
            // 
            this.rb4.AutoSize = true;
            this.rb4.BackColor = System.Drawing.Color.Transparent;
            this.rb4.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.rb4.CheckedState.BorderThickness = 0;
            this.rb4.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.rb4.CheckedState.InnerColor = System.Drawing.Color.White;
            this.rb4.CheckedState.InnerOffset = -4;
            this.rb4.Location = new System.Drawing.Point(612, 164);
            this.rb4.Name = "rb4";
            this.rb4.Size = new System.Drawing.Size(14, 13);
            this.rb4.TabIndex = 14;
            this.rb4.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.rb4.UncheckedState.BorderThickness = 2;
            this.rb4.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.rb4.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            this.rb4.UseVisualStyleBackColor = false;
            this.rb4.CheckedChanged += new System.EventHandler(this.rb4_CheckedChanged);
            // 
            // rb5
            // 
            this.rb5.AutoSize = true;
            this.rb5.BackColor = System.Drawing.Color.Transparent;
            this.rb5.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.rb5.CheckedState.BorderThickness = 0;
            this.rb5.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.rb5.CheckedState.InnerColor = System.Drawing.Color.White;
            this.rb5.CheckedState.InnerOffset = -4;
            this.rb5.Location = new System.Drawing.Point(632, 164);
            this.rb5.Name = "rb5";
            this.rb5.Size = new System.Drawing.Size(14, 13);
            this.rb5.TabIndex = 15;
            this.rb5.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.rb5.UncheckedState.BorderThickness = 2;
            this.rb5.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.rb5.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            this.rb5.UseVisualStyleBackColor = false;
            this.rb5.CheckedChanged += new System.EventHandler(this.rb5_CheckedChanged);
            // 
            // rb6
            // 
            this.rb6.AutoSize = true;
            this.rb6.BackColor = System.Drawing.Color.Transparent;
            this.rb6.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.rb6.CheckedState.BorderThickness = 0;
            this.rb6.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.rb6.CheckedState.InnerColor = System.Drawing.Color.White;
            this.rb6.CheckedState.InnerOffset = -4;
            this.rb6.Location = new System.Drawing.Point(652, 164);
            this.rb6.Name = "rb6";
            this.rb6.Size = new System.Drawing.Size(14, 13);
            this.rb6.TabIndex = 16;
            this.rb6.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.rb6.UncheckedState.BorderThickness = 2;
            this.rb6.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.rb6.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            this.rb6.UseVisualStyleBackColor = false;
            this.rb6.CheckedChanged += new System.EventHandler(this.rb6_CheckedChanged);
            // 
            // rb7
            // 
            this.rb7.AutoSize = true;
            this.rb7.BackColor = System.Drawing.Color.Transparent;
            this.rb7.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.rb7.CheckedState.BorderThickness = 0;
            this.rb7.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.rb7.CheckedState.InnerColor = System.Drawing.Color.White;
            this.rb7.CheckedState.InnerOffset = -4;
            this.rb7.Location = new System.Drawing.Point(672, 164);
            this.rb7.Name = "rb7";
            this.rb7.Size = new System.Drawing.Size(14, 13);
            this.rb7.TabIndex = 17;
            this.rb7.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.rb7.UncheckedState.BorderThickness = 2;
            this.rb7.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.rb7.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            this.rb7.UseVisualStyleBackColor = false;
            this.rb7.CheckedChanged += new System.EventHandler(this.rb7_CheckedChanged);
            // 
            // myAvatarMessage
            // 
            this.myAvatarMessage.Image = global::WisGalery.Properties.Resources.relief__1_;
            this.myAvatarMessage.ImageRotate = 0F;
            this.myAvatarMessage.Location = new System.Drawing.Point(677, 308);
            this.myAvatarMessage.Name = "myAvatarMessage";
            this.myAvatarMessage.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.myAvatarMessage.Size = new System.Drawing.Size(44, 42);
            this.myAvatarMessage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.myAvatarMessage.TabIndex = 19;
            this.myAvatarMessage.TabStop = false;
            this.myAvatarMessage.Visible = false;
            // 
            // txbMy
            // 
            this.txbMy.BackColor = System.Drawing.Color.CornflowerBlue;
            this.txbMy.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txbMy.Location = new System.Drawing.Point(569, 308);
            this.txbMy.Multiline = true;
            this.txbMy.Name = "txbMy";
            this.txbMy.Size = new System.Drawing.Size(114, 39);
            this.txbMy.TabIndex = 20;
            // 
            // imagensHome
            // 
            this.imagensHome.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imagensHome.ImageStream")));
            this.imagensHome.TransparentColor = System.Drawing.Color.Transparent;
            this.imagensHome.Images.SetKeyName(0, "amavel.jpg");
            this.imagensHome.Images.SetKeyName(1, "backgroundHappy.gif");
            this.imagensHome.Images.SetKeyName(2, "backgroundSite.gif");
            this.imagensHome.Images.SetKeyName(3, "gifTristeNoJardim.gif");
            this.imagensHome.Images.SetKeyName(4, "Loving.jpg");
            this.imagensHome.Images.SetKeyName(5, "nuvensCeu.gif");
            this.imagensHome.Images.SetKeyName(6, "ruaJapan1.gif");
            this.imagensHome.Images.SetKeyName(7, "ruaJapan2.gif");
            // 
            // UC_Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CornflowerBlue;
            this.Controls.Add(this.txbMy);
            this.Controls.Add(this.myAvatarMessage);
            this.Controls.Add(this.rb7);
            this.Controls.Add(this.rb6);
            this.Controls.Add(this.rb5);
            this.Controls.Add(this.rb4);
            this.Controls.Add(this.rb3);
            this.Controls.Add(this.rb2);
            this.Controls.Add(this.rb1);
            this.Controls.Add(this.rb0);
            this.Controls.Add(this.picBox);
            this.Controls.Add(this.friendAvatar2);
            this.Controls.Add(this.txbFriend2);
            this.Controls.Add(this.friendAvatar);
            this.Controls.Add(this.MyAvatar);
            this.Controls.Add(this.txbFriend1);
            this.Controls.Add(this.btnEnviarMensagem);
            this.Controls.Add(this.textoMensagem);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.guna2PictureBox1);
            this.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "UC_Home";
            this.Size = new System.Drawing.Size(800, 405);
            ((System.ComponentModel.ISupportInitialize)(this.friendAvatar2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.friendAvatar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MyAvatar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.myAvatarMessage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox textoMensagem;
        private Guna.UI2.WinForms.Guna2CircleButton btnEnviarMensagem;
        private Guna.UI2.WinForms.Guna2HtmlLabel txbFriend1;
        private Guna.UI2.WinForms.Guna2CirclePictureBox MyAvatar;
        private Guna.UI2.WinForms.Guna2CirclePictureBox friendAvatar;
        private Guna.UI2.WinForms.Guna2CirclePictureBox friendAvatar2;
        private Guna.UI2.WinForms.Guna2HtmlLabel txbFriend2;
        private Guna.UI2.WinForms.Guna2PictureBox picBox;
        private Guna.UI2.WinForms.Guna2RadioButton rb0;
        private Guna.UI2.WinForms.Guna2RadioButton rb1;
        private Guna.UI2.WinForms.Guna2RadioButton rb2;
        private Guna.UI2.WinForms.Guna2RadioButton rb3;
        private Guna.UI2.WinForms.Guna2RadioButton rb4;
        private Guna.UI2.WinForms.Guna2RadioButton rb5;
        private Guna.UI2.WinForms.Guna2RadioButton rb6;
        private Guna.UI2.WinForms.Guna2RadioButton rb7;
        private Guna.UI2.WinForms.Guna2CirclePictureBox myAvatarMessage;
        private System.Windows.Forms.TextBox txbMy;
        private System.Windows.Forms.ImageList imagensHome;
    }
}
