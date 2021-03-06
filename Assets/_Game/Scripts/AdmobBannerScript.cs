﻿using Assets._Game.Scripts;
using GoogleMobileAds.Api;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AdmobBannerScript : BaseMonoBehaviour
{
    private BannerView _bannerView;

    // Start is called before the first frame update zz
    void Start()
    {
        // Initialize the Google Mobile Ads SDK.
        MobileAds.Initialize(_appId);

        RequestBanner();
    }

    private void RequestBanner()
    {

#if UNITY_ANDROID
            string adUnitId = "ca-app-pub-3940256099942544/6300978111";
#elif UNITY_IPHONE
            string adUnitId = "ca-app-pub-3940256099942544/2934735716";
#else
        string adUnitId = "unexpected_platform";
#endif

        // Create a 320x50 banner at the top of the screen.
        _bannerView = new BannerView(adUnitId, AdSize.Banner, AdPosition.Top);

        _bannerView.OnAdLoaded += HandleOnAdLoaded;

        // Create an empty ad request.
        AdRequest request = new AdRequest.Builder().Build();

        // Load the banner with the request.
        _bannerView.LoadAd(request);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void HandleOnAdLoaded(object sender, EventArgs args)
    {
        _bannerView.Show();
    }

}
