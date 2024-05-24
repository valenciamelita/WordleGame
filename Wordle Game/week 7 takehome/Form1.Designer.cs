namespace week_7_takehome
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
            this.label_wordle = new System.Windows.Forms.Label();
            this.label_howmuch = new System.Windows.Forms.Label();
            this.textbox_input = new System.Windows.Forms.TextBox();
            this.button_play = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label_wordle
            // 
            this.label_wordle.AutoSize = true;
            this.label_wordle.Font = new System.Drawing.Font("Helvetica", 26F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_wordle.Location = new System.Drawing.Point(91, 28);
            this.label_wordle.Name = "label_wordle";
            this.label_wordle.Size = new System.Drawing.Size(259, 62);
            this.label_wordle.TabIndex = 0;
            this.label_wordle.Text = "WORDLE";
            // 
            // label_howmuch
            // 
            this.label_howmuch.AutoSize = true;
            this.label_howmuch.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_howmuch.Location = new System.Drawing.Point(22, 87);
            this.label_howmuch.Name = "label_howmuch";
            this.label_howmuch.Size = new System.Drawing.Size(390, 27);
            this.label_howmuch.TabIndex = 1;
            this.label_howmuch.Text = "Set How Much You can Guess!";
            // 
            // textbox_input
            // 
            this.textbox_input.Location = new System.Drawing.Point(81, 117);
            this.textbox_input.Name = "textbox_input";
            this.textbox_input.Size = new System.Drawing.Size(279, 26);
            this.textbox_input.TabIndex = 2;
            this.textbox_input.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textbox_input_KeyPress);
            // 
            // button_play
            // 
            this.button_play.Font = new System.Drawing.Font("Montserrat Medium", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_play.Location = new System.Drawing.Point(170, 149);
            this.button_play.Name = "button_play";
            this.button_play.Size = new System.Drawing.Size(93, 42);
            this.button_play.TabIndex = 3;
            this.button_play.Text = "Play!";
            this.button_play.UseVisualStyleBackColor = true;
            this.button_play.Click += new System.EventHandler(this.button_play_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(445, 342);
            this.Controls.Add(this.button_play);
            this.Controls.Add(this.textbox_input);
            this.Controls.Add(this.label_howmuch);
            this.Controls.Add(this.label_wordle);
            this.Name = "Form1";
            this.Text = "Welcome to WORDLE!";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_wordle;
        private System.Windows.Forms.Label label_howmuch;
        private System.Windows.Forms.TextBox textbox_input;
        private System.Windows.Forms.Button button_play;
    }
}

