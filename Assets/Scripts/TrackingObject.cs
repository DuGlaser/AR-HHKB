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

    public GameObject navigatorUI;

    private ARTrackedObjectManager trackedObjectManager;

    public static TrackingObject instance;
    void Awake() { instance = this; }

    void Start()
    {
        navigatorUI.SetActive(true);

        ARTrackedObjectManager trackedObjectManager = gameObject.AddComponent<ARTrackedObjectManager>();
        trackedObjectManager.referenceLibrary = xRReferenceObjectLibrary;
        trackedObjectManager.trackedObjectPrefab = prefabOnTrack;

        trackedObjectManager.enabled = true;
        /* trackedObjectManager.trackedObjectsChanged += OnTrackedObjectChanged; */
    }

    /* private void OnTrackedObjectChanged(ARTrackedObjectsChangedEventArgs eventArgs) */
    /* { */
    /* } */
}
