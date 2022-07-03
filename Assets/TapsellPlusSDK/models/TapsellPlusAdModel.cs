﻿using System;

namespace TapsellPlusSDK.models
{
    [Serializable]
    public class TapsellPlusAdModel
    {
        public string responseId;
        public string zoneId;

        public TapsellPlusAdModel(string responseId, string zoneId)
        {
            this.responseId = responseId;
            this.zoneId = zoneId;
        }
    }
}