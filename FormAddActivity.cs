using System;
using System.Windows.Forms;
using System.Text.Json;
using WindowsFormsApp6.DBCon;
using System.Linq;

namespace WindowsFormsApp6
{
    public partial class FormAddActivity : Form
    {
        public FormAddActivity()
        {
            InitializeComponent();
        }
        public List<int> Id_Juri = new List<int>();

        private void FormAddActivity_Load(object sender, EventArgs e)
        {
            eventBindingSource.DataSource = DBConst.model.Event.ToList();
            usersBindingSource.DataSource = DBConst.model.User.Where(x => x.RoleID == 1).ToList();
            usersBindingSource2.DataSource = DBConst.model.User.Where(x => x.RoleID == 2).ToList();
        }

        private void buttonAddActivity_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(titleTextBox.Text))
            {
                MessageBox.Show("Fill in the title field!");
                return;
            }
            try
            {
                Convert.ToInt32(dayTextBox.Text);
            }
            catch 
            {
                MessageBox.Show("Еhe day field must contain an integer value!");
            }
            if (Id_Juri.Count <= 0)
            {
                MessageBox.Show("Add a one juri at least!");
                return;
            }
            Activity activity = new Activity();
            activity.Title = titleTextBox.Text;
            activity.EventPlanID = (int)eventPlanIDComboBox.SelectedValue;
            activity.Day = Convert.ToInt32(dayTextBox.Text);
            activity.StartedAt = dateTimePicker1.Value.TimeOfDay;
            activity.ModeratorID = (int)ModeratorComboBox.SelectedValue;
            activity.GroupsJury = JsonSerializer.Serialize(Id_Juri);

            DBConst.model.Activity.Add(activity);
            try
            {
                DBConst.model.SaveChanges();
            }
            catch (Exception ex) 
            {
                MessageBox.Show(ex.Message);
                return;
            }
            Close();
        }
        private void buttonAddJuri_Click(object sender, EventArgs e)
        {
            int id = (int)juriComboBox.SelectedValue;
            if (!Id_Juri.Contains(id))
            {
                Id_Juri.Add(id);
                MessageBox.Show($"User with this ID - {juriComboBox.SelectedValue} has added!");
            }
            MessageBox.Show("You can't add the same jjuri");
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
