using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PJ03
{
    public partial class frmQuadrado : Form
    {
        public frmQuadrado()
        {
            InitializeComponent();
        }

        private void Calcular(object sender, EventArgs e)
        {
            Quadrado q;
            q = new Quadrado();
            q.setDiagonal(int.Parse(txtDiagonal1.Text));
            q.calcularArea();

            lblresultado.Text = q.getArea().ToString();
        }
    }
}
