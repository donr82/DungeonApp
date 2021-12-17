﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Threading;

namespace DungeonLibrary
{
    public abstract class Character
    {
        private int _life;

        public string Name { get; set; }
        public int HitChance { get; set; }
        public int Dodge { get; set; }
        public int MaxLife { get; set; }
        public int Life
        {
            get { return _life; }
            set
            {
                if (value <= MaxLife)
                {
                    _life = value;
                }
                else
                {
                    _life = MaxLife;
                }
            }//end set
        }//end Life

        public virtual int CalcDodge()
        {
            return Dodge;
        }//end CalcDodge()

        public virtual int CalcHitChance()
        {
            return HitChance;
        }//end ClacHitChance()

        public virtual int CalcDamage()
        {
            return 0;
        }//end CalcDamage()




    }//end class
}//end namespace
