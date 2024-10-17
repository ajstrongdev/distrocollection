namespace DistroCollection
{
    partial class Form1
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
            tblLayout = new TableLayoutPanel();
            flwLayoutTop = new FlowLayoutPanel();
            btnView = new Button();
            btnAdd = new Button();
            btnDelete = new Button();
            btnHome = new Button();
            lbxDistributions = new ListBox();
            lblDistributions = new Label();
            rtbxInfo = new RichTextBox();
            tbxInput = new TextBox();
            btnSubmit = new Button();
            tblLayout.SuspendLayout();
            flwLayoutTop.SuspendLayout();
            SuspendLayout();
            // 
            // tblLayout
            // 
            tblLayout.ColumnCount = 2;
            tblLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 91.2653046F));
            tblLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 132F));
            tblLayout.Controls.Add(flwLayoutTop, 0, 0);
            tblLayout.Controls.Add(lbxDistributions, 1, 1);
            tblLayout.Controls.Add(lblDistributions, 1, 0);
            tblLayout.Controls.Add(rtbxInfo, 0, 1);
            tblLayout.Controls.Add(tbxInput, 0, 2);
            tblLayout.Controls.Add(btnSubmit, 1, 2);
            tblLayout.Dock = DockStyle.Fill;
            tblLayout.Location = new Point(0, 0);
            tblLayout.Name = "tblLayout";
            tblLayout.RowCount = 3;
            tblLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 12.7049179F));
            tblLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 87.29508F));
            tblLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 66F));
            tblLayout.Size = new Size(1225, 555);
            tblLayout.TabIndex = 0;
            // 
            // flwLayoutTop
            // 
            flwLayoutTop.Controls.Add(btnView);
            flwLayoutTop.Controls.Add(btnAdd);
            flwLayoutTop.Controls.Add(btnDelete);
            flwLayoutTop.Controls.Add(btnHome);
            flwLayoutTop.Dock = DockStyle.Fill;
            flwLayoutTop.Location = new Point(3, 3);
            flwLayoutTop.Name = "flwLayoutTop";
            flwLayoutTop.Size = new Size(1087, 56);
            flwLayoutTop.TabIndex = 0;
            // 
            // btnView
            // 
            btnView.Location = new Point(3, 3);
            btnView.Name = "btnView";
            btnView.Size = new Size(94, 49);
            btnView.TabIndex = 0;
            btnView.Text = "View";
            btnView.UseVisualStyleBackColor = true;
            btnView.Click += btnView_Click;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(103, 3);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(94, 49);
            btnAdd.TabIndex = 1;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(203, 3);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(94, 49);
            btnDelete.TabIndex = 2;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnHome
            // 
            btnHome.Location = new Point(303, 3);
            btnHome.Name = "btnHome";
            btnHome.Size = new Size(94, 49);
            btnHome.TabIndex = 3;
            btnHome.Text = "Home";
            btnHome.UseVisualStyleBackColor = true;
            btnHome.Click += btnHome_Click;
            // 
            // lbxDistributions
            // 
            lbxDistributions.Dock = DockStyle.Fill;
            lbxDistributions.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbxDistributions.FormattingEnabled = true;
            lbxDistributions.ItemHeight = 28;
            lbxDistributions.Location = new Point(1096, 65);
            lbxDistributions.Name = "lbxDistributions";
            lbxDistributions.Size = new Size(126, 420);
            lbxDistributions.TabIndex = 3;
            // 
            // lblDistributions
            // 
            lblDistributions.Anchor = AnchorStyles.None;
            lblDistributions.AutoSize = true;
            lblDistributions.Font = new Font("Segoe UI", 12F);
            lblDistributions.Location = new Point(1097, 17);
            lblDistributions.Name = "lblDistributions";
            lblDistributions.Size = new Size(124, 28);
            lblDistributions.TabIndex = 4;
            lblDistributions.Text = "Distributions";
            // 
            // rtbxInfo
            // 
            rtbxInfo.BackColor = SystemColors.Window;
            rtbxInfo.BorderStyle = BorderStyle.None;
            rtbxInfo.Dock = DockStyle.Fill;
            rtbxInfo.Font = new Font("Segoe UI", 18F);
            rtbxInfo.Location = new Point(3, 65);
            rtbxInfo.Name = "rtbxInfo";
            rtbxInfo.ReadOnly = true;
            rtbxInfo.Size = new Size(1087, 420);
            rtbxInfo.TabIndex = 5;
            rtbxInfo.Text = "";
            // 
            // tbxInput
            // 
            tbxInput.BorderStyle = BorderStyle.None;
            tbxInput.Dock = DockStyle.Fill;
            tbxInput.Font = new Font("Segoe UI", 24F);
            tbxInput.Location = new Point(3, 491);
            tbxInput.Name = "tbxInput";
            tbxInput.Size = new Size(1087, 54);
            tbxInput.TabIndex = 6;
            tbxInput.KeyDown += tbxInput_KeyDown;
            // 
            // btnSubmit
            // 
            btnSubmit.Dock = DockStyle.Fill;
            btnSubmit.Font = new Font("Segoe UI", 12F);
            btnSubmit.Location = new Point(1096, 491);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.Size = new Size(126, 61);
            btnSubmit.TabIndex = 7;
            btnSubmit.Text = "Submit";
            btnSubmit.UseVisualStyleBackColor = true;
            btnSubmit.Click += btnSubmit_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1225, 555);
            Controls.Add(tblLayout);
            Name = "Form1";
            Text = "DistroCollection";
            Load += Form1_Load;
            tblLayout.ResumeLayout(false);
            tblLayout.PerformLayout();
            flwLayoutTop.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tblLayout;
        private FlowLayoutPanel flwLayoutTop;
        private ListBox lbxDistributions;
        private Label lblDistributions;
        private Button btnView;
        private Button btnAdd;
        private Button btnDelete;
        private RichTextBox rtbxInfo;
        private TextBox tbxInput;
        private Button btnSubmit;
        private Button btnHome;
    }
}
