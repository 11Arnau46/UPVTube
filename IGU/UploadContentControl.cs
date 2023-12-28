using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UPVTube.Services;
using UPVTube.Entities;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace IGU
{
    public partial class UploadContentControl : UserControl
    {
        private IUPVTubeService service;
        private Boolean isPublic;
        private IList<Subject> subjects;
        public UploadContentControl(IUPVTubeService service)
        {
            InitializeComponent();
            this.service = service;
            subjects = new List<Subject>();
            List<Control> textBoxes = new List<Control> { Title, Description, Url };
            foreach (var textBox in textBoxes)
            {
                SetDefaultTextAndColor(textBox, GetDefaultText(textBox));
                textBox.Enter += TextBox_Enter;
                textBox.Leave += TextBox_Leave;
            }
            //subjects = service.getAllSubjects();
            foreach (Subject s in subjects)
            {
                subjectsComboBox.Items.Add(s.Name);
            }
        }
        private void SetDefaultTextAndColor(Control textBox, string defaultText)
        {
            textBox.Text = defaultText;
            textBox.ForeColor = Color.Gray;
        }
        private void TextBox_Enter(object sender, EventArgs e)
        {
            Control control = sender as Control;
            if (control != null && control.Text == GetDefaultText(control))
            {
                control.Text = string.Empty;
                control.ForeColor = Color.Black;
            }
        }

        private void TextBox_Leave(object sender, EventArgs e)
        {
            Control control = sender as Control;
            if (control != null && string.IsNullOrWhiteSpace(control.Text))
            {
                control.Text = GetDefaultText(control);
                control.ForeColor = Color.Gray;
            }
        }

        private string GetDefaultText(Control control)
        {
            if (control == Title)
            {
                return "Add a title that describes your video...";
            }
            else if (control == Description)
            {
                return "Tell users what your video is about...";
            }
            else if (control == Url)
            {
                return "Enter a URL of your video...";
            }
           // else if (control == Subject)
            //{
               // return "Subjects related to your video...";
            //}
            return string.Empty; // Por si acaso
        }


        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void textBox_title(object sender, EventArgs e)
        {

        }

        private void textBox_Enter(object sender, EventArgs e)
        {

        }

        private void textBox_Leave(object sender, EventArgs e)
        {

        }


        private void Title_TextChanged(object sender, EventArgs e)
        {
            if (Title.Text != GetDefaultText(Title)) {
                UpdateCharacterCount(Title.Text.Length, titleNum, 180);
            }


        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void titlePanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Description_TextChanged(object sender, EventArgs e)
        {
            if (Description.Text != GetDefaultText(Description))
            {
                UpdateCharacterCount(Description.Text.Length, descriptionNum, 380);
            }

        }

        private void UpdateCharacterCount(int currentLength, Label characterCountLabel, int maxLength)
        {
            characterCountLabel.Text = $"{currentLength}/{maxLength}";
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void uploadVideoButton_Click(object sender, EventArgs e)
        {
            Content c = new Content(Url.Text,Description.Text,isPublic,Title.Text,DateTime.Now, service.getMember());
            service.UploadContent(c, subjects);
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked) isPublic = true;
            else isPublic = false;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked) isPublic = true;
            else isPublic = false;
        }

        private void añadirSubjectButton_Click(object sender, EventArgs e)
        {
           
           //subjects.Add(new Subject())
        }
    }
}