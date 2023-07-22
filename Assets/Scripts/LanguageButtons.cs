using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LanguageButtons : MonoBehaviour
{
    public static string language;
    private void OnMouseDown()
    {
        gameObject.GetComponent<RawImage>().color = Color.grey;
    }
    private void OnMouseUp()
    {
        gameObject.GetComponent<RawImage>().color = Color.white;
    }
    private void OnMouseUpAsButton()
    {
         ChangeLanguage();
    }

    private void ChangeLanguage()
    {
        SceneManager.LoadScene("start");

        switch (gameObject.name)
        {
            case "Armenian":
                language = "Armenian";
                break;
            case "Russian":
                language = "Russian";
                break;
            case "English":
                language = "English";
                break;
            //case "Arabian":
            //    language = "Arabian";
            //    break;       
        }
    }
}