namespace filtragemParam
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            debugBox = new GroupBox();
            SuspendLayout();
            // 
            // debugBox
            // 
            debugBox.Location = new Point(318, 29);
            debugBox.Name = "debugBox";
            debugBox.Size = new Size(250, 333);
            debugBox.TabIndex = 0;
            debugBox.TabStop = false;
            debugBox.Text = "debug";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1052, 550);
            Controls.Add(debugBox);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "MainForm";
            Text = "Módulo 4 - Filtragem de Parâmetros";
            ResumeLayout(false);
        }

        #endregion

        private GroupBox debugBox;
    }
}
