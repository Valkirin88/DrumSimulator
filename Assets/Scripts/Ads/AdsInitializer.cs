using UnityEngine.Advertisements;
using UnityEngine;

public class AdsInitializer : MonoBehaviour, IUnityAdsInitializationListener
{
    [SerializeField]
    private string _androidGameID;
    [SerializeField]
    private string _iOSGameID;
    [SerializeField]
    private bool _testMode = true;

    private string _gameID;

    private void Awake()
    {
        _gameID = (Application.platform == RuntimePlatform.IPhonePlayer) ? _iOSGameID : _androidGameID;
        Advertisement.Initialize(_gameID, _testMode, this);
    }

    public void OnInitializationComplete()
    {
        Debug.Log("Инициализация прошла успешно.");
    }

    public void OnInitializationFailed(UnityAdsInitializationError error, string message)
    {
        Debug.Log($"Ошибка инициализации: {error.ToString()} - {message}");
    }



    
}
