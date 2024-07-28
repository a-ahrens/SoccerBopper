using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ScoreBoard : MonoBehaviour
{
    private int RedScore;
    private int BlueScore;
    private UIManager UIManager;

    // Start is called before the first frame update
    void Start()
    {
        RedScore = 0;
        BlueScore = 0;
        UIManager = GameObject.Find("Canvas").GetComponent<UIManager>();

        if (UIManager == null)
        {
            Debug.LogError("UI Manager not found");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void UpdateScore(int teamNumber)
    {
        if(teamNumber == 1)
        {
            RedScore++;
            UIManager.UpdateScore(teamNumber, RedScore);
        } 
        else
        {
            BlueScore++;
            UIManager.UpdateScore(teamNumber, BlueScore);
        }
    }
}
