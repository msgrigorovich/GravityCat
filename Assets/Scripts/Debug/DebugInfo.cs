using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DebugInfo : MonoBehaviour
{
    public bool isDebugMode;
    public int avgFrameRate;
    public Text textFPS;
    public GameObject fps;
    public GameObject verion;

    void Start()
    {
        if (isDebugMode) fps.SetActive(true);verion.SetActive(true);
    }

    void Update()
    {
        float current = 0;
        current = (int)(1f / Time.unscaledDeltaTime);
        avgFrameRate = (int)current;
        textFPS.text = avgFrameRate.ToString() + " FPS";
    }
}
