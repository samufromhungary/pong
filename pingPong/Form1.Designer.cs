namespace pingPong
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.playground = new System.Windows.Forms.Panel();
            this.level = new System.Windows.Forms.Label();
            this.lvl = new System.Windows.Forms.Label();
            this.hp = new System.Windows.Forms.PictureBox();
            this.menu = new System.Windows.Forms.Label();
            this.scorepoints = new System.Windows.Forms.Label();
            this.score = new System.Windows.Forms.Label();
            this.ball = new System.Windows.Forms.PictureBox();
            this.racket = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.playground.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.hp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ball)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.racket)).BeginInit();
            this.SuspendLayout();
            // 
            // playground
            // 
            this.playground.BackColor = System.Drawing.SystemColors.Control;
            this.playground.Controls.Add(this.level);
            this.playground.Controls.Add(this.lvl);
            this.playground.Controls.Add(this.hp);
            this.playground.Controls.Add(this.menu);
            this.playground.Controls.Add(this.scorepoints);
            this.playground.Controls.Add(this.score);
            this.playground.Controls.Add(this.ball);
            this.playground.Controls.Add(this.racket);
            this.playground.Dock = System.Windows.Forms.DockStyle.Fill;
            this.playground.Location = new System.Drawing.Point(0, 0);
            this.playground.Name = "playground";
            this.playground.Size = new System.Drawing.Size(800, 450);
            this.playground.TabIndex = 0;
            // 
            // level
            // 
            this.level.AutoSize = true;
            this.level.BackColor = System.Drawing.Color.Transparent;
            this.level.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.level.Location = new System.Drawing.Point(76, 34);
            this.level.Name = "level";
            this.level.Size = new System.Drawing.Size(22, 25);
            this.level.TabIndex = 7;
            this.level.Text = "1";
            // 
            // lvl
            // 
            this.lvl.AutoSize = true;
            this.lvl.BackColor = System.Drawing.Color.Transparent;
            this.lvl.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lvl.Location = new System.Drawing.Point(3, 34);
            this.lvl.Name = "lvl";
            this.lvl.Size = new System.Drawing.Size(59, 25);
            this.lvl.TabIndex = 6;
            this.lvl.Text = "Level:";
            // 
            // hp
            // 
            this.hp.BackColor = System.Drawing.Color.OrangeRed;
            this.hp.Location = new System.Drawing.Point(758, 12);
            this.hp.Name = "hp";
            this.hp.Size = new System.Drawing.Size(30, 30);
            this.hp.TabIndex = 5;
            this.hp.TabStop = false;
            // 
            // menu
            // 
            this.menu.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.menu.AutoSize = true;
            this.menu.BackColor = System.Drawing.Color.Transparent;
            this.menu.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.menu.Location = new System.Drawing.Point(309, 142);
            this.menu.Name = "menu";
            this.menu.Size = new System.Drawing.Size(199, 100);
            this.menu.TabIndex = 4;
            this.menu.Text = "F1 - Start a new match\r\nF2 - Cheat mode\r\nF3 - OVERKILL MODE\r\nEsc - Exit";
            this.menu.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.menu.Visible = false;
            // 
            // scorepoints
            // 
            this.scorepoints.AutoSize = true;
            this.scorepoints.BackColor = System.Drawing.Color.Transparent;
            this.scorepoints.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.scorepoints.Location = new System.Drawing.Point(76, 9);
            this.scorepoints.Name = "scorepoints";
            this.scorepoints.Size = new System.Drawing.Size(22, 25);
            this.scorepoints.TabIndex = 3;
            this.scorepoints.Text = "0";
            // 
            // score
            // 
            this.score.AutoSize = true;
            this.score.BackColor = System.Drawing.Color.Transparent;
            this.score.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.score.Location = new System.Drawing.Point(3, 9);
            this.score.Name = "score";
            this.score.Size = new System.Drawing.Size(67, 25);
            this.score.TabIndex = 2;
            this.score.Text = "Points:";
            // 
            // ball
            // 
            this.ball.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ball.BackgroundImage")));
            this.ball.Location = new System.Drawing.Point(393, 192);
            this.ball.Name = "ball";
            this.ball.Size = new System.Drawing.Size(16, 16);
            this.ball.TabIndex = 1;
            this.ball.TabStop = false;
            // 
            // racket
            // 
            this.racket.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("racket.BackgroundImage")));
            this.racket.Location = new System.Drawing.Point(327, 423);
            this.racket.Name = "racket";
            this.racket.Size = new System.Drawing.Size(150, 15);
            this.racket.TabIndex = 0;
            this.racket.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Interval = 1;
            this.timer1.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.playground);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Ping Pong";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.playground.ResumeLayout(false);
            this.playground.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.hp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ball)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.racket)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel playground;
        private System.Windows.Forms.PictureBox ball;
        private System.Windows.Forms.PictureBox racket;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label scorepoints;
        private System.Windows.Forms.Label score;
        private System.Windows.Forms.Label menu;
        private System.Windows.Forms.PictureBox hp;
        private System.Windows.Forms.Label level;
        private System.Windows.Forms.Label lvl;
    }
}

