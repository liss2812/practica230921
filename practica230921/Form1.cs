using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace practica230921
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // instancia de la clase documento 
            Documento documento = new Documento();
            documento.setDocumentId(1);
            documento.setTitulo("practica");

            MessageBox.Show(documento.getDocumentId() + documento.getTitulo());

           
        }
    }
}
