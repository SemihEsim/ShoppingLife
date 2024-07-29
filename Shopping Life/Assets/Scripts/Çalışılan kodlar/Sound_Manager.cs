using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Sound_Manager : MonoBehaviour
{
    [SerializeField] private Image Sound_OnIcon;
    [SerializeField] private Image Sound_OfIcon;

    private bool isMuted;

    private void Start()
    {
        if (!PlayerPrefs.HasKey("isMuted"))
        {
            PlayerPrefs.SetInt("isMuted", 0);
            Load();
            //�lk Ba�ta isMuted diye bir key yoksa oyun ba�larken default olarak 0 dan ba�la
        }
        else
        {
            Load();
        }
        UpdateButtonIcon();
        AudioListener.pause = isMuted;
    }
    public void OnButtonPress()
    {
        if ( !isMuted )
        {
            isMuted = true;
            AudioListener.pause = true;
        }
        else
        {

            isMuted = false;
            AudioListener.pause = false;
        }
        UpdateButtonIcon();
        Save();
    }
    private void UpdateButtonIcon() // Bu kod butonun �eklinin her bas�l��ta de�i�tirilmesi i�in yaz�lm��t�r
    {
        if( !isMuted )
        {
            Sound_OnIcon.enabled = true;
            Sound_OfIcon.enabled = false;
        }
        else
        {
            Sound_OnIcon.enabled = false;
            Sound_OfIcon.enabled = true;
        }

    }
    private void Load()
    {
        isMuted = PlayerPrefs.GetInt("isMuted") == 1;  //Her y�kledi�imde true ile ba�lat
    }
    private void Save()
    {
        PlayerPrefs.SetInt("isMuted", isMuted ? 1 : 0);  // E�er isMuted do�ru ise 1 als�n yanl�� ise 0 als�n 
    }
}
