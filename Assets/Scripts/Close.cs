using UnityEngine;
using UnityEngine.SceneManagement;

public class Close : MonoBehaviour {
    void OnMouseUpAsButton()
    {        
        SceneManager.LoadScene("language");
    }
}
