using GoogleMobileAds.Api;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AdmobInterstitialScript : MonoBehaviour
{

    private InterstitialAd _interstitial;


    // Start is called before the first frame update
    void Start()
    {
        RequestInterstitial();   
    }

    // Update is called once per frame
    void Update()
    {
        Invoke("GameOver", 5);
    }

    private void RequestInterstitial()
    {
#if UNITY_ANDROID
        string adUnitId = "ca-app-pub-3940256099942544/1033173712";
#elif UNITY_IPHONE
        string adUnitId = "ca-app-pub-3940256099942544/4411468910";
#else
        string adUnitId = "unexpected_platform";
#endif

        // Initialize an InterstitialAd.
        _interstitial = new InterstitialAd(adUnitId);


        // Create an empty ad request.
        AdRequest request = new AdRequest.Builder().Build();
        // Load the interstitial with the request.
        _interstitial.LoadAd(request);
    }

    private void GameOver()
    {
        if (_interstitial.IsLoaded())
        {
            _interstitial.Show();
        }
    }

}
