using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Db4objects.Db4o;
namespace ADBTeam100_DB4O
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public IObjectContainer db;
        private void ThemCty_Click(object sender, EventArgs e)
        {
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DBConfig conn = new DBConfig();
            db = conn.db;
        }
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.CloseConn();
        }
        private void CloseConn()
        {
            db.Close();
        }
        public void LoadData()
        {          
        }
    }
}
