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

    void Start()
    {
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
