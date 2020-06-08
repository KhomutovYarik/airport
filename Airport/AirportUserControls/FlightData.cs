using Airport.GameLogicInterface;
using Airport.GameModel;
using Airport.GameViewController;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Airport
{
    public partial class FlightData : UserControl
    {
        public FlightData(bool isPassenger, Flight flight, IGameLogicInteractable game)
        {
            InitializeComponent();
        }
    }
}
