﻿namespace WindowsFormGame
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置 Managed 資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器
        /// 修改這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.label_npc = new System.Windows.Forms.Label();
            this.tb_user = new System.Windows.Forms.TextBox();
            this.label_ans = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label_npc
            // 
            this.label_npc.AutoSize = true;
            this.label_npc.Location = new System.Drawing.Point(75, 21);
            this.label_npc.Name = "label_npc";
            this.label_npc.Size = new System.Drawing.Size(27, 12);
            this.label_npc.TabIndex = 0;
            this.label_npc.Text = "NPC";
            // 
            // tb_user
            // 
            this.tb_user.Location = new System.Drawing.Point(77, 55);
            this.tb_user.MaxLength = 4;
            this.tb_user.Name = "tb_user";
            this.tb_user.Size = new System.Drawing.Size(100, 22);
            this.tb_user.TabIndex = 1;
            this.tb_user.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_user_KeyPress);
            // 
            // label_ans
            // 
            this.label_ans.AutoSize = true;
            this.label_ans.Location = new System.Drawing.Point(75, 103);
            this.label_ans.Name = "label_ans";
            this.label_ans.Size = new System.Drawing.Size(27, 12);
            this.label_ans.TabIndex = 2;
            this.label_ans.Text = "ANS";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 12);
            this.label1.TabIndex = 3;
            this.label1.Text = "NPC:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 12);
            this.label2.TabIndex = 4;
            this.label2.Text = "User:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 103);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 12);
            this.label3.TabIndex = 5;
            this.label3.Text = "Answer:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(102, 148);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "Run";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label_ans);
            this.Controls.Add(this.tb_user);
            this.Controls.Add(this.label_npc);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_npc;
        private System.Windows.Forms.TextBox tb_user;
        private System.Windows.Forms.Label label_ans;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
    }
}

