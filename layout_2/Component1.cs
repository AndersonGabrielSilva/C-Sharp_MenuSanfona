using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace layout_2
{
    public partial class MenuSanfona2 : Component
    {
        public MenuSanfona2()
        {
            InitializeComponent();
        }

        public MenuSanfona2(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }
    }
}
