using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.ManagedDataAccess.Client;

namespace Memo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            oracleConnection1.ConnectionString = "DATA SOURCE = localhost:1521/xepdb1;" + " USER ID = DKHONG; PASSWORD = 1234; load balancing=false; ha events=false;";
            oracleConnection1.Open();
            oracleCommand1.Connection = oracleConnection1;
            oracleCommand2.Connection = oracleConnection1;
            oracleCommand3.Connection = oracleConnection1;
            oracleCommand4.Connection = oracleConnection1;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        

        private void button1_Click_1(object sender, EventArgs e)
        {
            // 현재 시간을 DB에서 가져옴
            oracleCommand1.CommandText = "SELECT SYSDATE FROM DUAL";
            DateTime current_time;
            current_time = Convert.ToDateTime(oracleCommand1.ExecuteScalar());

            // 삽입할 데이터 준비
            oracleCommand2.CommandText = "INSERT INTO Memo_table (M_ID, M_KEYWORD, M_DATE, M_CONTENTS) " +
                                         "VALUES (memo_seq.nextval, :keyword, :m_date, :contents)";

            oracleCommand2.Parameters.Clear();
            oracleCommand2.Parameters.Add(new OracleParameter("keyword", keyword_textBox1.Text));
            oracleCommand2.Parameters.Add(new OracleParameter("m_date", current_time.ToString()));
            oracleCommand2.Parameters.Add(new OracleParameter("contents", textBox2.Text));

            // 실행
            oracleCommand2.ExecuteNonQuery();

            // 성공 메시지
            MessageBox.Show("Memo successfully added");
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            keyword_textBox1.Clear();
            textBox2.Clear();

            // 새로운 메모를 위한 준비 메시지
            MessageBox.Show("새로운 메모를 입력하세요.");
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void keyword_TextChanged(object sender, EventArgs e)
        {

        }

        private void list_textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void show_list_button_Click(object sender, EventArgs e)
        {
            string selectQuery = "SELECT M_ID, M_KEYWORD FROM Memo_table";
            oracleCommand3.CommandText = selectQuery;

            OracleDataReader reader = oracleCommand3.ExecuteReader();
            listBox1.Items.Clear();

            while (reader.Read())
            {
                string displayText = $"{reader["M_ID"]}: {reader["M_KEYWORD"]}";
                listBox1.Items.Add(displayText);
            }

            reader.Close();

        }

        private void show_con_button_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem != null)
            {
                string selectedText = listBox1.SelectedItem.ToString();
                int selectedId = int.Parse(selectedText.Split(':')[0]);

                try
                {
                    string selectMemoQuery = "SELECT M_DATE, M_CONTENTS FROM Memo_table WHERE M_ID = :id";
                    oracleCommand4.CommandText = selectMemoQuery;

                    oracleCommand4.Parameters.Clear();
                    oracleCommand4.Parameters.Add(new OracleParameter("id", selectedId));

                    OracleDataReader reader = oracleCommand4.ExecuteReader();

                    if (reader.Read())
                    {
                        string memoDate = reader["M_DATE"].ToString();
                        string memoContents = reader["M_CONTENTS"].ToString();
                        list_textBox3.Text = $"날짜: {memoDate} \r\n내용:{memoContents}";
                    }

                    reader.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("에러: " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("메모를 선택하세요.");
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
