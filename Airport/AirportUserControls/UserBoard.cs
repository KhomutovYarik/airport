using System.ComponentModel;
using System.Windows.Forms;
using System.ComponentModel.Design;
using System.Drawing;
using Airport.GameViewController;

namespace Airport
{
    [System.Serializable]
    [Designer("System.Windows.Forms.Design.ParentControlDesigner, System.Design", typeof(IDesigner))]
    public partial class UserBoard : UserControl, IContainerControl
    {

        public UserBoard()
        {
            InitializeComponent();
        }
    }
}
