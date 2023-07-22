using UnityEngine;
using UnityEngine.UI;

public class End : MonoBehaviour {

    [SerializeField] private GameObject winnerTeam;
	void Start()
    {
        if(Score.a > Score.b)
            winnerTeam.GetComponent<Text>().text = "Team 1 win";
        else if(Score.b > Score.a)
            winnerTeam.GetComponent<Text>().text = "Team 2 win";
        else if (Score.b == Score.a)
            winnerTeam.GetComponent<Text>().text = "Draw";
    }      
}
