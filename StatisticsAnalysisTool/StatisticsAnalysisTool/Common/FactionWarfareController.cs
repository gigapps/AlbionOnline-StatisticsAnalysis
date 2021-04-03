﻿using StatisticsAnalysisTool.Enumerations;

namespace StatisticsAnalysisTool.Common
{
    public static class FactionWarfareController
    {
        public static CityFaction GetCityFactionType(byte id)
        {
            switch (id)
            {
                case 6:
                    return CityFaction.Caerleon;
                case 5:
                    return CityFaction.Thetford;
                case 4:
                    return CityFaction.Bridgewatch;
                case 3:
                    return CityFaction.FortSterling;
                case 2:
                    return CityFaction.Martlock;
                case 1:
                    return CityFaction.Lymhurst;
                default:
                    return CityFaction.Unknown;
            }
        }
    }
}