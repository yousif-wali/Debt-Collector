﻿namespace DebtCalculator
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
            Data = new DataGridView();
            Insert = new Button();
            InputName = new TextBox();
            ناو = new Label();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            InputPhone = new TextBox();
            InputAddress = new TextBox();
            InputBalance = new TextBox();
            Delete = new Button();
            InputSearch = new TextBox();
            Search = new Button();
            Refresh = new Button();
            ((System.ComponentModel.ISupportInitialize)Data).BeginInit();
            SuspendLayout();
            // 
            // Data
            // 
            Data.AllowUserToAddRows = false;
            Data.AllowUserToDeleteRows = false;
            Data.AllowUserToOrderColumns = true;
            Data.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            Data.Location = new Point(12, 12);
            Data.Name = "Data";
            Data.ReadOnly = true;
            Data.Size = new Size(570, 266);
            Data.TabIndex = 0;
            Data.CellClick += Data_CellClick;
            // 
            // Insert
            // 
            Insert.Location = new Point(588, 241);
            Insert.Name = "Insert";
            Insert.Size = new Size(88, 37);
            Insert.TabIndex = 1;
            Insert.Text = "داخلکردن";
            Insert.UseVisualStyleBackColor = true;
            Insert.Click += Insert_Click;
            // 
            // InputName
            // 
            InputName.Location = new Point(588, 57);
            InputName.Name = "InputName";
            InputName.Size = new Size(189, 23);
            InputName.TabIndex = 2;
            // 
            // ناو
            // 
            ناو.AutoSize = true;
            ناو.Location = new Point(846, 60);
            ناو.Name = "ناو";
            ناو.RightToLeft = RightToLeft.Yes;
            ناو.Size = new Size(20, 15);
            ناو.TabIndex = 3;
            ناو.Text = "ناو";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(785, 103);
            label1.Name = "label1";
            label1.Size = new Size(81, 15);
            label1.TabIndex = 4;
            label1.Text = "ژمارەی مووبایل";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(811, 145);
            label2.Name = "label2";
            label2.Size = new Size(55, 15);
            label2.TabIndex = 5;
            label2.Text = "ناوونیشان";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(827, 185);
            label3.Name = "label3";
            label3.Size = new Size(39, 15);
            label3.TabIndex = 6;
            label3.Text = "باڵانس";
            // 
            // InputPhone
            // 
            InputPhone.Location = new Point(588, 100);
            InputPhone.Name = "InputPhone";
            InputPhone.Size = new Size(189, 23);
            InputPhone.TabIndex = 7;
            // 
            // InputAddress
            // 
            InputAddress.Location = new Point(588, 142);
            InputAddress.Name = "InputAddress";
            InputAddress.Size = new Size(189, 23);
            InputAddress.TabIndex = 8;
            // 
            // InputBalance
            // 
            InputBalance.Location = new Point(588, 182);
            InputBalance.Name = "InputBalance";
            InputBalance.Size = new Size(189, 23);
            InputBalance.TabIndex = 9;
            // 
            // Delete
            // 
            Delete.Location = new Point(682, 241);
            Delete.Name = "Delete";
            Delete.Size = new Size(88, 37);
            Delete.TabIndex = 10;
            Delete.Text = "سڕینەوە";
            Delete.UseVisualStyleBackColor = true;
            Delete.Click += Delete_Click;
            // 
            // InputSearch
            // 
            InputSearch.Location = new Point(12, 311);
            InputSearch.Name = "InputSearch";
            InputSearch.Size = new Size(189, 23);
            InputSearch.TabIndex = 11;
            // 
            // Search
            // 
            Search.Location = new Point(220, 303);
            Search.Name = "Search";
            Search.Size = new Size(88, 37);
            Search.TabIndex = 12;
            Search.Text = "گەڕان";
            Search.UseVisualStyleBackColor = true;
            Search.Click += Search_Click;
            // 
            // Refresh
            // 
            Refresh.Location = new Point(588, 12);
            Refresh.Name = "Refresh";
            Refresh.Size = new Size(88, 37);
            Refresh.TabIndex = 13;
            Refresh.Text = "نوێ کردنەوە";
            Refresh.UseVisualStyleBackColor = true;
            Refresh.Click += Refresh_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(878, 477);
            Controls.Add(Refresh);
            Controls.Add(Search);
            Controls.Add(InputSearch);
            Controls.Add(Delete);
            Controls.Add(InputBalance);
            Controls.Add(InputAddress);
            Controls.Add(InputPhone);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(ناو);
            Controls.Add(InputName);
            Controls.Add(Insert);
            Controls.Add(Data);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)Data).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView Data;
        private Button Insert;
        private TextBox InputName;
        private Label ناو;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox InputPhone;
        private TextBox InputAddress;
        private TextBox InputBalance;
        private Button Delete;
        private TextBox InputSearch;
        private Button Search;
        private Button Refresh;
    }
}
