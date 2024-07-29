using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    [SerializeField] private Text RedScoreTxt;
    [SerializeField] private Text BlueScoreTxt;
    [SerializeField] private TextMeshProUGUI ClockTxt;
    [SerializeField] private TextMeshProUGUI GoalMessageTxt;
    private FadeAway GoalMsgFadeAway;
    private ScoreBoard ScoreBoard;

    // Start is called before the first frame update
    void Start()
    {
        RedScoreTxt.text = "0";
        BlueScoreTxt.text = "0";
        GoalMessageTxt.text = "";
        GoalMsgFadeAway = GoalMessageTxt.GetComponent<FadeAway>();

        ScoreBoard = GameObject.Find("Scoreboard").GetComponent<ScoreBoard>();
    }

    public void UpdateScore(string teamColor, int score)
    {
        if(teamColor.Equals("Blue"))
        {
            BlueScoreTxt.text = score.ToString();
            GoalMessageTxt.color = Color.blue;
            GoalMessageTxt.text = "GOAAALLLLLL!";
        }
        else
        {
            RedScoreTxt.text = score.ToString();
            GoalMessageTxt.color = Color.red;
            GoalMessageTxt.text = "GOAAALLLLLL!";
        }
        GoalMsgFadeAway.StartFade(3);
    }

    public void EndOfRegulationText()
    {
        int redScore = ScoreBoard.GetRedScore();
        int blueScore = ScoreBoard.GetBlueScore();

        if (redScore > blueScore)
        {
            GoalMessageTxt.color = Color.red;
            GoalMessageTxt.text = "RED TEAM WINS!";
        }
        else if (blueScore > redScore)
        {
            GoalMessageTxt.color = Color.blue;
            GoalMessageTxt.text = "BLUE TEAM WINS!";
        }
        else
        {
            GoalMessageTxt.color = Color.white;
            GoalMessageTxt.text = "DRAW";
        }
        
        GoalMsgFadeAway.ResetTransparency();
    }
}
