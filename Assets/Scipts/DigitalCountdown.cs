using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class DigitalCountdown : MonoBehaviour
{
    private TextMeshProUGUI textClock;
    private CountdownTimer countdownTimer;

    void Awake()
    {
        textClock = GetComponent<TextMeshProUGUI>();
        countdownTimer = GetComponent<CountdownTimer>();
    }

    void Start()
    {
        countdownTimer.ResetTimer(30);
    }

    void Update()
    {
        int timeRemaining = countdownTimer.GetSecondsRemaining();
        string message = TimerMessage(timeRemaining);
        textClock.text = message;
    }

    private string TimerMessage(int secondsLeft)
    {
        if(secondsLeft <= 0)
        {
            return "END OF REGULATION";
        }
        else
        {
            return secondsLeft.ToString();
        }
    }
}
