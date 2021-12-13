using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace BeeHive_Management_System
{
    static class HoneyVault
    {
        private static float honey = 25f;
        private static float nectar = 100f;
        public const float NECTAR_CONVERSION_RATIO = 0.19f;
        public const float LOW_LEVEL_WARNING = 10f;

        public static string StatusReport
        {
            get
            {
                if (honey > LOW_LEVEL_WARNING)
                {
                    return $"Vault report:\n{honey} units of honey\n" +
                                      $"{nectar} units of nectar";
                }
                else
                {
                    return $"Vault report:\n{honey} units of honey\n" +
                                      $"{nectar} units of nectar\n" +
                                      $"LOW NECTAR - ADD A NECTAR COLLECTOR";
                }

            }
        }

        public static float Honey
        {
            get
            {
                return honey;
            }
            set
            {
                honey = value;
            }

        }

        public static float Nectar
        {
            get { return nectar; }
            set
            {
                nectar = value;
            }
        }

        public static void CollectNectar(float amount)
        {
            if (amount > 0f)
            {
                Nectar += amount;
            }
        }

        public static void ConvertNectarToHoney(float amount)
        {
            float honeyCreated;
            if (amount < nectar)
            {
                Nectar -= amount;
                honeyCreated = amount * NECTAR_CONVERSION_RATIO;
                Honey += honeyCreated;
            }
            else
            {
                honeyCreated = Nectar * NECTAR_CONVERSION_RATIO;
                Honey += honeyCreated;
            }

        }

        public static bool ConsumeHoney(float amount)
        {
            if (amount < honey)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

    }
}
