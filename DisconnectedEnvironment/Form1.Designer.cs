﻿namespace DisconnectedEnvironment
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.bindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCode = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.txtState = new System.Windows.Forms.TextBox();
            this.txtCountry = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.cbDepartment = new System.Windows.Forms.ComboBox();
            this.cbDesignation = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmdAdd = new System.Windows.Forms.Button();
            this.cmdSave = new System.Windows.Forms.Button();
            this.cmdDelete = new System.Windows.Forms.Button();
            this.hRDataSet = new DisconnectedEnvironment.HRDataSet();
            this.empdetailsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.empdetailsTableAdapter = new DisconnectedEnvironment.HRDataSetTableAdapters.empdetailsTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator)).BeginInit();
            this.bindingNavigator.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.hRDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.empdetailsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // bindingNavigator
            // 
            this.bindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.bindingNavigator.BindingSource = this.empdetailsBindingSource;
            this.bindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.bindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.bindingNavigator.Dock = System.Windows.Forms.DockStyle.None;
            this.bindingNavigator.Font = new System.Drawing.Font("HelveticaNowDisplay Regular", 7.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bindingNavigator.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.bindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem});
            this.bindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.bindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.bindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.bindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.bindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.bindingNavigator.Name = "bindingNavigator";
            this.bindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.bindingNavigator.Size = new System.Drawing.Size(343, 33);
            this.bindingNavigator.TabIndex = 15;
            this.bindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(34, 28);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Font = new System.Drawing.Font("HelveticaNowDisplay Regular", 8F);
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(49, 28);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(34, 28);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(34, 28);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(34, 28);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 33);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("HelveticaNowDisplay Regular", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 27);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 33);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(34, 28);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(34, 28);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 33);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AutoSize = true;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 240F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.txtCode, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.txtName, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.txtAddress, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.txtState, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.txtCountry, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.label4, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.label5, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.label6, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.label7, 0, 6);
            this.tableLayoutPanel1.Controls.Add(this.cbDepartment, 1, 6);
            this.tableLayoutPanel1.Controls.Add(this.cbDesignation, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(13, 48);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 7;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 44F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 45F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 47F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 46F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 49F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 51F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(369, 332);
            this.tableLayoutPanel1.TabIndex = 16;
            this.tableLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel1_Paint);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("HelveticaNowDisplay Regular", 8F);
            this.label2.Location = new System.Drawing.Point(3, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "Employee Name";
            // 
            // txtCode
            // 
            this.txtCode.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtCode.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.empdetailsBindingSource, "ccode", true));
            this.txtCode.Font = new System.Drawing.Font("HelveticaNowDisplay Regular", 8F);
            this.txtCode.Location = new System.Drawing.Point(132, 11);
            this.txtCode.Name = "txtCode";
            this.txtCode.Size = new System.Drawing.Size(233, 27);
            this.txtCode.TabIndex = 2;
            // 
            // txtName
            // 
            this.txtName.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtName.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.empdetailsBindingSource, "cname", true));
            this.txtName.Font = new System.Drawing.Font("HelveticaNowDisplay Regular", 8F);
            this.txtName.Location = new System.Drawing.Point(132, 58);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(233, 27);
            this.txtName.TabIndex = 3;
            // 
            // txtAddress
            // 
            this.txtAddress.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtAddress.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.empdetailsBindingSource, "caddress", true));
            this.txtAddress.Font = new System.Drawing.Font("HelveticaNowDisplay Regular", 8F);
            this.txtAddress.Location = new System.Drawing.Point(132, 103);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(233, 27);
            this.txtAddress.TabIndex = 4;
            // 
            // txtState
            // 
            this.txtState.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtState.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.empdetailsBindingSource, "cstate", true));
            this.txtState.Font = new System.Drawing.Font("HelveticaNowDisplay Regular", 8F);
            this.txtState.Location = new System.Drawing.Point(132, 149);
            this.txtState.Name = "txtState";
            this.txtState.Size = new System.Drawing.Size(233, 27);
            this.txtState.TabIndex = 5;
            // 
            // txtCountry
            // 
            this.txtCountry.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtCountry.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.empdetailsBindingSource, "ccountry", true));
            this.txtCountry.Font = new System.Drawing.Font("HelveticaNowDisplay Regular", 8F);
            this.txtCountry.Location = new System.Drawing.Point(132, 195);
            this.txtCountry.Name = "txtCountry";
            this.txtCountry.Size = new System.Drawing.Size(233, 27);
            this.txtCountry.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("HelveticaNowDisplay Regular", 8F);
            this.label3.Location = new System.Drawing.Point(3, 104);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 24);
            this.label3.TabIndex = 9;
            this.label3.Text = "Address";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("HelveticaNowDisplay Regular", 8F);
            this.label4.Location = new System.Drawing.Point(3, 150);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 24);
            this.label4.TabIndex = 10;
            this.label4.Text = "State";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("HelveticaNowDisplay Regular", 8F);
            this.label5.Location = new System.Drawing.Point(3, 197);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 24);
            this.label5.TabIndex = 11;
            this.label5.Text = "Country";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("HelveticaNowDisplay Regular", 8F);
            this.label6.Location = new System.Drawing.Point(3, 244);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(92, 24);
            this.label6.TabIndex = 12;
            this.label6.Text = "Designation";
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("HelveticaNowDisplay Regular", 8F);
            this.label7.Location = new System.Drawing.Point(3, 294);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(94, 24);
            this.label7.TabIndex = 13;
            this.label7.Text = "Department";
            // 
            // cbDepartment
            // 
            this.cbDepartment.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.cbDepartment.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.empdetailsBindingSource, "cDepartment", true));
            this.cbDepartment.Font = new System.Drawing.Font("HelveticaNowDisplay Regular", 8F);
            this.cbDepartment.FormattingEnabled = true;
            this.cbDepartment.Location = new System.Drawing.Point(132, 290);
            this.cbDepartment.Name = "cbDepartment";
            this.cbDepartment.Size = new System.Drawing.Size(233, 32);
            this.cbDepartment.TabIndex = 14;
            // 
            // cbDesignation
            // 
            this.cbDesignation.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.cbDesignation.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.empdetailsBindingSource, "cDesignation", true));
            this.cbDesignation.Font = new System.Drawing.Font("HelveticaNowDisplay Regular", 8F);
            this.cbDesignation.FormattingEnabled = true;
            this.cbDesignation.Location = new System.Drawing.Point(132, 240);
            this.cbDesignation.Name = "cbDesignation";
            this.cbDesignation.Size = new System.Drawing.Size(233, 32);
            this.cbDesignation.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("HelveticaNowDisplay Regular", 8F);
            this.label1.Location = new System.Drawing.Point(3, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Employee Code";
            // 
            // cmdAdd
            // 
            this.cmdAdd.AutoSize = true;
            this.cmdAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmdAdd.FlatAppearance.BorderSize = 0;
            this.cmdAdd.Font = new System.Drawing.Font("HelveticaNowDisplay Regular", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdAdd.Location = new System.Drawing.Point(400, 58);
            this.cmdAdd.Name = "cmdAdd";
            this.cmdAdd.Size = new System.Drawing.Size(108, 36);
            this.cmdAdd.TabIndex = 17;
            this.cmdAdd.Text = "Add";
            this.cmdAdd.UseVisualStyleBackColor = true;
            this.cmdAdd.Click += new System.EventHandler(this.cmdAdd_Click);
            // 
            // cmdSave
            // 
            this.cmdSave.AutoSize = true;
            this.cmdSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmdSave.FlatAppearance.BorderSize = 0;
            this.cmdSave.Font = new System.Drawing.Font("HelveticaNowDisplay Regular", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdSave.Location = new System.Drawing.Point(400, 116);
            this.cmdSave.Name = "cmdSave";
            this.cmdSave.Size = new System.Drawing.Size(108, 36);
            this.cmdSave.TabIndex = 18;
            this.cmdSave.Text = "Save";
            this.cmdSave.UseVisualStyleBackColor = true;
            this.cmdSave.Click += new System.EventHandler(this.cmdSave_Click);
            // 
            // cmdDelete
            // 
            this.cmdDelete.AutoSize = true;
            this.cmdDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmdDelete.FlatAppearance.BorderSize = 0;
            this.cmdDelete.Font = new System.Drawing.Font("HelveticaNowDisplay Regular", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdDelete.Location = new System.Drawing.Point(400, 174);
            this.cmdDelete.Name = "cmdDelete";
            this.cmdDelete.Size = new System.Drawing.Size(108, 36);
            this.cmdDelete.TabIndex = 19;
            this.cmdDelete.Text = "Delete";
            this.cmdDelete.UseVisualStyleBackColor = true;
            this.cmdDelete.Click += new System.EventHandler(this.cmdDelete_Click);
            // 
            // hRDataSet
            // 
            this.hRDataSet.DataSetName = "HRDataSet";
            this.hRDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // empdetailsBindingSource
            // 
            this.empdetailsBindingSource.DataMember = "empdetails";
            this.empdetailsBindingSource.DataSource = this.hRDataSet;
            // 
            // empdetailsTableAdapter
            // 
            this.empdetailsTableAdapter.ClearBeforeFill = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(528, 394);
            this.Controls.Add(this.cmdDelete);
            this.Controls.Add(this.cmdSave);
            this.Controls.Add(this.cmdAdd);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.bindingNavigator);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Employee Details";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator)).EndInit();
            this.bindingNavigator.ResumeLayout(false);
            this.bindingNavigator.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.hRDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.empdetailsBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingNavigator bindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCode;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.TextBox txtState;
        private System.Windows.Forms.TextBox txtCountry;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cbDepartment;
        private System.Windows.Forms.ComboBox cbDesignation;
        private System.Windows.Forms.Button cmdAdd;
        private System.Windows.Forms.Button cmdSave;
        private System.Windows.Forms.Button cmdDelete;
        private HRDataSet hRDataSet;
        private System.Windows.Forms.BindingSource empdetailsBindingSource;
        private HRDataSetTableAdapters.empdetailsTableAdapter empdetailsTableAdapter;
    }
}

