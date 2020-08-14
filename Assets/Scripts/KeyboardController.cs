using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyboardController : MonoBehaviour
{
    private float currentVelocity;


    private Dictionary<KeyCode, GameObject> KeyTable = new Dictionary<KeyCode, GameObject>();

    void Awake()
    {
        foreach (KeyCode code in Enum.GetValues(typeof(KeyCode)))
        {
            GameObject obj = GameObject.Find(code.ToString());
            if (obj != null)
            {
                try
                {
                    KeyTable.Add(code, obj);
                }
                catch
                {
                    Debug.LogError("Faild");
                    Debug.LogError(code);
                }
            }
        }
    }

    void OnEnable()
    {
        TrackingObject.instance.navigatorUI.SetActive(false);
    }

    void OnDisable()
    {
        TrackingObject.instance.navigatorUI.SetActive(true);
    }

    void Update()
    {
        foreach (var code in KeyTable)
        {
            if (Input.GetKeyDown(code.Key))
            {
                GameObject obj = code.Value;
                if (obj != null)
                {
                    KeyController keyController = obj.GetComponent<KeyController>();
                    keyController.isPushed = true;
                }
            }

            if (Input.GetKeyUp(code.Key))
            {
                GameObject obj = code.Value;
                if (obj != null)
                {
                    KeyController keyController = obj.GetComponent<KeyController>();
                    keyController.isPushed = false;
                }
            }
        }
    }
}
