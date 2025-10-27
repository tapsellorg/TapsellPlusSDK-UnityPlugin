using TapsellPlusSDK;
using UnityEngine;
using TMPro;

public class RewardedScene : MonoBehaviour
{
    private const string ZoneID = "5cfaa802e8d17f0001ffb28e";
    private static string _responseId;
    [SerializeField] private TextMeshProUGUI loadStatus;
    [SerializeField] private TextMeshProUGUI adStatus;

    public void Request()
    {
        loadStatus.text = "(Loading Ad...)";
        TapsellPlus.RequestRewardedVideoAd(ZoneID,
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
        TapsellPlus.ShowRewardedVideoAd(_responseId,
            tapsellPlusAdModel => {
                adStatus.text = "";
                 Debug.Log("onOpenAd " + tapsellPlusAdModel.zoneId); },
            tapsellPlusAdModel => { Debug.Log("onReward " + tapsellPlusAdModel.zoneId); 
            },
            tapsellPlusAdModel => { Debug.Log("onCloseAd " + tapsellPlusAdModel.zoneId); },
            error => { Debug.Log("onError " + error.errorMessage); }
        );
    }
}