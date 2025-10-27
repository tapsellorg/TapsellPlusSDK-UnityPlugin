using System;

namespace TapsellPlusSDK.models
{
    [Serializable]
    public class AdmobNativeAdModel
    {
        public string responseId;
        public string zoneId;
        public string adNetworkZoneId;

        public AdmobNativeAdModel(string responseId, string zoneId, string adNetworkZoneId)
        {
            this.responseId = responseId;
            this.zoneId = zoneId;
            this.adNetworkZoneId = adNetworkZoneId;
        }
    }
}