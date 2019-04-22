﻿using Firebase;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FirebaseScript : MonoBehaviour
{
    FirebaseApp _app;
    private bool _firebaseExists = false;

    // Start is called before the first frame update
    void Start()
    {
        //Firebase.FirebaseApp.CheckAndFixDependenciesAsync().ContinueWith(task => {
        //    var dependencyStatus = task.Result;
        //    if (dependencyStatus == Firebase.DependencyStatus.Available)
        //    {
        //        // Create and hold a reference to your FirebaseApp, i.e.
        //        _app = Firebase.FirebaseApp.DefaultInstance;
        //        // where app is a Firebase.FirebaseApp property of your application class.

        //        // Set a flag here indicating that Firebase is ready to use by your
        //        // application.
        //        _firebaseExists = true;

        //        // analytics
        //        Firebase.Analytics.FirebaseAnalytics
        //          .LogEvent(Firebase.Analytics.FirebaseAnalytics.EventEarnVirtualCurrency);

        //        // push notifications
        //        Firebase.Messaging.FirebaseMessaging.TokenReceived += OnTokenReceived;
        //        Firebase.Messaging.FirebaseMessaging.MessageReceived += OnMessageReceived;

        //    }
        //    else
        //    {
        //        UnityEngine.Debug.LogError(System.String.Format(
        //          "Could not resolve all Firebase dependencies: {0}", dependencyStatus));
        //        // Firebase Unity SDK is not safe to use here.
        //    }
        //});

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void OnTokenReceived(object sender, Firebase.Messaging.TokenReceivedEventArgs token)
    {
        UnityEngine.Debug.Log("Received Registration Token: " + token.Token);
    }

    public void OnMessageReceived(object sender, Firebase.Messaging.MessageReceivedEventArgs e)
    {
        UnityEngine.Debug.Log("Received a new message from: " + e.Message.From);
    }
}
