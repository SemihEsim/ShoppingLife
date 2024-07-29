/*using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Upgrade : MonoBehaviour
{
    public int MaxCustomer;
    public int EarnGold;
    public int UpgradeCost;

   public void Upgradeinfo()
    {
       
            // Varsayalým ki ShopInfo, bir GameObject'e baðlý bir MonoBehaviour betiðidir
            ShopInfo shopInfo = GameObject.FindObjectOfType<ShopInfo>();

            if (shopInfo != null)
            {
                MaxCustomer = shopInfo.MaxCustomer+2;
                EarnGold= shopInfo.EarnGold+10;
            }
            else
            {
                Debug.LogError("ShopInfo bileþeni bulunamadý!");
            }
        

    }
}
*/