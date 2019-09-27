﻿namespace FlyFF_AwakeBot {
    partial class ProcessSelector {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
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
            System.ComponentModel.ComponentResourceManager resources =
                new System.ComponentModel.ComponentResourceManager(typeof(ProcessSelector));
            this.ButtonSelectProcess = new System.Windows.Forms.Button();
            this.ListViewProcesses = new System.Windows.Forms.ListView();
            this.colName = new System.Windows.Forms.ColumnHeader();
            this.colPid = new System.Windows.Forms.ColumnHeader();
            this.colWndTitle = new System.Windows.Forms.ColumnHeader();
            this.SuspendLayout();
            // 
            // ButtonSelectProcess
            // 
            this.ButtonSelectProcess.Location = new System.Drawing.Point(14, 308);
            this.ButtonSelectProcess.Name = "ButtonSelectProcess";
            this.ButtonSelectProcess.Size = new System.Drawing.Size(611, 27);
            this.ButtonSelectProcess.TabIndex = 0;
            this.ButtonSelectProcess.Text = "Select";
            this.ButtonSelectProcess.UseVisualStyleBackColor = true;
            this.ButtonSelectProcess.Click += new System.EventHandler(this.ButtonSelectProcessOnClick);
            // 
            // ListViewProcesses
            // 
            this.ListViewProcesses.Columns.AddRange(new System.Windows.Forms.ColumnHeader[]
                {this.colName, this.colPid, this.colWndTitle});
            this.ListViewProcesses.FullRowSelect = true;
            this.ListViewProcesses.HideSelection = false;
            this.ListViewProcesses.Location = new System.Drawing.Point(14, 14);
            this.ListViewProcesses.MultiSelect = false;
            this.ListViewProcesses.Name = "ListViewProcesses";
            this.ListViewProcesses.Size = new System.Drawing.Size(611, 287);
            this.ListViewProcesses.TabIndex = 1;
            this.ListViewProcesses.UseCompatibleStateImageBehavior = false;
            this.ListViewProcesses.View = System.Windows.Forms.View.Details;
            // 
            // colName
            // 
            this.colName.Text = "Name";
            this.colName.Width = 97;
            // 
            // colPid
            // 
            this.colPid.Text = "PID";
            this.colPid.Width = 71;
            // 
            // colWndTitle
            // 
            this.colWndTitle.Text = "Window Title";
            this.colWndTitle.Width = 352;
            // 
            // ProcessSelector
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(639, 345);
            this.Controls.Add(this.ListViewProcesses);
            this.Controls.Add(this.ButtonSelectProcess);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon) (resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "ProcessSelector";
            this.Text = "Select the Flyff Process";
            this.Load += new System.EventHandler(this.ProcessSelector_Load);
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Button ButtonSelectProcess;
        private System.Windows.Forms.ListView ListViewProcesses;
        private System.Windows.Forms.ColumnHeader colName;
        private System.Windows.Forms.ColumnHeader colPid;
        private System.Windows.Forms.ColumnHeader colWndTitle;
    }
}