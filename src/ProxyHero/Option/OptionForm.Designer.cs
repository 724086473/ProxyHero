﻿namespace ProxyHero.Option
{
    partial class OptionForm
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
            this.SuspendLayout();
            // 
            // OptionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(627, 466);
            this.Name = "OptionForm";
            this.ShowCategoryDescription = true;
            this.ShowCategoryHeader = true;
            this.ShowOptionsPanelPath = true;
            this.Load += new System.EventHandler(this.OptionForm_Load);
            this.Shown += new System.EventHandler(this.OptionForm_Shown);
            this.ResumeLayout(false);

        }

        #endregion

    }
}