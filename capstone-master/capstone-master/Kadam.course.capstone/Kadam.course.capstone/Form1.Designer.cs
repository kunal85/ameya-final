namespace Kadam.course.capstone
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
            System.Windows.Forms.Label coursNOLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.Name = new System.Windows.Forms.TextBox();
            this.Number = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.Hybrid = new System.Windows.Forms.RadioButton();
            this.Number1 = new System.Windows.Forms.TextBox();
            this.Name1 = new System.Windows.Forms.TextBox();
            this.Date = new System.Windows.Forms.TextBox();
            this.Coursenumber = new System.Windows.Forms.TextBox();
            this.Type = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.online = new System.Windows.Forms.RadioButton();
            this.button1 = new System.Windows.Forms.Button();
            this.capstoneDataSet = new Kadam.course.capstone.CapstoneDataSet();
            this.numberBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.numberTableAdapter = new Kadam.course.capstone.CapstoneDataSetTableAdapters.NumberTableAdapter();
            this.tableAdapterManager = new Kadam.course.capstone.CapstoneDataSetTableAdapters.TableAdapterManager();
            this.numberBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.numberBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.coursNOTextBox = new System.Windows.Forms.TextBox();
            coursNOLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.capstoneDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numberBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numberBindingNavigator)).BeginInit();
            this.numberBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // coursNOLabel
            // 
            coursNOLabel.AutoSize = true;
            coursNOLabel.Location = new System.Drawing.Point(491, 291);
            coursNOLabel.Name = "coursNOLabel";
            coursNOLabel.Size = new System.Drawing.Size(56, 13);
            coursNOLabel.TabIndex = 26;
            coursNOLabel.Text = "Cours NO:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 15);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = " Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 114);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Start Date";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 61);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Number of courses";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(27, 207);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Type";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(27, 159);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Course Number";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(283, 61);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(96, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Number of courses";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(283, 15);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(38, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = " Name";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(283, 204);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(31, 13);
            this.label8.TabIndex = 7;
            this.label8.Text = "Type";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(283, 161);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(80, 13);
            this.label9.TabIndex = 8;
            this.label9.Text = "Course Number";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(283, 114);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(55, 13);
            this.label10.TabIndex = 9;
            this.label10.Text = "Start Date";
            // 
            // Name
            // 
            this.Name.Location = new System.Drawing.Point(176, 10);
            this.Name.Margin = new System.Windows.Forms.Padding(2);
            this.Name.Name = "Name";
            this.Name.Size = new System.Drawing.Size(76, 20);
            this.Name.TabIndex = 10;
            // 
            // Number
            // 
            this.Number.Location = new System.Drawing.Point(176, 57);
            this.Number.Margin = new System.Windows.Forms.Padding(2);
            this.Number.Name = "Number";
            this.Number.Size = new System.Drawing.Size(76, 20);
            this.Number.TabIndex = 11;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(100, 110);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(2);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(151, 20);
            this.dateTimePicker1.TabIndex = 12;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(160, 154);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(2);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(92, 21);
            this.comboBox1.TabIndex = 13;
            // 
            // Hybrid
            // 
            this.Hybrid.AutoSize = true;
            this.Hybrid.Checked = true;
            this.Hybrid.Location = new System.Drawing.Point(81, 206);
            this.Hybrid.Margin = new System.Windows.Forms.Padding(2);
            this.Hybrid.Name = "Hybrid";
            this.Hybrid.Size = new System.Drawing.Size(55, 17);
            this.Hybrid.TabIndex = 14;
            this.Hybrid.TabStop = true;
            this.Hybrid.Text = "Hybrid";
            this.Hybrid.UseVisualStyleBackColor = true;
            // 
            // Number1
            // 
            this.Number1.Location = new System.Drawing.Point(388, 61);
            this.Number1.Margin = new System.Windows.Forms.Padding(2);
            this.Number1.Name = "Number1";
            this.Number1.Size = new System.Drawing.Size(76, 20);
            this.Number1.TabIndex = 16;
            // 
            // Name1
            // 
            this.Name1.Location = new System.Drawing.Point(388, 12);
            this.Name1.Margin = new System.Windows.Forms.Padding(2);
            this.Name1.Name = "Name1";
            this.Name1.Size = new System.Drawing.Size(76, 20);
            this.Name1.TabIndex = 17;
            // 
            // Date
            // 
            this.Date.Location = new System.Drawing.Point(388, 111);
            this.Date.Margin = new System.Windows.Forms.Padding(2);
            this.Date.Name = "Date";
            this.Date.Size = new System.Drawing.Size(76, 20);
            this.Date.TabIndex = 18;
            // 
            // Coursenumber
            // 
            this.Coursenumber.Location = new System.Drawing.Point(388, 157);
            this.Coursenumber.Margin = new System.Windows.Forms.Padding(2);
            this.Coursenumber.Name = "Coursenumber";
            this.Coursenumber.Size = new System.Drawing.Size(76, 20);
            this.Coursenumber.TabIndex = 19;
            // 
            // Type
            // 
            this.Type.Location = new System.Drawing.Point(388, 202);
            this.Type.Margin = new System.Windows.Forms.Padding(2);
            this.Type.Name = "Type";
            this.Type.Size = new System.Drawing.Size(76, 20);
            this.Type.TabIndex = 20;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(309, 258);
            this.button2.Margin = new System.Windows.Forms.Padding(2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(106, 28);
            this.button2.TabIndex = 22;
            this.button2.Text = "Get";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(228, 315);
            this.button3.Margin = new System.Windows.Forms.Padding(2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(109, 28);
            this.button3.TabIndex = 23;
            this.button3.Text = "Exit";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // online
            // 
            this.online.AutoSize = true;
            this.online.Location = new System.Drawing.Point(142, 204);
            this.online.Margin = new System.Windows.Forms.Padding(2);
            this.online.Name = "online";
            this.online.Size = new System.Drawing.Size(53, 17);
            this.online.TabIndex = 24;
            this.online.TabStop = true;
            this.online.Text = "online";
            this.online.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(142, 258);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(116, 28);
            this.button1.TabIndex = 25;
            this.button1.Text = "Set";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // capstoneDataSet
            // 
            this.capstoneDataSet.DataSetName = "CapstoneDataSet";
            this.capstoneDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // numberBindingSource
            // 
            this.numberBindingSource.DataMember = "Number";
            this.numberBindingSource.DataSource = this.capstoneDataSet;
            // 
            // numberTableAdapter
            // 
            this.numberTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.NumberTableAdapter = this.numberTableAdapter;
            this.tableAdapterManager.UpdateOrder = Kadam.course.capstone.CapstoneDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // numberBindingNavigator
            // 
            this.numberBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.numberBindingNavigator.BindingSource = this.numberBindingSource;
            this.numberBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.numberBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.numberBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.bindingNavigatorDeleteItem,
            this.numberBindingNavigatorSaveItem});
            this.numberBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.numberBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.numberBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.numberBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.numberBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.numberBindingNavigator.Name = "numberBindingNavigator";
            this.numberBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.numberBindingNavigator.Size = new System.Drawing.Size(673, 25);
            this.numberBindingNavigator.TabIndex = 26;
            this.numberBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            this.bindingNavigatorMovePreviousItem.Click += new System.EventHandler(this.bindingNavigatorMovePreviousItem_Click);
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // numberBindingNavigatorSaveItem
            // 
            this.numberBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.numberBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("numberBindingNavigatorSaveItem.Image")));
            this.numberBindingNavigatorSaveItem.Name = "numberBindingNavigatorSaveItem";
            this.numberBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.numberBindingNavigatorSaveItem.Text = "Save Data";
            this.numberBindingNavigatorSaveItem.Click += new System.EventHandler(this.numberBindingNavigatorSaveItem_Click);
            // 
            // coursNOTextBox
            // 
            this.coursNOTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.numberBindingSource, "CoursNO", true));
            this.coursNOTextBox.Location = new System.Drawing.Point(553, 288);
            this.coursNOTextBox.Name = "coursNOTextBox";
            this.coursNOTextBox.Size = new System.Drawing.Size(100, 20);
            this.coursNOTextBox.TabIndex = 27;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(673, 366);
            this.Controls.Add(coursNOLabel);
            this.Controls.Add(this.coursNOTextBox);
            this.Controls.Add(this.numberBindingNavigator);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.online);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.Type);
            this.Controls.Add(this.Coursenumber);
            this.Controls.Add(this.Date);
            this.Controls.Add(this.Name1);
            this.Controls.Add(this.Number1);
            this.Controls.Add(this.Hybrid);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.Number);
            this.Controls.Add(this.Name);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2);
            //this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.capstoneDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numberBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numberBindingNavigator)).EndInit();
            this.numberBindingNavigator.ResumeLayout(false);
            this.numberBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox Name;
        private System.Windows.Forms.TextBox Number;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.RadioButton Hybrid;
        private System.Windows.Forms.TextBox Number1;
        private System.Windows.Forms.TextBox Name1;
        private System.Windows.Forms.TextBox Date;
        private System.Windows.Forms.TextBox Coursenumber;
        private System.Windows.Forms.TextBox Type;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.RadioButton online;
        private System.Windows.Forms.Button button1;
        private CapstoneDataSet capstoneDataSet;
        private System.Windows.Forms.BindingSource numberBindingSource;
        private CapstoneDataSetTableAdapters.NumberTableAdapter numberTableAdapter;
        private CapstoneDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator numberBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton numberBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox coursNOTextBox;
    }
}

