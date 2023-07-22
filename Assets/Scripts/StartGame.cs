using UnityEngine;
using UnityEngine.SceneManagement;

public class StartGame : MonoBehaviour {
    public static bool teamChoose = true;

    void OnMouseUpAsButton()
    {
        if (teamChoose) //First team
        {                      
            SceneManager.LoadScene("game1");
            teamChoose = false;
        }
        else //Second Team
        {                      
            SceneManager.LoadScene("game2");
            teamChoose = true;
        }
    }
}
