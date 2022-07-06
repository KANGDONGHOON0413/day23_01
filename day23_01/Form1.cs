using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace day23_01
{
    public partial class Form1 : Form
    {
        public class UserINFO
        {
            public string UserID { get; }
            public string UserPW { get; set; }
            public string userEmail { get; }
            public string username { get; }
            public UserINFO()
            {
                UserID = "test01";
                UserPW = "1234qwer";
                userEmail = "a@gmail.com";
                username = "kangdonghoon";
            }
        }
        UserINFO test01 = new UserINFO();
             
        public Form1()
        {
            InitializeComponent();
            Width = 300;
            Height = 200;
        }

        private void btn_login_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(ID_01.Text) || string.IsNullOrEmpty(PW_01.Text)) MessageBox.Show("입력칸이 비어있습니다");
            else if (!test01.UserID.Equals(ID_01.Text)) { MessageBox.Show("ID가 다릅니다."); ID_01.Text = ""; PW_01.Text = ""; }
            else if (!test01.UserPW.Equals(PW_01.Text)) {MessageBox.Show("PW가 다릅니다."); PW_01.Text = ""; }
            else MessageBox.Show("로그인 성공");
        }
    }
}
