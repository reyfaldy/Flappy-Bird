namespace FlappyBird
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            cloud = new PictureBox();
            flappy = new PictureBox();
            ground = new PictureBox();
            pipe_down = new PictureBox();
            pipe_up = new PictureBox();
            lb_score = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            lb_highscore = new Label();
            BtnRestart = new Button();
            ((System.ComponentModel.ISupportInitialize)cloud).BeginInit();
            ((System.ComponentModel.ISupportInitialize)flappy).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ground).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pipe_down).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pipe_up).BeginInit();
            SuspendLayout();
            // 
            // cloud
            // 
            cloud.Image = (Image)resources.GetObject("cloud.Image");
            cloud.Location = new Point(-2, 0);
            cloud.Margin = new Padding(3, 4, 3, 4);
            cloud.Name = "cloud";
            cloud.Size = new Size(727, 715);
            cloud.SizeMode = PictureBoxSizeMode.StretchImage;
            cloud.TabIndex = 0;
            cloud.TabStop = false;
            // 
            // flappy
            // 
            flappy.Image = (Image)resources.GetObject("flappy.Image");
            flappy.Location = new Point(80, 256);
            flappy.Margin = new Padding(3, 4, 3, 4);
            flappy.Name = "flappy";
            flappy.Size = new Size(80, 93);
            flappy.SizeMode = PictureBoxSizeMode.StretchImage;
            flappy.TabIndex = 1;
            flappy.TabStop = false;
            // 
            // ground
            // 
            ground.Image = (Image)resources.GetObject("ground.Image");
            ground.Location = new Point(-2, 708);
            ground.Margin = new Padding(3, 4, 3, 4);
            ground.Name = "ground";
            ground.Size = new Size(727, 241);
            ground.SizeMode = PictureBoxSizeMode.StretchImage;
            ground.TabIndex = 2;
            ground.TabStop = false;
            // 
            // pipe_down
            // 
            pipe_down.Image = (Image)resources.GetObject("pipe_down.Image");
            pipe_down.Location = new Point(413, 495);
            pipe_down.Margin = new Padding(3, 4, 3, 4);
            pipe_down.Name = "pipe_down";
            pipe_down.Size = new Size(114, 220);
            pipe_down.SizeMode = PictureBoxSizeMode.StretchImage;
            pipe_down.TabIndex = 3;
            pipe_down.TabStop = false;
            // 
            // pipe_up
            // 
            pipe_up.Image = (Image)resources.GetObject("pipe_up.Image");
            pipe_up.Location = new Point(413, 0);
            pipe_up.Margin = new Padding(3, 4, 3, 4);
            pipe_up.Name = "pipe_up";
            pipe_up.Size = new Size(114, 220);
            pipe_up.SizeMode = PictureBoxSizeMode.StretchImage;
            pipe_up.TabIndex = 4;
            pipe_up.TabStop = false;
            // 
            // lb_score
            // 
            lb_score.AutoSize = true;
            lb_score.BackColor = Color.Transparent;
            lb_score.Font = new Font("Stencil", 24F, FontStyle.Bold, GraphicsUnit.Point);
            lb_score.Location = new Point(12, 75);
            lb_score.Name = "lb_score";
            lb_score.Size = new Size(195, 47);
            lb_score.TabIndex = 5;
            lb_score.Text = "SCORE: 0";
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Tick += Timer1_Tick;
            // 
            // lb_highscore
            // 
            lb_highscore.AutoSize = true;
            lb_highscore.BackColor = Color.Transparent;
            lb_highscore.Font = new Font("Stencil", 24F, FontStyle.Bold, GraphicsUnit.Point);
            lb_highscore.Location = new Point(12, 18);
            lb_highscore.Name = "lb_highscore";
            lb_highscore.Size = new Size(311, 47);
            lb_highscore.TabIndex = 6;
            lb_highscore.Text = "HIGH SCORE: 0";
            // 
            // BtnRestart
            // 
            BtnRestart.BackColor = Color.Transparent;
            BtnRestart.FlatAppearance.BorderSize = 0;
            BtnRestart.Font = new Font("Stencil", 24F, FontStyle.Bold, GraphicsUnit.Point);
            BtnRestart.Location = new Point(260, 307);
            BtnRestart.Name = "BtnRestart";
            BtnRestart.Size = new Size(217, 63);
            BtnRestart.TabIndex = 7;
            BtnRestart.Text = "RESTART";
            BtnRestart.UseVisualStyleBackColor = false;
            BtnRestart.Visible = false;
            BtnRestart.Click += BtnRestart_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(725, 948);
            Controls.Add(BtnRestart);
            Controls.Add(lb_highscore);
            Controls.Add(lb_score);
            Controls.Add(pipe_up);
            Controls.Add(pipe_down);
            Controls.Add(ground);
            Controls.Add(flappy);
            Controls.Add(cloud);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            KeyDown += Form1_KeyDown;
            KeyUp += Form1_KeyUp;
            ((System.ComponentModel.ISupportInitialize)cloud).EndInit();
            ((System.ComponentModel.ISupportInitialize)flappy).EndInit();
            ((System.ComponentModel.ISupportInitialize)ground).EndInit();
            ((System.ComponentModel.ISupportInitialize)pipe_down).EndInit();
            ((System.ComponentModel.ISupportInitialize)pipe_up).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox cloud;
        private PictureBox flappy;
        private PictureBox ground;
        private PictureBox pipe_down;
        private PictureBox pipe_up;
        private Label lb_score;
        private System.Windows.Forms.Timer timer1;
        private Label lb_highscore;
        private Button BtnRestart;
    }
}