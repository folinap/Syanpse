using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    void OnMouseUpAsButton()
    {
        SceneManager.LoadScene("start");
        PlayerPrefs.SetString("Team1Score", 0.ToString());
        PlayerPrefs.SetString("Team2Score", 0.ToString());
        Score.a = 0;
        Score.b = 0;
        StartGame.teamChoose = true;
    }
}
