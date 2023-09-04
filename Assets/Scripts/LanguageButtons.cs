using UnityEngine;
using UnityEngine.SceneManagement;

public class LanguageButtons : MonoBehaviour
{
    public static string Language;

    public void ChangeLanguage()
    {
        SceneManager.LoadScene("start");

        switch (gameObject.name)
        {
            case "Armenian":
                Language = "Armenian";
                break;
            case "Russian":
                Language = "Russian";
                break;
            case "English":
                Language = "English";
                break;
            //case "Arabian":
            //    language = "Arabian";
            //    break;       
        }
    }
}