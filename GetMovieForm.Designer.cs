﻿
namespace MovieDatabase
{
    partial class GetMovieForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GetMovieForm));
            this.movieListBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.movieInfoButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // movieListBox
            // 
            this.movieListBox.FormattingEnabled = true;
            this.movieListBox.Location = new System.Drawing.Point(88, 62);
            this.movieListBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.movieListBox.Name = "movieListBox";
            this.movieListBox.Size = new System.Drawing.Size(184, 21);
            this.movieListBox.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(148, 39);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Movie List";
            // 
            // movieInfoButton
            // 
            this.movieInfoButton.Location = new System.Drawing.Point(135, 105);
            this.movieInfoButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.movieInfoButton.Name = "movieInfoButton";
            this.movieInfoButton.Size = new System.Drawing.Size(83, 31);
            this.movieInfoButton.TabIndex = 2;
            this.movieInfoButton.Text = "Info";
            this.movieInfoButton.UseVisualStyleBackColor = true;
            this.movieInfoButton.Click += new System.EventHandler(this.movieInfoButton_Click);
            // 
            // GetMovieForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(364, 163);
            this.Controls.Add(this.movieInfoButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.movieListBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "GetMovieForm";
            this.Text = "Preview Movie";
            this.Load += new System.EventHandler(this.GetMovieForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox movieListBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button movieInfoButton;
    }
}