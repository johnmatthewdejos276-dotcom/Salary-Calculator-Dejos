namespace Salary_Calculator_Dejos
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
            this.btnCompute = new System.Windows.Forms.Button();
            this.txtHours = new System.Windows.Forms.TextBox();
            this.txtRate = new System.Windows.Forms.TextBox();
            this.lblHours = new System.Windows.Forms.Label();
            this.txtSalary = new System.Windows.Forms.TextBox();
            this.lblRate = new System.Windows.Forms.Label();
            this.lblSalary = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCompute
            // 
            this.btnCompute.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnCompute.Location = new System.Drawing.Point(144, 229);
            this.btnCompute.Name = "btnCompute";
            this.btnCompute.Size = new System.Drawing.Size(147, 37);
            this.btnCompute.TabIndex = 0;
            this.btnCompute.Text = "COMPUTE";
            this.btnCompute.UseVisualStyleBackColor = false;
            this.btnCompute.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtHours
            // 
            this.txtHours.ForeColor = System.Drawing.SystemColors.MenuText;
            this.txtHours.Location = new System.Drawing.Point(176, 126);
            this.txtHours.Name = "txtHours";
            this.txtHours.Size = new System.Drawing.Size(301, 20);
            this.txtHours.TabIndex = 1;
            this.txtHours.TextChanged += new System.EventHandler(this.txtHours_TextChanged);
            // 
            // txtRate
            // 
            this.txtRate.Location = new System.Drawing.Point(176, 152);
            this.txtRate.Name = "txtRate";
            this.txtRate.Size = new System.Drawing.Size(300, 20);
            this.txtRate.TabIndex = 2;
            // 
            // lblHours
            // 
            this.lblHours.AutoSize = true;
            this.lblHours.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHours.Location = new System.Drawing.Point(62, 130);
            this.lblHours.Name = "lblHours";
            this.lblHours.Size = new System.Drawing.Size(48, 16);
            this.lblHours.TabIndex = 3;
            this.lblHours.Text = "Hours";
            this.lblHours.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtSalary
            // 
            this.txtSalary.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtSalary.Location = new System.Drawing.Point(176, 178);
            this.txtSalary.Name = "txtSalary";
            this.txtSalary.ReadOnly = true;
            this.txtSalary.Size = new System.Drawing.Size(301, 20);
            this.txtSalary.TabIndex = 4;
            this.txtSalary.UseWaitCursor = true;
            this.txtSalary.TextChanged += new System.EventHandler(this.txtSalary_TextChanged);
            // 
            // lblRate
            // 
            this.lblRate.AutoSize = true;
            this.lblRate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRate.Location = new System.Drawing.Point(62, 156);
            this.lblRate.Name = "lblRate";
            this.lblRate.Size = new System.Drawing.Size(40, 16);
            this.lblRate.TabIndex = 5;
            this.lblRate.Text = "Rate";
            this.lblRate.Click += new System.EventHandler(this.label2_Click);
            // 
            // lblSalary
            // 
            this.lblSalary.AutoSize = true;
            this.lblSalary.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSalary.Location = new System.Drawing.Point(62, 182);
            this.lblSalary.Name = "lblSalary";
            this.lblSalary.Size = new System.Drawing.Size(97, 16);
            this.lblSalary.TabIndex = 6;
            this.lblSalary.Text = "Gross Salary";
            this.lblSalary.Click += new System.EventHandler(this.label3_Click);
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnClear.Location = new System.Drawing.Point(297, 229);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(148, 37);
            this.btnClear.TabIndex = 7;
            this.btnClear.Text = "CLEAR";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Stencil", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(145, 64);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(300, 32);
            this.lblTitle.TabIndex = 9;
            this.lblTitle.Text = "Salary Calculator";
            this.lblTitle.Click += new System.EventHandler(this.label4_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.SystemColors.Window;
            this.btnExit.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btnExit.Location = new System.Drawing.Point(222, 272);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(147, 37);
            this.btnExit.TabIndex = 10;
            this.btnExit.Text = "EXIT";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(599, 344);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.lblSalary);
            this.Controls.Add(this.lblRate);
            this.Controls.Add(this.txtSalary);
            this.Controls.Add(this.lblHours);
            this.Controls.Add(this.txtRate);
            this.Controls.Add(this.txtHours);
            this.Controls.Add(this.btnCompute);
            this.Name = "Form1";
            this.Text = "Form1";
            this.TransparencyKey = System.Drawing.SystemColors.ButtonFace;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCompute;
        private System.Windows.Forms.TextBox txtHours;
        private System.Windows.Forms.TextBox txtRate;
        private System.Windows.Forms.Label lblHours;
        private System.Windows.Forms.TextBox txtSalary;
        private System.Windows.Forms.Label lblRate;
        private System.Windows.Forms.Label lblSalary;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnExit;
    }
}

