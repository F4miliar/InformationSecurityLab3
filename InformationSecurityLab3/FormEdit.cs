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
    public partial class FormEdit : Form
    {
        private Form _form;
        public FormEdit(Form form) //Импортировать и выгружать нормально списки
        {
            _form = form;
            InitializeComponent();
        }

        private void buttonUserAdd_Click(object sender, EventArgs e)
        {
            
        }

        private void buttonObjectAdd_Click(object sender, EventArgs e)
        {

        }
    }
}
