
namespace Polomka
{
    partial class Main
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.showClient = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.addNewClient = new System.Windows.Forms.Button();
            this.serch = new System.Windows.Forms.Label();
            this.SerchText = new System.Windows.Forms.TextBox();
            this.SerchButton = new System.Windows.Forms.Button();
            this.delete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // showClient
            // 
            this.showClient.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(156)))), ((int)(((byte)(26)))));
            this.showClient.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.showClient.Location = new System.Drawing.Point(12, 25);
            this.showClient.Name = "showClient";
            this.showClient.Size = new System.Drawing.Size(205, 68);
            this.showClient.TabIndex = 0;
            this.showClient.Text = "Показать Клиентов";
            this.showClient.UseVisualStyleBackColor = false;
            this.showClient.Click += new System.EventHandler(this.showClient_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(247, 25);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(448, 437);
            this.dataGridView1.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Polomka.Properties.Resources.service_logo;
            this.pictureBox1.Location = new System.Drawing.Point(12, 367);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(94, 95);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // addNewClient
            // 
            this.addNewClient.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(156)))), ((int)(((byte)(26)))));
            this.addNewClient.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addNewClient.Location = new System.Drawing.Point(12, 123);
            this.addNewClient.Name = "addNewClient";
            this.addNewClient.Size = new System.Drawing.Size(205, 68);
            this.addNewClient.TabIndex = 3;
            this.addNewClient.Text = "Добавить нового клиента";
            this.addNewClient.UseVisualStyleBackColor = false;
            this.addNewClient.Click += new System.EventHandler(this.addNewClient_Click);
            // 
            // serch
            // 
            this.serch.AutoSize = true;
            this.serch.Location = new System.Drawing.Point(27, 273);
            this.serch.Name = "serch";
            this.serch.Size = new System.Drawing.Size(48, 17);
            this.serch.TabIndex = 4;
            this.serch.Text = "Поиск";
            this.serch.Visible = false;
            // 
            // SerchText
            // 
            this.SerchText.Location = new System.Drawing.Point(21, 313);
            this.SerchText.Name = "SerchText";
            this.SerchText.Size = new System.Drawing.Size(100, 22);
            this.SerchText.TabIndex = 5;
            this.SerchText.Visible = false;
            // 
            // SerchButton
            // 
            this.SerchButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(156)))), ((int)(((byte)(26)))));
            this.SerchButton.Location = new System.Drawing.Point(149, 313);
            this.SerchButton.Name = "SerchButton";
            this.SerchButton.Size = new System.Drawing.Size(85, 23);
            this.SerchButton.TabIndex = 6;
            this.SerchButton.Text = "Поиск";
            this.SerchButton.UseVisualStyleBackColor = false;
            this.SerchButton.Visible = false;
            this.SerchButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // delete
            // 
            this.delete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(156)))), ((int)(((byte)(26)))));
            this.delete.Location = new System.Drawing.Point(159, 367);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(75, 23);
            this.delete.TabIndex = 7;
            this.delete.Text = "Удалить";
            this.delete.UseVisualStyleBackColor = false;
            this.delete.Visible = false;
            this.delete.Click += new System.EventHandler(this.delete_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(707, 474);
            this.Controls.Add(this.delete);
            this.Controls.Add(this.SerchButton);
            this.Controls.Add(this.SerchText);
            this.Controls.Add(this.serch);
            this.Controls.Add(this.addNewClient);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.showClient);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Main";
            this.Text = "Главная страница (ООО \"Поломка\")";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button showClient;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label serch;
        private System.Windows.Forms.TextBox SerchText;
        private System.Windows.Forms.Button SerchButton;
        private System.Windows.Forms.Button addNewClient;
        private System.Windows.Forms.Button delete;
    }
}

