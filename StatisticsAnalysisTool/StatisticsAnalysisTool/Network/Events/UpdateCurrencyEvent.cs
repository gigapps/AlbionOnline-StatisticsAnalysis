﻿using Albion.Network;
using StatisticsAnalysisTool.Common;
using StatisticsAnalysisTool.Enumerations;
using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace StatisticsAnalysisTool.Network.Handler
{
    public class UpdateCurrencyEvent : BaseEvent
    {
        public CityFaction CityFaction;
        public FixPoint GainedFactionPoints;
        public FixPoint BonusPremiumGainedFractionFlagPoints;
        public FixPoint TotalPlayerFactionPoints;

        public UpdateCurrencyEvent(Dictionary<byte, object> parameters) : base(parameters)
        {
            try
            {
                if (parameters.ContainsKey(1))
                {
                    CityFaction = FactionWarfareController.GetCityFactionType(parameters[1].ObjectToByte());
                }

                if (parameters.ContainsKey(2))
                {
                    GainedFactionPoints = FixPoint.FromInternalValue(parameters[2].ObjectToLong() ?? 0);
                }

                //if (parameters.ContainsKey(2))
                //{
                //    BonusPremiumGainedFractionFlagPoints = FixPoint.FromInternalValue(parameters[2].ObjectToLong() ?? 0);
                //}

                if (parameters.ContainsKey(8))
                {
                    TotalPlayerFactionPoints = FixPoint.FromInternalValue(parameters[8].ObjectToLong() ?? 0);
                }
            }
            catch (Exception e)
            {
                Debug.Print(e.Message);
            }
        }
    }
}