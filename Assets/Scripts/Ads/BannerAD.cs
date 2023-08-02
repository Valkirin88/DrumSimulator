using UnityEngine;
using UnityEngine.Advertisements;


public class BannerAD : MonoBehaviour
{
    [SerializeField] BannerPosition bannerPosition;

    [SerializeField] string androidAdID = "Banner_Android";
    [SerializeField] string iOSAdID = "Banner_iOS";
    private string adID;

    private void Awake()
    {
        adID = (Application.platform == RuntimePlatform.IPhonePlayer) ? iOSAdID : androidAdID;
    }

    private void Start()
    {
        Advertisement.Banner.SetPosition(bannerPosition);
        ShowAd();
    }

    public void ShowAd()
    {
        BannerLoadOptions optionsLoad = new BannerLoadOptions { loadCallback = OnBannerLoaded, errorCallback = OnBannerError };
        Advertisement.Banner.Load(adID, optionsLoad);

        BannerOptions optionsShow = new BannerOptions { clickCallback = OnBannerClicked, hideCallback = OnBannerHidden, showCallback = OnBannerShow };
        Advertisement.Banner.Show(adID, optionsShow);
    }

    private void OnBannerLoaded()
    {
        Debug.Log("������ ��������");
    }

    private void OnBannerError(string message)
    {
        Debug.Log($"������ �������� �������: {message}");
    }

    private void OnBannerClicked()
    {
        Debug.Log("������ ��� �������");
    }

    private void OnBannerHidden()
    {
        Debug.Log("������ ��� �����");
    }

    private void OnBannerShow()
    {
        Debug.Log("������ ��� �������");
    }
}

