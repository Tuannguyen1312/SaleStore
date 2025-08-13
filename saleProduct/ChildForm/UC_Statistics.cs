using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace saleProduct.ChildForm
{
    public partial class UC_Statistics : UserControl
    {
        private static UC_Statistics _instance;
        public static UC_Statistics Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new UC_Statistics();
                }
                return _instance;
            }
        }
        public UC_Statistics()
        {
            InitializeComponent();
        }

        
    }
}
