using UnityEngine;
using UnityEngine.SceneManagement;

public class Score : MonoBehaviour
{   
    public static int FirstTeamScore = 0;
    public static int SecondTeamScore = 0;
    
    public void ScoreAdd()
    {              
            if (SceneManager.GetActiveScene().name == "game1")
                FirstTeamScore++;
            else if (SceneManager.GetActiveScene().name == "game2")
                SecondTeamScore++;
        PlayerPrefs.SetString("Team1Score", FirstTeamScore.ToString());
        PlayerPrefs.SetString("Team2Score", SecondTeamScore.ToString());  
    }
}

