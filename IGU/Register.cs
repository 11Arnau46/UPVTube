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

namespace IGU
{
    public partial class Register : Form
    {
        private IUPVTubeService service;
        private Login login;
        private String nickname;
        private String email;
        private String password;
        private String confirmPassword;
        private String name;
        private const string AllowedChars = " abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890^-*().";

        public Register(IUPVTubeService service)
        {
            InitializeComponent();
            this.service = service;
            login = new Login(service);
            this.Nickname_textbox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBox_KeyPress);
            this.Password_textbox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBox_KeyPress);
        }
        private void TextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Verifica si el carácter presionado no está permitido y lo maneja
            if (e.KeyChar >= ' ' && !AllowedChars.Contains(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void Register_Load(object sender, EventArgs e)
        {

        }
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void confirm_pas_textbox_TextChanged(object sender, EventArgs e)
        {
            if (Confirm_pas_textbox.Text != Password_textbox.Text)
            {
                ConfirmP_label_errors.Text = "Las contraseñas no coinciden.";
            }
            else
            {
                ConfirmP_label_errors.Text = string.Empty;
            }
        }

        private void password_textbox_TextChanged(object sender, EventArgs e)
        {
            if (Password_textbox.Text.Length < 4)
            {
                Password_label_errors.Text = "Contraseña debe tener al menos 4 caracteres.";
            }
            else
            {
                Password_label_errors.Text = string.Empty;
            }
        }

        private void nickname_textbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void email_textbox_TextChanged(object sender, EventArgs e)
        {
            if (!Email_textbox.Text.Contains("@") && (!Email_textbox.Text.Contains(".es") || !Email_textbox.Text.Contains(".com")))
            {
                Email_label_errors.Text = "Formato de correo electrónico incorrecto.";
            }
            else
            {
                Email_label_errors.Text = string.Empty;
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (CheckBox1.Checked)
            {
                Password_textbox.PasswordChar = '\0'; // Show password
                Confirm_pas_textbox.PasswordChar = '\0'; // Show confirmation password
            }
            else
            {
                Password_textbox.PasswordChar = '*'; // Hide password
                Confirm_pas_textbox.PasswordChar = '*'; // Hide confirmation password
            }
        }
        private void backToLogin_label_Click(object sender, EventArgs e)
        {
            Login loginView = new Login(service);

            // Establece el formulario actual como el propietario de la nueva ventana
            loginView.Owner = this;
            this.Hide();
            // Muestra la nueva ventana
            loginView.ShowDialog();

            // Opcional: Puedes ocultar la ventana actual si es necesario
            this.Close();
        }

        private void Register_Button_Click(object sender, EventArgs e)
        {
            String errorMessage="";
            Boolean correct = false;
            if (Email_label_errors.Text == string.Empty &&Password_label_errors.Text == string.Empty && ConfirmP_label_errors.Text == string.Empty)
            {
                nickname = Nickname_textbox.Text;
                email = Email_textbox.Text;
                name = Name_textbox.Text;
                password = Password_textbox.Text;
                confirmPassword = Confirm_pas_textbox.Text;
                if (password.Equals(confirmPassword)) {
                    try
                    {
                        correct = service.Register(email, name, DateTime.Now, nickname, password);
                    }
                    catch (ServiceException error)
                    {
                        errorMessage = error.Message;
                    }
                    //Accede directamente sin pasar por login 
                    //MEJORAR, controlar excepciones lanzadas, hacerlo más estético, el lanzamiento de errores
                    //comprobaciones y paso de Member
                    if (correct) {
                        service.Login(nickname, password);
                        Home homeView = new Home(service);
                        // Establece el formulario actual como el propietario de la nueva ventana
                        homeView.Owner = this;
                        this.Hide();
                        homeView.ShowDialog();
                        this.Close();
                    }
                    else
                    {
                        if (errorMessage.Equals("A member with this email already exists."))
                        {
                            Email_label_errors.Text = errorMessage;
                        }
                        else if (errorMessage.Equals("A member with this email already exists."))
                        {
                            Nick_label_errors.Text = errorMessage;
                        }
                    }
                }
            }
            else
            {
                // Encuentra el primer TextBox con error y establece el foco en él.
                if (Email_label_errors.Text != string.Empty)
                {
                    Email_textbox.Focus();
                    Email_textbox.Text = string.Empty;
                }
                else if (Password_label_errors.Text != string.Empty || ConfirmP_label_errors.Text != string.Empty)
                {
                    Password_textbox.Focus();
                    Password_textbox.Text = string.Empty;
                    Confirm_pas_textbox.Text = string.Empty;
                }
            }
        }

    }
}
