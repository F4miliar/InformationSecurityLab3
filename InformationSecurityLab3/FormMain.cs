﻿using System;
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
    public partial class FormMain : Form
    {
        private List<string> _users;
        private List<Text> _objects;
        private List<List<int>> _accesses;

        private int pickedUser;
        private int pickedObject = -1;

        public FormMain()
        {
            InitializeComponent();
            MatrixInit();
            UIElementsUpdate();
        }

        private void MatrixInit()
        {
            _users = new List<string> { "Администратор", "Пользователь", "Читатель", "Редактор" };
            _objects = new List<Text> {
                new Text("Объект1", "Текст первого объекта"),
                new Text("Объект2", "Текст второго объекта"),
                new Text("Объект3", "Текст третьего объекта") };
            _accesses = new List<List<int>> { 
                new List<int> { 1, 0, 1, 2 },
                new List<int> { 0, 0, 0, 0 },
                new List<int> { 0, 1, 1, 1 },
                new List<int> { 0, 2, 2, 2 },
            };
        }

        private void UIElementsUpdate()
        {
            comboBoxUserPick.Items.Clear();
            listBoxObject.Items.Clear();

            foreach (string user in _users)
                comboBoxUserPick.Items.Add(user);
            foreach (Text text in _objects)
                listBoxObject.Items.Add(text.GetName());

            comboBoxUserPick.SelectedIndex = pickedUser = 0;
        }

        private void UpdateText()
        {
            if (_accesses[pickedUser][pickedObject + 1] == 0)
            {
                textBoxObjectEdit.Visible = false;
            } else if (_accesses[pickedUser][pickedObject + 1] == 1)
            {
                textBoxObjectEdit.Visible = true;
                textBoxObjectEdit.Text = _objects[pickedObject].GetText();
                textBoxObjectEdit.ReadOnly = true;
            } else if (_accesses[pickedUser][pickedObject + 1] == 2)
            {
                textBoxObjectEdit.Visible = true;
                textBoxObjectEdit.Text = _objects[pickedObject].GetText();
                textBoxObjectEdit.ReadOnly = false;
            }
        }

        private void comboBoxUserPick_SelectedIndexChanged(object sender, EventArgs e)
        {
            pickedUser = comboBoxUserPick.SelectedIndex;
            if (_accesses[pickedUser][0] == 0)
            {
                buttonUserEdit.Enabled = false;
            }
            else if (_accesses[pickedUser][0] == 1)
            {
                buttonUserEdit.Enabled = true;
            }

            if (pickedObject != -1)
                UpdateText();
        }

        private void listBoxObject_SelectedIndexChanged(object sender, EventArgs e)
        {
            pickedObject = listBoxObject.SelectedIndex;
            UpdateText();
        }

        private void textBoxObjectEdit_TextChanged(object sender, EventArgs e)
        {
            _objects[pickedObject].SetText(textBoxObjectEdit.Text);
        }

        private void buttonUserEdit_Click(object sender, EventArgs e)
        {
            FormEdit formEdit = new FormEdit(_users, _objects, _accesses);
            formEdit.ShowDialog(this);
            UpdateLists(formEdit);
            UIElementsUpdate();
        }

        private void UpdateLists(FormEdit formEdit)
        {
            _users = formEdit.GetUsers();
            _objects = formEdit.GetObjects();
            _accesses = formEdit.GetAccesses();
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
