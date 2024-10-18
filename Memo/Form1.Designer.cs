
namespace Memo
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            Oracle.ManagedDataAccess.Client.OracleParameter oracleParameter1 = new Oracle.ManagedDataAccess.Client.OracleParameter();
            Oracle.ManagedDataAccess.Client.OracleParameter oracleParameter2 = new Oracle.ManagedDataAccess.Client.OracleParameter();
            Oracle.ManagedDataAccess.Client.OracleParameter oracleParameter3 = new Oracle.ManagedDataAccess.Client.OracleParameter();
            Oracle.ManagedDataAccess.Client.OracleParameter oracleParameter4 = new Oracle.ManagedDataAccess.Client.OracleParameter();
            this.oracleCommand1 = new Oracle.ManagedDataAccess.Client.OracleCommand();
            this.oracleConnection1 = new Oracle.ManagedDataAccess.Client.OracleConnection();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.save = new System.Windows.Forms.Button();
            this.next = new System.Windows.Forms.Button();
            this.keyword_textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.show_list_button = new System.Windows.Forms.Button();
            this.show_con_button = new System.Windows.Forms.Button();
            this.list_textBox3 = new System.Windows.Forms.TextBox();
            this.oracleCommand2 = new Oracle.ManagedDataAccess.Client.OracleCommand();
            this.oracleCommand3 = new Oracle.ManagedDataAccess.Client.OracleCommand();
            this.oracleCommand4 = new Oracle.ManagedDataAccess.Client.OracleCommand();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // oracleCommand1
            // 
            oracleParameter1.OracleDbType = Oracle.ManagedDataAccess.Client.OracleDbType.Varchar2;
            oracleParameter1.ParameterName = "a";
            oracleParameter2.OracleDbType = Oracle.ManagedDataAccess.Client.OracleDbType.Varchar2;
            oracleParameter2.ParameterName = "b";
            this.oracleCommand1.Parameters.Add(oracleParameter1);
            this.oracleCommand1.Parameters.Add(oracleParameter2);
            this.oracleCommand1.Transaction = null;
            // 
            // oracleConnection1
            // 
            this.oracleConnection1.ChunkMigrationConnectionTimeout = "120";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(68, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.RightToLeftLayout = true;
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(626, 375);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.DarkGray;
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.textBox2);
            this.tabPage1.Controls.Add(this.keyword_textBox1);
            this.tabPage1.Controls.Add(this.next);
            this.tabPage1.Controls.Add(this.save);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(618, 346);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "메모입력";
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.DarkGray;
            this.tabPage2.Controls.Add(this.list_textBox3);
            this.tabPage2.Controls.Add(this.show_con_button);
            this.tabPage2.Controls.Add(this.show_list_button);
            this.tabPage2.Controls.Add(this.listBox1);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(618, 346);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "메모리스트";
            this.tabPage2.Click += new System.EventHandler(this.tabPage2_Click);
            // 
            // save
            // 
            this.save.Location = new System.Drawing.Point(250, 32);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(75, 23);
            this.save.TabIndex = 0;
            this.save.Text = "메모저장";
            this.save.UseVisualStyleBackColor = true;
            this.save.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // next
            // 
            this.next.Location = new System.Drawing.Point(334, 32);
            this.next.Name = "next";
            this.next.Size = new System.Drawing.Size(75, 23);
            this.next.TabIndex = 1;
            this.next.Text = "다음메모";
            this.next.UseVisualStyleBackColor = true;
            this.next.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // keyword_textBox1
            // 
            this.keyword_textBox1.Location = new System.Drawing.Point(82, 30);
            this.keyword_textBox1.Name = "keyword_textBox1";
            this.keyword_textBox1.Size = new System.Drawing.Size(159, 25);
            this.keyword_textBox1.TabIndex = 2;
            this.keyword_textBox1.TextChanged += new System.EventHandler(this.keyword_TextChanged);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(43, 73);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(543, 247);
            this.textBox2.TabIndex = 3;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 15);
            this.label1.TabIndex = 4;
            this.label1.Text = "키워드";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 15;
            this.listBox1.Location = new System.Drawing.Point(32, 26);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(397, 94);
            this.listBox1.TabIndex = 0;
            // 
            // show_list_button
            // 
            this.show_list_button.Location = new System.Drawing.Point(460, 26);
            this.show_list_button.Name = "show_list_button";
            this.show_list_button.Size = new System.Drawing.Size(116, 49);
            this.show_list_button.TabIndex = 1;
            this.show_list_button.Text = "리스트보기";
            this.show_list_button.UseVisualStyleBackColor = true;
            this.show_list_button.Click += new System.EventHandler(this.show_list_button_Click);
            // 
            // show_con_button
            // 
            this.show_con_button.Location = new System.Drawing.Point(460, 95);
            this.show_con_button.Name = "show_con_button";
            this.show_con_button.Size = new System.Drawing.Size(85, 32);
            this.show_con_button.TabIndex = 2;
            this.show_con_button.Text = "내용보기";
            this.show_con_button.UseVisualStyleBackColor = true;
            this.show_con_button.Click += new System.EventHandler(this.show_con_button_Click);
            // 
            // list_textBox3
            // 
            this.list_textBox3.Location = new System.Drawing.Point(32, 153);
            this.list_textBox3.Multiline = true;
            this.list_textBox3.Name = "list_textBox3";
            this.list_textBox3.Size = new System.Drawing.Size(331, 165);
            this.list_textBox3.TabIndex = 3;
            this.list_textBox3.TextChanged += new System.EventHandler(this.list_textBox3_TextChanged);
            // 
            // oracleCommand2
            // 
            this.oracleCommand2.Transaction = null;
            // 
            // oracleCommand3
            // 
            oracleParameter3.OracleDbType = Oracle.ManagedDataAccess.Client.OracleDbType.Varchar2;
            oracleParameter3.ParameterName = "list";
            this.oracleCommand3.Parameters.Add(oracleParameter3);
            this.oracleCommand3.Transaction = null;
            // 
            // oracleCommand4
            // 
            oracleParameter4.OracleDbType = Oracle.ManagedDataAccess.Client.OracleDbType.Varchar2;
            oracleParameter4.ParameterName = "con";
            this.oracleCommand4.Parameters.Add(oracleParameter4);
            this.oracleCommand4.Transaction = null;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Oracle.ManagedDataAccess.Client.OracleCommand oracleCommand1;
        private Oracle.ManagedDataAccess.Client.OracleConnection oracleConnection1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button next;
        private System.Windows.Forms.Button save;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox keyword_textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox list_textBox3;
        private System.Windows.Forms.Button show_con_button;
        private System.Windows.Forms.Button show_list_button;
        private System.Windows.Forms.ListBox listBox1;
        private Oracle.ManagedDataAccess.Client.OracleCommand oracleCommand2;
        private Oracle.ManagedDataAccess.Client.OracleCommand oracleCommand3;
        private Oracle.ManagedDataAccess.Client.OracleCommand oracleCommand4;
    }
}

