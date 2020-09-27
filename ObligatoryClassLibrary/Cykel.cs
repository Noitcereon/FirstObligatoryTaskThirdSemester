using System;
using System.Collections.Generic;
using System.Text;

namespace ObligatoryClassLibrary
{
    public class Cykel
    {
        private int _id;
        private string _farve;
        private decimal _pris;
        private int _gear;

        public Cykel()
        {

        }
        public Cykel(int id, string farve, decimal pris, int gear)
        {
            Id = id;
            Farve = farve;
            Pris = pris;
            Gear = gear;
        }

        public int Id
        {
            get => _id;
            set => _id = value;
        }

        public string Farve
        {
            get => _farve;
            set
            {
                if(value.Length < 2) { throw new ArgumentOutOfRangeException("_farve", "_farve must be at least 2 letters");}
                _farve = value;
            }
        }

        public decimal Pris
        {
            get => _pris;
            set
            {
                if (value < 0) { throw new ArgumentOutOfRangeException("_pris", "_pris cannot be negative."); }
                _pris = value;
            }
        }

        public int Gear
        {
            get => _gear;
            set
            {
                if(value > 32 || value < 3) { throw new ArgumentOutOfRangeException("_gear","_gear must be no less than 3 and no more than 32."); }
                _gear = value;
            }
        }

        public override string ToString()
        {
            return $"Id: {Id}, Farve: {Farve}, Gear: {Gear}, Pris: {Pris}";
        }
    }
}
