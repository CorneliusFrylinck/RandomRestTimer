namespace RandomRestTimer
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            lblIntervalTimeLeft = new Label();
            tbxTotal = new TextBox();
            tbxIntervalTime = new TextBox();
            tbxIntervalRestTime = new TextBox();
            tbxRestIntervals = new TextBox();
            tbxIntervalRange = new TextBox();
            lblTotalTimeLeft = new Label();
            label8 = new Label();
            cbxIncludeRest = new CheckBox();
            btnStart = new Button();
            btnReset = new Button();
            tmrChillTimer = new System.Windows.Forms.Timer(components);
            redDisplay = new RichTextBox();
            lblCurrentTime = new Label();
            label9 = new Label();
            lblCurrentState = new Label();
            label10 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(82, 66);
            label1.Name = "label1";
            label1.Size = new Size(98, 15);
            label1.TabIndex = 0;
            label1.Text = "Time per interval:";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(82, 124);
            label2.Name = "label2";
            label2.Size = new Size(76, 15);
            label2.TabIndex = 1;
            label2.Text = "Rest Intervals";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(82, 37);
            label3.Name = "label3";
            label3.Size = new Size(62, 15);
            label3.TabIndex = 2;
            label3.Text = "Total time:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(82, 95);
            label4.Name = "label4";
            label4.Size = new Size(181, 15);
            label4.TabIndex = 3;
            label4.Text = "Rest between intervals (seconds):";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(82, 153);
            label5.Name = "label5";
            label5.Size = new Size(215, 15);
            label5.TabIndex = 4;
            label5.Text = "Rest interval range (seconds - seconds):";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(34, 365);
            label6.Name = "label6";
            label6.Size = new Size(133, 15);
            label6.TabIndex = 5;
            label6.Text = "Interval time remaining:";
            // 
            // lblIntervalTimeLeft
            // 
            lblIntervalTimeLeft.AutoSize = true;
            lblIntervalTimeLeft.Font = new Font("Segoe UI", 72F, FontStyle.Bold, GraphicsUnit.Point);
            lblIntervalTimeLeft.Location = new Point(12, 380);
            lblIntervalTimeLeft.Name = "lblIntervalTimeLeft";
            lblIntervalTimeLeft.Size = new Size(300, 128);
            lblIntervalTimeLeft.TabIndex = 6;
            lblIntervalTimeLeft.Text = "00:00";
            // 
            // tbxTotal
            // 
            tbxTotal.Location = new Point(303, 34);
            tbxTotal.Name = "tbxTotal";
            tbxTotal.Size = new Size(126, 23);
            tbxTotal.TabIndex = 7;
            tbxTotal.Text = "8";
            // 
            // tbxIntervalTime
            // 
            tbxIntervalTime.Location = new Point(303, 63);
            tbxIntervalTime.Name = "tbxIntervalTime";
            tbxIntervalTime.Size = new Size(126, 23);
            tbxIntervalTime.TabIndex = 8;
            tbxIntervalTime.Text = "1";
            // 
            // tbxIntervalRestTime
            // 
            tbxIntervalRestTime.Location = new Point(303, 92);
            tbxIntervalRestTime.Name = "tbxIntervalRestTime";
            tbxIntervalRestTime.Size = new Size(126, 23);
            tbxIntervalRestTime.TabIndex = 9;
            tbxIntervalRestTime.Text = "10";
            // 
            // tbxRestIntervals
            // 
            tbxRestIntervals.Location = new Point(303, 121);
            tbxRestIntervals.Name = "tbxRestIntervals";
            tbxRestIntervals.Size = new Size(126, 23);
            tbxRestIntervals.TabIndex = 10;
            tbxRestIntervals.Text = "30";
            // 
            // tbxIntervalRange
            // 
            tbxIntervalRange.Location = new Point(303, 150);
            tbxIntervalRange.Name = "tbxIntervalRange";
            tbxIntervalRange.Size = new Size(126, 23);
            tbxIntervalRange.TabIndex = 11;
            tbxIntervalRange.Text = "15-25";
            // 
            // lblTotalTimeLeft
            // 
            lblTotalTimeLeft.AutoSize = true;
            lblTotalTimeLeft.Font = new Font("Segoe UI", 72F, FontStyle.Bold, GraphicsUnit.Point);
            lblTotalTimeLeft.Location = new Point(12, 540);
            lblTotalTimeLeft.Name = "lblTotalTimeLeft";
            lblTotalTimeLeft.Size = new Size(300, 128);
            lblTotalTimeLeft.TabIndex = 13;
            lblTotalTimeLeft.Text = "00:00";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(32, 525);
            label8.Name = "label8";
            label8.Size = new Size(119, 15);
            label8.TabIndex = 12;
            label8.Text = "Total time remaining:";
            // 
            // cbxIncludeRest
            // 
            cbxIncludeRest.AutoSize = true;
            cbxIncludeRest.Checked = true;
            cbxIncludeRest.CheckState = CheckState.Checked;
            cbxIncludeRest.Location = new Point(450, 36);
            cbxIncludeRest.Name = "cbxIncludeRest";
            cbxIncludeRest.Size = new Size(127, 19);
            cbxIncludeRest.TabIndex = 14;
            cbxIncludeRest.Text = "Include rest in total";
            cbxIncludeRest.UseVisualStyleBackColor = true;
            // 
            // btnStart
            // 
            btnStart.Font = new Font("Segoe UI", 36F, FontStyle.Regular, GraphicsUnit.Point);
            btnStart.Location = new Point(588, 150);
            btnStart.Name = "btnStart";
            btnStart.Size = new Size(162, 91);
            btnStart.TabIndex = 15;
            btnStart.Text = "Start";
            btnStart.UseVisualStyleBackColor = true;
            btnStart.Click += btnStart_Click;
            // 
            // btnReset
            // 
            btnReset.Font = new Font("Segoe UI", 36F, FontStyle.Regular, GraphicsUnit.Point);
            btnReset.Location = new Point(772, 150);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(162, 91);
            btnReset.TabIndex = 16;
            btnReset.Text = "Reset";
            btnReset.UseVisualStyleBackColor = true;
            btnReset.Click += btnReset_Click;
            // 
            // tmrChillTimer
            // 
            tmrChillTimer.Tick += tmrChillTimer_Tick;
            // 
            // redDisplay
            // 
            redDisplay.Location = new Point(542, 262);
            redDisplay.Name = "redDisplay";
            redDisplay.Size = new Size(392, 360);
            redDisplay.TabIndex = 17;
            redDisplay.Text = "";
            // 
            // lblCurrentTime
            // 
            lblCurrentTime.AutoSize = true;
            lblCurrentTime.Font = new Font("Segoe UI", 72F, FontStyle.Bold, GraphicsUnit.Point);
            lblCurrentTime.Location = new Point(12, 225);
            lblCurrentTime.Name = "lblCurrentTime";
            lblCurrentTime.Size = new Size(300, 128);
            lblCurrentTime.TabIndex = 19;
            lblCurrentTime.Text = "00:00";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(34, 210);
            label9.Name = "label9";
            label9.Size = new Size(134, 15);
            label9.TabIndex = 18;
            label9.Text = "Current time remaining:";
            // 
            // lblCurrentState
            // 
            lblCurrentState.AutoSize = true;
            lblCurrentState.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblCurrentState.Location = new Point(318, 198);
            lblCurrentState.Name = "lblCurrentState";
            lblCurrentState.Size = new Size(67, 30);
            lblCurrentState.TabIndex = 21;
            lblCurrentState.Text = "None";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(233, 210);
            label10.Name = "label10";
            label10.Size = new Size(79, 15);
            label10.TabIndex = 20;
            label10.Text = "Current State:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(946, 690);
            Controls.Add(lblCurrentState);
            Controls.Add(label10);
            Controls.Add(lblCurrentTime);
            Controls.Add(label9);
            Controls.Add(redDisplay);
            Controls.Add(btnReset);
            Controls.Add(btnStart);
            Controls.Add(cbxIncludeRest);
            Controls.Add(lblTotalTimeLeft);
            Controls.Add(label8);
            Controls.Add(tbxIntervalRange);
            Controls.Add(tbxRestIntervals);
            Controls.Add(tbxIntervalRestTime);
            Controls.Add(tbxIntervalTime);
            Controls.Add(tbxTotal);
            Controls.Add(lblIntervalTimeLeft);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Random Rest Timer";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label lblIntervalTimeLeft;
        private TextBox tbxTotal;
        private TextBox tbxIntervalTime;
        private TextBox tbxIntervalRestTime;
        private TextBox tbxRestIntervals;
        private TextBox tbxIntervalRange;
        private Label lblTotalTimeLeft;
        private Label label8;
        private CheckBox cbxIncludeRest;
        private Button btnStart;
        private Button btnReset;
        private System.Windows.Forms.Timer tmrChillTimer;
        private RichTextBox redDisplay;
        private Label lblCurrentTime;
        private Label label9;
        private Label lblCurrentState;
        private Label label10;
    }
}