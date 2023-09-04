using UnityEngine;
using UnityEngine.UI;

public class ShowScore : MonoBehaviour {

    [SerializeField]private Text _score1;
    [SerializeField]private Text _score2;

    void Start ()
    {
        _score1.text = PlayerPrefs.GetString("Team1Score");
        _score2.text = PlayerPrefs.GetString("Team2Score");
    }
}
