using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using System.ComponentModel.Design;
using Airport.GameViewController;

namespace Airport
{
    [System.Serializable]
    [Designer("System.Windows.Forms.Design.ParentControlDesigner, System.Design", typeof(IDesigner))]
    public partial class UserScroll : UserControl, IContainerControl
    {

        public UserScroll()
        {
            InitializeComponent();
        }

    }
}
