namespace PickAScriptureAppUI
{
    partial class PickAScripture
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.numberOfScriptures = new System.Windows.Forms.NumericUpDown();
            this.scriptureDisplay = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numberOfScriptures)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(2083, 126);
            this.label1.TabIndex = 0;
            this.label1.Text = "Pick A Scripture App";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.SystemColors.Control;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 167);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(2083, 46);
            this.label2.TabIndex = 1;
            this.label2.Text = "Pick the amount of scriptures";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // numberOfScriptures
            // 
            this.numberOfScriptures.Location = new System.Drawing.Point(889, 239);
            this.numberOfScriptures.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numberOfScriptures.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numberOfScriptures.Name = "numberOfScriptures";
            this.numberOfScriptures.Size = new System.Drawing.Size(284, 26);
            this.numberOfScriptures.TabIndex = 2;
            this.numberOfScriptures.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // scriptureDisplay
            // 
            this.scriptureDisplay.FormattingEnabled = true;
            this.scriptureDisplay.ItemHeight = 20;
            this.scriptureDisplay.Location = new System.Drawing.Point(753, 445);
            this.scriptureDisplay.Name = "scriptureDisplay";
            this.scriptureDisplay.Size = new System.Drawing.Size(531, 264);
            this.scriptureDisplay.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button1.Location = new System.Drawing.Point(941, 271);
            this.button1.Name = "button1";
            this.button1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.button1.Size = new System.Drawing.Size(190, 38);
            this.button1.TabIndex = 4;
            this.button1.Text = "Pick Scriptures";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // PickAScripture
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(2107, 1194);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.scriptureDisplay);
            this.Controls.Add(this.numberOfScriptures);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "PickAScripture";
            this.Text = "Pick A Scripture";
            ((System.ComponentModel.ISupportInitialize)(this.numberOfScriptures)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numberOfScriptures;
        private System.Windows.Forms.ListBox scriptureDisplay;
        private System.Windows.Forms.Button button1;
    }
}

