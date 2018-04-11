namespace Appli2
{
    partial class frmAppli2
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAppli2));
            this.gbx_Para = new System.Windows.Forms.GroupBox();
            this.textBox_Temp = new System.Windows.Forms.TextBox();
            this.textBox_Vtesse = new System.Windows.Forms.TextBox();
            this.lbl_Temp = new System.Windows.Forms.Label();
            this.lbl_vitesse = new System.Windows.Forms.Label();
            this.btn_Exit = new System.Windows.Forms.Button();
            this.btn_Refresh = new System.Windows.Forms.Button();
            this.btn_OK = new System.Windows.Forms.Button();
            this.lbl_Choose_Speed = new System.Windows.Forms.Label();
            this.lbl_Choose_Temp = new System.Windows.Forms.Label();
            this.cbx_speed = new System.Windows.Forms.ComboBox();
            this.cbx_Temp = new System.Windows.Forms.ComboBox();
            this.gbx_Para.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbx_Para
            // 
            this.gbx_Para.Controls.Add(this.textBox_Temp);
            this.gbx_Para.Controls.Add(this.textBox_Vtesse);
            this.gbx_Para.Controls.Add(this.lbl_Temp);
            this.gbx_Para.Controls.Add(this.lbl_vitesse);
            this.gbx_Para.Location = new System.Drawing.Point(12, 155);
            this.gbx_Para.Name = "gbx_Para";
            this.gbx_Para.Size = new System.Drawing.Size(218, 91);
            this.gbx_Para.TabIndex = 0;
            this.gbx_Para.TabStop = false;
            this.gbx_Para.Text = "Paramètres retenus";
            this.gbx_Para.Visible = false;
            // 
            // textBox_Temp
            // 
            this.textBox_Temp.Location = new System.Drawing.Point(112, 55);
            this.textBox_Temp.Name = "textBox_Temp";
            this.textBox_Temp.ReadOnly = true;
            this.textBox_Temp.Size = new System.Drawing.Size(100, 20);
            this.textBox_Temp.TabIndex = 3;
            // 
            // textBox_Vtesse
            // 
            this.textBox_Vtesse.Location = new System.Drawing.Point(112, 29);
            this.textBox_Vtesse.Name = "textBox_Vtesse";
            this.textBox_Vtesse.ReadOnly = true;
            this.textBox_Vtesse.Size = new System.Drawing.Size(100, 20);
            this.textBox_Vtesse.TabIndex = 2;
            // 
            // lbl_Temp
            // 
            this.lbl_Temp.AutoSize = true;
            this.lbl_Temp.Location = new System.Drawing.Point(6, 62);
            this.lbl_Temp.Name = "lbl_Temp";
            this.lbl_Temp.Size = new System.Drawing.Size(73, 13);
            this.lbl_Temp.TabIndex = 1;
            this.lbl_Temp.Text = "Température :";
            // 
            // lbl_vitesse
            // 
            this.lbl_vitesse.AutoSize = true;
            this.lbl_vitesse.Location = new System.Drawing.Point(6, 36);
            this.lbl_vitesse.Name = "lbl_vitesse";
            this.lbl_vitesse.Size = new System.Drawing.Size(50, 13);
            this.lbl_vitesse.TabIndex = 0;
            this.lbl_vitesse.Text = "Vitesse : ";
            // 
            // btn_Exit
            // 
            this.btn_Exit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_Exit.Location = new System.Drawing.Point(236, 223);
            this.btn_Exit.Name = "btn_Exit";
            this.btn_Exit.Size = new System.Drawing.Size(75, 23);
            this.btn_Exit.TabIndex = 2;
            this.btn_Exit.Text = "Quitter";
            this.btn_Exit.UseVisualStyleBackColor = true;
            this.btn_Exit.Click += new System.EventHandler(this.btn_Exit_Click);
            // 
            // btn_Refresh
            // 
            this.btn_Refresh.Location = new System.Drawing.Point(236, 194);
            this.btn_Refresh.Name = "btn_Refresh";
            this.btn_Refresh.Size = new System.Drawing.Size(75, 23);
            this.btn_Refresh.TabIndex = 3;
            this.btn_Refresh.Text = "Rétablir";
            this.btn_Refresh.UseVisualStyleBackColor = true;
            this.btn_Refresh.Click += new System.EventHandler(this.btn_Refresh_Click);
            // 
            // btn_OK
            // 
            this.btn_OK.Location = new System.Drawing.Point(236, 165);
            this.btn_OK.Name = "btn_OK";
            this.btn_OK.Size = new System.Drawing.Size(75, 23);
            this.btn_OK.TabIndex = 4;
            this.btn_OK.Text = "OK";
            this.btn_OK.UseVisualStyleBackColor = true;
            this.btn_OK.Click += new System.EventHandler(this.btn_OK_Click);
            this.btn_OK.Enter += new System.EventHandler(this.btn_OK_Click);
            // 
            // lbl_Choose_Speed
            // 
            this.lbl_Choose_Speed.AutoSize = true;
            this.lbl_Choose_Speed.Location = new System.Drawing.Point(24, 21);
            this.lbl_Choose_Speed.Name = "lbl_Choose_Speed";
            this.lbl_Choose_Speed.Size = new System.Drawing.Size(104, 13);
            this.lbl_Choose_Speed.TabIndex = 5;
            this.lbl_Choose_Speed.Text = "Choisir une vitesse : ";
            // 
            // lbl_Choose_Temp
            // 
            this.lbl_Choose_Temp.AutoSize = true;
            this.lbl_Choose_Temp.Location = new System.Drawing.Point(24, 68);
            this.lbl_Choose_Temp.Name = "lbl_Choose_Temp";
            this.lbl_Choose_Temp.Size = new System.Drawing.Size(124, 13);
            this.lbl_Choose_Temp.TabIndex = 6;
            this.lbl_Choose_Temp.Text = "Choisir une température :";
            // 
            // cbx_speed
            // 
            this.cbx_speed.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbx_speed.FormattingEnabled = true;
            this.cbx_speed.Items.AddRange(new object[] {
            "100",
            "200",
            "300",
            "500"});
            this.cbx_speed.Location = new System.Drawing.Point(185, 21);
            this.cbx_speed.Name = "cbx_speed";
            this.cbx_speed.Size = new System.Drawing.Size(121, 21);
            this.cbx_speed.TabIndex = 7;
            this.cbx_speed.SelectedIndexChanged += new System.EventHandler(this.cbx_speed_SelectedIndexChanged);
            // 
            // cbx_Temp
            // 
            this.cbx_Temp.AutoCompleteCustomSource.AddRange(new string[] {
            "50",
            "80",
            "100"});
            this.cbx_Temp.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbx_Temp.FormattingEnabled = true;
            this.cbx_Temp.Items.AddRange(new object[] {
            "50",
            "80",
            "100"});
            this.cbx_Temp.Location = new System.Drawing.Point(185, 60);
            this.cbx_Temp.Name = "cbx_Temp";
            this.cbx_Temp.Size = new System.Drawing.Size(121, 21);
            this.cbx_Temp.TabIndex = 8;
            this.cbx_Temp.SelectedIndexChanged += new System.EventHandler(this.cbx_Temp_SelectedIndexChanged);
            // 
            // frmAppli2
            // 
            this.AcceptButton = this.btn_OK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btn_Exit;
            this.ClientSize = new System.Drawing.Size(318, 251);
            this.Controls.Add(this.cbx_Temp);
            this.Controls.Add(this.cbx_speed);
            this.Controls.Add(this.lbl_Choose_Temp);
            this.Controls.Add(this.lbl_Choose_Speed);
            this.Controls.Add(this.btn_OK);
            this.Controls.Add(this.btn_Refresh);
            this.Controls.Add(this.btn_Exit);
            this.Controls.Add(this.gbx_Para);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmAppli2";
            this.Text = "Paramètre de l\'analyseur";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Frm_Appli2_FormClosing);
            this.gbx_Para.ResumeLayout(false);
            this.gbx_Para.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbx_Para;
        private System.Windows.Forms.Button btn_Exit;
        private System.Windows.Forms.Button btn_Refresh;
        private System.Windows.Forms.Button btn_OK;
        private System.Windows.Forms.TextBox textBox_Temp;
        private System.Windows.Forms.TextBox textBox_Vtesse;
        private System.Windows.Forms.Label lbl_Temp;
        private System.Windows.Forms.Label lbl_vitesse;
        private System.Windows.Forms.Label lbl_Choose_Speed;
        private System.Windows.Forms.Label lbl_Choose_Temp;
        private System.Windows.Forms.ComboBox cbx_speed;
        private System.Windows.Forms.ComboBox cbx_Temp;
    }
}

