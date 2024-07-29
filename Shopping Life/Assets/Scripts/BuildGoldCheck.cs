using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuildGoldCheck : MonoBehaviour
{



    public GameObject[] Shop; 
    public GameObject[] BackGroundShop;
    //public TotalGold totalGold;
    int totalGoldCount;


    private void Update()
    {
        
        for (int i = 0; i < Shop.Length; i++)
        {
            if (TotalGold.CurrentGold < Shop[i].GetComponent<ShopInfo>().BuildCost) 
            {
                Shop[i].SetActive(false);
                BackGroundShop[i].SetActive(true);
          
            }
            else {
                Shop[i].SetActive(true);
                BackGroundShop[i].SetActive(false);

            }
        }
    }
}

