using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EFSample
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnTest_Click(object sender, EventArgs e)
        {
            using (var context = new MonitorDBContext("Server=.;Database=MonitorDB;Trusted_Connection=True;"))
            {
                var users = context.Users.ToList();
                Console.WriteLine("{0,6}   {1,5}   {2,20}", "ID", "Name", "Email");
                foreach (var user in users)
                {
                    Console.WriteLine("{0,6}   {1,5}   {2,20}", user.Id, user.Name, user.Email);
                }
                Console.ReadKey();
            }
        }
    }
}
