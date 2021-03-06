# Expanse Asset Demo
This repo has the most simple example of using scripts inside asset bundles within the Expanse. Soon we will release a Unity plugin designed to package up your asset scripts and prefab simplifying teh process of creating asset bundles compatible with The Expanse.

### What Is This?
This is an example asset for use with the social VR platform - The Expanse. The Expanse is a metaverse style VR game with integrated content creation tools and support for loading in 3d models and unity asset bundles.

### How To Use

The included script files `ExpanseAsset.cs` and `Trigger.cs` are quite simple. The `Trigger` class is used to handle collider events and to change the color of the collider object depending on trigger enter or trigger exit ( in this case a Sphere inside the included prefab ). The `ExpanseAsset` class is used to initialise the `Trigger` class on the Sphere at runtime. This is needed as the refereneces on objects will be broken when the classes are compiled at runtime. This is because the created Components no longer have the same GUIDs as they did in the Unity Editor. We must re-add these Components at runtime using the `AddComponent` method. Then to kick things off our main class ( `ExpanseAsset` in this case ) must inherit from the class `ExpanseBehaviour` rather than `MonoBehaviour`. This means it will be automatically instantiated on the parent game object and can kick everything off. 

The included `ExpanseBehaviour` is just a dummy class to allow the untiy editor to compile your main classes without error. Once you are ready use the [Unity Asset Bundle Browser](https://assetstore.unity.com/packages/tools/utilities/asset-bundle-browser-93571) and follow the instructions [here](https://docs.unity3d.com/Manual/AssetBundles-Browser.html) to get started. When creating an android asset bundle variant, you must rename that bundle to `<MAIN_BUNDLE_NAME>_android` for instance if your main bundle is called `expanseasset` then your android variant will be named `expanseasset_android`. Once you have created your asset bundles you need to place them at a publically accessible url ( not google drive ). You can use github with github pages or githack.com or your own servers. You only need to input the main asset bundle url, The Expanse will automatically append `_android` for that platform.

In the image below the `ExpanseAsset` script will be added to the `AssetRoot` game object. You can reference the children from that point in the scene hierarchy.


![Exapnse Unity Hierarchy](https://i.imgur.com/IxErGkk.jpg)

#### TL;DR 
  * Create a dummy class called `ExpanseBehaviour` with the following code inside; 
```
using UnityEngine;
public class ExpanseBehaviour : MonoBehaviour {}
```
  * Inherit from the `ExpanseBehaviour` class for any behaviours you want to be automatically added to the root level above all prefabs.
  * Rename all script files from <NAME>.cs to <NAME>.txt
  * Add all files to an asset bundle using the [Unity Asset Bundle Browser](https://assetstore.unity.com/packages/tools/utilities/asset-bundle-browser-93571)
  * Create an android version with the same name plus `_android` i.e. `expanseasset` and `expanseasset_android`.
  * Upload your assets to a publically accessible location. 
  * Load the asset into the expanse scene editor using the main asset bundle url ( android is appended automatically ) ! 
 
 ### Demo
 Import the following url into the expanse to test this asset bundle.
 
 https://rawcdn.githack.com/the-expanse/ExpanseAsset/34a047b75eb97ef7518c7b0dcf058717ff30a7e8/AssetBundles/expanseasset


![Demo](https://raw.githubusercontent.com/the-expanse/ExpanseAsset/master/demo.gif)
