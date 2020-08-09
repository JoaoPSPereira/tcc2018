using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.IO.Ports;

namespace Projeto
{
    class Arduino
    {
        private String TAG;

        public Arduino()
        {

        }

        public String ReturnTagArduino(SerialPort usb_arduino)
        {
            TAG = usb_arduino.ReadLine().Replace("\r", "").ToUpper();

            return TAG;
        }

        

        public void AbrirConexao(SerialPort usb_arduino, String porta)
        {
            usb_arduino.PortName = porta;
            usb_arduino.BaudRate = 9600;
            try
            {
                usb_arduino.Open();
            }
            catch(Exception erro)
            {
                MessageBox.Show(erro.Message);
            }
        }

        public void FecharConexao(SerialPort usb_arduino)
        {
            usb_arduino.Dispose();
            usb_arduino.Close();
        }
        
    }
}
