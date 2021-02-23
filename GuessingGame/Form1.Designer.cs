namespace GuessingGame
{
    partial class titleLabel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(titleLabel));
            this.guessingGameTitle = new System.Windows.Forms.Label();
            this.enterNumberLabel = new System.Windows.Forms.Label();
            this.numberInput = new System.Windows.Forms.TextBox();
            this.guessButton = new System.Windows.Forms.Button();
            this.answerOutput = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // guessingGameTitle
            // 
            this.guessingGameTitle.AutoSize = true;
            this.guessingGameTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guessingGameTitle.Location = new System.Drawing.Point(65, 25);
            this.guessingGameTitle.Name = "guessingGameTitle";
            this.guessingGameTitle.Size = new System.Drawing.Size(206, 29);
            this.guessingGameTitle.TabIndex = 0;
            this.guessingGameTitle.Text = "Guessing Game ";
            // 
            // enterNumberLabel
            // 
            this.enterNumberLabel.AutoSize = true;
            this.enterNumberLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.enterNumberLabel.Location = new System.Drawing.Point(51, 77);
            this.enterNumberLabel.Name = "enterNumberLabel";
            this.enterNumberLabel.Size = new System.Drawing.Size(235, 16);
            this.enterNumberLabel.TabIndex = 1;
            this.enterNumberLabel.Text = "Enter a number between 1 to 100.";
            // 
            // numberInput
            // 
            this.numberInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numberInput.Location = new System.Drawing.Point(143, 108);
            this.numberInput.Name = "numberInput";
            this.numberInput.Size = new System.Drawing.Size(47, 29);
            this.numberInput.TabIndex = 2;
            // 
            // guessButton
            // 
            this.guessButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guessButton.Location = new System.Drawing.Point(120, 143);
            this.guessButton.Name = "guessButton";
            this.guessButton.Size = new System.Drawing.Size(87, 33);
            this.guessButton.TabIndex = 3;
            this.guessButton.Text = "Guess";
            this.guessButton.UseVisualStyleBackColor = true;
            this.guessButton.Click += new System.EventHandler(this.GuessButton_Click);
            // 
            // answerOutput
            // 
            this.answerOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.answerOutput.Location = new System.Drawing.Point(81, 193);
            this.answerOutput.Name = "answerOutput";
            this.answerOutput.Size = new System.Drawing.Size(164, 41);
            this.answerOutput.TabIndex = 4;
            this.answerOutput.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // titleLabel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(337, 254);
            this.Controls.Add(this.answerOutput);
            this.Controls.Add(this.guessButton);
            this.Controls.Add(this.numberInput);
            this.Controls.Add(this.enterNumberLabel);
            this.Controls.Add(this.guessingGameTitle);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "titleLabel";
            this.Text = "Guessing Game ";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label guessingGameTitle;
        private System.Windows.Forms.Label enterNumberLabel;
        private System.Windows.Forms.TextBox numberInput;
        private System.Windows.Forms.Button guessButton;
        private System.Windows.Forms.Label answerOutput;
    }
}

