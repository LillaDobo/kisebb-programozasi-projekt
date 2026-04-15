namespace Labirintus
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
            panel1 = new Panel();
            timer1 = new System.Windows.Forms.Timer(components);
            btn_Start = new Button();
            btn_New_Game = new Button();
            btn_Exit = new Button();
            label1 = new Label();
            label2 = new Label();
            btn_load = new Button();
            label3 = new Label();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel1.AutoScroll = true;
            panel1.Location = new Point(0, 95);
            panel1.Name = "panel1";
            panel1.Size = new Size(1242, 509);
            panel1.TabIndex = 0;
            // 
            // timer1
            // 
            timer1.Tick += timer1_Tick;
            // 
            // btn_Start
            // 
            btn_Start.Location = new Point(12, 30);
            btn_Start.Name = "btn_Start";
            btn_Start.Size = new Size(98, 26);
            btn_Start.TabIndex = 1;
            btn_Start.Text = "Start";
            btn_Start.UseVisualStyleBackColor = true;
            btn_Start.Click += btn_Start_Click;
            // 
            // btn_New_Game
            // 
            btn_New_Game.Location = new Point(155, 30);
            btn_New_Game.Name = "btn_New_Game";
            btn_New_Game.Size = new Size(98, 26);
            btn_New_Game.TabIndex = 2;
            btn_New_Game.Text = "Új játék";
            btn_New_Game.UseVisualStyleBackColor = true;
            btn_New_Game.Click += btn_New_Game_Click;
            // 
            // btn_Exit
            // 
            btn_Exit.Location = new Point(299, 30);
            btn_Exit.Name = "btn_Exit";
            btn_Exit.Size = new Size(95, 26);
            btn_Exit.TabIndex = 3;
            btn_Exit.Text = "Kilépés";
            btn_Exit.UseVisualStyleBackColor = true;
            btn_Exit.Click += btn_Exit_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(1091, 14);
            label1.Name = "label1";
            label1.Size = new Size(0, 15);
            label1.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(1089, 44);
            label2.Name = "label2";
            label2.Size = new Size(0, 15);
            label2.TabIndex = 5;
            // 
            // btn_load
            // 
            btn_load.Location = new Point(427, 30);
            btn_load.Name = "btn_load";
            btn_load.Size = new Size(92, 26);
            btn_load.TabIndex = 6;
            btn_load.Text = "Betöltés";
            btn_load.UseVisualStyleBackColor = true;
            btn_load.Click += button1_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(1044, 70);
            label3.Name = "label3";
            label3.Size = new Size(0, 15);
            label3.TabIndex = 7;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1242, 604);
            Controls.Add(label3);
            Controls.Add(btn_load);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btn_Exit);
            Controls.Add(btn_New_Game);
            Controls.Add(btn_Start);
            Controls.Add(panel1);
            KeyPreview = true;
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }


        #endregion

        private Panel panel1;
        private System.Windows.Forms.Timer timer1;
        private Button btn_Start;
        private Button btn_New_Game;
        private Button btn_Exit;
        private Label label1;
        private Label label2;
        private Button btn_load;
        private Label label3;
    }
}
