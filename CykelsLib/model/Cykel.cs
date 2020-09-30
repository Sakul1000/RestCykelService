using System;
using System.Collections.Generic;
using System.Text;

namespace CykelsLib.model
{
   public class Cykel
    {
        private int _id;
        private string _farve;
        private int _pris;
        private int _gear;

        public Cykel()
        {

        }

        public Cykel(int id, string farve, int pris, int gear)
        {
            _id = id;
            _farve = farve;
            _pris = pris;
            _gear = gear;


        }

        public int Id
        {
            get => _id;
            set => _id = value;
        }

        public string Farve
        {
            get => _farve;
            set => _farve = value;
        }

        public int Pris
        {
            get => _pris;
            set => _pris = value;
        }

        public int Gear
        {
            get => _gear;
            set => _gear = value;
        }

        public override string ToString()
        {
            return $"{nameof(Id)}: {Id}, {nameof(Farve)}: {Farve}, {nameof(Pris)}: {Pris}, {nameof(Gear)}: {Gear} ";
        }
    }
}
