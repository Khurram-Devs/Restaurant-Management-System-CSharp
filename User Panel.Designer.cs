namespace Admin_Panel_Assignment
{
    partial class User_Panel
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(User_Panel));
            this.foodpandaDataSet2 = new Admin_Panel_Assignment.foodpandaDataSet2();
            this.foodlistBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.foodlistTableAdapter = new Admin_Panel_Assignment.foodpandaDataSet2TableAdapters.foodlistTableAdapter();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.foodIDDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.food_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.food_price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.food_quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.foodpandaDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.foodlistBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // foodpandaDataSet2
            // 
            this.foodpandaDataSet2.DataSetName = "foodpandaDataSet2";
            this.foodpandaDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // foodlistBindingSource
            // 
            this.foodlistBindingSource.DataMember = "foodlist";
            this.foodlistBindingSource.DataSource = this.foodpandaDataSet2;
            // 
            // foodlistTableAdapter
            // 
            this.foodlistTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToResizeColumns = false;
            this.dataGridView2.AllowUserToResizeRows = false;
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.BackgroundColor = System.Drawing.Color.LightCoral;
            this.dataGridView2.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Salmon;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Rockwell", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(5);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Firebrick;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView2.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.foodIDDataGridViewTextBoxColumn1,
            this.food_name,
            this.food_price,
            this.food_quantity});
            this.dataGridView2.Cursor = System.Windows.Forms.Cursors.Default;
            this.dataGridView2.DataSource = this.foodlistBindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.LightCoral;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(5);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Brown;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView2.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView2.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridView2.GridColor = System.Drawing.Color.DarkRed;
            this.dataGridView2.Location = new System.Drawing.Point(12, 107);
            this.dataGridView2.MultiSelect = false;
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersVisible = false;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.MistyRose;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Rockwell", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.Padding = new System.Windows.Forms.Padding(10);
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            this.dataGridView2.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView2.RowTemplate.Height = 50;
            this.dataGridView2.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridView2.Size = new System.Drawing.Size(604, 553);
            this.dataGridView2.TabIndex = 1;
            // 
            // foodIDDataGridViewTextBoxColumn1
            // 
            this.foodIDDataGridViewTextBoxColumn1.DataPropertyName = "food_ID";
            this.foodIDDataGridViewTextBoxColumn1.HeaderText = "food_ID";
            this.foodIDDataGridViewTextBoxColumn1.Name = "foodIDDataGridViewTextBoxColumn1";
            this.foodIDDataGridViewTextBoxColumn1.ReadOnly = true;
            this.foodIDDataGridViewTextBoxColumn1.Visible = false;
            // 
            // food_name
            // 
            this.food_name.DataPropertyName = "food_name";
            this.food_name.HeaderText = "NAME";
            this.food_name.MinimumWidth = 200;
            this.food_name.Name = "food_name";
            this.food_name.ReadOnly = true;
            this.food_name.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.food_name.Width = 200;
            // 
            // food_price
            // 
            this.food_price.DataPropertyName = "food_price";
            this.food_price.HeaderText = "PRICE";
            this.food_price.MinimumWidth = 200;
            this.food_price.Name = "food_price";
            this.food_price.ReadOnly = true;
            this.food_price.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.food_price.Width = 200;
            // 
            // food_quantity
            // 
            this.food_quantity.DataPropertyName = "food_quantity";
            this.food_quantity.HeaderText = "QUANTITY";
            this.food_quantity.MinimumWidth = 200;
            this.food_quantity.Name = "food_quantity";
            this.food_quantity.ReadOnly = true;
            this.food_quantity.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.food_quantity.Width = 200;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(45, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(529, 89);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Firebrick;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(136, 668);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(357, 59);
            this.button1.TabIndex = 10;
            this.button1.Text = "BACK";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // User_Panel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.IndianRed;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(625, 733);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.dataGridView2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "User_Panel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "KABABJEES MENU";
            this.Load += new System.EventHandler(this.User_Panel_Load);
            ((System.ComponentModel.ISupportInitialize)(this.foodpandaDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.foodlistBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private foodpandaDataSet2 foodpandaDataSet2;
        private System.Windows.Forms.BindingSource foodlistBindingSource;
        private foodpandaDataSet2TableAdapters.foodlistTableAdapter foodlistTableAdapter;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridViewTextBoxColumn foodIDDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn food_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn food_price;
        private System.Windows.Forms.DataGridViewTextBoxColumn food_quantity;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button1;
    }
}