﻿using System;

namespace TapsellPlusSDK.models
{
    [Serializable]
    public class AdMobNativeAd : TapsellPlusAdModel
    {
        public string adNetworkZoneId;

        public AdMobNativeAd(string responseId, string zoneId, string adNetworkZoneId) : base(responseId, zoneId)
        {
            this.adNetworkZoneId = adNetworkZoneId;
        }
    }
}