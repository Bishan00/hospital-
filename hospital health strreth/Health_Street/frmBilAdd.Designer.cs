namespace Health_Street
{
    partial class frmBilAdd
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBilAdd));
            this.elips = new Guna.UI.WinForms.GunaElipse(this.components);
            this.pnlTheme = new Guna.UI.WinForms.GunaPanel();
            this.btnClose = new Guna.UI.WinForms.GunaControlBox();
            this.gunaLabel18 = new Guna.UI.WinForms.GunaLabel();
            this.gunaGroupBox2 = new Guna.UI.WinForms.GunaGroupBox();
            this.gunaLabel15 = new Guna.UI.WinForms.GunaLabel();
            this.lblRelationship = new Guna.UI.WinForms.GunaLabel();
            this.lblTPnumber = new Guna.UI.WinForms.GunaLabel();
            this.lblAddress = new Guna.UI.WinForms.GunaLabel();
            this.lblNic = new Guna.UI.WinForms.GunaLabel();
            this.lblName = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel5 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel9 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel11 = new Guna.UI.WinForms.GunaLabel();
            this.btnPSave = new Guna.UI.WinForms.GunaAdvenceButton();
            this.gunaLabel12 = new Guna.UI.WinForms.GunaLabel();
            this.txtNic = new Guna.UI.WinForms.GunaTextBox();
            this.txtRelationship = new Guna.UI.WinForms.GunaTextBox();
            this.txtTpNumber = new Guna.UI.WinForms.GunaTextBox();
            this.txtAddress = new Guna.UI.WinForms.GunaTextBox();
            this.txtName = new Guna.UI.WinForms.GunaTextBox();
            this.gunaLabel13 = new Guna.UI.WinForms.GunaLabel();
            this.lblTime = new Guna.UI.WinForms.GunaLabel();
            this.lblDate = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel14 = new Guna.UI.WinForms.GunaLabel();
            this.tmrDateTime = new System.Windows.Forms.Timer(this.components);
            this.Animate = new Guna.UI.WinForms.GunaAnimateWindow(this.components);
            this.pnlTheme.SuspendLayout();
            this.gunaGroupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // elips
            // 
            this.elips.Radius = 0;
            this.elips.TargetControl = this;
            // 
            // pnlTheme
            // 
            this.pnlTheme.AutoScroll = true;
            this.pnlTheme.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnlTheme.BackgroundImage")));
            this.pnlTheme.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlTheme.Controls.Add(this.btnClose);
            this.pnlTheme.Controls.Add(this.gunaLabel18);
            this.pnlTheme.Controls.Add(this.gunaGroupBox2);
            this.pnlTheme.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlTheme.Location = new System.Drawing.Point(0, 0);
            this.pnlTheme.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pnlTheme.Name = "pnlTheme";
            this.pnlTheme.Size = new System.Drawing.Size(572, 640);
            this.pnlTheme.TabIndex = 0;
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.AnimationHoverSpeed = 0.07F;
            this.btnClose.AnimationSpeed = 0.03F;
            this.btnClose.IconColor = System.Drawing.Color.Black;
            this.btnClose.IconSize = 15F;
            this.btnClose.Location = new System.Drawing.Point(512, 0);
            this.btnClose.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnClose.Name = "btnClose";
            this.btnClose.OnHoverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(17)))), ((int)(((byte)(35)))));
            this.btnClose.OnHoverIconColor = System.Drawing.Color.White;
            this.btnClose.OnPressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(112)))), ((int)(((byte)(122)))));
            this.btnClose.Size = new System.Drawing.Size(59, 35);
            this.btnClose.TabIndex = 4;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // gunaLabel18
            // 
            this.gunaLabel18.AutoSize = true;
            this.gunaLabel18.Font = new System.Drawing.Font("Segoe UI", 30F, System.Drawing.FontStyle.Bold);
            this.gunaLabel18.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(96)))), ((int)(((byte)(104)))));
            this.gunaLabel18.Location = new System.Drawing.Point(11, 9);
            this.gunaLabel18.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.gunaLabel18.Name = "gunaLabel18";
            this.gunaLabel18.Size = new System.Drawing.Size(302, 54);
            this.gunaLabel18.TabIndex = 1;
            this.gunaLabel18.Text = "Add Guardians";
            // 
            // gunaGroupBox2
            // 
            this.gunaGroupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.gunaGroupBox2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.gunaGroupBox2.BaseColor = System.Drawing.Color.Transparent;
            this.gunaGroupBox2.BorderColor = System.Drawing.Color.Gainsboro;
            this.gunaGroupBox2.Controls.Add(this.gunaLabel15);
            this.gunaGroupBox2.Controls.Add(this.lblRelationship);
            this.gunaGroupBox2.Controls.Add(this.lblTPnumber);
            this.gunaGroupBox2.Controls.Add(this.lblAddress);
            this.gunaGroupBox2.Controls.Add(this.lblNic);
            this.gunaGroupBox2.Controls.Add(this.lblName);
            this.gunaGroupBox2.Controls.Add(this.gunaLabel5);
            this.gunaGroupBox2.Controls.Add(this.gunaLabel9);
            this.gunaGroupBox2.Controls.Add(this.gunaLabel11);
            this.gunaGroupBox2.Controls.Add(this.btnPSave);
            this.gunaGroupBox2.Controls.Add(this.gunaLabel12);
            this.gunaGroupBox2.Controls.Add(this.txtNic);
            this.gunaGroupBox2.Controls.Add(this.txtRelationship);
            this.gunaGroupBox2.Controls.Add(this.txtTpNumber);
            this.gunaGroupBox2.Controls.Add(this.txtAddress);
            this.gunaGroupBox2.Controls.Add(this.txtName);
            this.gunaGroupBox2.Controls.Add(this.gunaLabel13);
            this.gunaGroupBox2.Controls.Add(this.lblTime);
            this.gunaGroupBox2.Controls.Add(this.lblDate);
            this.gunaGroupBox2.Controls.Add(this.gunaLabel14);
            this.gunaGroupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaGroupBox2.ForeColor = System.Drawing.Color.White;
            this.gunaGroupBox2.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(144)))), ((int)(((byte)(156)))));
            this.gunaGroupBox2.LineTop = 40;
            this.gunaGroupBox2.Location = new System.Drawing.Point(32, 65);
            this.gunaGroupBox2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gunaGroupBox2.Name = "gunaGroupBox2";
            this.gunaGroupBox2.Size = new System.Drawing.Size(494, 446);
            this.gunaGroupBox2.TabIndex = 0;
            this.gunaGroupBox2.Text = "Guardian Details";
            this.gunaGroupBox2.TextLocation = new System.Drawing.Point(10, 8);
            // 
            // gunaLabel15
            // 
            this.gunaLabel15.AutoSize = true;
            this.gunaLabel15.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.gunaLabel15.ForeColor = System.Drawing.Color.DimGray;
            this.gunaLabel15.Location = new System.Drawing.Point(237, 199);
            this.gunaLabel15.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.gunaLabel15.Name = "gunaLabel15";
            this.gunaLabel15.Size = new System.Drawing.Size(91, 19);
            this.gunaLabel15.TabIndex = 1;
            this.gunaLabel15.Text = "Relationship";
            // 
            // lblRelationship
            // 
            this.lblRelationship.AutoSize = true;
            this.lblRelationship.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblRelationship.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(17)))), ((int)(((byte)(35)))));
            this.lblRelationship.Location = new System.Drawing.Point(248, 256);
            this.lblRelationship.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblRelationship.Name = "lblRelationship";
            this.lblRelationship.Size = new System.Drawing.Size(0, 15);
            this.lblRelationship.TabIndex = 6;
            // 
            // lblTPnumber
            // 
            this.lblTPnumber.AutoSize = true;
            this.lblTPnumber.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblTPnumber.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(17)))), ((int)(((byte)(35)))));
            this.lblTPnumber.Location = new System.Drawing.Point(16, 256);
            this.lblTPnumber.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTPnumber.Name = "lblTPnumber";
            this.lblTPnumber.Size = new System.Drawing.Size(0, 15);
            this.lblTPnumber.TabIndex = 6;
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblAddress.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(17)))), ((int)(((byte)(35)))));
            this.lblAddress.Location = new System.Drawing.Point(16, 184);
            this.lblAddress.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(0, 15);
            this.lblAddress.TabIndex = 6;
            // 
            // lblNic
            // 
            this.lblNic.AutoSize = true;
            this.lblNic.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblNic.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(17)))), ((int)(((byte)(35)))));
            this.lblNic.Location = new System.Drawing.Point(248, 114);
            this.lblNic.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNic.Name = "lblNic";
            this.lblNic.Size = new System.Drawing.Size(0, 15);
            this.lblNic.TabIndex = 6;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(17)))), ((int)(((byte)(35)))));
            this.lblName.Location = new System.Drawing.Point(16, 113);
            this.lblName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(0, 15);
            this.lblName.TabIndex = 6;
            // 
            // gunaLabel5
            // 
            this.gunaLabel5.AutoSize = true;
            this.gunaLabel5.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.gunaLabel5.ForeColor = System.Drawing.Color.DimGray;
            this.gunaLabel5.Location = new System.Drawing.Point(11, 201);
            this.gunaLabel5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.gunaLabel5.Name = "gunaLabel5";
            this.gunaLabel5.Size = new System.Drawing.Size(85, 19);
            this.gunaLabel5.TabIndex = 1;
            this.gunaLabel5.Text = "TP Number";
            // 
            // gunaLabel9
            // 
            this.gunaLabel9.AutoSize = true;
            this.gunaLabel9.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.gunaLabel9.ForeColor = System.Drawing.Color.DimGray;
            this.gunaLabel9.Location = new System.Drawing.Point(11, 128);
            this.gunaLabel9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.gunaLabel9.Name = "gunaLabel9";
            this.gunaLabel9.Size = new System.Drawing.Size(63, 19);
            this.gunaLabel9.TabIndex = 1;
            this.gunaLabel9.Text = "Address";
            // 
            // gunaLabel11
            // 
            this.gunaLabel11.AutoSize = true;
            this.gunaLabel11.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.gunaLabel11.ForeColor = System.Drawing.Color.DimGray;
            this.gunaLabel11.Location = new System.Drawing.Point(237, 58);
            this.gunaLabel11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.gunaLabel11.Name = "gunaLabel11";
            this.gunaLabel11.Size = new System.Drawing.Size(33, 19);
            this.gunaLabel11.TabIndex = 1;
            this.gunaLabel11.Text = "NIC";
            // 
            // btnPSave
            // 
            this.btnPSave.AnimationHoverSpeed = 0.07F;
            this.btnPSave.AnimationSpeed = 0.03F;
            this.btnPSave.BackColor = System.Drawing.Color.Transparent;
            this.btnPSave.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(144)))), ((int)(((byte)(156)))));
            this.btnPSave.BorderColor = System.Drawing.Color.Black;
            this.btnPSave.CheckedBaseColor = System.Drawing.Color.Gray;
            this.btnPSave.CheckedBorderColor = System.Drawing.Color.Black;
            this.btnPSave.CheckedForeColor = System.Drawing.Color.White;
            this.btnPSave.CheckedImage = null;
            this.btnPSave.CheckedLineColor = System.Drawing.Color.DimGray;
            this.btnPSave.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnPSave.FocusedColor = System.Drawing.Color.Empty;
            this.btnPSave.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnPSave.ForeColor = System.Drawing.Color.White;
            this.btnPSave.Image = null;
            this.btnPSave.ImageSize = new System.Drawing.Size(20, 20);
            this.btnPSave.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btnPSave.Location = new System.Drawing.Point(339, 375);
            this.btnPSave.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnPSave.Name = "btnPSave";
            this.btnPSave.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(96)))), ((int)(((byte)(104)))));
            this.btnPSave.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnPSave.OnHoverForeColor = System.Drawing.Color.White;
            this.btnPSave.OnHoverImage = null;
            this.btnPSave.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btnPSave.OnPressedColor = System.Drawing.Color.Black;
            this.btnPSave.Radius = 22;
            this.btnPSave.Size = new System.Drawing.Size(137, 58);
            this.btnPSave.TabIndex = 5;
            this.btnPSave.Text = "Save";
            this.btnPSave.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnPSave.Click += new System.EventHandler(this.btnPSave_Click);
            // 
            // gunaLabel12
            // 
            this.gunaLabel12.AutoSize = true;
            this.gunaLabel12.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.gunaLabel12.ForeColor = System.Drawing.Color.DimGray;
            this.gunaLabel12.Location = new System.Drawing.Point(11, 58);
            this.gunaLabel12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.gunaLabel12.Name = "gunaLabel12";
            this.gunaLabel12.Size = new System.Drawing.Size(49, 19);
            this.gunaLabel12.TabIndex = 1;
            this.gunaLabel12.Text = "Name";
            // 
            // txtNic
            // 
            this.txtNic.BaseColor = System.Drawing.Color.White;
            this.txtNic.BorderColor = System.Drawing.Color.Silver;
            this.txtNic.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNic.FocusedBaseColor = System.Drawing.Color.White;
            this.txtNic.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(96)))), ((int)(((byte)(104)))));
            this.txtNic.FocusedForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.txtNic.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtNic.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.txtNic.Location = new System.Drawing.Point(240, 79);
            this.txtNic.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtNic.Name = "txtNic";
            this.txtNic.PasswordChar = '\0';
            this.txtNic.SelectedText = "";
            this.txtNic.Size = new System.Drawing.Size(226, 32);
            this.txtNic.TabIndex = 0;
            this.txtNic.TextChanged += new System.EventHandler(this.txtNic_TextChanged);
            // 
            // txtRelationship
            // 
            this.txtRelationship.BaseColor = System.Drawing.Color.White;
            this.txtRelationship.BorderColor = System.Drawing.Color.Silver;
            this.txtRelationship.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtRelationship.FocusedBaseColor = System.Drawing.Color.White;
            this.txtRelationship.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(96)))), ((int)(((byte)(104)))));
            this.txtRelationship.FocusedForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.txtRelationship.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtRelationship.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.txtRelationship.Location = new System.Drawing.Point(241, 222);
            this.txtRelationship.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtRelationship.Name = "txtRelationship";
            this.txtRelationship.PasswordChar = '\0';
            this.txtRelationship.SelectedText = "";
            this.txtRelationship.Size = new System.Drawing.Size(226, 32);
            this.txtRelationship.TabIndex = 0;
            this.txtRelationship.TextChanged += new System.EventHandler(this.txtRelationship_TextChanged);
            // 
            // txtTpNumber
            // 
            this.txtTpNumber.BaseColor = System.Drawing.Color.White;
            this.txtTpNumber.BorderColor = System.Drawing.Color.Silver;
            this.txtTpNumber.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTpNumber.FocusedBaseColor = System.Drawing.Color.White;
            this.txtTpNumber.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(96)))), ((int)(((byte)(104)))));
            this.txtTpNumber.FocusedForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.txtTpNumber.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtTpNumber.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.txtTpNumber.Location = new System.Drawing.Point(14, 222);
            this.txtTpNumber.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtTpNumber.Name = "txtTpNumber";
            this.txtTpNumber.PasswordChar = '\0';
            this.txtTpNumber.SelectedText = "";
            this.txtTpNumber.Size = new System.Drawing.Size(208, 32);
            this.txtTpNumber.TabIndex = 0;
            this.txtTpNumber.TextChanged += new System.EventHandler(this.txtTpNumber_TextChanged);
            // 
            // txtAddress
            // 
            this.txtAddress.BaseColor = System.Drawing.Color.White;
            this.txtAddress.BorderColor = System.Drawing.Color.Silver;
            this.txtAddress.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtAddress.FocusedBaseColor = System.Drawing.Color.White;
            this.txtAddress.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(96)))), ((int)(((byte)(104)))));
            this.txtAddress.FocusedForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.txtAddress.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtAddress.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.txtAddress.Location = new System.Drawing.Point(14, 150);
            this.txtAddress.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.PasswordChar = '\0';
            this.txtAddress.SelectedText = "";
            this.txtAddress.Size = new System.Drawing.Size(452, 32);
            this.txtAddress.TabIndex = 0;
            this.txtAddress.TextChanged += new System.EventHandler(this.txtAddress_TextChanged);
            // 
            // txtName
            // 
            this.txtName.BaseColor = System.Drawing.Color.White;
            this.txtName.BorderColor = System.Drawing.Color.Silver;
            this.txtName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtName.FocusedBaseColor = System.Drawing.Color.White;
            this.txtName.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(96)))), ((int)(((byte)(104)))));
            this.txtName.FocusedForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.txtName.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtName.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.txtName.Location = new System.Drawing.Point(14, 79);
            this.txtName.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtName.Name = "txtName";
            this.txtName.PasswordChar = '\0';
            this.txtName.SelectedText = "";
            this.txtName.Size = new System.Drawing.Size(208, 32);
            this.txtName.TabIndex = 0;
            this.txtName.TextChanged += new System.EventHandler(this.txtName_TextChanged);
            // 
            // gunaLabel13
            // 
            this.gunaLabel13.AutoSize = true;
            this.gunaLabel13.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.gunaLabel13.ForeColor = System.Drawing.Color.DimGray;
            this.gunaLabel13.Location = new System.Drawing.Point(17, 282);
            this.gunaLabel13.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.gunaLabel13.Name = "gunaLabel13";
            this.gunaLabel13.Size = new System.Drawing.Size(44, 19);
            this.gunaLabel13.TabIndex = 1;
            this.gunaLabel13.Text = "Date:";
            this.gunaLabel13.Click += new System.EventHandler(this.gunaLabel13_Click);
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblTime.ForeColor = System.Drawing.Color.DimGray;
            this.lblTime.Location = new System.Drawing.Point(314, 307);
            this.lblTime.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(0, 19);
            this.lblTime.TabIndex = 1;
            this.lblTime.Click += new System.EventHandler(this.lblTime_Click);
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblDate.ForeColor = System.Drawing.Color.DimGray;
            this.lblDate.Location = new System.Drawing.Point(61, 307);
            this.lblDate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(0, 19);
            this.lblDate.TabIndex = 1;
            // 
            // gunaLabel14
            // 
            this.gunaLabel14.AutoSize = true;
            this.gunaLabel14.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.gunaLabel14.ForeColor = System.Drawing.Color.DimGray;
            this.gunaLabel14.Location = new System.Drawing.Point(268, 282);
            this.gunaLabel14.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.gunaLabel14.Name = "gunaLabel14";
            this.gunaLabel14.Size = new System.Drawing.Size(46, 19);
            this.gunaLabel14.TabIndex = 1;
            this.gunaLabel14.Text = "Time:";
            this.gunaLabel14.Click += new System.EventHandler(this.gunaLabel14_Click);
            // 
            // tmrDateTime
            // 
            this.tmrDateTime.Tick += new System.EventHandler(this.tmrDateTime_Tick);
            // 
            // Animate
            // 
            this.Animate.AnimationType = Guna.UI.WinForms.GunaAnimateWindow.AnimateWindowType.AW_HOR_POSITIVE;
            this.Animate.Interval = 800;
            this.Animate.TargetControl = this;
            // 
            // frmBilAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(572, 640);
            this.Controls.Add(this.pnlTheme);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "frmBilAdd";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmADAddmitPatient";
            this.Load += new System.EventHandler(this.frmADAddmitPatient_Load);
            this.pnlTheme.ResumeLayout(false);
            this.pnlTheme.PerformLayout();
            this.gunaGroupBox2.ResumeLayout(false);
            this.gunaGroupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI.WinForms.GunaElipse elips;
        private Guna.UI.WinForms.GunaPanel pnlTheme;
        private Guna.UI.WinForms.GunaGroupBox gunaGroupBox2;
        private Guna.UI.WinForms.GunaLabel gunaLabel5;
        private Guna.UI.WinForms.GunaLabel gunaLabel9;
        private Guna.UI.WinForms.GunaLabel gunaLabel11;
        private Guna.UI.WinForms.GunaLabel gunaLabel12;
        private Guna.UI.WinForms.GunaTextBox txtNic;
        private Guna.UI.WinForms.GunaTextBox txtName;
        private Guna.UI.WinForms.GunaLabel lblTime;
        private Guna.UI.WinForms.GunaLabel gunaLabel14;
        private Guna.UI.WinForms.GunaLabel gunaLabel13;
        private System.Windows.Forms.Timer tmrDateTime;
        private Guna.UI.WinForms.GunaLabel lblDate;
        private Guna.UI.WinForms.GunaAdvenceButton btnPSave;
        private Guna.UI.WinForms.GunaLabel gunaLabel15;
        private Guna.UI.WinForms.GunaTextBox txtRelationship;
        private Guna.UI.WinForms.GunaTextBox txtTpNumber;
        private Guna.UI.WinForms.GunaTextBox txtAddress;
        private Guna.UI.WinForms.GunaLabel lblRelationship;
        private Guna.UI.WinForms.GunaLabel lblTPnumber;
        private Guna.UI.WinForms.GunaLabel lblAddress;
        private Guna.UI.WinForms.GunaLabel lblNic;
        private Guna.UI.WinForms.GunaLabel lblName;
        private Guna.UI.WinForms.GunaAnimateWindow Animate;
        private Guna.UI.WinForms.GunaLabel gunaLabel18;
        private Guna.UI.WinForms.GunaControlBox btnClose;
    }
}