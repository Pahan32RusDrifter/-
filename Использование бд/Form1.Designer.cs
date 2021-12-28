namespace Использование_бд
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
            this.tbxLogin = new System.Windows.Forms.TextBox();
            this.tbxPass = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnReg = new System.Windows.Forms.Button();
            this.etoBazaDataSet = new Использование_бд.EtoBazaDataSet();
            this.usersTableAdapter = new Использование_бд.EtoBazaDataSetTableAdapters.UsersTableAdapter();
            this.tableAdapterManager = new Использование_бд.EtoBazaDataSetTableAdapters.TableAdapterManager();
            ((System.ComponentModel.ISupportInitialize)(this.etoBazaDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // tbxLogin
            // 
            this.tbxLogin.Location = new System.Drawing.Point(28, 58);
            this.tbxLogin.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.tbxLogin.Name = "tbxLogin";
            this.tbxLogin.Size = new System.Drawing.Size(443, 34);
            this.tbxLogin.TabIndex = 0;
            // 
            // tbxPass
            // 
            this.tbxPass.Location = new System.Drawing.Point(28, 167);
            this.tbxPass.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.tbxPass.Name = "tbxPass";
            this.tbxPass.Size = new System.Drawing.Size(443, 34);
            this.tbxPass.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 22);
            this.label1.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 29);
            this.label1.TabIndex = 2;
            this.label1.Text = "Логин:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 125);
            this.label2.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 29);
            this.label2.TabIndex = 3;
            this.label2.Text = "Пароль:";
            // 
            // btnOK
            // 
            this.btnOK.BackColor = System.Drawing.Color.LightSalmon;
            this.btnOK.Location = new System.Drawing.Point(296, 280);
            this.btnOK.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(175, 77);
            this.btnOK.TabIndex = 4;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = false;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnReg
            // 
            this.btnReg.BackColor = System.Drawing.Color.LightSalmon;
            this.btnReg.Location = new System.Drawing.Point(33, 280);
            this.btnReg.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.btnReg.Name = "btnReg";
            this.btnReg.Size = new System.Drawing.Size(187, 77);
            this.btnReg.TabIndex = 5;
            this.btnReg.Text = "Регистрация";
            this.btnReg.UseVisualStyleBackColor = false;
            this.btnReg.Click += new System.EventHandler(this.btnReg_Click);
            // 
            // etoBazaDataSet
            // 
            this.etoBazaDataSet.DataSetName = "EtoBazaDataSet";
            this.etoBazaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // usersTableAdapter
            // 
            this.usersTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.UpdateOrder = Использование_бд.EtoBazaDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.UsersTableAdapter = this.usersTableAdapter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Bisque;
            this.ClientSize = new System.Drawing.Size(513, 373);
            this.Controls.Add(this.btnReg);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbxPass);
            this.Controls.Add(this.tbxLogin);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Использование баз данных";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.etoBazaDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbxLogin;
        private System.Windows.Forms.TextBox tbxPass;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnReg;
        private EtoBazaDataSet etoBazaDataSet;
        private EtoBazaDataSetTableAdapters.UsersTableAdapter usersTableAdapter;
        private EtoBazaDataSetTableAdapters.TableAdapterManager tableAdapterManager;
    }
}

