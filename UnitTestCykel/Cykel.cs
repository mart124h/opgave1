using System;

namespace UnitTestCykel
{
    public class Cykel
    {
        #region Instancefields
        private int _id;
        private string _farve;
        private double _pris;
        private int _gear;
        #endregion

        #region Properties
        public int Id
        {
            get { return _id; }
            set
            {
                _id = value;
            }
        }

        public string Farve
        {
            get { return _farve; }
            set
            {
                if (value.Length < 1)
                    throw new ArgumentException();

                _farve = value;
            }
        }

        public double Pris
        {
            get { return _pris; }
            set
            {
                if (value <= 0.0)
                    throw new ArgumentOutOfRangeException();
                _pris = value;
            }
        }

        public int Gear
        {
            get { return _gear; }
            set
            {
                if (value < 3 || value > 32)
                    throw new ArgumentOutOfRangeException();

                _gear = value;
            }
        }
        #endregion

        #region Constructor

        public Cykel()
        {

        }

        public Cykel(int id, string farve, double pris, int gear)
        {
            _id = id;
            _farve = farve;
            _pris = pris;
            _gear = gear;
        }

        #endregion
    }
}
