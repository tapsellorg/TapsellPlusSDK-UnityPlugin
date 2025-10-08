using TapsellPlusSDK;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FirstScene : MonoBehaviour
{
    private const string TapsellPlusKey = "alsoatsrtrotpqacegkehkaiieckldhrgsbspqtgqnbrrfccrtbdomgjtahflchkqtqosa";

    private void Start()
    {
        TapsellPlus.Initialize(TapsellPlusKey,
            adNetworkName => Debug.Log(adNetworkName + " Initialized Successfully."),
            error => Debug.Log(error.ToString()));
        TapsellPlus.SetGdprConsent(true);
        TapsellPlus.SetDebugMode(3);
    }

    public void ChangeScenes(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }
}