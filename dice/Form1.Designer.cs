namespace dice
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
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
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
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_GO = new System.Windows.Forms.Button();
            this.tb_input = new System.Windows.Forms.TextBox();
            this.rtb_show = new System.Windows.Forms.RichTextBox();
            this.btn_text = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_GO
            // 
            this.btn_GO.Font = new System.Drawing.Font("新細明體", 60F);
            this.btn_GO.Location = new System.Drawing.Point(44, 270);
            this.btn_GO.Name = "btn_GO";
            this.btn_GO.Size = new System.Drawing.Size(273, 140);
            this.btn_GO.TabIndex = 0;
            this.btn_GO.Text = "GO";
            this.btn_GO.UseVisualStyleBackColor = true;
            this.btn_GO.Click += new System.EventHandler(this.Button1_Click);
            // 
            // tb_input
            // 
            this.tb_input.Location = new System.Drawing.Point(44, 123);
            this.tb_input.Name = "tb_input";
            this.tb_input.Size = new System.Drawing.Size(126, 22);
            this.tb_input.TabIndex = 1;
            // 
            // rtb_show
            // 
            this.rtb_show.Location = new System.Drawing.Point(452, 12);
            this.rtb_show.Name = "rtb_show";
            this.rtb_show.Size = new System.Drawing.Size(297, 398);
            this.rtb_show.TabIndex = 2;
            this.rtb_show.Text = "";
            this.rtb_show.TextChanged += new System.EventHandler(this.Rtb_show_TextChanged);
            // 
            // btn_text
            // 
            this.btn_text.Location = new System.Drawing.Point(141, 202);
            this.btn_text.Name = "btn_text";
            this.btn_text.Size = new System.Drawing.Size(75, 23);
            this.btn_text.TabIndex = 3;
            this.btn_text.Text = "TEXT";
            this.btn_text.UseVisualStyleBackColor = true;
            this.btn_text.Click += new System.EventHandler(this.Btn_text_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_text);
            this.Controls.Add(this.rtb_show);
            this.Controls.Add(this.tb_input);
            this.Controls.Add(this.btn_GO);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_GO;
        private System.Windows.Forms.TextBox tb_input;
        private System.Windows.Forms.RichTextBox rtb_show;
        private System.Windows.Forms.Button btn_text;
    }
}

