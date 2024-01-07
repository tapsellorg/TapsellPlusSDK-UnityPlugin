﻿using System;

namespace TapsellPlusSDK.models
{
    [Serializable]
    public class TapsellPlusRequestError
    {
        public string zoneId;
        public string message;

        public TapsellPlusRequestError(string zoneId, string message)
        {
            this.zoneId = zoneId;
            this.message = message;
        }
    }
}