namespace WindowsFormsApp1
{
    partial class Form6
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
            this.client = new System.Windows.Forms.TextBox();
            this.cargo = new System.Windows.Forms.TextBox();
            this.truck = new System.Windows.Forms.TextBox();
            this.city = new System.Windows.Forms.TextBox();
            this.date = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dataGridView5 = new System.Windows.Forms.DataGridView();
            this.butt_add = new System.Windows.Forms.Button();
            this.butt_update = new System.Windows.Forms.Button();
            this.butt_del = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView5)).BeginInit();
            this.SuspendLayout();
            // 
            // client
            // 
            this.client.Location = new System.Drawing.Point(12, 31);
            this.client.Name = "client";
            this.client.Size = new System.Drawing.Size(100, 20);
            this.client.TabIndex = 0;
            // 
            // cargo
            // 
            this.cargo.Location = new System.Drawing.Point(12, 79);
            this.cargo.Name = "cargo";
            this.cargo.Size = new System.Drawing.Size(100, 20);
            this.cargo.TabIndex = 1;
            // 
            // truck
            // 
            this.truck.Location = new System.Drawing.Point(12, 125);
            this.truck.Name = "truck";
            this.truck.Size = new System.Drawing.Size(100, 20);
            this.truck.TabIndex = 2;
            // 
            // city
            // 
            this.city.Location = new System.Drawing.Point(12, 174);
            this.city.Name = "city";
            this.city.Size = new System.Drawing.Size(100, 20);
            this.city.TabIndex = 3;
            // 
            // date
            // 
            this.date.Location = new System.Drawing.Point(12, 218);
            this.date.Name = "date";
            this.date.Size = new System.Drawing.Size(100, 20);
            this.date.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "id Клиента";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "id Груза";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 109);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "id Грузовика";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 158);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "id Города";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 202);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Дата поставки";
            // 
            // dataGridView5
            // 
            this.dataGridView5.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView5.Location = new System.Drawing.Point(1, 273);
            this.dataGridView5.Name = "dataGridView5";
            this.dataGridView5.Size = new System.Drawing.Size(549, 175);
            this.dataGridView5.TabIndex = 10;
            // 
            // butt_add
            // 
            this.butt_add.Location = new System.Drawing.Point(197, 41);
            this.butt_add.Name = "butt_add";
            this.butt_add.Size = new System.Drawing.Size(92, 35);
            this.butt_add.TabIndex = 11;
            this.butt_add.Text = "Добавить";
            this.butt_add.UseVisualStyleBackColor = true;
            this.butt_add.Click += new System.EventHandler(this.butt_add_Click);
            // 
            // butt_update
            // 
            this.butt_update.Location = new System.Drawing.Point(197, 104);
            this.butt_update.Name = "butt_update";
            this.butt_update.Size = new System.Drawing.Size(92, 32);
            this.butt_update.TabIndex = 12;
            this.butt_update.Text = "Обновить";
            this.butt_update.UseVisualStyleBackColor = true;
            this.butt_update.Click += new System.EventHandler(this.butt_update_Click);
            // 
            // butt_del
            // 
            this.butt_del.Location = new System.Drawing.Point(197, 167);
            this.butt_del.Name = "butt_del";
            this.butt_del.Size = new System.Drawing.Size(92, 33);
            this.butt_del.TabIndex = 13;
            this.butt_del.Text = "Удалить";
            this.butt_del.UseVisualStyleBackColor = true;
            this.butt_del.Click += new System.EventHandler(this.butt_del_Click);
            // 
            // Form6
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(551, 450);
            this.Controls.Add(this.butt_del);
            this.Controls.Add(this.butt_update);
            this.Controls.Add(this.butt_add);
            this.Controls.Add(this.dataGridView5);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.date);
            this.Controls.Add(this.city);
            this.Controls.Add(this.truck);
            this.Controls.Add(this.cargo);
            this.Controls.Add(this.client);
            this.Name = "Form6";
            this.Text = "Form6";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView5)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox client;
        private System.Windows.Forms.TextBox cargo;
        private System.Windows.Forms.TextBox truck;
        private System.Windows.Forms.TextBox city;
        private System.Windows.Forms.TextBox date;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dataGridView5;
        private System.Windows.Forms.Button butt_add;
        private System.Windows.Forms.Button butt_update;
        private System.Windows.Forms.Button butt_del;
    }
}