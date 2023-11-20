namespace 课设
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
            new_game = new Button();
            score = new Label();
            rules = new Label();
            Box = new GroupBox();
            box1 = new Label();
            box16 = new Label();
            box15 = new Label();
            box12 = new Label();
            box11 = new Label();
            box14 = new Label();
            box13 = new Label();
            box6 = new Label();
            box7 = new Label();
            box9 = new Label();
            box8 = new Label();
            box10 = new Label();
            box5 = new Label();
            box4 = new Label();
            box3 = new Label();
            box2 = new Label();
            best = new Label();
            warn = new Label();
            _score = new Label();
            _best = new Label();
            title = new Label();
            label1 = new Label();
            label3 = new Label();
            blink = new Button();
            timer1 = new System.Windows.Forms.Timer(components);
            type = new ComboBox();
            Speaker = new PictureBox();
            timer2 = new System.Windows.Forms.Timer(components);
            timer3 = new System.Windows.Forms.Timer(components);
            Box.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)Speaker).BeginInit();
            SuspendLayout();
            // 
            // new_game
            // 
            new_game.BackColor = Color.BurlyWood;
            new_game.Font = new Font("Microsoft YaHei UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            new_game.Location = new Point(10, 339);
            new_game.Name = "new_game";
            new_game.Size = new Size(196, 79);
            new_game.TabIndex = 0;
            new_game.Text = "New Game";
            new_game.UseVisualStyleBackColor = false;
            new_game.Click += new_game_Click;
            // 
            // score
            // 
            score.BackColor = Color.PeachPuff;
            score.Font = new Font("Microsoft YaHei UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            score.Location = new Point(10, 164);
            score.Name = "score";
            score.Size = new Size(135, 50);
            score.TabIndex = 3;
            score.Text = "score:";
            // 
            // rules
            // 
            rules.Location = new Point(0, 0);
            rules.Name = "rules";
            rules.Size = new Size(100, 23);
            rules.TabIndex = 21;
            // 
            // Box
            // 
            Box.BackColor = Color.Peru;
            Box.Controls.Add(box1);
            Box.Controls.Add(box16);
            Box.Controls.Add(box15);
            Box.Controls.Add(box12);
            Box.Controls.Add(box11);
            Box.Controls.Add(box14);
            Box.Controls.Add(box13);
            Box.Controls.Add(box6);
            Box.Controls.Add(box7);
            Box.Controls.Add(box9);
            Box.Controls.Add(box8);
            Box.Controls.Add(box10);
            Box.Controls.Add(box5);
            Box.Controls.Add(box4);
            Box.Controls.Add(box3);
            Box.Controls.Add(box2);
            Box.ImeMode = ImeMode.NoControl;
            Box.Location = new Point(445, 48);
            Box.Name = "Box";
            Box.Size = new Size(750, 750);
            Box.TabIndex = 8;
            Box.TabStop = false;
            // 
            // box1
            // 
            box1.BackColor = Color.Linen;
            box1.Font = new Font("Microsoft YaHei UI", 26F, FontStyle.Regular, GraphicsUnit.Point);
            box1.Location = new Point(30, 30);
            box1.Name = "box1";
            box1.Size = new Size(150, 150);
            box1.TabIndex = 17;
            box1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // box16
            // 
            box16.BackColor = Color.Linen;
            box16.Font = new Font("Microsoft YaHei UI", 26F, FontStyle.Regular, GraphicsUnit.Point);
            box16.Location = new Point(570, 570);
            box16.Name = "box16";
            box16.RightToLeft = RightToLeft.No;
            box16.Size = new Size(150, 150);
            box16.TabIndex = 16;
            box16.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // box15
            // 
            box15.BackColor = Color.Linen;
            box15.Font = new Font("Microsoft YaHei UI", 26F, FontStyle.Regular, GraphicsUnit.Point);
            box15.Location = new Point(390, 570);
            box15.Name = "box15";
            box15.RightToLeft = RightToLeft.No;
            box15.Size = new Size(150, 150);
            box15.TabIndex = 15;
            box15.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // box12
            // 
            box12.BackColor = Color.Linen;
            box12.Font = new Font("Microsoft YaHei UI", 26F, FontStyle.Regular, GraphicsUnit.Point);
            box12.Location = new Point(570, 390);
            box12.Name = "box12";
            box12.RightToLeft = RightToLeft.No;
            box12.Size = new Size(150, 150);
            box12.TabIndex = 14;
            box12.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // box11
            // 
            box11.BackColor = Color.Linen;
            box11.Font = new Font("Microsoft YaHei UI", 26F, FontStyle.Regular, GraphicsUnit.Point);
            box11.Location = new Point(390, 390);
            box11.Name = "box11";
            box11.RightToLeft = RightToLeft.No;
            box11.Size = new Size(150, 150);
            box11.TabIndex = 13;
            box11.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // box14
            // 
            box14.BackColor = Color.Linen;
            box14.Font = new Font("Microsoft YaHei UI", 26F, FontStyle.Regular, GraphicsUnit.Point);
            box14.Location = new Point(210, 570);
            box14.Name = "box14";
            box14.RightToLeft = RightToLeft.No;
            box14.Size = new Size(150, 150);
            box14.TabIndex = 12;
            box14.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // box13
            // 
            box13.BackColor = Color.Linen;
            box13.Font = new Font("Microsoft YaHei UI", 26F, FontStyle.Regular, GraphicsUnit.Point);
            box13.Location = new Point(30, 570);
            box13.Name = "box13";
            box13.RightToLeft = RightToLeft.No;
            box13.Size = new Size(150, 150);
            box13.TabIndex = 11;
            box13.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // box6
            // 
            box6.BackColor = Color.Linen;
            box6.Font = new Font("Microsoft YaHei UI", 26F, FontStyle.Regular, GraphicsUnit.Point);
            box6.Location = new Point(210, 210);
            box6.Name = "box6";
            box6.RightToLeft = RightToLeft.No;
            box6.Size = new Size(150, 150);
            box6.TabIndex = 10;
            box6.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // box7
            // 
            box7.BackColor = Color.Linen;
            box7.Font = new Font("Microsoft YaHei UI", 26F, FontStyle.Regular, GraphicsUnit.Point);
            box7.Location = new Point(390, 210);
            box7.Name = "box7";
            box7.RightToLeft = RightToLeft.No;
            box7.Size = new Size(150, 150);
            box7.TabIndex = 9;
            box7.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // box9
            // 
            box9.BackColor = Color.Linen;
            box9.Font = new Font("Microsoft YaHei UI", 26F, FontStyle.Regular, GraphicsUnit.Point);
            box9.Location = new Point(30, 390);
            box9.Name = "box9";
            box9.RightToLeft = RightToLeft.No;
            box9.Size = new Size(150, 150);
            box9.TabIndex = 8;
            box9.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // box8
            // 
            box8.BackColor = Color.Linen;
            box8.Font = new Font("Microsoft YaHei UI", 26F, FontStyle.Regular, GraphicsUnit.Point);
            box8.Location = new Point(570, 210);
            box8.Name = "box8";
            box8.RightToLeft = RightToLeft.No;
            box8.Size = new Size(150, 150);
            box8.TabIndex = 7;
            box8.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // box10
            // 
            box10.BackColor = Color.Linen;
            box10.Font = new Font("Microsoft YaHei UI", 26F, FontStyle.Regular, GraphicsUnit.Point);
            box10.Location = new Point(210, 390);
            box10.Name = "box10";
            box10.RightToLeft = RightToLeft.No;
            box10.Size = new Size(150, 150);
            box10.TabIndex = 6;
            box10.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // box5
            // 
            box5.BackColor = Color.Linen;
            box5.Font = new Font("Microsoft YaHei UI", 26F, FontStyle.Regular, GraphicsUnit.Point);
            box5.Location = new Point(30, 210);
            box5.Name = "box5";
            box5.RightToLeft = RightToLeft.No;
            box5.Size = new Size(150, 150);
            box5.TabIndex = 5;
            box5.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // box4
            // 
            box4.BackColor = Color.Linen;
            box4.Font = new Font("Microsoft YaHei UI", 26F, FontStyle.Regular, GraphicsUnit.Point);
            box4.Location = new Point(570, 30);
            box4.Name = "box4";
            box4.RightToLeft = RightToLeft.No;
            box4.Size = new Size(150, 150);
            box4.TabIndex = 4;
            box4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // box3
            // 
            box3.BackColor = Color.Linen;
            box3.Font = new Font("Microsoft YaHei UI", 26F, FontStyle.Regular, GraphicsUnit.Point);
            box3.Location = new Point(390, 30);
            box3.Name = "box3";
            box3.RightToLeft = RightToLeft.No;
            box3.Size = new Size(150, 150);
            box3.TabIndex = 3;
            box3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // box2
            // 
            box2.BackColor = Color.Linen;
            box2.Font = new Font("Microsoft YaHei UI", 26F, FontStyle.Regular, GraphicsUnit.Point);
            box2.Location = new Point(210, 30);
            box2.Name = "box2";
            box2.RightToLeft = RightToLeft.No;
            box2.Size = new Size(150, 150);
            box2.TabIndex = 2;
            box2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // best
            // 
            best.BackColor = Color.PeachPuff;
            best.Font = new Font("Microsoft YaHei UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            best.Location = new Point(10, 225);
            best.Name = "best";
            best.Size = new Size(135, 50);
            best.TabIndex = 20;
            best.Text = "Best:";
            best.TextAlign = ContentAlignment.TopRight;
            // 
            // warn
            // 
            warn.BackColor = Color.PeachPuff;
            warn.Font = new Font("Microsoft YaHei UI", 24F, FontStyle.Regular, GraphicsUnit.Point);
            warn.Location = new Point(10, 547);
            warn.Name = "warn";
            warn.Size = new Size(342, 164);
            warn.TabIndex = 17;
            warn.Text = "欢迎";
            warn.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // _score
            // 
            _score.BackColor = Color.PeachPuff;
            _score.Font = new Font("Microsoft YaHei UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            _score.Location = new Point(155, 164);
            _score.Name = "_score";
            _score.Size = new Size(150, 50);
            _score.TabIndex = 18;
            _score.Text = "0";
            // 
            // _best
            // 
            _best.BackColor = Color.PeachPuff;
            _best.Font = new Font("Microsoft YaHei UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            _best.Location = new Point(155, 225);
            _best.Name = "_best";
            _best.Size = new Size(150, 50);
            _best.TabIndex = 19;
            _best.Text = "0";
            // 
            // title
            // 
            title.Font = new Font("Mistral", 72F, FontStyle.Regular, GraphicsUnit.Point);
            title.Location = new Point(0, 0);
            title.Name = "title";
            title.Size = new Size(354, 150);
            title.TabIndex = 22;
            title.Text = "2048";
            title.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            label1.Font = new Font("Microsoft YaHei UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(10, 287);
            label1.Name = "label1";
            label1.Size = new Size(268, 36);
            label1.TabIndex = 23;
            label1.Text = "合并数字,组合成 2048!";
            // 
            // label3
            // 
            label3.Location = new Point(10, 434);
            label3.Name = "label3";
            label3.Size = new Size(333, 103);
            label3.TabIndex = 24;
            label3.Text = "玩法说明: 使用wsad可以上下左右移动方块, 当两个具有相同数字的方块碰触时,它们会和二为一!\r\nE是返回上一步  Q是结束游戏";
            // 
            // blink
            // 
            blink.Location = new Point(12, 723);
            blink.Name = "blink";
            blink.Size = new Size(133, 75);
            blink.TabIndex = 25;
            blink.Text = "闪烁";
            blink.UseVisualStyleBackColor = true;
            blink.Click += blink_Click;
            // 
            // timer1
            // 
            timer1.Tick += timer1_Tick;
            // 
            // type
            // 
            type.FormattingEnabled = true;
            type.ImeMode = ImeMode.Off;
            type.Items.AddRange(new object[] { "数字", "段位", "海贼王" });
            type.Location = new Point(222, 339);
            type.Name = "type";
            type.Size = new Size(100, 32);
            type.TabIndex = 26;
            type.Text = "数字";
            // 
            // Speaker
            // 
            Speaker.Image = (Image)resources.GetObject("Speaker.Image");
            Speaker.Location = new Point(252, 723);
            Speaker.Name = "Speaker";
            Speaker.Size = new Size(100, 75);
            Speaker.SizeMode = PictureBoxSizeMode.StretchImage;
            Speaker.TabIndex = 27;
            Speaker.TabStop = false;
            Speaker.Click += Speaker_Click;
            // 
            // timer2
            // 
            timer2.Interval = 1000;
            timer2.Tick += timer2_Tick;
            // 
            // timer3
            // 
            timer3.Interval = 200;
            timer3.Tick += timer3_Tick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(11F, 24F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SeaShell;
            ClientSize = new Size(1207, 819);
            Controls.Add(Speaker);
            Controls.Add(type);
            Controls.Add(blink);
            Controls.Add(_best);
            Controls.Add(_score);
            Controls.Add(warn);
            Controls.Add(best);
            Controls.Add(rules);
            Controls.Add(score);
            Controls.Add(new_game);
            Controls.Add(Box);
            Controls.Add(title);
            Controls.Add(label3);
            Controls.Add(label1);
            Font = new Font("Microsoft YaHei UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            KeyPreview = true;
            Name = "Form1";
            Text = "2048";
            KeyDown += Form1_KeyDown;
            Box.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)Speaker).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button new_game;
        private Label score;
        private Label rules;
        private GroupBox Box;
        private Label box2;
        private Label box16;
        private Label box15;
        private Label box12;
        private Label box11;
        private Label box14;
        private Label box13;
        private Label box6;
        private Label box7;
        private Label box9;
        private Label box8;
        private Label box10;
        private Label box5;
        private Label box4;
        private Label box3;
        private Label best;
        private Label warn;
        private Label _score;
        private Label _best;
        private Label title;
        private Label label1;
        private Label label3;
        private Label box1;
        private Button blink;
        private System.Windows.Forms.Timer timer1;
        private ComboBox type;
        private PictureBox Speaker;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Timer timer3;
    }
}