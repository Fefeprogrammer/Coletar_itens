namespace Coletar_itens
{
    partial class Coleta
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
            this.components = new System.ComponentModel.Container();
            this.lb_score = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.game_over = new System.Windows.Forms.PictureBox();
            this.pictureBox11 = new System.Windows.Forms.PictureBox();
            this.pictureBox10 = new System.Windows.Forms.PictureBox();
            this.pictureBox9 = new System.Windows.Forms.PictureBox();
            this.pictureBox8 = new System.Windows.Forms.PictureBox();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Player = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btn_reload = new System.Windows.Forms.Button();
            this.lb_level = new System.Windows.Forms.Label();
            this.lb_tempo = new System.Windows.Forms.Label();
            this.timer3 = new System.Windows.Forms.Timer(this.components);
            this.timer4 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.game_over)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Player)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // lb_score
            // 
            this.lb_score.AutoSize = true;
            this.lb_score.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_score.Location = new System.Drawing.Point(12, 9);
            this.lb_score.Name = "lb_score";
            this.lb_score.Size = new System.Drawing.Size(107, 31);
            this.lb_score.TabIndex = 12;
            this.lb_score.Text = "Score: ";
            // 
            // timer1
            // 
            this.timer1.Interval = 10000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer2
            // 
            this.timer2.Interval = 10000;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // game_over
            // 
            this.game_over.Image = global::Coletar_itens.Properties.Resources.game_over;
            this.game_over.Location = new System.Drawing.Point(165, 112);
            this.game_over.Name = "game_over";
            this.game_over.Size = new System.Drawing.Size(513, 205);
            this.game_over.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.game_over.TabIndex = 13;
            this.game_over.TabStop = false;
            this.game_over.Visible = false;
            // 
            // pictureBox11
            // 
            this.pictureBox11.Image = global::Coletar_itens.Properties.Resources.maca;
            this.pictureBox11.Location = new System.Drawing.Point(664, 375);
            this.pictureBox11.Name = "pictureBox11";
            this.pictureBox11.Size = new System.Drawing.Size(100, 50);
            this.pictureBox11.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox11.TabIndex = 11;
            this.pictureBox11.TabStop = false;
            this.pictureBox11.Tag = "maca";
            // 
            // pictureBox10
            // 
            this.pictureBox10.Image = global::Coletar_itens.Properties.Resources.maca;
            this.pictureBox10.Location = new System.Drawing.Point(654, 205);
            this.pictureBox10.Name = "pictureBox10";
            this.pictureBox10.Size = new System.Drawing.Size(100, 50);
            this.pictureBox10.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox10.TabIndex = 10;
            this.pictureBox10.TabStop = false;
            this.pictureBox10.Tag = "maca";
            // 
            // pictureBox9
            // 
            this.pictureBox9.Image = global::Coletar_itens.Properties.Resources.maca;
            this.pictureBox9.Location = new System.Drawing.Point(446, 375);
            this.pictureBox9.Name = "pictureBox9";
            this.pictureBox9.Size = new System.Drawing.Size(100, 50);
            this.pictureBox9.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox9.TabIndex = 9;
            this.pictureBox9.TabStop = false;
            this.pictureBox9.Tag = "maca";
            // 
            // pictureBox8
            // 
            this.pictureBox8.Image = global::Coletar_itens.Properties.Resources.maca;
            this.pictureBox8.Location = new System.Drawing.Point(529, 285);
            this.pictureBox8.Name = "pictureBox8";
            this.pictureBox8.Size = new System.Drawing.Size(100, 50);
            this.pictureBox8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox8.TabIndex = 8;
            this.pictureBox8.TabStop = false;
            this.pictureBox8.Tag = "maca";
            // 
            // pictureBox7
            // 
            this.pictureBox7.Image = global::Coletar_itens.Properties.Resources.maca;
            this.pictureBox7.Location = new System.Drawing.Point(68, 343);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(100, 50);
            this.pictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox7.TabIndex = 7;
            this.pictureBox7.TabStop = false;
            this.pictureBox7.Tag = "maca";
            // 
            // pictureBox6
            // 
            this.pictureBox6.Image = global::Coletar_itens.Properties.Resources.maca;
            this.pictureBox6.Location = new System.Drawing.Point(254, 375);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(100, 50);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox6.TabIndex = 6;
            this.pictureBox6.TabStop = false;
            this.pictureBox6.Tag = "maca";
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = global::Coletar_itens.Properties.Resources.maca;
            this.pictureBox5.Location = new System.Drawing.Point(405, 205);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(100, 50);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox5.TabIndex = 5;
            this.pictureBox5.TabStop = false;
            this.pictureBox5.Tag = "maca";
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::Coletar_itens.Properties.Resources.maca;
            this.pictureBox4.Location = new System.Drawing.Point(86, 138);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(100, 50);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 4;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.Tag = "maca";
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::Coletar_itens.Properties.Resources.maca;
            this.pictureBox3.Location = new System.Drawing.Point(472, 70);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(100, 50);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 3;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Tag = "maca";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Coletar_itens.Properties.Resources.maca;
            this.pictureBox1.Location = new System.Drawing.Point(320, 285);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Tag = "maca";
            // 
            // Player
            // 
            this.Player.Image = global::Coletar_itens.Properties.Resources.rigth;
            this.Player.Location = new System.Drawing.Point(282, 70);
            this.Player.Name = "Player";
            this.Player.Size = new System.Drawing.Size(93, 80);
            this.Player.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Player.TabIndex = 0;
            this.Player.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Coletar_itens.Properties.Resources.maca;
            this.pictureBox2.Location = new System.Drawing.Point(654, 70);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(100, 50);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Tag = "maca";
            // 
            // btn_reload
            // 
            this.btn_reload.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_reload.Location = new System.Drawing.Point(293, 323);
            this.btn_reload.Name = "btn_reload";
            this.btn_reload.Size = new System.Drawing.Size(230, 46);
            this.btn_reload.TabIndex = 14;
            this.btn_reload.Text = "Jogar novamente";
            this.btn_reload.UseVisualStyleBackColor = true;
            this.btn_reload.Visible = false;
            this.btn_reload.Click += new System.EventHandler(this.btn_reload_Click);
            // 
            // lb_level
            // 
            this.lb_level.AutoSize = true;
            this.lb_level.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_level.Location = new System.Drawing.Point(616, 15);
            this.lb_level.Name = "lb_level";
            this.lb_level.Size = new System.Drawing.Size(83, 25);
            this.lb_level.TabIndex = 15;
            this.lb_level.Text = "Level: ";
            // 
            // lb_tempo
            // 
            this.lb_tempo.AutoSize = true;
            this.lb_tempo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_tempo.Location = new System.Drawing.Point(305, 15);
            this.lb_tempo.Name = "lb_tempo";
            this.lb_tempo.Size = new System.Drawing.Size(97, 25);
            this.lb_tempo.TabIndex = 16;
            this.lb_tempo.Text = "Tempo: ";
            // 
            // timer3
            // 
            this.timer3.Interval = 1000;
            this.timer3.Tick += new System.EventHandler(this.timer3_Tick);
            // 
            // timer4
            // 
            this.timer4.Interval = 500;
            this.timer4.Tick += new System.EventHandler(this.timer4_Tick);
            // 
            // Coleta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(808, 460);
            this.Controls.Add(this.lb_tempo);
            this.Controls.Add(this.lb_level);
            this.Controls.Add(this.btn_reload);
            this.Controls.Add(this.game_over);
            this.Controls.Add(this.lb_score);
            this.Controls.Add(this.pictureBox11);
            this.Controls.Add(this.pictureBox10);
            this.Controls.Add(this.pictureBox9);
            this.Controls.Add(this.pictureBox8);
            this.Controls.Add(this.pictureBox7);
            this.Controls.Add(this.pictureBox6);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Player);
            this.Controls.Add(this.pictureBox2);
            this.Name = "Coleta";
            this.Text = "Coletar Items";
            this.Load += new System.EventHandler(this.score_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.game_over)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Player)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox Player;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.PictureBox pictureBox8;
        private System.Windows.Forms.PictureBox pictureBox9;
        private System.Windows.Forms.PictureBox pictureBox10;
        private System.Windows.Forms.PictureBox pictureBox11;
        private System.Windows.Forms.Label lb_score;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.PictureBox game_over;
        private System.Windows.Forms.Button btn_reload;
        private System.Windows.Forms.Label lb_level;
        private System.Windows.Forms.Label lb_tempo;
        private System.Windows.Forms.Timer timer3;
        private System.Windows.Forms.Timer timer4;
    }
}

