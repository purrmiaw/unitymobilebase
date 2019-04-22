using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace Assets._Game.Scripts
{
    public class BaseMonoBehaviour : MonoBehaviour
    {
        protected string _appId {
            get
            {
                string appId = "";

#if UNITY_ANDROID
                appId = "ca-app-pub-5129348250377085~1856868770";
#elif UNITY_IPHONE
            appId = "ca-app-pub-3940256099942544~1458002511";
#else
        appId = "unexpected_platform";
#endif

                return appId;
            }
        }
    }
}
