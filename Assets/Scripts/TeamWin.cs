using UnityEngine;
using UnityEngine.SceneManagement;

public class TeamWin : MonoBehaviour
{
    private readonly int winScore = 100;
    void Start()
    {
        if (StartGame.teamChoose)
        {
            if (Score.a > winScore || Score.b > winScore)
            {
                SceneManager.LoadScene("end");
            }
        }
    }
}
