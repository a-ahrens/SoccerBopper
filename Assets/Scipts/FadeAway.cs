using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class FadeAway : MonoBehaviour
{
    private CountdownTimer countdownTimer;
    private TextMeshProUGUI textUI;

    void Awake()
    {
        textUI = GetComponent<TextMeshProUGUI>();
        countdownTimer = GetComponent<CountdownTimer>();
    }

    void Start()
    {
        Color c = textUI.color;
        c.a = 0f;
        textUI.color = c;

    }

    void Update()
    {
        float alphaRemaining = countdownTimer.GetProportionTimeRemaining();
        print(alphaRemaining);
        Color c = textUI.color;
        c.a = alphaRemaining;
        textUI.color = c;
    }

    public void StartFade(int fadeTime)
    {
        countdownTimer.ResetTimer(fadeTime);
    }
}
