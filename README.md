# UnityMobile Base

A base app for me when starting mobile Unity projects.

Currently with Firebase and Admob installed.

Uses Git LFS. So please install Git LFS first and then clone this project instead of directly downloading the zip file.

```
git clone https://github.com/purrmiaw/unitymobilebase
```

# Steps to use

## Replace Firebase google-services files

Replace the GoogleService-Info.plist and google-services.json files with your own. You can get it from Firebase console.

https://firebase.google.com/docs/unity/setup


## Set the APP ID for Admob integration

Android: Add your AdMob app ID to the AndroidManifest.xml file in the Assets/Plugins/Android/GoogleMobileAdsPlugin .
iOS: Open PListProcessor.cs in the Assets/GoogleMobileAds/Editor and replace the Admob app ID.

https://developers.google.com/admob/unity/start

That should be it.
