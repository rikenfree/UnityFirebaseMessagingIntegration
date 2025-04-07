# Firebase Cloud Messaging Integration (Unity)
---
## :rocket: Getting Started
### 1. Create a New Unity Project
### 2. Switch Platform to **Android** via **File > Build Settings**
---
## :wrench: Firebase Console Setup
1. Go to :point_right: [Firebase Console](https://console.firebase.google.com)
2. Click **"Add Project"**
3. Enter your **Project Name**, then click **Continue**
4. Continue through Analytics setup
5. In Google Analytics, select **Default Account for Firebase**
6. Once created, go to **Project Settings** (:gear:)
7. Scroll to **Your Apps** and click the **Unity** icon
8. Check **Register as Android app**, enter your **Package Name** and **App Name**, then click **Register App**
9. Download the `google-services.json` file
---
## :electric_plug: Unity Setup
1. Place `google-services.json` inside the `Assets/` folder
2. Download and import the [Firebase Unity SDK](https://firebase.google.com/download/unity)
   - Unzip it and import **Firebase Messaging** into Unity
3. Restart Unity
---
## :jigsaw: Firebase Code Integration in Unity
1. In Unity:
   - Create an **Empty GameObject** and name it `PushNotification`
   - Create a new C# script called `PushNotification.cs`
   - Copy the code from :point_right: [PushNotification Script Code](https://pastebin.com/raw/DqBjTFeH)
   - Attach the script to the `PushNotification` GameObject
2. Make a build of your project
---
## :warning: Troubleshooting (Build/Crash Issues)
### Player Settings
Go to **Edit > Project Settings > Player > Other Settings** and set:
- **Minimum API Level**: Android 7.0 (API Level 24) or higher
- **Scripting Backend**: IL2CPP
- **Target Architectures**: ARMv7 and ARM64
###:test_tube: Testing Push Notifications
- **On your Android device:
- **Go to Settings > App Info > Notification and ensure it's enabled
- **On Firebase Console:
- **Go to Run > Messaging
- **Click Create your first campaign
- **Choose Notification, then click Create
- **Enter Title and Message
- **Select your App
- **Choose Send Now or Schedule
- **Click Review then Publish
##:calling: Your device should receive the notification within 2–5 minutes
##:white_check_mark: Final Checklist
 - **Unity build is working
- ** Notification permission allowed
- ** google-services.json correctly placed in Assets
### AndroidManifest.xml Setup
If `AndroidManifest.xml` doesn't exist in `Assets/Plugins/Android`, create one with:
```xml
<uses-permission android:name="android.permission.INTERNET" />
<uses-permission android:name="android.permission.RECEIVE_BOOT_COMPLETED" />
<uses-permission android:name="android.permission.WAKE_LOCK" />
