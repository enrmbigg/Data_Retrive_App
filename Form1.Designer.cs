namespace Data_Retrive_App
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
            this.btnWrite = new System.Windows.Forms.Button();
            this.lblResult = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.txtTable = new System.Windows.Forms.TextBox();
            this.lblTable = new System.Windows.Forms.Label();
            this.lblDB = new System.Windows.Forms.Label();
            this.txtCon = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnWrite
            // 
            this.btnWrite.Location = new System.Drawing.Point(3, 211);
            this.btnWrite.Name = "btnWrite";
            this.btnWrite.Size = new System.Drawing.Size(128, 23);
            this.btnWrite.TabIndex = 12;
            this.btnWrite.Text = "Write Folder To DB";
            this.btnWrite.UseVisualStyleBackColor = true;
            this.btnWrite.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // lblResult
            // 
            this.lblResult.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblResult.Location = new System.Drawing.Point(3, 9);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(266, 43);
            this.lblResult.TabIndex = 14;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(137, 211);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(132, 23);
            this.btnDelete.TabIndex = 15;
            this.btnDelete.Text = "Delete All Records";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.button2_Click);
            // 
            // txtTable
            // 
            this.txtTable.Location = new System.Drawing.Point(137, 185);
            this.txtTable.Name = "txtTable";
            this.txtTable.Size = new System.Drawing.Size(100, 20);
            this.txtTable.TabIndex = 16;
            this.txtTable.Text = "Insert Table Here";
            // 
            // lblTable
            // 
            this.lblTable.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblTable.Location = new System.Drawing.Point(3, 69);
            this.lblTable.Name = "lblTable";
            this.lblTable.Size = new System.Drawing.Size(266, 43);
            this.lblTable.TabIndex = 14;
            // 
            // lblDB
            // 
            this.lblDB.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblDB.Location = new System.Drawing.Point(3, 122);
            this.lblDB.Name = "lblDB";
            this.lblDB.Size = new System.Drawing.Size(266, 43);
            this.lblDB.TabIndex = 14;
            // 
            // txtCon
            // 
            this.txtCon.Location = new System.Drawing.Point(31, 185);
            this.txtCon.Name = "txtCon";
            this.txtCon.Size = new System.Drawing.Size(100, 20);
            this.txtCon.TabIndex = 17;
            this.txtCon.Text = "Insert DB Con Here";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(273, 243);
            this.Controls.Add(this.txtCon);
            this.Controls.Add(this.txtTable);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.lblDB);
            this.Controls.Add(this.lblTable);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.btnWrite);
            this.Name = "Form1";
            this.Text = "Data App";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnWrite;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.TextBox txtTable;
        private System.Windows.Forms.Label lblTable;
        private System.Windows.Forms.Label lblDB;
        private System.Windows.Forms.TextBox txtCon;
    }
}

