using System.Collections;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Timer : MonoBehaviour {
    
    private readonly int time = 60;
    [SerializeField] GameObject interstitialAds;
    
    void Start () {       
        StartCoroutine("BackTime", time);
    }

    IEnumerator BackTime(int i)
    {
        while(i > 0)
        {
            i--;
            gameObject.GetComponent<Text>().text = i.ToString();
            yield return new WaitForSeconds(1);
            if (i == 0)
            {
                SceneManager.LoadScene("score");
                if (StartGame.teamChoose)
                {
                    interstitialAds.GetComponent<InterstitialAds>().ShowAd();
                }
            }
        }
    }
}
