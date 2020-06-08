using Airport.Properties;
using System;
using System.Drawing;

namespace Airport.GameModel
{
    [Serializable]
    public class Plane
    {
        [Serializable]
        public enum Models
        {
            AirbusA330_200,
            Boeing747_8I,
            McDonnelDouglasMD11F
        }

        //Идентификатор самолёта
        public string ID { get; }

        //Модель самолёта
        public Models Model { get; }

        //Скорость (в км./ч.)
        public double Speed { get; }

        //Максимальная дальность перелетов (в км.)
        public double Range { get; }

        //Максимальное число пассажиров
        public uint MaxSeatings { get; }

        //Максимальная грузовместимость (в тоннах)
        public double Payload { get; }

        //контракт с магазинов (аренда или лизинг)
        public MarketContract MarketC { get; }

        public string status { get; set; }

        private double deprecationDegree;

        [Serializable]
        public enum Owns
        {
            Bought,
            Rented,
            Leased
        }

        public Owns Own { get; }
        //Степень износа
        public double DeprecationDegree
        {
            get
            {
                return deprecationDegree;
            }
            set
            {
                if (value < 0)
                    deprecationDegree = 0;
                else
                {
                    if (value > 100)
                        deprecationDegree = 100;
                    else
                        deprecationDegree = value;
                }
                DeprecationDegreeChanged?.Invoke(this, deprecationDegree);
            }
        }

        //Изображение самолета
        public Bitmap Picture
        {
            get
            {
                Bitmap picture = null;
                switch (Model)
                {
                    case Models.AirbusA330_200:
                        {
                            picture = Resources.AirbusA330_200;
                        }
                        break;
                    case Models.Boeing747_8I:
                        {
                            picture = Resources.Boeing747_8i;
                        }
                        break;
                    case Models.McDonnelDouglasMD11F:
                        {
                            picture = Resources.McDonnelDouglasMD11F;
                        }
                        break;
                }
                return picture;
            }
        }

        public Plane(string ID, Models model, Owns own, MarketContract marketContract = null)
        {
            this.ID = ID;
            Model = model;
            PlaneCharacteristics characteristics = PlaneCharacteristicsStorage.Characteristics[model];

            Speed = characteristics.Speed;
            Range = characteristics.Range;
            MaxSeatings = characteristics.MaxSeatings;
            Payload = characteristics.Payload;
            Own = own;
            MarketC = marketContract;
        }

        public Plane Clone()
        {

            Plane clone = new Plane(ID, Model, Own, MarketC);
            return clone;
        }

        public event EventHandler<double> DeprecationDegreeChanged;
    }
}
