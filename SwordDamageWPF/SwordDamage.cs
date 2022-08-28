using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace SwordDamageWPF
{
    class SwordDamage
    {
        public const int BASE_DAMAGE = 3;
        public const int FLAME_DAMAGE = 2;

        public int Roll;
        private decimal magicMultiplier = 1M;
        private int flamingDamage = 0;
        public int Damage;

        private void CalculateDamage()
        {
            Damage = (int)(Roll * magicMultiplier) + BASE_DAMAGE + flamingDamage;
        }

        public void SetMagic(bool isMagic)
        {
            if (isMagic)
            {
                magicMultiplier = 1.75M;
            }
            else
            {
                magicMultiplier = 1M;
            }
            CalculateDamage();
        }

        public void SetFlaming(bool isFlaming)
        {
            CalculateDamage();
            if (isFlaming)
            {
                Damage += FLAME_DAMAGE;
            }
        }
    }
}
