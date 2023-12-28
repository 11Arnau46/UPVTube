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
using UPVTube.Persistence;

namespace IGU
{
    public partial class Login : Form
    {
        private IUPVTubeService service;
        private const string AllowedChars = " abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890^-*().";
        private const int MaxNicknameLength = 25;
        String errorMessage;
        

        bool inicio;
        public Login(IUPVTubeService service)
        {
            InitializeComponent();
            this.service = service;

            this.User_textbox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBox_KeyPress);
            this.User_textbox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBox_Limit);
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
        private void TextBox_Limit(object sender, KeyPressEventArgs e)
        {
            if (User_textbox.Text.Length + 1 > MaxNicknameLength && e.KeyChar != (char)Keys.Back)
            {
                // Si supera el límite, marca el evento como manejado y no permite la entrada
                e.Handled = true;
            }
        }



        private void Register_Label_Click(object sender, EventArgs e)
        {
            Register registerView = new Register(service);

            // Establece el formulario actual como el propietario de la nueva ventana
            registerView.Owner = this;
            this.Hide();
            // Muestra la nueva ventana
            registerView.ShowDialog();

            // Opcional: Puedes ocultar la ventana actual si es necesario
            
            this.Close();
        }

        private void Nick_TextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void Password_TextBox_TextChanged(object sender, EventArgs e)
        {
            Password_Error_Label.Text =  "";
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (CheckBox1.Checked)
            {
                Password_textbox.PasswordChar = '\0'; // Show password
            }
            else
            {
                Password_textbox.PasswordChar = '*'; // Hide password
            }
        }

        private void Login_button_Click(object sender, EventArgs e)
        {
            // (FUTURO) A IMPLEMENTAR SI SE QUIERE MOSTRAR NICKNAME INCORRECTO
            errorMessage = "";
            inicio = false;
            String user = User_textbox.Text;
            String password = Password_textbox.Text;

            try
            {
                inicio = service.Login(user, password);
            }
            catch (ServiceException error)
            {
                errorMessage = error.Message;
                
            }
            
            // Si es correcto el Login, se actualiza currentMember y se abre la ventana principal
            if (inicio)
            {
                Home homeView = new Home(service);
                // Establece el formulario actual como el propietario de la nueva ventana
                homeView.Owner = this;
                this.Hide();
                // Muestra la nueva ventana
                homeView.ShowDialog();
                this.Close();
            }
            else //no es correcto muestra mensaje contraseña incorrecta
            {
                if (errorMessage.Equals("Incorrect password."))
                {
                    Password_Error_Label.Text = errorMessage;
                    Password_textbox.Focus();

                }
                
            }

        }


       
    }
}
