using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AntecedentesPenalesApp.Business
{
    internal class AuxiliarClass
    {
        public void LoadModule(Form moduleForm, Panel panel)
        {
            // Limpia el panel
            panel.Controls.Clear();

            // Configura el formulario para que se muestre dentro del panel
            moduleForm.TopLevel = false;
            moduleForm.Dock = DockStyle.Fill;
            panel.Controls.Add(moduleForm);
            moduleForm.Show();
        }
    }
}
