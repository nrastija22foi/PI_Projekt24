using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TestoBus.Models;

namespace TestoBus
{
    public partial class FrmUpdate : Form
    {
        public event EventHandler RequestUpdated;
        private VozniRed vozni;
        public FrmUpdate(VozniRed oznaceni)
        {
            InitializeComponent();
        }
    }
}
