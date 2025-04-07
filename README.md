*Firebase Cloud Messaging**
> **1.** **Create New Project**
>
> **2.** **Switch Platform (Android)**
>
> **3.** **Go to Google and search for Firebase Console.**
>
> [https://console.firebase.google.com]{.underline}
![](vertopal_2866db3dc40240e0a98626cb4a574a74/media/image2.png){width="5.752777777777778in"
height="2.9093066491688537in"}![](vertopal_2866db3dc40240e0a98626cb4a574a74/media/image3.png){width="5.763888888888889in"
height="2.9305555555555554in"}
> **4.** **Create a Firebase Project.**
>
> **Click on the Highlighted Area.**
>
> **5.** **Enter Your Project Name And Click On The Continue.**
![](vertopal_2866db3dc40240e0a98626cb4a574a74/media/image1.png){width="5.759722222222222in"
height="2.8013877952755903in"}
> **6.** **Click On The Continue.**
![](vertopal_2866db3dc40240e0a98626cb4a574a74/media/image4.png){width="5.763888888888889in"
height="2.8208333333333333in"}
> **7.** **Click On The Continue.**
![](vertopal_2866db3dc40240e0a98626cb4a574a74/media/image5.png){width="5.75in"
height="2.8402777777777777in"}
> **8.** **In the Google Analytics account dropdown menu, select Default
> Account for**
>
> **Firebase & Click On The Continue.**
![](vertopal_2866db3dc40240e0a98626cb4a574a74/media/image6.png){width="5.7555555555555555in"
height="2.8in"}
> **9.** **Click on the settings icon next to Project Overview, then
> click on Project**
>
> **settings.**
![](vertopal_2866db3dc40240e0a98626cb4a574a74/media/image7.png){width="5.756944444444445in"
height="2.1916655730533683in"}
![](vertopal_2866db3dc40240e0a98626cb4a574a74/media/image9.png){width="5.756944444444445in"
height="3.3979101049868765in"}![](vertopal_2866db3dc40240e0a98626cb4a574a74/media/image10.png){width="5.763888888888889in"
height="3.4027777777777777in"}
> **10. Now, in the Your Apps section, click on the Unity icon as
> highlighted in the** **screenshot below.**
>
> **11. Now, check the Register as Android app option, enter your
> package name and** **app name, then click Register App.**
![](vertopal_2866db3dc40240e0a98626cb4a574a74/media/image8.png){width="5.756944444444445in"
height="2.6513877952755904in"}
> **12. Now, click on Download google-services.json to download your
> filethan click** **on the Next.**
>
> **13. Open the Project window of your Unity project, then move your
> downloaded** **Firebase config file into the Assets folder.**
![](vertopal_2866db3dc40240e0a98626cb4a574a74/media/image11.png){width="5.7555555555555555in"
height="2.7263888888888888in"}
> **14. Now, download the ZIP file, unzip it, and import the Firebase
> Messaging** **package into your Unity project. After that, restart
> your project.**
![](vertopal_2866db3dc40240e0a98626cb4a574a74/media/image12.png){width="5.7652777777777775in"
height="2.6416666666666666in"}
> **15. Now clcik on the Continue to console.**
![](vertopal_2866db3dc40240e0a98626cb4a574a74/media/image13.png){width="5.766666666666667in"
height="2.5125in"}
> **16. After completing these steps, go to your Unity project, create
> an empty**
**GameObject, and name it PushNotification. Then, add a new script
named**
> **PushNotification and copy-paste the following code into it:**
>
> using System.Collections;\
> using System.Collections.Generic;\
> using UnityEngine;\
> using Firebase.Messaging;\
> public class PushNotification : MonoBehaviour\
> {\
> public void Start()\
> {\
> Firebase.FirebaseApp.CheckAndFixDependenciesAsync().ContinueWith(task
> =\> { var dependencyStatus = task.Result;\
> if (dependencyStatus == Firebase.DependencyStatus.Available)\
> {\
> // Create and hold a reference to your FirebaseApp,\
> // where app is a Firebase.FirebaseApp property of your application
> class.
>
> Firebase.FirebaseApp app = Firebase.FirebaseApp.DefaultInstance; //
> Set a flag here to indicate whether Firebase is ready to use by your
> app.
>
> }\
> else\
> {\
> UnityEngine.Debug.LogError(System.String.Format(\
> \"Could not resolve all Firebase dependencies: {0}\",
> dependencyStatus)); // Firebase Unity SDK is not safe to use here.
>
> }\
> });\
> Firebase.Messaging.FirebaseMessaging.TokenReceived +=
> OnTokenReceived;\
> Firebase.Messaging.FirebaseMessaging.MessageReceived +=
> OnMessageReceived;\
> }\
> public void OnTokenReceived(object sender,
> Firebase.Messaging.TokenReceivedEventArgs token) {\
> UnityEngine.Debug.Log(\"Received Registration Token: \" +
> token.Token);\
> }\
> public void OnMessageReceived(object sender,
> Firebase.Messaging.MessageReceivedEventArgs e) {\
> UnityEngine.Debug.Log(\"Received a new message from: \" +
> e.Message.From);\
> }\
> }
>
>  **After adding the script, save it and attach it to the
> PushNotification**
>
> **GameObject in your scene.**
>
>  **Now, create a build of your project.**
>
>  **If you face any issues while building or if the application
> crashes, check the**
>
> **following:**
>
>  **1. Player Settings Adjustments**
>
>  **Go to Edit →Project Settings →Player →Other Settings, and
> ensure:**
>
>  **Minimum API Level is Android 7.0 (API Level 24) or higher.**
>
>  **Scripting Backend is set to IL2CPP (for newer Firebase
> versions).**
>
>  **Target Architectures include ARMv7 and ARM64.**
>
>  **2. AndroidManifest.xml Adjustments**
>
>  **If issues persist, modify the AndroidManifest.xml file:**
>
>  **Locate it inside Assets/Plugins/Android (if not present, generate
> one).**
>
>  **Ensure it includes Firebase permissions like:**
>
> \<uses-permission android:name=\"android.permission.INTERNET\"/\>
>
> \<uses-permission
> android:name=\"android.permission.RECEIVE_BOOT_COMPLETED\"/\>
>
> \<uses-permission android:name=\"android.permission.WAKE_LOCK\"/\>
![](vertopal_2866db3dc40240e0a98626cb4a574a74/media/image14.png){width="6.972222222222222in"
height="3.986111111111111in"}![](vertopal_2866db3dc40240e0a98626cb4a574a74/media/image15.png){width="6.966666666666667in"
height="3.2963090551181105in"}![](vertopal_2866db3dc40240e0a98626cb4a574a74/media/image16.png){width="5.777777777777778in"
height="1.5138888888888888in"}![](vertopal_2866db3dc40240e0a98626cb4a574a74/media/image17.png){width="5.768055555555556in"
height="1.4962992125984251in"}
> **17. Now, check if the build works correctly and if there are any
> crashes. If everything is working fine, go to your device\'s Build
> Information and enable Notification Permissions.**
>
> **18. Now, go to the Firebase Console, click on Run, and then select
> Messaging from** **the dropdown menu.**
>
> **19. Now, click on Create your first campaign.**
>
> **20. Now, based on the screenshot below, select any one of the
> available options** **and click Create.**
>
> ![](vertopal_2866db3dc40240e0a98626cb4a574a74/media/image18.png){width="5.426388888888889in"
> height="5.063888888888889in"}
>
> **21. Now, enter the notification title and text, then click Next.**
>
> ![](vertopal_2866db3dc40240e0a98626cb4a574a74/media/image19.png){width="4.480555555555555in"
> height="4.509722222222222in"}
>
> **22. In the second step, select your app, and in the third step,
> choose the time when you want to send the notification. If you click
> Now, the notification will be sent immediately. If you click Schedule,
> you can set a fixed date and time for the notification.Once that is
> done, click Review, then Publish. Your notification should be
> delivered to your device within 2 to 5 minutes.**
>
> **Make sure that:**
>
>  **Your build is set up correctly.**
>
>  **Notification permissions are granted.**
>
>  **If everything is configured properly, your notification should
> appear on** **your device.**
