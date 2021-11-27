using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    public class Weapon
    {
        private int _distance;

        public bool IsShotGun { get; set; }
        public int Damage { get; set; }
        public float ReloadTime { get; set; }
        public int Distance
        {
            get { return _distance; }
            set 
            {
                if (value > 0)
                    _distance = value;
            }

        }

        public Weapon(int damage, float reloadTime, int dist)
        {
            Damage = damage;
            ReloadTime = reloadTime;
            _distance = dist;
        }

        public string Shoot()
        {
            return "Bange-bang";
        }
    }
}
