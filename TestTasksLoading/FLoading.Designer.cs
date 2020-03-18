namespace TestTasksLoading
{
    partial class FLoading
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
            this.PctLoading = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.PctLoading)).BeginInit();
            this.SuspendLayout();
            // 
            // PctLoading
            // 
            this.PctLoading.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.PctLoading.Image = global::TestTasksLoading.Properties.Resources.loading2CirculosIncompletos;
            this.PctLoading.Location = new System.Drawing.Point(289, 119);
            this.PctLoading.Name = "PctLoading";
            this.PctLoading.Size = new System.Drawing.Size(223, 212);
            this.PctLoading.TabIndex = 1;
            this.PctLoading.TabStop = false;
            // 
            // FLoading
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.PctLoading);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FLoading";
            this.Opacity = 0.8D;
            this.Text = "FLoading";
            this.Load += new System.EventHandler(this.FLoading_LoadAsync);
            ((System.ComponentModel.ISupportInitialize)(this.PctLoading)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox PctLoading;
    }
}