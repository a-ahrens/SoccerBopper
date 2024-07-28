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

    // Start is called before the first frame update
    void Start()
    {
        RedScoreTxt.text = "0";
        BlueScoreTxt.text = "0";
        GoalMessageTxt.text = "";
        GoalMsgFadeAway = GoalMessageTxt.GetComponent<FadeAway>();
    }

    public void UpdateScore(int teamNumber, int score)
    {
        if(teamNumber == 1)
        {
            BlueScoreTxt.text = score.ToString();
            GoalMessageTxt.text = "GOOOOOOOOOOAAAALLL BLUE TEAM!";
            GoalMsgFadeAway.StartFade(3);
        }
        else
        {
            RedScoreTxt.text = score.ToString();
            GoalMessageTxt.text = "GOOOOOOOOOOAAAALLL RED TEAM!";
            GoalMsgFadeAway.StartFade(3);
        }
    }
}
