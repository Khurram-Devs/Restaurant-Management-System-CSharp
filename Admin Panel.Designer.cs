namespace Admin_Panel_Assignment
{
    partial class Admin_Panel
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle19 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle20 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle21 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Admin_Panel));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.food_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.food_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.food_price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.food_quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.foodlistBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.foodpandaDataSet1 = new Admin_Panel_Assignment.foodpandaDataSet1();
            this.foodlistBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.foodpandaDataSet = new Admin_Panel_Assignment.foodpandaDataSet();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.button4 = new System.Windows.Forms.Button();
            this.foodlistTableAdapter = new Admin_Panel_Assignment.foodpandaDataSetTableAdapters.foodlistTableAdapter();
            this.label2 = new System.Windows.Forms.Label();
            this.foodpandaDataList = new Admin_Panel_Assignment.FoodpandaDataList();
            this.foodlistBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.foodlistTableAdapter1 = new Admin_Panel_Assignment.FoodpandaDataListTableAdapters.foodlistTableAdapter();
            this.foodlistTableAdapter2 = new Admin_Panel_Assignment.foodpandaDataSet1TableAdapters.foodlistTableAdapter();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.foodlistBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.foodpandaDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.foodlistBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.foodpandaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.foodpandaDataList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.foodlistBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.LightCoral;
            this.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle19.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle19.BackColor = System.Drawing.Color.Salmon;
            dataGridViewCellStyle19.Font = new System.Drawing.Font("Rockwell", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle19.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle19.Padding = new System.Windows.Forms.Padding(5);
            dataGridViewCellStyle19.SelectionBackColor = System.Drawing.Color.Firebrick;
            dataGridViewCellStyle19.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle19.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle19;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.food_ID,
            this.food_name,
            this.food_price,
            this.food_quantity});
            this.dataGridView1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dataGridView1.DataSource = this.foodlistBindingSource2;
            dataGridViewCellStyle20.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle20.BackColor = System.Drawing.Color.LightCoral;
            dataGridViewCellStyle20.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle20.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle20.Padding = new System.Windows.Forms.Padding(5);
            dataGridViewCellStyle20.SelectionBackColor = System.Drawing.Color.Brown;
            dataGridViewCellStyle20.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle20.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle20;
            this.dataGridView1.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridView1.GridColor = System.Drawing.Color.DarkRed;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            dataGridViewCellStyle21.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle21.BackColor = System.Drawing.Color.MistyRose;
            dataGridViewCellStyle21.Font = new System.Drawing.Font("Rockwell", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle21.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle21.Padding = new System.Windows.Forms.Padding(10);
            dataGridViewCellStyle21.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle21.SelectionForeColor = System.Drawing.Color.White;
            this.dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle21;
            this.dataGridView1.RowTemplate.Height = 50;
            this.dataGridView1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridView1.Size = new System.Drawing.Size(606, 501);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // food_ID
            // 
            this.food_ID.DataPropertyName = "food_ID";
            this.food_ID.HeaderText = "food_ID";
            this.food_ID.Name = "food_ID";
            this.food_ID.ReadOnly = true;
            this.food_ID.Visible = false;
            // 
            // food_name
            // 
            this.food_name.DataPropertyName = "food_name";
            this.food_name.HeaderText = "ITEM NAME";
            this.food_name.MinimumWidth = 200;
            this.food_name.Name = "food_name";
            this.food_name.Width = 200;
            // 
            // food_price
            // 
            this.food_price.DataPropertyName = "food_price";
            this.food_price.HeaderText = "PRICE";
            this.food_price.MinimumWidth = 200;
            this.food_price.Name = "food_price";
            this.food_price.Width = 200;
            // 
            // food_quantity
            // 
            this.food_quantity.DataPropertyName = "food_quantity";
            this.food_quantity.HeaderText = "QUANTITY";
            this.food_quantity.MinimumWidth = 200;
            this.food_quantity.Name = "food_quantity";
            this.food_quantity.Width = 200;
            // 
            // foodlistBindingSource2
            // 
            this.foodlistBindingSource2.DataMember = "foodlist";
            this.foodlistBindingSource2.DataSource = this.foodpandaDataSet1;
            // 
            // foodpandaDataSet1
            // 
            this.foodpandaDataSet1.DataSetName = "foodpandaDataSet1";
            this.foodpandaDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // foodlistBindingSource
            // 
            this.foodlistBindingSource.DataMember = "foodlist";
            this.foodlistBindingSource.DataSource = this.foodpandaDataSet;
            // 
            // foodpandaDataSet
            // 
            this.foodpandaDataSet.DataSetName = "foodpandaDataSet";
            this.foodpandaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Firebrick;
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(633, 397);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(270, 47);
            this.button2.TabIndex = 1;
            this.button2.Text = "DELETE ITEM";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Firebrick;
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(633, 291);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(270, 47);
            this.button3.TabIndex = 2;
            this.button3.Text = "INSERT ITEM";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox1.Font = new System.Drawing.Font("Rockwell", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(633, 137);
            this.textBox1.MaximumSize = new System.Drawing.Size(270, 39);
            this.textBox1.MinimumSize = new System.Drawing.Size(270, 39);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(270, 39);
            this.textBox1.TabIndex = 3;
            // 
            // textBox2
            // 
            this.textBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox2.Font = new System.Drawing.Font("Rockwell", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(633, 182);
            this.textBox2.MaximumSize = new System.Drawing.Size(270, 39);
            this.textBox2.MinimumSize = new System.Drawing.Size(270, 39);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(270, 39);
            this.textBox2.TabIndex = 3;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Firebrick;
            this.button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.Color.White;
            this.button4.Location = new System.Drawing.Point(633, 344);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(270, 47);
            this.button4.TabIndex = 4;
            this.button4.Text = "UPDATE ITEM";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // foodlistTableAdapter
            // 
            this.foodlistTableAdapter.ClearBeforeFill = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Rockwell Extra Bold", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DarkRed;
            this.label2.Location = new System.Drawing.Point(666, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(215, 37);
            this.label2.TabIndex = 6;
            this.label2.Text = "MENU LIST";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // foodpandaDataList
            // 
            this.foodpandaDataList.DataSetName = "FoodpandaDataList";
            this.foodpandaDataList.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // foodlistBindingSource1
            // 
            this.foodlistBindingSource1.DataMember = "foodlist";
            this.foodlistBindingSource1.DataSource = this.foodpandaDataList;
            // 
            // foodlistTableAdapter1
            // 
            this.foodlistTableAdapter1.ClearBeforeFill = true;
            // 
            // foodlistTableAdapter2
            // 
            this.foodlistTableAdapter2.ClearBeforeFill = true;
            // 
            // textBox3
            // 
            this.textBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox3.Font = new System.Drawing.Font("Rockwell", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox3.Location = new System.Drawing.Point(633, 227);
            this.textBox3.MaximumSize = new System.Drawing.Size(270, 39);
            this.textBox3.MinimumSize = new System.Drawing.Size(270, 39);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(270, 39);
            this.textBox3.TabIndex = 7;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(633, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(270, 70);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Firebrick;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(716, 464);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(102, 47);
            this.button1.TabIndex = 9;
            this.button1.Text = "BACK";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // Admin_Panel
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.IndianRed;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(912, 523);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Admin_Panel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "KABABJEES ADMIN";
            this.Load += new System.EventHandler(this.Admin_Panel_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.foodlistBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.foodpandaDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.foodlistBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.foodpandaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.foodpandaDataList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.foodlistBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button button4;
        private foodpandaDataSet foodpandaDataSet;
        private System.Windows.Forms.BindingSource foodlistBindingSource;
        private foodpandaDataSetTableAdapters.foodlistTableAdapter foodlistTableAdapter;
        private System.Windows.Forms.Label label2;
        private FoodpandaDataList foodpandaDataList;
        private System.Windows.Forms.BindingSource foodlistBindingSource1;
        private FoodpandaDataListTableAdapters.foodlistTableAdapter foodlistTableAdapter1;
        private foodpandaDataSet1 foodpandaDataSet1;
        private System.Windows.Forms.BindingSource foodlistBindingSource2;
        private foodpandaDataSet1TableAdapters.foodlistTableAdapter foodlistTableAdapter2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.DataGridViewTextBoxColumn food_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn food_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn food_price;
        private System.Windows.Forms.DataGridViewTextBoxColumn food_quantity;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button1;
    }
}