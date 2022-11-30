using UnityEngine;

namespace TapsellPlusSDK
{
    public class TapsellPlusAndroidPlugin : TapsellPlusPlugin
    {
#if UNITY_ANDROID
        private static AndroidJavaClass _tapsellPlus;

        private static void SetJavaObject()
        {
            _tapsellPlus = new AndroidJavaClass("ir.tapsell.plus.TapsellPlus");
        }

        private static void InitializeSDK(string key)
        {
            _tapsellPlus?.CallStatic("initialize", key);
        }

        public override void Initialize(string key)
        {
            SetJavaObject();
            InitializeSDK(key);
        }

        public override void SetDebugMode(int logLevel)
        {
            _tapsellPlus?.CallStatic("setDebugMode", logLevel);
        }

        public override void SetGdprConsent(bool consent)
        {
            _tapsellPlus?.CallStatic("setGDPRConsent", consent);
        }

        public override void RequestRewardedVideoAd(string zoneId)
        {
            _tapsellPlus?.CallStatic("requestRewardedVideoAd", zoneId);
        }

        public override void ShowRewardedVideoAd(string responseId)
        {
            _tapsellPlus?.CallStatic("showRewardedVideoAd", responseId);
        }

        public override void RequestInterstitialAd(string zoneId)
        {
            _tapsellPlus?.CallStatic("requestInterstitialAd", zoneId);
        }

        public override void ShowInterstitialAd(string responseId)
        {
            _tapsellPlus?.CallStatic("showInterstitialAd", responseId);
        }

        public override void RequestStandardBannerAd(string zoneId, int bannerSize)
        {
            _tapsellPlus?.CallStatic("requestStandardBannerAd", zoneId, bannerSize);
        }

        public override void ShowStandardBannerAd(string responseId, int horizontalGravity, int verticalGravity)
        {
            _tapsellPlus?.CallStatic("showStandardBannerAd", responseId, horizontalGravity, verticalGravity);
        }

        public override void DestroyStandardBannerAd(string responseId)
        {
            _tapsellPlus?.CallStatic("destroyStandardBannerAd", responseId);
        }

        public override void DisplayStandardBannerAd()
        {
            _tapsellPlus?.CallStatic("displayStandardBannerAd");
        }

        public override void HideStandardBannerAd()
        {
            _tapsellPlus?.CallStatic("hideStandardBannerAd");
        }

        public override void RequestNativeBannerAd(string zoneId)
        {
            _tapsellPlus?.CallStatic("requestNativeBannerAd", zoneId);
        }

        public override void ShowNativeBannerAd(string zoneId)
        {
            _tapsellPlus?.CallStatic("showNativeBannerAd", zoneId);
        }

        public override void NativeBannerAdClicked(string responseId)
        {
            _tapsellPlus?.CallStatic("nativeBannerAdClicked", responseId);
        }

        public override void SendAdMobNativeAdSuccessReport(string responseId, string adNetworkZoneId)
        {
            _tapsellPlus?.CallStatic("sendAdMobNativeAdSuccessReport", responseId, adNetworkZoneId);
        }

        public override void SendAdMobNativeAdWin(string responseId, string adNetworkZoneId)
        {
            _tapsellPlus?.CallStatic("sendAdMobNativeAdWin", responseId, adNetworkZoneId);
        }

        public override void SendAdMobNativeAdShowStart(string responseId, string adNetworkZoneId)
        {
            _tapsellPlus?.CallStatic("sendAdMobNativeAdShowStart", responseId, adNetworkZoneId);
        }

        public override void SendAdMobNativeAdFailedReport(string zoneId, string responseId, string json)
        {
            _tapsellPlus?.CallStatic("sendAdMobNativeAdFailedReport", zoneId, responseId, json);
        }
#endif
    }
}