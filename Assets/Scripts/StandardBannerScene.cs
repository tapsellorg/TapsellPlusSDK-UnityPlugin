using TapsellPlusSDK;
using TapsellPlusSDK.models;
using UnityEngine;
using TMPro;

public class StandardBannerScene : MonoBehaviour
{
    private const string ZoneID = "5cfaaa30e8d17f0001ffb294";
    private static string _responseId;
    [SerializeField] private TextMeshProUGUI loadStatus;
    [SerializeField] private TextMeshProUGUI adStatus;


    public void Request()
    {
        loadStatus.text = "(Loading Ad...)";
        TapsellPlus.RequestStandardBannerAd(ZoneID, BannerType.Banner320X50,
            tapsellPlusAdModel =>
            {
                Debug.Log("on response " + tapsellPlusAdModel.responseId);
                loadStatus.text = "";
                adStatus.text = "•";
                _responseId = tapsellPlusAdModel.responseId;
            },
            error => { 
                loadStatus.text = "";
                Debug.Log("Error " + error.message); 
                }
        );
    }

    public void Show()
    {
        TapsellPlus.ShowStandardBannerAd(_responseId, Gravity.Bottom, Gravity.Center,
            tapsellPlusAdModel => {
                 adStatus.text = "";
                 Debug.Log("onOpenAd " + tapsellPlusAdModel.zoneId); 
                 },
            error => { Debug.Log("onError " + error.errorMessage); }
        );
    }

    public void Hide()
    {
        TapsellPlus.HideStandardBannerAd();
    }

    public void Display()
    {
        TapsellPlus.DisplayStandardBannerAd();
    }

    public void Destroy()
    {
        TapsellPlus.DestroyStandardBannerAd(_responseId);
    }
}