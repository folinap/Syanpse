using UnityEngine;
using UnityEngine.SceneManagement;

public class Start : MonoBehaviour {

    public void Starter()
    {
        SceneManager.LoadScene("score");
        PlayerPrefs.SetString("Team1Score", 0.ToString());
        PlayerPrefs.SetString("Team2Score", 0.ToString());
        Score.FirstTeamScore = 0;
        Score.SecondTeamScore = 0;
        StartGame.TeamChoose = true;
    }
}
