using UnityEngine;
using UnityEngine.Advertisements;

public class AdsInitializer : MonoBehaviour, IUnityAdsInitializationListener
{
    [SerializeField] string androidGameID = "5349407";
    [SerializeField] bool testMode = false;

    private void Awake()
    {
        Advertisement.Initialize(androidGameID, testMode, this);
    }


    public void OnInitializationComplete()
    {
        Debug.Log("������������� ������ �������.");
    }

    public void OnInitializationFailed(UnityAdsInitializationError error, string message)
    {
        Debug.Log($"������ �������������: {error.ToString()} - {message}");
    }

}