using UnityEngine;
using UnityEngine.SceneManagement;

public class TeamWin : MonoBehaviour
{
    private readonly int winScore = 100;
    void Start()
    {
        if (StartGame.TeamChoose)
        {
            if (Score.FirstTeamScore > winScore || Score.SecondTeamScore > winScore)
            {
                SceneManager.LoadScene("end");
            }
        }
    }
}
