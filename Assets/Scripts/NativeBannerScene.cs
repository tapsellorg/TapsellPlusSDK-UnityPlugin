using ArabicSupport;
using TapsellPlusSDK;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class NativeBannerScene : MonoBehaviour
{
    private const string ZoneID = "5d123c9968287d00019e1a94";
    private static string _responseId;
    [SerializeField] private RawImage adImage;
    [SerializeField] private TextMeshProUGUI adHeadline;
    [SerializeField] private TextMeshProUGUI adCallToAction;
    [SerializeField] private TextMeshProUGUI adBody;
    [SerializeField] private TextMeshProUGUI adStatus;
    [SerializeField] private TextMeshProUGUI loadStatus;
    public void Request()
    {
        loadStatus.text = "(Loading Ad...)";
        TapsellPlus.RequestNativeBannerAd(ZoneID,
            tapsellPlusAdModel =>
            {
                Debug.Log("On Response " + tapsellPlusAdModel.responseId);
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
        TapsellPlus.ShowNativeBannerAd(_responseId, this,
            tapsellPlusNativeBannerAd =>
            {
                adStatus.text = "";
                Debug.Log("onOpenAd " + tapsellPlusNativeBannerAd.zoneId);
                adHeadline.text = tapsellPlusNativeBannerAd.title;
                adCallToAction.text = tapsellPlusNativeBannerAd.callToActionText;
                adBody.text = tapsellPlusNativeBannerAd.description;
                adImage.texture = tapsellPlusNativeBannerAd.landscapeBannerImage;
                
                tapsellPlusNativeBannerAd.RegisterImageGameObject(adImage.gameObject);
                tapsellPlusNativeBannerAd.RegisterHeadlineTextGameObject(adHeadline.gameObject);
                tapsellPlusNativeBannerAd.RegisterCallToActionGameObject(adCallToAction.gameObject);
                tapsellPlusNativeBannerAd.RegisterBodyTextGameObject(adBody.gameObject);
                tapsellPlusNativeBannerAd.RegisterBodyTextGameObject(adStatus.gameObject);
                tapsellPlusNativeBannerAd.RegisterBodyTextGameObject(loadStatus.gameObject);
            },
            error => { Debug.Log("onError " + error.errorMessage); }
        );
    }
}