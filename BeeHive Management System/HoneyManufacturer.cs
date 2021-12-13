﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace BeeHive_Management_System
{
    class HoneyManufacturer : Bee
    {
        public const float NECTAR_PROCESSED_PER_SHIFT = 33.15f;
        public override float CostPerShift
        {
            get { return 1.7f; }
        }
        public HoneyManufacturer() : base("Honey Manufacturer")
        {

        }

        protected override void DoJob()
        {
            HoneyVault.ConvertNectarToHoney(NECTAR_PROCESSED_PER_SHIFT);
        }
    }
}
