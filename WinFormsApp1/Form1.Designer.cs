namespace WinFormsApp1
{
    partial class deletethis
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
            groupBox1 = new GroupBox();
            btnAddCounter = new Button();
            txtCounterLimit = new TextBox();
            label2 = new Label();
            txtCounterRouteName = new TextBox();
            label1 = new Label();
            groupBox2 = new GroupBox();
            btnAddTime = new Button();
            txtTimeWindow = new TextBox();
            label5 = new Label();
            txtTimeLimit = new TextBox();
            label4 = new Label();
            txtTimeRouteName = new TextBox();
            label3 = new Label();
            grpRequest = new GroupBox();
            lblRequestResult2 = new Label();
            lblRequestResult = new Label();
            btnRequest = new Button();
            txtRequestRoute = new TextBox();
            label6 = new Label();
            grpStatus = new GroupBox();
            txtStatusDisplay = new TextBox();
            btnStatus = new Button();
            txtStatusRoute = new TextBox();
            label7 = new Label();
            grpReset = new GroupBox();
            btnReset = new Button();
            txtResetRoute = new TextBox();
            label8 = new Label();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            grpRequest.SuspendLayout();
            grpStatus.SuspendLayout();
            grpReset.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnAddCounter);
            groupBox1.Controls.Add(txtCounterLimit);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(txtCounterRouteName);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(294, 208);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Add Counter Route";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // btnAddCounter
            // 
            btnAddCounter.Location = new Point(53, 156);
            btnAddCounter.Name = "btnAddCounter";
            btnAddCounter.Size = new Size(177, 34);
            btnAddCounter.TabIndex = 4;
            btnAddCounter.Text = "Add Counter Route";
            btnAddCounter.UseVisualStyleBackColor = true;
            btnAddCounter.Click += btnAddCounter_Click;
            // 
            // txtCounterLimit
            // 
            txtCounterLimit.Location = new Point(122, 64);
            txtCounterLimit.Name = "txtCounterLimit";
            txtCounterLimit.Size = new Size(146, 31);
            txtCounterLimit.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 64);
            label2.Name = "label2";
            label2.Size = new Size(54, 25);
            label2.TabIndex = 2;
            label2.Text = "Limit:";
            // 
            // txtCounterRouteName
            // 
            txtCounterRouteName.Location = new Point(122, 30);
            txtCounterRouteName.Name = "txtCounterRouteName";
            txtCounterRouteName.Size = new Size(146, 31);
            txtCounterRouteName.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 33);
            label1.Name = "label1";
            label1.Size = new Size(114, 25);
            label1.TabIndex = 0;
            label1.Text = "Route Name:";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(btnAddTime);
            groupBox2.Controls.Add(txtTimeWindow);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(txtTimeLimit);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(txtTimeRouteName);
            groupBox2.Controls.Add(label3);
            groupBox2.Location = new Point(347, 12);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(305, 208);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Add Time Route";
            // 
            // btnAddTime
            // 
            btnAddTime.Location = new Point(72, 156);
            btnAddTime.Name = "btnAddTime";
            btnAddTime.Size = new Size(169, 34);
            btnAddTime.TabIndex = 2;
            btnAddTime.Text = "Add Time Route";
            btnAddTime.UseVisualStyleBackColor = true;
            btnAddTime.Click += btnAddTime_Click_1;
            // 
            // txtTimeWindow
            // 
            txtTimeWindow.Location = new Point(126, 106);
            txtTimeWindow.Name = "txtTimeWindow";
            txtTimeWindow.Size = new Size(150, 31);
            txtTimeWindow.TabIndex = 5;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(6, 106);
            label5.Name = "label5";
            label5.Size = new Size(119, 25);
            label5.TabIndex = 4;
            label5.Text = "Window(Sec):";
            label5.Click += label5_Click;
            // 
            // txtTimeLimit
            // 
            txtTimeLimit.Location = new Point(126, 70);
            txtTimeLimit.Name = "txtTimeLimit";
            txtTimeLimit.Size = new Size(150, 31);
            txtTimeLimit.TabIndex = 3;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(6, 70);
            label4.Name = "label4";
            label4.Size = new Size(54, 25);
            label4.TabIndex = 2;
            label4.Text = "Limit:";
            // 
            // txtTimeRouteName
            // 
            txtTimeRouteName.Location = new Point(126, 33);
            txtTimeRouteName.Name = "txtTimeRouteName";
            txtTimeRouteName.Size = new Size(150, 31);
            txtTimeRouteName.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(6, 36);
            label3.Name = "label3";
            label3.Size = new Size(114, 25);
            label3.TabIndex = 0;
            label3.Text = "Route Name:";
            // 
            // grpRequest
            // 
            grpRequest.Controls.Add(lblRequestResult2);
            grpRequest.Controls.Add(lblRequestResult);
            grpRequest.Controls.Add(btnRequest);
            grpRequest.Controls.Add(txtRequestRoute);
            grpRequest.Controls.Add(label6);
            grpRequest.Location = new Point(681, 12);
            grpRequest.Name = "grpRequest";
            grpRequest.Size = new Size(286, 208);
            grpRequest.TabIndex = 2;
            grpRequest.TabStop = false;
            grpRequest.Text = "Make Request";
            grpRequest.Enter += grpRequest_Enter;
            // 
            // lblRequestResult2
            // 
            lblRequestResult2.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblRequestResult2.Location = new Point(17, 82);
            lblRequestResult2.Name = "lblRequestResult2";
            lblRequestResult2.Size = new Size(253, 49);
            lblRequestResult2.TabIndex = 4;
            // 
            // lblRequestResult
            // 
            lblRequestResult.AutoSize = true;
            lblRequestResult.Location = new Point(17, 82);
            lblRequestResult.Name = "lblRequestResult";
            lblRequestResult.Size = new Size(0, 25);
            lblRequestResult.TabIndex = 3;
            lblRequestResult.Click += label7_Click;
            // 
            // btnRequest
            // 
            btnRequest.Location = new Point(79, 156);
            btnRequest.Name = "btnRequest";
            btnRequest.Size = new Size(128, 34);
            btnRequest.TabIndex = 2;
            btnRequest.Text = "Send Request";
            btnRequest.UseVisualStyleBackColor = true;
            btnRequest.Click += btnRequest_Click_1;
            // 
            // txtRequestRoute
            // 
            txtRequestRoute.Location = new Point(120, 40);
            txtRequestRoute.Name = "txtRequestRoute";
            txtRequestRoute.Size = new Size(150, 31);
            txtRequestRoute.TabIndex = 1;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(0, 43);
            label6.Name = "label6";
            label6.Size = new Size(114, 25);
            label6.TabIndex = 0;
            label6.Text = "Route Name:";
            label6.Click += label6_Click;
            // 
            // grpStatus
            // 
            grpStatus.Controls.Add(txtStatusDisplay);
            grpStatus.Controls.Add(btnStatus);
            grpStatus.Controls.Add(txtStatusRoute);
            grpStatus.Controls.Add(label7);
            grpStatus.Location = new Point(980, 12);
            grpStatus.Name = "grpStatus";
            grpStatus.Size = new Size(325, 208);
            grpStatus.TabIndex = 3;
            grpStatus.TabStop = false;
            grpStatus.Text = "Route Status";
            // 
            // txtStatusDisplay
            // 
            txtStatusDisplay.Location = new Point(6, 118);
            txtStatusDisplay.Multiline = true;
            txtStatusDisplay.Name = "txtStatusDisplay";
            txtStatusDisplay.ReadOnly = true;
            txtStatusDisplay.ScrollBars = ScrollBars.Vertical;
            txtStatusDisplay.Size = new Size(313, 84);
            txtStatusDisplay.TabIndex = 4;
            // 
            // btnStatus
            // 
            btnStatus.Location = new Point(126, 80);
            btnStatus.Name = "btnStatus";
            btnStatus.Size = new Size(71, 32);
            btnStatus.TabIndex = 5;
            btnStatus.Text = "Check Status";
            btnStatus.UseVisualStyleBackColor = true;
            // 
            // txtStatusRoute
            // 
            txtStatusRoute.Location = new Point(126, 43);
            txtStatusRoute.Name = "txtStatusRoute";
            txtStatusRoute.Size = new Size(175, 31);
            txtStatusRoute.TabIndex = 4;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(6, 46);
            label7.Name = "label7";
            label7.Size = new Size(114, 25);
            label7.TabIndex = 0;
            label7.Text = "Route Name:";
            // 
            // grpReset
            // 
            grpReset.Controls.Add(btnReset);
            grpReset.Controls.Add(txtResetRoute);
            grpReset.Controls.Add(label8);
            grpReset.Location = new Point(12, 277);
            grpReset.Name = "grpReset";
            grpReset.Size = new Size(300, 209);
            grpReset.TabIndex = 4;
            grpReset.TabStop = false;
            grpReset.Text = "Reset Route\n";
            // 
            // btnReset
            // 
            btnReset.ForeColor = Color.Red;
            btnReset.Location = new Point(80, 119);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(129, 34);
            btnReset.TabIndex = 2;
            btnReset.Text = "Reset";
            btnReset.UseVisualStyleBackColor = true;
            btnReset.Click += btnReset_Click_1;
            // 
            // txtResetRoute
            // 
            txtResetRoute.Location = new Point(129, 35);
            txtResetRoute.Name = "txtResetRoute";
            txtResetRoute.Size = new Size(150, 31);
            txtResetRoute.TabIndex = 1;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(9, 38);
            label8.Name = "label8";
            label8.Size = new Size(114, 25);
            label8.TabIndex = 0;
            label8.Text = "Route Name:";
            // 
            // deletethis
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1317, 739);
            Controls.Add(grpReset);
            Controls.Add(grpStatus);
            Controls.Add(grpRequest);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "deletethis";
            Text = "Route Status";
            Load += grpStatus_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            grpRequest.ResumeLayout(false);
            grpRequest.PerformLayout();
            grpStatus.ResumeLayout(false);
            grpStatus.PerformLayout();
            grpReset.ResumeLayout(false);
            grpReset.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Label label1;
        private TextBox txtCounterRouteName;
        private Label label2;
        private TextBox txtCounterLimit;
        private Button btnAddCounter;
        private GroupBox groupBox2;
        private Label label3;
        private TextBox txtTimeRouteName;
        private Label label4;
        private TextBox txtTimeLimit;
        private Label label5;
        private TextBox txtTimeWindow;
        private Button btnAddTime;
        private GroupBox grpRequest;
        private Label label6;
        private Button btnRequest;
        private TextBox txtRequestRoute;
        private Label lblRequestResult;
        private Label lblRequestResult2;
        private GroupBox grpStatus;
        private Label label7;
        private TextBox txtStatusRoute;
        private Button btnStatus;
        private TextBox txtStatusDisplay;
        private GroupBox grpReset;
        private Label label8;
        private TextBox txtResetRoute;
        private Button btnReset;
    }
}
