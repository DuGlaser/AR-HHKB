using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyboardController : MonoBehaviour
{
    private Dictionary<KeyCode, GameObject> KeyTable = new Dictionary<KeyCode, GameObject>();

    void Start()
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

    void Update()
    {
        if (Input.anyKeyDown)
        {
            foreach (var code in KeyTable)
            {
                if (Input.GetKeyDown(code.Key))
                {
                    GameObject obj = code.Value;
                    if (obj != null)
                    {
                        obj.SetActive(false);
                    }
                }
            }
        }
    }
}
