using UnityEngine;
using UnityEngine.UI;

public class ShowScore : MonoBehaviour {

    [SerializeField]private GameObject score1;
    [SerializeField]private GameObject score2;

    void Start ()
    {
        score1.GetComponent<Text>().text = PlayerPrefs.GetString("Team1Score");
        score2.GetComponent<Text>().text = PlayerPrefs.GetString("Team2Score");
    }
}
