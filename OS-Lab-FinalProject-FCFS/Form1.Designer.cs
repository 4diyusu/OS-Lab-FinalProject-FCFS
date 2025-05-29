namespace OS_Lab_FinalProject_FCFS
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
            this.txtCustomerName = new System.Windows.Forms.TextBox();
            this.nudBurstTime = new System.Windows.Forms.NumericUpDown();
            this.btnAddCustomer = new System.Windows.Forms.Button();
            this.btnServeNext = new System.Windows.Forms.Button();
            this.btnResetQueue = new System.Windows.Forms.Button();
            this.dgvQueue = new System.Windows.Forms.DataGridView();
            this.lstServed = new System.Windows.Forms.ListBox();
            this.lblCurrent = new System.Windows.Forms.Label();
            this.timerBurst = new System.Windows.Forms.Timer(this.components);
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblFullName = new System.Windows.Forms.Label();
            this.lblTimer = new System.Windows.Forms.Label();
            this.lblQueue = new System.Windows.Forms.Label();
            this.lblNowServing = new System.Windows.Forms.Label();
            this.lblLastServed = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nudBurstTime)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvQueue)).BeginInit();
            this.SuspendLayout();
            // 
            // txtCustomerName
            // 
            this.txtCustomerName.Location = new System.Drawing.Point(61, 152);
            this.txtCustomerName.Name = "txtCustomerName";
            this.txtCustomerName.Size = new System.Drawing.Size(229, 20);
            this.txtCustomerName.TabIndex = 0;
            // 
            // nudBurstTime
            // 
            this.nudBurstTime.Location = new System.Drawing.Point(61, 214);
            this.nudBurstTime.Name = "nudBurstTime";
            this.nudBurstTime.Size = new System.Drawing.Size(92, 20);
            this.nudBurstTime.TabIndex = 1;
            // 
            // btnAddCustomer
            // 
            this.btnAddCustomer.Location = new System.Drawing.Point(192, 214);
            this.btnAddCustomer.Name = "btnAddCustomer";
            this.btnAddCustomer.Size = new System.Drawing.Size(98, 23);
            this.btnAddCustomer.TabIndex = 2;
            this.btnAddCustomer.Text = "Add Customer";
            this.btnAddCustomer.UseVisualStyleBackColor = true;
            this.btnAddCustomer.Click += new System.EventHandler(this.btnAddCustomer_Click);
            // 
            // btnServeNext
            // 
            this.btnServeNext.Location = new System.Drawing.Point(192, 258);
            this.btnServeNext.Name = "btnServeNext";
            this.btnServeNext.Size = new System.Drawing.Size(98, 23);
            this.btnServeNext.TabIndex = 3;
            this.btnServeNext.Text = "Next Customer";
            this.btnServeNext.UseVisualStyleBackColor = true;
            this.btnServeNext.Click += new System.EventHandler(this.btnServeNext_Click);
            // 
            // btnResetQueue
            // 
            this.btnResetQueue.Location = new System.Drawing.Point(538, 508);
            this.btnResetQueue.Name = "btnResetQueue";
            this.btnResetQueue.Size = new System.Drawing.Size(96, 23);
            this.btnResetQueue.TabIndex = 4;
            this.btnResetQueue.Text = "Reset Queue";
            this.btnResetQueue.UseVisualStyleBackColor = true;
            this.btnResetQueue.Click += new System.EventHandler(this.btnResetQueue_Click);
            // 
            // dgvQueue
            // 
            this.dgvQueue.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvQueue.Location = new System.Drawing.Point(61, 342);
            this.dgvQueue.Name = "dgvQueue";
            this.dgvQueue.Size = new System.Drawing.Size(350, 187);
            this.dgvQueue.TabIndex = 5;
            // 
            // lstServed
            // 
            this.lstServed.FormattingEnabled = true;
            this.lstServed.Location = new System.Drawing.Point(432, 342);
            this.lstServed.Name = "lstServed";
            this.lstServed.Size = new System.Drawing.Size(202, 160);
            this.lstServed.TabIndex = 6;
            // 
            // lblCurrent
            // 
            this.lblCurrent.AutoSize = true;
            this.lblCurrent.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurrent.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.lblCurrent.Location = new System.Drawing.Point(360, 152);
            this.lblCurrent.Name = "lblCurrent";
            this.lblCurrent.Size = new System.Drawing.Size(57, 20);
            this.lblCurrent.TabIndex = 7;
            this.lblCurrent.Text = "--------";
            // 
            // timerBurst
            // 
            this.timerBurst.Tick += new System.EventHandler(this.timerBurst_Tick);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(64, 32);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(552, 55);
            this.lblTitle.TabIndex = 8;
            this.lblTitle.Text = "First Come First Served";
            // 
            // lblFullName
            // 
            this.lblFullName.AutoSize = true;
            this.lblFullName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFullName.Location = new System.Drawing.Point(58, 133);
            this.lblFullName.Name = "lblFullName";
            this.lblFullName.Size = new System.Drawing.Size(77, 16);
            this.lblFullName.TabIndex = 9;
            this.lblFullName.Text = "Full Name";
            // 
            // lblTimer
            // 
            this.lblTimer.AutoSize = true;
            this.lblTimer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTimer.Location = new System.Drawing.Point(58, 195);
            this.lblTimer.Name = "lblTimer";
            this.lblTimer.Size = new System.Drawing.Size(122, 16);
            this.lblTimer.TabIndex = 10;
            this.lblTimer.Text = "Timer (Seconds)";
            // 
            // lblQueue
            // 
            this.lblQueue.AutoSize = true;
            this.lblQueue.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQueue.Location = new System.Drawing.Point(58, 323);
            this.lblQueue.Name = "lblQueue";
            this.lblQueue.Size = new System.Drawing.Size(105, 16);
            this.lblQueue.TabIndex = 11;
            this.lblQueue.Text = "Current Queue";
            // 
            // lblNowServing
            // 
            this.lblNowServing.AutoSize = true;
            this.lblNowServing.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNowServing.Location = new System.Drawing.Point(359, 111);
            this.lblNowServing.Name = "lblNowServing";
            this.lblNowServing.Size = new System.Drawing.Size(173, 25);
            this.lblNowServing.TabIndex = 12;
            this.lblNowServing.Text = "NOW SERVING";
            // 
            // lblLastServed
            // 
            this.lblLastServed.AutoSize = true;
            this.lblLastServed.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLastServed.Location = new System.Drawing.Point(429, 323);
            this.lblLastServed.Name = "lblLastServed";
            this.lblLastServed.Size = new System.Drawing.Size(126, 16);
            this.lblLastServed.TabIndex = 13;
            this.lblLastServed.Text = "Customer Served";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 561);
            this.Controls.Add(this.lblLastServed);
            this.Controls.Add(this.lblNowServing);
            this.Controls.Add(this.lblQueue);
            this.Controls.Add(this.lblTimer);
            this.Controls.Add(this.lblFullName);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.lblCurrent);
            this.Controls.Add(this.lstServed);
            this.Controls.Add(this.dgvQueue);
            this.Controls.Add(this.btnResetQueue);
            this.Controls.Add(this.btnServeNext);
            this.Controls.Add(this.btnAddCustomer);
            this.Controls.Add(this.nudBurstTime);
            this.Controls.Add(this.txtCustomerName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Queueing System";
            ((System.ComponentModel.ISupportInitialize)(this.nudBurstTime)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvQueue)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtCustomerName;
        private System.Windows.Forms.NumericUpDown nudBurstTime;
        private System.Windows.Forms.Button btnAddCustomer;
        private System.Windows.Forms.Button btnServeNext;
        private System.Windows.Forms.Button btnResetQueue;
        private System.Windows.Forms.DataGridView dgvQueue;
        private System.Windows.Forms.ListBox lstServed;
        private System.Windows.Forms.Label lblCurrent;
        private System.Windows.Forms.Timer timerBurst;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblFullName;
        private System.Windows.Forms.Label lblTimer;
        private System.Windows.Forms.Label lblQueue;
        private System.Windows.Forms.Label lblNowServing;
        private System.Windows.Forms.Label lblLastServed;
    }
}

