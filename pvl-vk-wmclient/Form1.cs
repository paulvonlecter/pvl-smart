using System;
using System.Linq;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Net;
using System.Web;
using System.IO;

namespace pvl_vk_wmclient
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            WebRequest request = WebRequest.Create("https://api.vk.com/method/account.getProfileInfo?token="+Properties.Resources.token);
            WebResponse response = request.GetResponse();
            Stream dataStream = response.GetResponseStream();
            StreamReader reader = new StreamReader(dataStream);
            string responseFromServer = reader.ReadToEnd();
            reader.Close();
            response.Close();
            responseFromServer = 
        }

        private void menuItem3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("ВК клиент\nby Paul von Lecter\n\n\nСпециально для себя\nбугага ;)","О программе");
        }

        private void menuItem4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}