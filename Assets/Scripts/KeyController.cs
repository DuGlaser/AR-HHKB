using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class KeyController : MonoBehaviour
{
    [SerializeField]
    private float keyBottomPos = 0.05f;

    [SerializeField]
    private float keyDefaultPos = 0.075f;

    [SerializeField]
    private Color defaultColor = new Color(137.0f / 255.0f, 248.0f / 255.0f, 243f / 255.0f, 1f);

    [SerializeField]
    private Color highlightColor = new Color(248.0f / 255.0f, 187.0f / 255.0f, 137.0f / 255.0f, 1f);

    public bool isPushed = false;
    private float speed = 12.0f;

    void Update()
    {
        if (isPushed && transform.position.y != keyBottomPos)
        {
            MoveKey(keyBottomPos);
            HighlightKey(highlightColor);
        }
        else if (!isPushed && transform.position.y != keyDefaultPos)
        {
            MoveKey(keyDefaultPos);
            HighlightKey(defaultColor);
        }
    }

    private void MoveKey(float toPos)
    {
        Vector3 curPos = this.transform.position;
        curPos.y = Mathf.Lerp(curPos.y, toPos, Time.deltaTime * speed);

        this.transform.position = curPos;
    }

    private void HighlightKey(Color toColor)
    {
        Color curColor = this.GetComponent<Image>().color;

        curColor.r = Mathf.Lerp(curColor.r, toColor.r, Time.deltaTime * speed);
        curColor.g = Mathf.Lerp(curColor.g, toColor.g, Time.deltaTime * speed);
        curColor.b = Mathf.Lerp(curColor.b, toColor.b, Time.deltaTime * speed);

        this.GetComponent<Image>().color = curColor;

        for (int i = 0; i < this.transform.childCount; i++)
        {
            Color curTextColor = this.transform.GetChild(i).GetComponent<TextMeshProUGUI>().color;

            curTextColor.r = Mathf.Lerp(curTextColor.r, toColor.r, Time.deltaTime * speed);
            curTextColor.g = Mathf.Lerp(curTextColor.g, toColor.g, Time.deltaTime * speed);
            curTextColor.b = Mathf.Lerp(curTextColor.b, toColor.b, Time.deltaTime * speed);

            this.transform.GetChild(i).GetComponent<TextMeshProUGUI>().color = curTextColor;
        }
    }
}
