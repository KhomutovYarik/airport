using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Drawing;
using System.Windows.Forms;
using Airport.AirportUserControls;
using Airport.CustomDialogs;
using Airport.GameLogicInterface;
using Airport.GameModel;
using Airport.GameViewController;

namespace Airport
{
    [Serializable]
    public partial class PlaneData : UserControl
    {
        public PlaneData(PlaneDataType type, IGameLogicInteractable game, List<City> cities, Plane plane)
        {
            InitializeComponent();
        }
    }
}
