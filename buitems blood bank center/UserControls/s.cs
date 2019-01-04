using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace buitems_blood_bank_center
{
    public partial class s : UserControl
    {

        private static s _instance;
        public static s Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new s();
                return _instance;
            }
        }
        public s()
        {
            InitializeComponent();
        }
    }
}
