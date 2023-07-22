using UnityEngine;
using UnityEngine.Advertisements;

public class InterstitialAds : MonoBehaviour, IUnityAdsLoadListener, IUnityAdsShowListener
{
    [SerializeField] string androidAdID = "Interstitial_Android";
    private string adID;

    private void Awake()
    {
        adID = androidAdID;
    }

    public void ShowAd()
    {
        Advertisement.Load(adID, this);
        Advertisement.Show(adID, this);
    }

    public void OnUnityAdsAdLoaded(string placementId)
    {
        Debug.Log("������� ���������: " + placementId);
    }

    public void OnUnityAdsFailedToLoad(string placementId, UnityAdsLoadError error, string message)
    {
        Debug.Log($"������ �������� �������: {error.ToString()} - {message}");
    }

    public void OnUnityAdsShowFailure(string placementId, UnityAdsShowError error, string message)
    {
        Debug.Log($"������ ������ �������: {error.ToString()} - {message}");
    }

    public void OnUnityAdsShowStart(string placementId)
    {
        Debug.Log("����� ������ �������: " + placementId);
    }

    public void OnUnityAdsShowClick(string placementId)
    {
        Debug.Log("���� �� �������: " + placementId);
    }

    public void OnUnityAdsShowComplete(string placementId, UnityAdsShowCompletionState showCompletionState)
    {
        Debug.Log("����� �������� ����� �������.");
    }

}