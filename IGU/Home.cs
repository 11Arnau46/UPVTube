using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UPVTube.Entities;
using UPVTube.Services;
using static System.Net.Mime.MediaTypeNames;

namespace IGU
{
    public partial class Home : Form
    {
        private IUPVTubeService service;
        private Button lastActiveButton;
        private Member member;
        public Home(IUPVTubeService service)
        {
            InitializeComponent();
            this.service = service;
            SidePanel.Height = videos.Height;
            SidePanel.Top = videos.Top;
            videosControl1.BringToFront();
            ChangeActiveButtonColor(videos);
            member = service.getMember();
            if(member == null)
            {
                member = new Member("upv.edu.es", "Juan", DateTime.Now, "juanito", "1234");
            }
            nickname.Text = member.Nick;
        }

        private void videos_button(object sender, EventArgs e)
        {
            ChangeActiveButtonColor(videos);
            SidePanel.Height = videos.Height;
            SidePanel.Top = videos.Top;
            videosControl1.BringToFront();
        }

        private void history_button(object sender, EventArgs e)
        {
            SidePanel.Height = history.Height;
            SidePanel.Top = history.Top;
            historyControl1.BringToFront();
            ChangeActiveButtonColor(history);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Home_Load(object sender, EventArgs e)
        {

        }

        private void evaluate_content_button(object sender, EventArgs e)
        {
            SidePanel.Height = evaluate_content.Height;
            SidePanel.Top = evaluate_content.Top;
            evaluateContentControl1.BringToFront();
            ChangeActiveButtonColor(evaluate_content);

        }

        private void logout_Click(object sender, EventArgs e)
        {
            service.Logout(member);
            Login loginView = new Login(service);

            // Establece el formulario actual como el propietario de la nueva ventana
            loginView.Owner = this;
            this.Hide();
            // Muestra la nueva ventana
            loginView.ShowDialog();

            // Opcional: Puedes ocultar la ventana actual si es necesario
            this.Close();
        }

        private void upload_content_Click(object sender, EventArgs e)
        {
            SidePanel.Height = upload_content.Height;
            SidePanel.Top = upload_content.Top;
            uploadContentControl1.BringToFront();
            ChangeActiveButtonColor(upload_content);
        }
        private void ChangeActiveButtonColor(Button newActiveButton)
        {
            // Restaurar el color del botón anterior
            if (lastActiveButton != null)
            {
                SetButtonBackgroundColor(lastActiveButton, Color.FromArgb(41,56, 79)); // Puedes cambiar SystemColors.Control al color original de tus botones
            }

            // Almacenar el nuevo botón como activo y cambiar su color
            lastActiveButton = newActiveButton;
            SetButtonBackgroundColor(lastActiveButton, Color.FromArgb(64, 64, 125));
        }
        private void SetButtonBackgroundColor(Button button, Color color)
        {
            if (button != null)
            {
                button.BackColor = color;
            }
        }

       
    }
}
