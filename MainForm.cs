using Persons.models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Persons
{
    public partial class MainForm : Form
    {

        List<Person> persons = new List<Person>();

        public MainForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnUpload_Click(object sender, EventArgs e)
        {
            persons.Add(new Person(
                tbName.Text,
                tbAddress.Text,
                birthdate: dfBirthday.Value
                ));

            ClearFields();
        }

        private void ShowPerson(Person obj)
        {
            MessageBox.Show(obj.GetInfo());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            persons.ForEach(ShowPerson);
        }

        private void ClearFields()
        {
            this.tbName.Text = "";
            this.tbAddress.Text = "";
            this.dfBirthday.Value = DateTime.Now;

            //this.tbName.Focus;
        }
    }
}
