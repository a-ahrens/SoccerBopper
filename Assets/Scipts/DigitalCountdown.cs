using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class DigitalCountdown : MonoBehaviour
{

    [SerializeField] private int TimerLength;
    private TextMeshProUGUI textClock;
    private CountdownTimer countdownTimer;
    private UIManager uiManager;

    void Awake()
    {
        textClock = GetComponent<TextMeshProUGUI>();
        countdownTimer = GetComponent<CountdownTimer>();
    }

    void Start()
    {
        uiManager = GameObject.Find("Canvas").GetComponent<UIManager>();
        countdownTimer.ResetTimer(TimerLength);

        if(uiManager == null)
        {
            Debug.LogError("UIManager not found");
        }
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
            uiManager.EndOfRegulationText();
            return "END OF REGULATION";
        }
        else
        {
            return secondsLeft.ToString();
        }
    }
}
