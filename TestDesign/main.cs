using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestDesign
{
    public partial class main : UserControl
    {
        private static main _main;
        public static main MainSection
        {
            get
            {
                if (_main == null)
                {
                    _main = new main();
                }
                return _main;
            }
        }

        public main()
        {
            InitializeComponent();
        }
    }
}
