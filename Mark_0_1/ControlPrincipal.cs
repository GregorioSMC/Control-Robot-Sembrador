using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FireSharp.Config;
using FireSharp.Interfaces;
using FireSharp.Response;
using FireSharp;
using ROBOTIS;

namespace Mark_0_1
{
    public partial class ControlPrincipal : Form
    {


        IFirebaseConfig fireConfig = new FirebaseConfig
        {
            AuthSecret = "Clave-YourFirebase",
            BasePath = "URL-YourFirebase"
        };

        IFirebaseClient fireCliente;

        public const int DEFAULT_PORTNUM = 20;
        public const int DEFAULT_BAUDRATE = 1;
        bool flagDireccion;
        bool flagVelocidad;


        public ControlPrincipal()
        {
            fireCliente = new FireSharp.FirebaseClient(fireConfig);

            if (fireCliente != null)
            {
                MessageBox.Show("Existe Conexion con Firebase");
            }
            else
            {
                MessageBox.Show("Revisa la Conexion con Firebase");
            }

            InitializeComponent();
            dynamixel.dxl_initialize(DEFAULT_PORTNUM, DEFAULT_BAUDRATE);
        }

        private void btnAvanzar_Click(object sender, EventArgs e)
        {
            Avanzar();
        }


        private void Avanzar()
        {
            flagDireccion = false;
            flagVelocidad = false;
            int dir = tkbDireccion.Value;
            int velocidad = tkbVelocidad.Value;
            dynamixel.dxl_write_word(1, 30, dir);
            dynamixel.dxl_write_word(2, 30, dir);
            dynamixel.dxl_write_word(3, 32, velocidad);
            dynamixel.dxl_write_word(4, 32, velocidad | 0x400);
            dynamixel.dxl_write_word(5, 32, velocidad);
            dynamixel.dxl_write_word(6, 32, velocidad | 0x400);
            dynamixel.dxl_write_word(10, 32, velocidad);
        }

        private void Detener()
        {
            tkbDireccion.Value = 2048;
            dynamixel.dxl_write_word(1, 30, 2048);
            dynamixel.dxl_write_word(2, 30, 2048);
            dynamixel.dxl_write_word(3, 32, 0);
            dynamixel.dxl_write_word(4, 32, 0);
            dynamixel.dxl_write_word(5, 32, 0);
            dynamixel.dxl_write_word(6, 32, 0);
            dynamixel.dxl_write_word(10, 32, 0);
        }

        private void Retroceder()
        {
            flagDireccion = true;
            flagVelocidad = true;
            int dir = tkbDireccion.Value;
            int velocidad = tkbVelocidad.Value;
            dynamixel.dxl_write_word(1, 30, dir);
            dynamixel.dxl_write_word(2, 30, dir);
            dynamixel.dxl_write_word(3, 32, velocidad | 0x400);
            dynamixel.dxl_write_word(4, 32, velocidad);
            dynamixel.dxl_write_word(5, 32, velocidad | 0x400);
            dynamixel.dxl_write_word(6, 32, velocidad);
            dynamixel.dxl_write_word(10, 32, velocidad | 0x400);
        }

        private void btnDetener_Click(object sender, EventArgs e)
        {
            Detener();
        }

        private void tkbVelocidad_Scroll(object sender, EventArgs e)
        {
            int velocidad = tkbVelocidad.Value;
            int dir = tkbDireccion.Value;

            if (flagVelocidad)
            {
                dynamixel.dxl_write_word(1, 30, dir);
                dynamixel.dxl_write_word(2, 30, dir);
                dynamixel.dxl_write_word(3, 32, velocidad | 0x400);
                dynamixel.dxl_write_word(4, 32, velocidad);
                dynamixel.dxl_write_word(5, 32, velocidad | 0x400);
                dynamixel.dxl_write_word(6, 32, velocidad);
                dynamixel.dxl_write_word(10, 32, velocidad | 0x400);

            }
            else
            {
                dynamixel.dxl_write_word(1, 30, dir);
                dynamixel.dxl_write_word(2, 30, dir);
                dynamixel.dxl_write_word(3, 32, velocidad);
                dynamixel.dxl_write_word(4, 32, velocidad | 0x400);
                dynamixel.dxl_write_word(5, 32, velocidad);
                dynamixel.dxl_write_word(6, 32, velocidad | 0x400);
                dynamixel.dxl_write_word(10, 32, velocidad);
            }

        }

        private void tmVoz_Tick(object sender, EventArgs e)
        {
            Voz();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            tmVoz.Enabled = false;
        }

        private async void Insertar()
        {

            var datex = new Datex
            {
                val = "null"
            };

            FirebaseResponse au = await fireCliente.UpdateAsync("Mark0/", datex);

        }

        internal class Datex
        {
            public string val { get; set; }
        }


        private async void Voz()
        {
            FirebaseResponse res = await fireCliente.GetAsync("Mark0/");
            Datex std = res.ResultAs<Datex>();
            string opc = std.val;

            switch (opc)
            {
                case "0":                   
                    Detener();
                    break;

                case "1":               
                    Avanzar();                    
                    break;

                case "2":                    
                    Retroceder();
                    break;
            }

        }

        private void btnVozOn_Click(object sender, EventArgs e)
        {
            tmVoz.Enabled = true;
        }

        private void btnVozOff_Click(object sender, EventArgs e)
        {
            tmVoz.Enabled = false;
        }

        private void btnRetroceder_Click(object sender, EventArgs e)
        {
            Retroceder();
        }

        private void lblVelocidad_Click(object sender, EventArgs e)
        {

        }

        private void tkbDireccion_Scroll(object sender, EventArgs e)
        {
            int velocidad = tkbVelocidad.Value;
            int dir = tkbDireccion.Value;

            if (flagDireccion)
            {
                dynamixel.dxl_write_word(1, 30, dir);
                dynamixel.dxl_write_word(2, 30, dir);
                dynamixel.dxl_write_word(3, 32, velocidad | 0x400);
                dynamixel.dxl_write_word(4, 32, velocidad);
                dynamixel.dxl_write_word(5, 32, velocidad | 0x400);
                dynamixel.dxl_write_word(6, 32, velocidad);
                dynamixel.dxl_write_word(10, 32, velocidad | 0x400);

            }
            else
            {
                dynamixel.dxl_write_word(1, 30, dir);
                dynamixel.dxl_write_word(2, 30, dir);
                dynamixel.dxl_write_word(3, 32, velocidad);
                dynamixel.dxl_write_word(4, 32, velocidad | 0x400);
                dynamixel.dxl_write_word(5, 32, velocidad);
                dynamixel.dxl_write_word(6, 32, velocidad | 0x400);
                dynamixel.dxl_write_word(10, 32, velocidad);
            }
        }
    }
}
