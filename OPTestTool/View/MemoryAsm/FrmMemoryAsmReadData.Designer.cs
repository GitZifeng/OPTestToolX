﻿
namespace ScriptTestTools.View.MemoryAsm
{
    partial class FrmMemoryAsmReadData
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
            label1 = new Label();
            btnSure = new Button();
            btnCancel = new Button();
            txtLen = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(76, 26);
            label1.Name = "label1";
            label1.Size = new Size(35, 12);
            label1.TabIndex = 0;
            label1.Text = "长度:";
            // 
            // btnSure
            // 
            btnSure.Location = new Point(64, 81);
            btnSure.Name = "btnSure";
            btnSure.Size = new Size(75, 23);
            btnSure.TabIndex = 2;
            btnSure.Text = "确定";
            btnSure.UseVisualStyleBackColor = true;
            btnSure.Click += btnSure_Click;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(154, 81);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(75, 23);
            btnCancel.TabIndex = 2;
            btnCancel.Text = "取消";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // txtLen
            // 
            txtLen.Location = new Point(122, 23);
            txtLen.Name = "txtLen";
            txtLen.Size = new Size(79, 21);
            txtLen.TabIndex = 3;
            // 
            // FrmMemoryAsmReadData
            // 
            AutoScaleDimensions = new SizeF(6F, 12F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(271, 136);
            Controls.Add(txtLen);
            Controls.Add(btnCancel);
            Controls.Add(btnSure);
            Controls.Add(label1);
            Font = new Font("宋体", 9F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FrmMemoryAsmReadData";
            StartPosition = FormStartPosition.CenterParent;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSure;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.TextBox txtLen;
    }
}