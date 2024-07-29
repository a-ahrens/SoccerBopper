using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Goal : MonoBehaviour
{

    [SerializeField] private string AddScoreToTeam;
    [SerializeField] ScoreBoard scoreBoard;


    private void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.layer == 7)
        {
            if (AddScoreToTeam.Equals("Red"))
            {
                Debug.Log("RED TEAM SCORES!");
                scoreBoard.UpdateScore("Red");
                collision.transform.position = new Vector3(0, collision.transform.position.y, 0);
            }
            else
            {
                Debug.Log("BLUE TEAM SCORES!");
                scoreBoard.UpdateScore("Blue");
                collision.transform.position = new Vector3(0, collision.transform.position.y, 0);
            }
            
        }
    }
}
