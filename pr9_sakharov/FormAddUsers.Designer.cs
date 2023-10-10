namespace pr9_sakharov
{
    partial class FormAddUsers
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
            this.buttonBack = new System.Windows.Forms.Button();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.labelName = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.loginTextBox = new System.Windows.Forms.TextBox();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.passwordTextBox2 = new System.Windows.Forms.TextBox();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.first_NameTextBox = new System.Windows.Forms.TextBox();
            this.second_NameTextBox = new System.Windows.Forms.TextBox();
            this.roleIDcomboBox = new System.Windows.Forms.ComboBox();
            this.radioButtonMen = new System.Windows.Forms.RadioButton();
            this.radioButtonWoman = new System.Windows.Forms.RadioButton();
            this.PhonemaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.bindingSourceRole = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceRole)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonBack
            // 
            this.buttonBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonBack.Location = new System.Drawing.Point(12, 12);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(127, 34);
            this.buttonBack.TabIndex = 3;
            this.buttonBack.Text = "Назад";
            this.buttonBack.UseVisualStyleBackColor = true;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // buttonAdd
            // 
            this.buttonAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonAdd.Location = new System.Drawing.Point(661, 404);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(127, 34);
            this.buttonAdd.TabIndex = 4;
            this.buttonAdd.Text = "Добавить";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelName.Location = new System.Drawing.Point(180, 12);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(524, 37);
            this.labelName.TabIndex = 5;
            this.labelName.Text = "Добавление Нового Пользователей";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 111);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 29);
            this.label1.TabIndex = 5;
            this.label1.Text = "Логин:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(12, 185);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(194, 29);
            this.label2.TabIndex = 5;
            this.label2.Text = "Повтор пароля:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(12, 148);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 29);
            this.label3.TabIndex = 5;
            this.label3.Text = "Пароль:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(12, 222);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(137, 29);
            this.label4.TabIndex = 5;
            this.label4.Text = "Эл. почта: ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(12, 259);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(125, 29);
            this.label5.TabIndex = 5;
            this.label5.Text = "Телефон:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(447, 148);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(129, 29);
            this.label6.TabIndex = 5;
            this.label6.Text = "Фамилия:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(447, 222);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 29);
            this.label7.TabIndex = 5;
            this.label7.Text = "Пол:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(447, 111);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(69, 29);
            this.label8.TabIndex = 5;
            this.label8.Text = "Имя:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.Location = new System.Drawing.Point(447, 185);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(77, 29);
            this.label9.TabIndex = 5;
            this.label9.Text = "Роль:";
            // 
            // loginTextBox
            // 
            this.loginTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.loginTextBox.Location = new System.Drawing.Point(230, 108);
            this.loginTextBox.Name = "loginTextBox";
            this.loginTextBox.Size = new System.Drawing.Size(200, 35);
            this.loginTextBox.TabIndex = 6;
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.passwordTextBox.Location = new System.Drawing.Point(230, 145);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.PasswordChar = '*';
            this.passwordTextBox.Size = new System.Drawing.Size(200, 35);
            this.passwordTextBox.TabIndex = 6;
            // 
            // passwordTextBox2
            // 
            this.passwordTextBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.passwordTextBox2.Location = new System.Drawing.Point(230, 182);
            this.passwordTextBox2.Name = "passwordTextBox2";
            this.passwordTextBox2.PasswordChar = '*';
            this.passwordTextBox2.Size = new System.Drawing.Size(200, 35);
            this.passwordTextBox2.TabIndex = 6;
            // 
            // emailTextBox
            // 
            this.emailTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.emailTextBox.Location = new System.Drawing.Point(230, 219);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(200, 35);
            this.emailTextBox.TabIndex = 6;
            // 
            // first_NameTextBox
            // 
            this.first_NameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.first_NameTextBox.Location = new System.Drawing.Point(578, 108);
            this.first_NameTextBox.Name = "first_NameTextBox";
            this.first_NameTextBox.Size = new System.Drawing.Size(200, 35);
            this.first_NameTextBox.TabIndex = 6;
            // 
            // second_NameTextBox
            // 
            this.second_NameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.second_NameTextBox.Location = new System.Drawing.Point(578, 145);
            this.second_NameTextBox.Name = "second_NameTextBox";
            this.second_NameTextBox.Size = new System.Drawing.Size(200, 35);
            this.second_NameTextBox.TabIndex = 6;
            // 
            // roleIDcomboBox
            // 
            this.roleIDcomboBox.DataSource = this.bindingSourceRole;
            this.roleIDcomboBox.DisplayMember = "Name";
            this.roleIDcomboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.roleIDcomboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.roleIDcomboBox.FormattingEnabled = true;
            this.roleIDcomboBox.Location = new System.Drawing.Point(578, 182);
            this.roleIDcomboBox.Name = "roleIDcomboBox";
            this.roleIDcomboBox.Size = new System.Drawing.Size(200, 37);
            this.roleIDcomboBox.TabIndex = 7;
            this.roleIDcomboBox.ValueMember = "ID";
            // 
            // radioButtonMen
            // 
            this.radioButtonMen.AutoSize = true;
            this.radioButtonMen.Checked = true;
            this.radioButtonMen.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radioButtonMen.Location = new System.Drawing.Point(604, 221);
            this.radioButtonMen.Name = "radioButtonMen";
            this.radioButtonMen.Size = new System.Drawing.Size(51, 33);
            this.radioButtonMen.TabIndex = 8;
            this.radioButtonMen.TabStop = true;
            this.radioButtonMen.Text = "М";
            this.radioButtonMen.UseVisualStyleBackColor = true;
            // 
            // radioButtonWoman
            // 
            this.radioButtonWoman.AutoSize = true;
            this.radioButtonWoman.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radioButtonWoman.Location = new System.Drawing.Point(661, 221);
            this.radioButtonWoman.Name = "radioButtonWoman";
            this.radioButtonWoman.Size = new System.Drawing.Size(52, 33);
            this.radioButtonWoman.TabIndex = 8;
            this.radioButtonWoman.Text = "Ж";
            this.radioButtonWoman.UseVisualStyleBackColor = true;
            // 
            // PhonemaskedTextBox
            // 
            this.PhonemaskedTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PhonemaskedTextBox.Location = new System.Drawing.Point(230, 256);
            this.PhonemaskedTextBox.Mask = "+7 (000) 000-00-00";
            this.PhonemaskedTextBox.Name = "PhonemaskedTextBox";
            this.PhonemaskedTextBox.Size = new System.Drawing.Size(200, 31);
            this.PhonemaskedTextBox.TabIndex = 9;
            // 
            // bindingSourceRole
            // 
            this.bindingSourceRole.DataSource = typeof(pr9_sakharov.DBContext.Roles);
            // 
            // FormAddUsers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.PhonemaskedTextBox);
            this.Controls.Add(this.radioButtonWoman);
            this.Controls.Add(this.radioButtonMen);
            this.Controls.Add(this.roleIDcomboBox);
            this.Controls.Add(this.emailTextBox);
            this.Controls.Add(this.second_NameTextBox);
            this.Controls.Add(this.passwordTextBox2);
            this.Controls.Add(this.first_NameTextBox);
            this.Controls.Add(this.passwordTextBox);
            this.Controls.Add(this.loginTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.buttonBack);
            this.Name = "FormAddUsers";
            this.Text = "FormAddUsers";
            this.Load += new System.EventHandler(this.FormAddUsers_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceRole)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonBack;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox loginTextBox;
        private System.Windows.Forms.TextBox passwordTextBox;
        private System.Windows.Forms.TextBox passwordTextBox2;
        private System.Windows.Forms.TextBox emailTextBox;
        private System.Windows.Forms.TextBox first_NameTextBox;
        private System.Windows.Forms.TextBox second_NameTextBox;
        private System.Windows.Forms.ComboBox roleIDcomboBox;
        private System.Windows.Forms.RadioButton radioButtonMen;
        private System.Windows.Forms.RadioButton radioButtonWoman;
        private System.Windows.Forms.MaskedTextBox PhonemaskedTextBox;
        private System.Windows.Forms.BindingSource bindingSourceRole;
    }
}