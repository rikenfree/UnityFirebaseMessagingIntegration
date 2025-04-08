using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Unity.Notifications.Android;
using UnityEngine.Android;

public class Android1Notification : MonoBehaviour
{
    
    // Request authorization to send notifications
    public void RequestAuthorization()
    {
        if (!Permission.HasUserAuthorizedPermission("android.permission.POST_NOTIFICATIONS"))
        {
            Permission.RequestUserPermission("android.permission.POST_NOTIFICATIONS");
        }
    }

    // Register user notification channel
    public void RegisterNotificationChannel()
    {
        var channel = new AndroidNotificationChannel()
        {
            Id = "default_channel",
            Name = "Default Channel",
            Importance = Importance.Default,
            Description = "Notifications for app events"
        };

        AndroidNotificationCenter.RegisterNotificationChannel(channel);
    }

    // Set a notification template
    public void SendNotification(string title, string text, int fireTimeInHours)
    {
        var notification = new AndroidNotification
        {
            Title = title,
            Text = text,
            FireTime = System.DateTime.Now.AddMinutes(fireTimeInHours),
            SmallIcon = "icon_0",
            LargeIcon = "icon_1"
            
        };

        AndroidNotificationCenter.SendNotification(notification, "default_channel");
    }

   
}
