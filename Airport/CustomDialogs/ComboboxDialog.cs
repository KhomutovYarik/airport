using Airport.GameModel;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Airport.CustomDialogs
{
    public partial class ComboboxDialog : Form
    {
        public ComboboxDialog(List<City> cities)
        {
            InitializeComponent();
        }
    }
}
