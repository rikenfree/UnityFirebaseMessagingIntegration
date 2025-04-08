using System.Collections;
using UnityEngine;
#if UNITY_ANDROID
using Unity.Notifications.Android;
using UnityEngine.Android;
#endif


#if UNITY_IOS
using Unity.Notifications.iOS;
#endif

public class NotificationsController : MonoBehaviour
{
#if UNITY_ANDROID
    [SerializeField] Android1Notification Android;
#endif

#if UNITY_IOS
    [SerializeField] IosNotification Ios;
#endif

    private void Start()
    {
#if UNITY_ANDROID
        if (Android != null)
        {
            Android.RequestAuthorization();
            Android.RegisterNotificationChannel();
        }
#endif

#if UNITY_IOS
        if (Ios != null)
        {
            StartCoroutine(Ios.RequestAuthorization());
        }
#endif
    }

    private void OnApplicationFocus(bool focus)
    {
        if (!focus)
        {
#if UNITY_ANDROID
            if (Android != null)
            {
                AndroidNotificationCenter.CancelAllDisplayedNotifications();
                Android.SendNotification("Full Lives", "Your lives are now restored!", 1);
            }
#endif

#if UNITY_IOS
            if (Ios != null)
            {
                iOSNotificationCenter.RemoveAllScheduledNotifications();
                Ios.SendNotification("Full Lives", "Your lives are now restored!", "Come Back", 1);
            }
#endif
        }
    }
}
