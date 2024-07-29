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
            //Ýlk Baþta isMuted diye bir key yoksa oyun baþlarken default olarak 0 dan baþla
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
    private void UpdateButtonIcon() // Bu kod butonun þeklinin her basýlýþta deðiþtirilmesi için yazýlmýþtýr
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
        isMuted = PlayerPrefs.GetInt("isMuted") == 1;  //Her yüklediðimde true ile baþlat
    }
    private void Save()
    {
        PlayerPrefs.SetInt("isMuted", isMuted ? 1 : 0);  // Eðer isMuted doðru ise 1 alsýn yanlýþ ise 0 alsýn 
    }
}
