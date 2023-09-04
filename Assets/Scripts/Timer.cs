using System.Collections;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Timer : MonoBehaviour {
    
    private readonly int _time = 60;
    [SerializeField]private InterstitialAds _interstitialAds;
    [SerializeField]private Text _shownTime;
    
    void Start () {       
        StartCoroutine(BackTime(_time));
    }

    IEnumerator BackTime(int i)
    {
        while(i > 0)
        {
            i--;
            _shownTime.text = i.ToString();
            yield return new WaitForSeconds(1);
            if (i == 0)
            {
                AdShow();
            }
        }
    }

    private void AdShow()
    {
        SceneManager.LoadScene("score");
        if (StartGame.TeamChoose)
        {
            _interstitialAds.ShowAd();
        }
    }
}
