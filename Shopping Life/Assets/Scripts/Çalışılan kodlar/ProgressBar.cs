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
        progressbar = GetComponent<Image>();   // bu objenin �zerindeki image e ula�
        currentcoin = GameEndManager.CurrentFinalGold;
        maxcoin = GameEndManager.FinalGold;
        progressbar.fillAmount=currentcoin/maxcoin; // progress bar� ba�lang��ta durdu�u konumu ayarlar
    }

    
    void Update()
    {
        currentcoin = GameEndManager.CurrentFinalGold;
        if (progressbar.fillAmount <1) 
        { 
            progressbar.fillAmount=(float)currentcoin /(float) maxcoin; //progress bar� s�rekli g�nceller
        }
    }
    }

