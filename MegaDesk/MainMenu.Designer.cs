﻿namespace MegaDesk
{
    partial class MainMenu
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
            this.addQuoteBtn = new System.Windows.Forms.Button();
            this.viewQuoteBtn = new System.Windows.Forms.Button();
            this.searchQuotesBtn = new System.Windows.Forms.Button();
            this.exitBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // addQuoteBtn
            // 
            this.addQuoteBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addQuoteBtn.Location = new System.Drawing.Point(81, 130);
            this.addQuoteBtn.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.addQuoteBtn.Name = "addQuoteBtn";
            this.addQuoteBtn.Size = new System.Drawing.Size(341, 70);
            this.addQuoteBtn.TabIndex = 0;
            this.addQuoteBtn.Text = "Add Quote";
            this.addQuoteBtn.UseVisualStyleBackColor = true;
            this.addQuoteBtn.Click += new System.EventHandler(this.addQuoteBtn_Click);
            // 
            // viewQuoteBtn
            // 
            this.viewQuoteBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewQuoteBtn.Location = new System.Drawing.Point(81, 234);
            this.viewQuoteBtn.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.viewQuoteBtn.Name = "viewQuoteBtn";
            this.viewQuoteBtn.Size = new System.Drawing.Size(341, 70);
            this.viewQuoteBtn.TabIndex = 1;
            this.viewQuoteBtn.Text = "View Quotes";
            this.viewQuoteBtn.UseVisualStyleBackColor = true;
            this.viewQuoteBtn.Click += new System.EventHandler(this.viewQuoteBtn_Click);
            // 
            // searchQuotesBtn
            // 
            this.searchQuotesBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchQuotesBtn.Location = new System.Drawing.Point(81, 343);
            this.searchQuotesBtn.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.searchQuotesBtn.Name = "searchQuotesBtn";
            this.searchQuotesBtn.Size = new System.Drawing.Size(341, 70);
            this.searchQuotesBtn.TabIndex = 2;
            this.searchQuotesBtn.Text = "Search Quotes";
            this.searchQuotesBtn.UseVisualStyleBackColor = true;
            this.searchQuotesBtn.Click += new System.EventHandler(this.searchQuotesBtn_Click);
            // 
            // exitBtn
            // 
            this.exitBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitBtn.Location = new System.Drawing.Point(81, 449);
            this.exitBtn.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(341, 70);
            this.exitBtn.TabIndex = 3;
            this.exitBtn.Text = "Exit";
            this.exitBtn.UseVisualStyleBackColor = true;
            this.exitBtn.Click += new System.EventHandler(this.exitBtn_Click);
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(929, 679);
            this.Controls.Add(this.exitBtn);
            this.Controls.Add(this.searchQuotesBtn);
            this.Controls.Add(this.viewQuoteBtn);
            this.Controls.Add(this.addQuoteBtn);
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "MainMenu";
            this.Text = "MainMenu";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainMenu_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button addQuoteBtn;
        private System.Windows.Forms.Button viewQuoteBtn;
        private System.Windows.Forms.Button searchQuotesBtn;
        private System.Windows.Forms.Button exitBtn;
    }
}
