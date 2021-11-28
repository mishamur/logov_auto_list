
namespace lab1_list
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dateTimeTalk = new System.Windows.Forms.DateTimePicker();
            this.button1 = new System.Windows.Forms.Button();
            this.dateTimeBeginTalk = new System.Windows.Forms.DateTimePicker();
            this.dateTimeEndTalk = new System.Windows.Forms.DateTimePicker();
            this.textBoxTarif = new System.Windows.Forms.TextBox();
            this.textBoxSecondName = new System.Windows.Forms.TextBox();
            this.textBoxPhoneNumber = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.propertyGrid1 = new System.Windows.Forms.PropertyGrid();
            this.button3 = new System.Windows.Forms.Button();
            this.buttonAddAfter = new System.Windows.Forms.Button();
            this.buttonAddBefore = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.textBoxIndex = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.buttonSearchSecondName = new System.Windows.Forms.Button();
            this.buttonSearchDate = new System.Windows.Forms.Button();
            this.textBoxSearchName = new System.Windows.Forms.TextBox();
            this.dateTimePickerSeacrhDate = new System.Windows.Forms.DateTimePicker();
            this.buttonReset = new System.Windows.Forms.Button();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.bindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.dateTimePickerViewMoreCurrent = new System.Windows.Forms.DateTimePicker();
            this.buttonViewMoreCurrent = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Фамилия";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "номер телефона";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 144);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 15);
            this.label3.TabIndex = 3;
            this.label3.Text = "тарифза минуту";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(28, 110);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 15);
            this.label4.TabIndex = 2;
            this.label4.Text = "дата разговора";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(28, 210);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(169, 15);
            this.label5.TabIndex = 5;
            this.label5.Text = "время оконачания разговора";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(28, 176);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(142, 15);
            this.label6.TabIndex = 4;
            this.label6.Text = "время начала разговора";
            // 
            // dateTimeTalk
            // 
            this.dateTimeTalk.Location = new System.Drawing.Point(204, 110);
            this.dateTimeTalk.Name = "dateTimeTalk";
            this.dateTimeTalk.Size = new System.Drawing.Size(200, 23);
            this.dateTimeTalk.TabIndex = 6;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(0, 1);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(123, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "Добавить запись";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dateTimeBeginTalk
            // 
            this.dateTimeBeginTalk.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dateTimeBeginTalk.Location = new System.Drawing.Point(204, 170);
            this.dateTimeBeginTalk.Name = "dateTimeBeginTalk";
            this.dateTimeBeginTalk.Size = new System.Drawing.Size(200, 23);
            this.dateTimeBeginTalk.TabIndex = 8;
            // 
            // dateTimeEndTalk
            // 
            this.dateTimeEndTalk.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dateTimeEndTalk.Location = new System.Drawing.Point(204, 204);
            this.dateTimeEndTalk.Name = "dateTimeEndTalk";
            this.dateTimeEndTalk.Size = new System.Drawing.Size(200, 23);
            this.dateTimeEndTalk.TabIndex = 9;
            // 
            // textBoxTarif
            // 
            this.textBoxTarif.Location = new System.Drawing.Point(204, 141);
            this.textBoxTarif.Name = "textBoxTarif";
            this.textBoxTarif.Size = new System.Drawing.Size(200, 23);
            this.textBoxTarif.TabIndex = 10;
            // 
            // textBoxSecondName
            // 
            this.textBoxSecondName.Location = new System.Drawing.Point(204, 32);
            this.textBoxSecondName.Name = "textBoxSecondName";
            this.textBoxSecondName.Size = new System.Drawing.Size(200, 23);
            this.textBoxSecondName.TabIndex = 11;
            // 
            // textBoxPhoneNumber
            // 
            this.textBoxPhoneNumber.Location = new System.Drawing.Point(204, 72);
            this.textBoxPhoneNumber.Name = "textBoxPhoneNumber";
            this.textBoxPhoneNumber.Size = new System.Drawing.Size(200, 23);
            this.textBoxPhoneNumber.TabIndex = 12;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(139, 3);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(153, 23);
            this.button2.TabIndex = 13;
            this.button2.Text = "Сортировка по фамилии";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // listBox1
            // 
            this.listBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.HorizontalScrollbar = true;
            this.listBox1.ItemHeight = 15;
            this.listBox1.Items.AddRange(new object[] {
            " "});
            this.listBox1.Location = new System.Drawing.Point(466, 12);
            this.listBox1.MultiColumn = true;
            this.listBox1.Name = "listBox1";
            this.listBox1.ScrollAlwaysVisible = true;
            this.listBox1.Size = new System.Drawing.Size(294, 214);
            this.listBox1.TabIndex = 14;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // propertyGrid1
            // 
            this.propertyGrid1.Location = new System.Drawing.Point(307, 233);
            this.propertyGrid1.Name = "propertyGrid1";
            this.propertyGrid1.Size = new System.Drawing.Size(477, 208);
            this.propertyGrid1.TabIndex = 15;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(307, 3);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(153, 23);
            this.button3.TabIndex = 16;
            this.button3.Text = "Сортировка по дате";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // buttonAddAfter
            // 
            this.buttonAddAfter.Location = new System.Drawing.Point(28, 254);
            this.buttonAddAfter.Name = "buttonAddAfter";
            this.buttonAddAfter.Size = new System.Drawing.Size(118, 23);
            this.buttonAddAfter.TabIndex = 17;
            this.buttonAddAfter.Text = "Добавить после";
            this.buttonAddAfter.UseVisualStyleBackColor = true;
            this.buttonAddAfter.Click += new System.EventHandler(this.buttonAddAfter_Click);
            // 
            // buttonAddBefore
            // 
            this.buttonAddBefore.Location = new System.Drawing.Point(158, 254);
            this.buttonAddBefore.Name = "buttonAddBefore";
            this.buttonAddBefore.Size = new System.Drawing.Size(134, 23);
            this.buttonAddBefore.TabIndex = 18;
            this.buttonAddBefore.Text = "Добавить перед";
            this.buttonAddBefore.UseVisualStyleBackColor = true;
            this.buttonAddBefore.Click += new System.EventHandler(this.buttonAddBefore_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.Location = new System.Drawing.Point(28, 283);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(75, 23);
            this.buttonDelete.TabIndex = 19;
            this.buttonDelete.Text = "Удалить ";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // textBoxIndex
            // 
            this.textBoxIndex.Location = new System.Drawing.Point(476, 233);
            this.textBoxIndex.Name = "textBoxIndex";
            this.textBoxIndex.Size = new System.Drawing.Size(100, 23);
            this.textBoxIndex.TabIndex = 20;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(109, 285);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(66, 21);
            this.label7.TabIndex = 21;
            this.label7.Text = "Номер";
            // 
            // buttonSearchSecondName
            // 
            this.buttonSearchSecondName.Location = new System.Drawing.Point(0, 321);
            this.buttonSearchSecondName.Name = "buttonSearchSecondName";
            this.buttonSearchSecondName.Size = new System.Drawing.Size(127, 23);
            this.buttonSearchSecondName.TabIndex = 22;
            this.buttonSearchSecondName.Text = "Поиск по фамилии";
            this.buttonSearchSecondName.UseVisualStyleBackColor = true;
            this.buttonSearchSecondName.Click += new System.EventHandler(this.buttonSearchSecondName_Click);
            // 
            // buttonSearchDate
            // 
            this.buttonSearchDate.Location = new System.Drawing.Point(0, 350);
            this.buttonSearchDate.Name = "buttonSearchDate";
            this.buttonSearchDate.Size = new System.Drawing.Size(103, 23);
            this.buttonSearchDate.TabIndex = 23;
            this.buttonSearchDate.Text = "Поиск по дате";
            this.buttonSearchDate.UseVisualStyleBackColor = true;
            this.buttonSearchDate.Click += new System.EventHandler(this.buttonSearchDate_Click);
            // 
            // textBoxSearchName
            // 
            this.textBoxSearchName.Location = new System.Drawing.Point(133, 322);
            this.textBoxSearchName.Name = "textBoxSearchName";
            this.textBoxSearchName.Size = new System.Drawing.Size(159, 23);
            this.textBoxSearchName.TabIndex = 24;
            // 
            // dateTimePickerSeacrhDate
            // 
            this.dateTimePickerSeacrhDate.Location = new System.Drawing.Point(112, 350);
            this.dateTimePickerSeacrhDate.Name = "dateTimePickerSeacrhDate";
            this.dateTimePickerSeacrhDate.Size = new System.Drawing.Size(189, 23);
            this.dateTimePickerSeacrhDate.TabIndex = 25;
            // 
            // buttonReset
            // 
            this.buttonReset.Location = new System.Drawing.Point(51, 415);
            this.buttonReset.Name = "buttonReset";
            this.buttonReset.Size = new System.Drawing.Size(192, 23);
            this.buttonReset.TabIndex = 26;
            this.buttonReset.Text = "Сбросить";
            this.buttonReset.UseVisualStyleBackColor = true;
            this.buttonReset.Click += new System.EventHandler(this.buttonReset_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(171, 287);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 23);
            this.comboBox1.TabIndex = 27;
            // 
            // dateTimePickerViewMoreCurrent
            // 
            this.dateTimePickerViewMoreCurrent.Location = new System.Drawing.Point(112, 379);
            this.dateTimePickerViewMoreCurrent.Name = "dateTimePickerViewMoreCurrent";
            this.dateTimePickerViewMoreCurrent.Size = new System.Drawing.Size(189, 23);
            this.dateTimePickerViewMoreCurrent.TabIndex = 28;
            // 
            // buttonViewMoreCurrent
            // 
            this.buttonViewMoreCurrent.Location = new System.Drawing.Point(0, 379);
            this.buttonViewMoreCurrent.Name = "buttonViewMoreCurrent";
            this.buttonViewMoreCurrent.Size = new System.Drawing.Size(106, 23);
            this.buttonViewMoreCurrent.TabIndex = 29;
            this.buttonViewMoreCurrent.Text = "Вывести даты  >";
            this.buttonViewMoreCurrent.UseVisualStyleBackColor = true;
            this.buttonViewMoreCurrent.Click += new System.EventHandler(this.buttonViewMoreCurrent_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonViewMoreCurrent);
            this.Controls.Add(this.dateTimePickerViewMoreCurrent);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.buttonReset);
            this.Controls.Add(this.dateTimePickerSeacrhDate);
            this.Controls.Add(this.textBoxSearchName);
            this.Controls.Add(this.buttonSearchDate);
            this.Controls.Add(this.buttonSearchSecondName);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textBoxIndex);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.buttonAddBefore);
            this.Controls.Add(this.buttonAddAfter);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.propertyGrid1);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.textBoxPhoneNumber);
            this.Controls.Add(this.textBoxSecondName);
            this.Controls.Add(this.textBoxTarif);
            this.Controls.Add(this.dateTimeEndTalk);
            this.Controls.Add(this.dateTimeBeginTalk);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dateTimeTalk);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Удалить";
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource2)).EndInit();
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
        private System.Windows.Forms.DateTimePicker dateTimeTalk;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DateTimePicker dateTimeBeginTalk;
        private System.Windows.Forms.DateTimePicker dateTimeEndTalk;
        private System.Windows.Forms.TextBox textBoxTarif;
        private System.Windows.Forms.TextBox textBoxSecondName;
        private System.Windows.Forms.TextBox textBoxPhoneNumber;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.PropertyGrid propertyGrid1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button buttonAddAfter;
        private System.Windows.Forms.Button buttonAddBefore;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.TextBox textBoxIndex;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button buttonSearchSecondName;
        private System.Windows.Forms.Button buttonSearchDate;
        private System.Windows.Forms.TextBox textBoxSearchName;
        private System.Windows.Forms.DateTimePicker dateTimePickerSeacrhDate;
        private System.Windows.Forms.Button buttonReset;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.BindingSource bindingSource2;
        private System.Windows.Forms.DateTimePicker dateTimePickerViewMoreCurrent;
        private System.Windows.Forms.Button buttonViewMoreCurrent;
    }
}

