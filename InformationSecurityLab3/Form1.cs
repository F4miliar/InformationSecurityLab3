using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InformationSecurityLab3
{
    public partial class Form1 : Form
    {
        List<string> users;
        List<Text> objects;
        List<List<int>> accesses;

        int PickedUser;
        int PickedObject = -1;

        public Form1()
        {
            InitializeComponent();
            MatrixInit();
            UIElementsUpdate();
        }

        private void MatrixInit()
        {
            users = new List<string> { "Администратор", "Пользователь", "Читатель", "Редактор" };
            objects = new List<Text> {
                new Text("Объект1", "Текст первого объекта"),
                new Text("Объект2", "Текст второго объекта"),
                new Text("Объект3", "Текст третьего объекта") };
            accesses = new List<List<int>> { 
                new List<int> { 1, 0, 1, 2 },
                new List<int> { 0, 0, 0, 0 },
                new List<int> { 0, 1, 1, 1 },
                new List<int> { 0, 2, 2, 2 },
            };
        }

        private void UIElementsUpdate()
        {
            foreach (string user in users)
                comboBoxUserPick.Items.Add(user);
            foreach (Text text in objects)
                listBoxObject.Items.Add(text.GetName());
            comboBoxUserPick.SelectedIndex = 0;
        }

        private void UpdateText()
        {
            if (accesses[PickedUser][PickedObject + 1] == 0)
            {
                textBoxObjectEdit.Text = "";
            } else if (accesses[PickedUser][PickedObject + 1] == 1)
            {
                textBoxObjectEdit.Text = objects[PickedObject].GetText();
                textBoxObjectEdit.Enabled = false;
            } else if (accesses[PickedUser][PickedObject + 1] == 2)
            {
                textBoxObjectEdit.Text = objects[PickedObject].GetText();
                textBoxObjectEdit.Enabled = true;
            }
        }

        private void comboBoxUserPick_SelectedIndexChanged(object sender, EventArgs e)
        {
            PickedUser = comboBoxUserPick.SelectedIndex;
            if (PickedObject != -1)
                UpdateText();
        }

        private void listBoxObject_SelectedIndexChanged(object sender, EventArgs e)
        {
            PickedObject = listBoxObject.SelectedIndex;
            UpdateText();
        }

        private void textBoxObjectEdit_TextChanged(object sender, EventArgs e)
        {
            objects[PickedObject].SetText(textBoxObjectEdit.Text);
        }
    }

    public class Text
    {
        private string Name;
        private string Value;

        public Text(string name, string value)
        {
            Name = name;
            Value = value;
        }

        public string GetName() => Name;
        public string GetText() => Value;
        public void SetText(string text) { Value = text; }
    }
}
