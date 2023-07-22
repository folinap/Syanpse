using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Score : MonoBehaviour
{   
    public static int a = 0;
    public static int b = 0;

    private void Update()
    {
        PlayerPrefs.SetString("Team1Score", a.ToString());
        PlayerPrefs.SetString("Team2Score", b.ToString());  
    }
    
    private void OnMouseUpAsButton()
    {              
            if (SceneManager.GetActiveScene().name == "game1")
                a++;
            else if (SceneManager.GetActiveScene().name == "game2")
                b++;
    }
}

