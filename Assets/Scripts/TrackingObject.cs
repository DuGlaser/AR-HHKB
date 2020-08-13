using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.ARFoundation;
using UnityEngine.XR.ARSubsystems;

public class TrackingObject : MonoBehaviour
{
    [SerializeField]
    private XRReferenceObjectLibrary xRReferenceObjectLibrary;

    [SerializeField]
    private GameObject prefabOnTrack;

    [SerializeField]
    private GameObject navigatorUI;

    private ARTrackedObjectManager trackedObjectManager;

    void Start()
    {
        navigatorUI.SetActive(true);

        ARTrackedObjectManager trackedObjectManager = gameObject.AddComponent<ARTrackedObjectManager>();
        trackedObjectManager.referenceLibrary = xRReferenceObjectLibrary;
        trackedObjectManager.trackedObjectPrefab = prefabOnTrack;

        trackedObjectManager.enabled = true;
        /* trackedObjectManager.trackedObjectsChanged += OnTrackedObjectChanged; */
    }

    void Update()
    {
        /* if (trackedObjectManager.isActiveAndEnabled) */
        /* { */
        /*     navigatorUI.SetActive(false); */
        /* } */
    }

    /* private void OnTrackedObjectChanged(ARTrackedObjectsChangedEventArgs eventArgs) */
    /* { */
    /* } */
}
