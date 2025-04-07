# :bell: Firebase Cloud Messaging Integration (Unity)
This guide walks you through integrating **Firebase Cloud Messaging (FCM)** into your Unity project for sending push notifications on Android.
---
## :white_check_mark: Prerequisites
- Unity (Android platform selected)
- Firebase Console access
- Android device or emulator for testing
---
## :rocket: Setup Steps
### 1. Firebase Project Setup
1. Visit [Firebase Console](https://console.firebase.google.com)
2. Click **"Add Project"**
3. Enter your **Project Name** → Click **Continue** (three times)
4. Choose **Default Account for Firebase Analytics** → Click **Create Project**
---
### 2. Add Unity App to Firebase
1. Go to **Project Settings** → Under **Your Apps**, click the **Unity icon**
2. Check **Android**, enter:
   - Your **Package Name**
   - Your **App Name**
   - Click **Register App**
3. Download the `google-services.json` file
4. Move the file into your Unity project's `Assets` folder
---
### 3. Import Firebase SDK
1. Download the latest [Firebase Unity SDK](https://firebase.google.com/download/unity)
2. Unzip it and import **Firebase Messaging** `.unitypackage` into your project
3. Restart Unity after import
---
### 4. Unity Setup
1. Create an **Empty GameObject** named `PushNotification`
2. Create a script named `PushNotification.cs`
3. Paste the code from:
   :link: [PushNotification Script](https://pastebin.com/raw/DqBjTFeH)
4. Attach the script to the `PushNotification` GameObject
---
### 5. Player Settings Configuration
Go to **Edit → Project Settings → Player → Other Settings**:
- :white_check_mark: **Minimum API Level**: Android 7.0 (API Level 24) or higher
- :white_check_mark: **Scripting Backend**: IL2CPP
- :white_check_mark: **Target Architectures**: ARMv7 and ARM64
---
### 6. AndroidManifest Setup (If Needed)
If you encounter build issues or crashes:
1. Navigate to `Assets/Plugins/Android`
   - If `AndroidManifest.xml` doesn't exist, create one manually
2. Ensure it includes the following permissions:
```xml
<uses-permission android:name="android.permission.INTERNET" />
<uses-permission android:name="android.permission.RECEIVE_BOOT_COMPLETED" />
<uses-permission android:name="android.permission.WAKE_LOCK" />
