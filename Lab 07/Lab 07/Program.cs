﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_07
{
    class Program
    {
        static void Main(string[] args)
        {

        }
    }
    class Professor : Teacher
        {
            private float emolument;  // เงินประจำตำแหน่ง

            public Professor(string name, float billingRate) : base(name, billingRate)
            {
            }

            public Professor(string name, float billingRate, float emolument)
            : this(name, billingRate)
            {
                this.emolument = emolument;
            }

            // new function, because it's different than the base version
            public new float CalculateCharge(float hours)
            {
                if (hours < 1.0F)
                    hours = 1.0F; // minimum charge.
                return (hours * billingRate) + emolument;
            }
            // new function, because it's different than the base version
            public new string TypeName()
            {
                return ("Professor");
            }
        }

    }
}

