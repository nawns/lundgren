﻿namespace Lundgren.Forms
{
    partial class MainForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.startButton = new System.Windows.Forms.Button();
            this.logText = new System.Windows.Forms.TextBox();
            this.btnA = new System.Windows.Forms.Button();
            this.btnB = new System.Windows.Forms.Button();
            this.btnY = new System.Windows.Forms.Button();
            this.btnX = new System.Windows.Forms.Button();
            this.btnStart = new System.Windows.Forms.Button();
            this.btnSUp = new System.Windows.Forms.Button();
            this.btnSDown = new System.Windows.Forms.Button();
            this.btnSLeft = new System.Windows.Forms.Button();
            this.btnSRight = new System.Windows.Forms.Button();
            this.frame = new System.Windows.Forms.TextBox();
            this.timer = new System.Windows.Forms.TextBox();
            this.stage = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.p1stocks = new System.Windows.Forms.TextBox();
            this.p2stocks = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.p1char = new System.Windows.Forms.TextBox();
            this.p2char = new System.Windows.Forms.TextBox();
            this.p2percent = new System.Windows.Forms.TextBox();
            this.p1percent = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.p1Animation = new System.Windows.Forms.TextBox();
            this.p2Animation = new System.Windows.Forms.TextBox();
            this.p1X = new System.Windows.Forms.TextBox();
            this.p1Y = new System.Windows.Forms.TextBox();
            this.p2X = new System.Windows.Forms.TextBox();
            this.p2Y = new System.Windows.Forms.TextBox();
            this.p1PictureBox = new System.Windows.Forms.PictureBox();
            this.p2PictureBox = new System.Windows.Forms.PictureBox();
            this.p1CursorX = new System.Windows.Forms.TextBox();
            this.p2CursorX = new System.Windows.Forms.TextBox();
            this.p1CursorY = new System.Windows.Forms.TextBox();
            this.p2CursorY = new System.Windows.Forms.TextBox();
            this.p1NameEntryPos = new System.Windows.Forms.TextBox();
            this.checkNotHosting = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.p1PictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.p2PictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(240, 162);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(20, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "P1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(405, 162);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(20, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "P2";
            // 
            // startButton
            // 
            this.startButton.Location = new System.Drawing.Point(94, 223);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(108, 35);
            this.startButton.TabIndex = 23;
            this.startButton.Text = "Driver Start";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // logText
            // 
            this.logText.Location = new System.Drawing.Point(12, 12);
            this.logText.Multiline = true;
            this.logText.Name = "logText";
            this.logText.ReadOnly = true;
            this.logText.Size = new System.Drawing.Size(210, 202);
            this.logText.TabIndex = 24;
            // 
            // btnA
            // 
            this.btnA.Location = new System.Drawing.Point(21, 316);
            this.btnA.Name = "btnA";
            this.btnA.Size = new System.Drawing.Size(34, 33);
            this.btnA.TabIndex = 26;
            this.btnA.Text = "A";
            this.btnA.UseVisualStyleBackColor = true;
            this.btnA.Click += new System.EventHandler(this.btnA_Click);
            // 
            // btnB
            // 
            this.btnB.Location = new System.Drawing.Point(61, 316);
            this.btnB.Name = "btnB";
            this.btnB.Size = new System.Drawing.Size(34, 33);
            this.btnB.TabIndex = 27;
            this.btnB.Text = "B";
            this.btnB.UseVisualStyleBackColor = true;
            this.btnB.Click += new System.EventHandler(this.btnB_Click);
            // 
            // btnY
            // 
            this.btnY.Location = new System.Drawing.Point(61, 277);
            this.btnY.Name = "btnY";
            this.btnY.Size = new System.Drawing.Size(34, 33);
            this.btnY.TabIndex = 28;
            this.btnY.Text = "Y";
            this.btnY.UseVisualStyleBackColor = true;
            this.btnY.Click += new System.EventHandler(this.btnY_Click);
            // 
            // btnX
            // 
            this.btnX.Location = new System.Drawing.Point(101, 277);
            this.btnX.Name = "btnX";
            this.btnX.Size = new System.Drawing.Size(34, 33);
            this.btnX.TabIndex = 29;
            this.btnX.Text = "X";
            this.btnX.UseVisualStyleBackColor = true;
            this.btnX.Click += new System.EventHandler(this.btnX_Click);
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(101, 316);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(44, 33);
            this.btnStart.TabIndex = 30;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnSUp
            // 
            this.btnSUp.Location = new System.Drawing.Point(176, 277);
            this.btnSUp.Name = "btnSUp";
            this.btnSUp.Size = new System.Drawing.Size(22, 33);
            this.btnSUp.TabIndex = 31;
            this.btnSUp.Text = "^";
            this.btnSUp.UseVisualStyleBackColor = true;
            this.btnSUp.Click += new System.EventHandler(this.btnSUp_Click);
            // 
            // btnSDown
            // 
            this.btnSDown.Location = new System.Drawing.Point(176, 320);
            this.btnSDown.Name = "btnSDown";
            this.btnSDown.Size = new System.Drawing.Size(22, 33);
            this.btnSDown.TabIndex = 32;
            this.btnSDown.Text = "v";
            this.btnSDown.UseVisualStyleBackColor = true;
            this.btnSDown.Click += new System.EventHandler(this.btnSDown_Click);
            // 
            // btnSLeft
            // 
            this.btnSLeft.Location = new System.Drawing.Point(152, 298);
            this.btnSLeft.Name = "btnSLeft";
            this.btnSLeft.Size = new System.Drawing.Size(18, 33);
            this.btnSLeft.TabIndex = 33;
            this.btnSLeft.Text = "<";
            this.btnSLeft.UseVisualStyleBackColor = true;
            this.btnSLeft.Click += new System.EventHandler(this.btnSLeft_Click);
            // 
            // btnSRight
            // 
            this.btnSRight.Location = new System.Drawing.Point(204, 298);
            this.btnSRight.Name = "btnSRight";
            this.btnSRight.Size = new System.Drawing.Size(18, 33);
            this.btnSRight.TabIndex = 34;
            this.btnSRight.Text = ">";
            this.btnSRight.UseVisualStyleBackColor = true;
            this.btnSRight.Click += new System.EventHandler(this.btnSRight_Click);
            // 
            // frame
            // 
            this.frame.Location = new System.Drawing.Point(431, 303);
            this.frame.Name = "frame";
            this.frame.Size = new System.Drawing.Size(100, 20);
            this.frame.TabIndex = 35;
            // 
            // timer
            // 
            this.timer.Location = new System.Drawing.Point(431, 329);
            this.timer.Name = "timer";
            this.timer.Size = new System.Drawing.Size(101, 20);
            this.timer.TabIndex = 36;
            // 
            // stage
            // 
            this.stage.Location = new System.Drawing.Point(431, 353);
            this.stage.Name = "stage";
            this.stage.Size = new System.Drawing.Size(101, 20);
            this.stage.TabIndex = 37;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(389, 332);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 13);
            this.label3.TabIndex = 38;
            this.label3.Text = "Timer:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(389, 356);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 13);
            this.label4.TabIndex = 39;
            this.label4.Text = "Stage:";
            // 
            // p1stocks
            // 
            this.p1stocks.Location = new System.Drawing.Point(309, 159);
            this.p1stocks.Name = "p1stocks";
            this.p1stocks.Size = new System.Drawing.Size(30, 20);
            this.p1stocks.TabIndex = 40;
            // 
            // p2stocks
            // 
            this.p2stocks.Cursor = System.Windows.Forms.Cursors.Default;
            this.p2stocks.Location = new System.Drawing.Point(467, 159);
            this.p2stocks.Name = "p2stocks";
            this.p2stocks.Size = new System.Drawing.Size(29, 20);
            this.p2stocks.TabIndex = 41;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(502, 162);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 13);
            this.label5.TabIndex = 42;
            this.label5.Text = "Stocks";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(345, 162);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 13);
            this.label6.TabIndex = 43;
            this.label6.Text = "Stocks";
            // 
            // p1char
            // 
            this.p1char.Location = new System.Drawing.Point(309, 185);
            this.p1char.Name = "p1char";
            this.p1char.Size = new System.Drawing.Size(73, 20);
            this.p1char.TabIndex = 44;
            // 
            // p2char
            // 
            this.p2char.Location = new System.Drawing.Point(467, 185);
            this.p2char.Name = "p2char";
            this.p2char.Size = new System.Drawing.Size(72, 20);
            this.p2char.TabIndex = 45;
            // 
            // p2percent
            // 
            this.p2percent.Location = new System.Drawing.Point(431, 159);
            this.p2percent.Name = "p2percent";
            this.p2percent.Size = new System.Drawing.Size(29, 20);
            this.p2percent.TabIndex = 46;
            // 
            // p1percent
            // 
            this.p1percent.Location = new System.Drawing.Point(274, 159);
            this.p1percent.Name = "p1percent";
            this.p1percent.Size = new System.Drawing.Size(29, 20);
            this.p1percent.TabIndex = 48;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(378, 310);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(46, 13);
            this.label7.TabIndex = 49;
            this.label7.Text = "Frame #";
            // 
            // p1Animation
            // 
            this.p1Animation.Location = new System.Drawing.Point(309, 211);
            this.p1Animation.Name = "p1Animation";
            this.p1Animation.Size = new System.Drawing.Size(73, 20);
            this.p1Animation.TabIndex = 52;
            // 
            // p2Animation
            // 
            this.p2Animation.Location = new System.Drawing.Point(467, 211);
            this.p2Animation.Name = "p2Animation";
            this.p2Animation.Size = new System.Drawing.Size(72, 20);
            this.p2Animation.TabIndex = 53;
            // 
            // p1X
            // 
            this.p1X.Location = new System.Drawing.Point(239, 185);
            this.p1X.Name = "p1X";
            this.p1X.Size = new System.Drawing.Size(64, 20);
            this.p1X.TabIndex = 55;
            // 
            // p1Y
            // 
            this.p1Y.Location = new System.Drawing.Point(238, 211);
            this.p1Y.Name = "p1Y";
            this.p1Y.Size = new System.Drawing.Size(65, 20);
            this.p1Y.TabIndex = 56;
            // 
            // p2X
            // 
            this.p2X.Location = new System.Drawing.Point(397, 185);
            this.p2X.Name = "p2X";
            this.p2X.Size = new System.Drawing.Size(64, 20);
            this.p2X.TabIndex = 57;
            // 
            // p2Y
            // 
            this.p2Y.Location = new System.Drawing.Point(397, 211);
            this.p2Y.Name = "p2Y";
            this.p2Y.Size = new System.Drawing.Size(65, 20);
            this.p2Y.TabIndex = 58;
            // 
            // p1PictureBox
            // 
            this.p1PictureBox.Location = new System.Drawing.Point(243, 12);
            this.p1PictureBox.Name = "p1PictureBox";
            this.p1PictureBox.Size = new System.Drawing.Size(139, 141);
            this.p1PictureBox.TabIndex = 59;
            this.p1PictureBox.TabStop = false;
            // 
            // p2PictureBox
            // 
            this.p2PictureBox.Location = new System.Drawing.Point(400, 12);
            this.p2PictureBox.Name = "p2PictureBox";
            this.p2PictureBox.Size = new System.Drawing.Size(139, 141);
            this.p2PictureBox.TabIndex = 60;
            this.p2PictureBox.TabStop = false;
            // 
            // p1CursorX
            // 
            this.p1CursorX.Location = new System.Drawing.Point(238, 237);
            this.p1CursorX.Name = "p1CursorX";
            this.p1CursorX.Size = new System.Drawing.Size(65, 20);
            this.p1CursorX.TabIndex = 64;
            // 
            // p2CursorX
            // 
            this.p2CursorX.Location = new System.Drawing.Point(397, 237);
            this.p2CursorX.Name = "p2CursorX";
            this.p2CursorX.Size = new System.Drawing.Size(65, 20);
            this.p2CursorX.TabIndex = 65;
            // 
            // p1CursorY
            // 
            this.p1CursorY.Location = new System.Drawing.Point(309, 237);
            this.p1CursorY.Name = "p1CursorY";
            this.p1CursorY.Size = new System.Drawing.Size(73, 20);
            this.p1CursorY.TabIndex = 66;
            // 
            // p2CursorY
            // 
            this.p2CursorY.Location = new System.Drawing.Point(467, 237);
            this.p2CursorY.Name = "p2CursorY";
            this.p2CursorY.Size = new System.Drawing.Size(72, 20);
            this.p2CursorY.TabIndex = 67;
            // 
            // p1NameEntryPos
            // 
            this.p1NameEntryPos.Location = new System.Drawing.Point(238, 263);
            this.p1NameEntryPos.Name = "p1NameEntryPos";
            this.p1NameEntryPos.Size = new System.Drawing.Size(65, 20);
            this.p1NameEntryPos.TabIndex = 68;
            // 
            // checkNotHosting
            // 
            this.checkNotHosting.AutoSize = true;
            this.checkNotHosting.Location = new System.Drawing.Point(243, 336);
            this.checkNotHosting.Name = "checkNotHosting";
            this.checkNotHosting.Size = new System.Drawing.Size(82, 17);
            this.checkNotHosting.TabIndex = 69;
            this.checkNotHosting.Text = "Not Hosting";
            this.checkNotHosting.UseVisualStyleBackColor = true;
            this.checkNotHosting.CheckedChanged += new System.EventHandler(this.checkNotHosting_CheckedChanged);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(550, 380);
            this.Controls.Add(this.checkNotHosting);
            this.Controls.Add(this.p1NameEntryPos);
            this.Controls.Add(this.p2CursorY);
            this.Controls.Add(this.p1CursorY);
            this.Controls.Add(this.p2CursorX);
            this.Controls.Add(this.p1CursorX);
            this.Controls.Add(this.p2PictureBox);
            this.Controls.Add(this.p1PictureBox);
            this.Controls.Add(this.p2Y);
            this.Controls.Add(this.p2X);
            this.Controls.Add(this.p1Y);
            this.Controls.Add(this.p1X);
            this.Controls.Add(this.p2Animation);
            this.Controls.Add(this.p1Animation);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.p1percent);
            this.Controls.Add(this.p2percent);
            this.Controls.Add(this.p2char);
            this.Controls.Add(this.p1char);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.p2stocks);
            this.Controls.Add(this.p1stocks);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.stage);
            this.Controls.Add(this.timer);
            this.Controls.Add(this.frame);
            this.Controls.Add(this.btnSRight);
            this.Controls.Add(this.btnSLeft);
            this.Controls.Add(this.btnSDown);
            this.Controls.Add(this.btnSUp);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.btnX);
            this.Controls.Add(this.btnY);
            this.Controls.Add(this.btnB);
            this.Controls.Add(this.btnA);
            this.Controls.Add(this.logText);
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "MainForm";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.p1PictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.p2PictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.TextBox logText;
        private System.Windows.Forms.Button btnA;
        private System.Windows.Forms.Button btnB;
        private System.Windows.Forms.Button btnY;
        private System.Windows.Forms.Button btnX;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnSUp;
        private System.Windows.Forms.Button btnSDown;
        private System.Windows.Forms.Button btnSLeft;
        private System.Windows.Forms.Button btnSRight;
        private System.Windows.Forms.TextBox frame;
        private System.Windows.Forms.TextBox timer;
        private System.Windows.Forms.TextBox stage;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox p1stocks;
        private System.Windows.Forms.TextBox p2stocks;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox p1char;
        private System.Windows.Forms.TextBox p2char;
        private System.Windows.Forms.TextBox p2percent;
        private System.Windows.Forms.TextBox p1percent;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox p1Animation;
        private System.Windows.Forms.TextBox p2Animation;
        private System.Windows.Forms.TextBox p1X;
        private System.Windows.Forms.TextBox p1Y;
        private System.Windows.Forms.TextBox p2X;
        private System.Windows.Forms.TextBox p2Y;
        private System.Windows.Forms.PictureBox p1PictureBox;
        private System.Windows.Forms.PictureBox p2PictureBox;
        private System.Windows.Forms.TextBox p1CursorX;
        private System.Windows.Forms.TextBox p2CursorX;
        private System.Windows.Forms.TextBox p1CursorY;
        private System.Windows.Forms.TextBox p2CursorY;
        private System.Windows.Forms.TextBox p1NameEntryPos;
        private System.Windows.Forms.CheckBox checkNotHosting;
    }
}

