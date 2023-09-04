using UnityEngine;
using UnityEngine.UI;

public class End : MonoBehaviour {

    [SerializeField] private Text _winnerTeam;
	void Start()
    {
        if(Score.FirstTeamScore > Score.SecondTeamScore)
            _winnerTeam.text = "Team 1 win";
        else if(Score.SecondTeamScore > Score.FirstTeamScore)
            _winnerTeam.text = "Team 2 win";
        else if (Score.SecondTeamScore == Score.FirstTeamScore)
            _winnerTeam.text = "Draw";
    }      
}
