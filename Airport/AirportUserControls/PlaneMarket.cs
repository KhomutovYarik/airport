using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Airport.GameLogicInterface;
using Airport.GameModel;
using Airport.GameViewController;
using Airport.Properties;

namespace Airport.AirportUserControls
{
    [Serializable]
    public partial class PlaneMarket : UserControl
    {
        public PlaneMarket(IGameLogicInteractable game, Plane.Models model, int days)
        {
            InitializeComponent();
        }
    }
}
