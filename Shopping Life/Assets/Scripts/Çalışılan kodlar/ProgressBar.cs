using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Progress : MonoBehaviour
{
    Image progressbar;
    public  int maxcoin;
    public int currentcoin;    
    public GameEndManager GameEndManager;
    void Start()
    {
        progressbar = GetComponent<Image>();   // bu objenin üzerindeki image e ulaþ
        currentcoin = GameEndManager.CurrentFinalGold;
        maxcoin = GameEndManager.FinalGold;
        progressbar.fillAmount=currentcoin/maxcoin; // progress barý baþlangýçta durduðu konumu ayarlar
    }

    
    void Update()
    {
        currentcoin = GameEndManager.CurrentFinalGold;
        if (progressbar.fillAmount <1) 
        { 
            progressbar.fillAmount=(float)currentcoin /(float) maxcoin; //progress barý sürekli günceller
        }
    }
    }

