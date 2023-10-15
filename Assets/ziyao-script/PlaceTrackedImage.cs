using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR;
using UnityEngine.XR.ARFoundation;

public class PlaceTrackedImage : MonoBehaviour
{
    private ARTrackedImageManager _arTrackedImageManager;
    private void Awake()
    {
        _arTrackedImageManager = FindObjectOfType<ARTrackedImageManager>();
    }
    public void OnEnable()
    {
        _arTrackedImageManager.trackedImagesChanged += imagechanged;
    }
    public void OnDisable()
    {
        _arTrackedImageManager.trackedImagesChanged -= imagechanged;
    }
    public void imagechanged(ARTrackedImagesChangedEventArgs args)
    {
        foreach (var trackedimage in args.added)
        {
            Debug.Log(trackedimage.name);
        }
    }
}
    