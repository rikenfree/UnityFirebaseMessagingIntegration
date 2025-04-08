using System.Collections;
using System.Collections.Generic;
using UnityEngine;
#if UNITY_IOS
using Unity.Notifications.iOS;
using UnityEngine.iOS;
#endif


public class IosNotification : MonoBehaviour
{
    // Request access to send notifications

#if UNITY_IOS
    public IEnumerator RequestAuthorization()
    {
        using (var request = new AuthorizationRequest(AuthorizationOption.Alert | AuthorizationOption.Badge, true))
        {
            while (!request.IsFinished)
            {
                yield return null;
            }

            if (request.Granted)
            {
                Debug.Log("Notification permission granted.");
            }
            else
            {
                Debug.LogError("Notification permission denied.");
            }
        }
    }

    // Set up notification template
    public void SendNotification(string title, string body, string subtitle, int fireTimeInHours)
    {
        var timeTrigger = new iOSNotificationTimeIntervalTrigger()
        {
            TimeInterval = new System.TimeSpan(0, fireTimeInHours, 0),
            Repeats = false
        };

        var notification = new iOSNotification()
        {
            Identifier = "lives_full",
            Title = title,
            Body = body,
            Subtitle = subtitle,
            ShowInForeground = true,
            ForegroundPresentationOption = PresentationOption.Alert | PresentationOption.Badge,
            CategoryIdentifier = "default_category",
            ThreadIdentifier = "thread1",
            Trigger = timeTrigger
        };

        notification.Trigger = timeTrigger;

        iOSNotificationCenter.ScheduleNotification(notification);
        Debug.Log("Notification scheduled: " + title);
    }
#endif
}
