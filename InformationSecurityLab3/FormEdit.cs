using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace InformationSecurityLab3
{
    public partial class FormEdit : Form
    {
        private List<string> _users;
        private List<Text> _objects;
        private List<List<int>> _accesses;

        private int pickedUser = 0;
        private int pickedObject = 0;

        public FormEdit(List<string> users, List<Text> objects, List<List<int>> accesses)
        {
            InitializeComponent();
            _users = users;
            _objects = objects;
            _accesses = accesses;
            UIElementsUpdate();

            comboBoxUserPick.SelectedIndex = pickedUser = 0;
            comboBoxObjectPick.SelectedIndex = pickedObject = 0;
        }

        private void UIElementsUpdate()
        {
            comboBoxUserPick.Items.Clear();
            comboBoxObjectPick.Items.Clear();
            dataGridViewAccesses.Rows.Clear();
            dataGridViewAccesses.Columns.Clear();

            foreach (string user in _users)
                comboBoxUserPick.Items.Add(user);
            foreach (Text text in _objects)
                comboBoxObjectPick.Items.Add(text.GetName());

            dataGridViewAccesses.Columns.Add("Админ", "Админ");
            dataGridViewAccesses.Columns[0].Width = 55;
            for (int i = 0; i < _objects.Count; i++)
            {
                dataGridViewAccesses.Columns.Add(_objects[i].GetName(), _objects[i].GetName());
                dataGridViewAccesses.Columns[i + 1].Width = 55;
            }

            int pointer = 0;
            foreach (List<int> list in _accesses)
            {
                dataGridViewAccesses.Rows.Add(list);
                for (int i = 0; i < list.Count; i++)
                    dataGridViewAccesses.Rows[pointer].Cells[i].Value = list[i];
                pointer++;
            }
        }

        private void buttonUserAdd_Click(object sender, EventArgs e)
        {
            if(textBoxUserName.Text != null)
            {
                _users.Add(textBoxUserName.Text);
                List<int> list = new List<int>(_objects.Count + 1);
                for (int i = 0; i < _objects.Count + 1; i++)
                    _accesses[i].Add(0);
                UIElementsUpdate();
            }
        }

        private void buttonObjectAdd_Click(object sender, EventArgs e)
        {
            if (textBoxObjectName.Text != null)
            {
                _objects.Add(new Text(textBoxObjectName.Text, ""));
                foreach (List<int> list in _accesses)
                    list.Add(0);
                UIElementsUpdate();
            }
        }

        private void buttonUserDelete_Click(object sender, EventArgs e)
        {

        }

        private void buttonObjectDelete_Click(object sender, EventArgs e)
        {

        }

        private void buttonAccessAdd_Click(object sender, EventArgs e)
        {

        }
    }
}
