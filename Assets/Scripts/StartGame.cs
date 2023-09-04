using UnityEngine;
using UnityEngine.SceneManagement;

public class StartGame : MonoBehaviour {
    public static bool TeamChoose = true;

    public void SceneChooser()
    {
        if (TeamChoose) //First team
        {                      
            SceneManager.LoadScene("game1");
            TeamChoose = false;
        }
        else //Second Team
        {                      
            SceneManager.LoadScene("game2");
            TeamChoose = true;
        }
    }
}
