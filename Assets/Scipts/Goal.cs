using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Goal : MonoBehaviour
{

    [SerializeField] private int AddScoreToTeamNumber;
    [SerializeField] ScoreBoard scoreBoard;

    // Start is called before the first frame update
    void Start()
    {

    }

    private void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.layer == 7)
        {
            if (AddScoreToTeamNumber == 1)
            {
                Debug.Log("RED TEAM SCORES!");
                scoreBoard.UpdateScore(1);
                collision.transform.position = new Vector3(0, collision.transform.position.y, 0);
            }
            else
            {
                Debug.Log("BLUE TEAM SCORES!");
                scoreBoard.UpdateScore(2);
                collision.transform.position = new Vector3(0, collision.transform.position.y, 0);
            }
            
        }
    }
}
