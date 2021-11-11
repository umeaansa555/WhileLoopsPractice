
namespace WhileLoopsPractice
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
            this.Button = new System.Windows.Forms.Button();
            this.value1Input = new System.Windows.Forms.TextBox();
            this.value2Input = new System.Windows.Forms.TextBox();
            this.outputLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Button
            // 
            this.Button.Location = new System.Drawing.Point(172, 165);
            this.Button.Name = "Button";
            this.Button.Size = new System.Drawing.Size(153, 32);
            this.Button.TabIndex = 0;
            this.Button.Text = "Show values";
            this.Button.UseVisualStyleBackColor = true;
            this.Button.Click += new System.EventHandler(this.Button_Click);
            // 
            // value1Input
            // 
            this.value1Input.Location = new System.Drawing.Point(172, 64);
            this.value1Input.Name = "value1Input";
            this.value1Input.Size = new System.Drawing.Size(156, 20);
            this.value1Input.TabIndex = 1;
            // 
            // value2Input
            // 
            this.value2Input.Location = new System.Drawing.Point(172, 90);
            this.value2Input.Name = "value2Input";
            this.value2Input.Size = new System.Drawing.Size(156, 20);
            this.value2Input.TabIndex = 2;
            // 
            // outputLabel
            // 
            this.outputLabel.AutoSize = true;
            this.outputLabel.Location = new System.Drawing.Point(50, 221);
            this.outputLabel.Name = "outputLabel";
            this.outputLabel.Size = new System.Drawing.Size(39, 13);
            this.outputLabel.TabIndex = 3;
            this.outputLabel.Text = "Output";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(377, 314);
            this.Controls.Add(this.outputLabel);
            this.Controls.Add(this.value2Input);
            this.Controls.Add(this.value1Input);
            this.Controls.Add(this.Button);
            this.Name = "Form1";
            this.Text = " ";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Button;
        private System.Windows.Forms.TextBox value1Input;
        private System.Windows.Forms.TextBox value2Input;
        private System.Windows.Forms.Label outputLabel;
    }
}

