using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp6.DBCon;

namespace WindowsFormsApp6
{
    public partial class UserControJuri : UserControl
    {
        public UserControJuri()
        {
            InitializeComponent();
        }

        public void Fill(User user, int number)
        {
            labelName.Text = "Juri - " + number.ToString();
            userBindingSource.DataSource = user;
        }
 
    }
}
