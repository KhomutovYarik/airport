using Airport.GameLogicInterface;
using Airport.GameModel;
using Airport.GameViewController;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Airport
{
    [Serializable]
    public partial class ContractData : UserControl
    {
        Contract contract;
        private Flight flight;
        public uint FlightNum => flight.Number;
        IGameLogicInteractable game;
        ContractForm newForm;

        public ContractData(bool isPassenger, IGameLogicInteractable game, Contract contract, Flight flight)
        {
            InitializeComponent();
        }
    }
}
