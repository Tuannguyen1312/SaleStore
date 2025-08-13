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
    public partial class UC_ImportReceipt : UserControl
    {
        private static UC_ImportReceipt _instance;
        public static UC_ImportReceipt Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new UC_ImportReceipt();
                }
                return _instance;
            }
        }
        public UC_ImportReceipt()
        {
            InitializeComponent();
        }
    }
}
