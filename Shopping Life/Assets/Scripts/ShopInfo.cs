using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class ShopInfo : MonoBehaviour
{

    public  int MaxCustomer;
    public int EarnGold;
    public float SpendTime;
    public int BuildCost;
    public int UpgradeCost;
    public int UpgradeCost2;
    public int Selected;
    public  int upgradenumber;
    public CreateBuild createBuild;
    int gold;
    public TextMeshProUGUI goldText;

    public void Upgrade()
    {
        gold= TotalGold.CurrentGold;

        if (gold >= UpgradeCost && upgradenumber == 0)
        {

                switch (Selected)
                {
                    case 0:
                        MaxCustomer = MaxCustomer + 4;
                        EarnGold = EarnGold + 25;
                        gold = gold - UpgradeCost;
                        UpdateGoldText(gold);
                        TotalGold.CurrentGold = gold;
                        upgradenumber++;

                        break;
                    case 1:
                        MaxCustomer = MaxCustomer + 5;
                        EarnGold += 45;//(deðiþcek)
                        gold = gold - UpgradeCost;
                        UpdateGoldText(gold);
                        TotalGold.CurrentGold = gold;
                        upgradenumber++;
                        break;

                case 2:
                    MaxCustomer = MaxCustomer + 6;
                    EarnGold = EarnGold + 20;
                    gold = gold - UpgradeCost;
                    UpdateGoldText(gold);
                    TotalGold.CurrentGold = gold;
                    upgradenumber++;

                    break;
                case 3:
                    MaxCustomer = MaxCustomer +8;
                    EarnGold = EarnGold + 35;
                    gold = gold - UpgradeCost;
                    UpdateGoldText(gold);
                    TotalGold.CurrentGold = gold;
                    upgradenumber++;

                    break;
                case 4:
                    MaxCustomer = MaxCustomer + 10;
                    EarnGold = EarnGold + 15;
                    gold = gold - UpgradeCost;
                    UpdateGoldText(gold);
                    TotalGold.CurrentGold = gold;
                    upgradenumber++;

                    break;
                case 5:
                    MaxCustomer = MaxCustomer + 9;
                    EarnGold = EarnGold + 40;
                    gold = gold - UpgradeCost;
                    UpdateGoldText(gold);
                    TotalGold.CurrentGold = gold;
                    upgradenumber++;

                    break;
                case 6:
                    MaxCustomer = MaxCustomer + 8;
                    EarnGold = EarnGold + 50;
                    gold = gold - UpgradeCost;
                    UpdateGoldText(gold);
                    TotalGold.CurrentGold = gold;
                    upgradenumber++;

                    break;
                case 7:
                    MaxCustomer = MaxCustomer + 20;
                    EarnGold = EarnGold + 75;
                    gold = gold - UpgradeCost;
                    UpdateGoldText(gold);
                    TotalGold.CurrentGold = gold;
                    upgradenumber++;

                    break;
                case 8:
                    MaxCustomer = MaxCustomer + 20;
                    EarnGold = EarnGold + 75;
                    gold = gold - UpgradeCost;
                    UpdateGoldText(gold);
                    TotalGold.CurrentGold = gold;
                    upgradenumber++;

                    break;


            }
        }

       else if (gold >= UpgradeCost2)
       {
          
            if (upgradenumber == 1)
            {
               
                switch (Selected)
                {
                    case 0:
                        MaxCustomer = MaxCustomer + 4;
                        EarnGold = EarnGold + 25;
                        gold = gold - UpgradeCost2;
                        UpdateGoldText(gold);
                        TotalGold.CurrentGold = gold;
                        createBuild.upgrade[Selected].gameObject.SetActive(false);  //upgrade butonunu kapatýr.
                        break;
                    case 1:
                        MaxCustomer = MaxCustomer + 5;
                        
                        EarnGold += 30;//(deðiþcek)
                        gold = gold - UpgradeCost2;
                        UpdateGoldText(gold);
                        TotalGold.CurrentGold = gold;
                        createBuild.upgrade[Selected].gameObject.SetActive(false);
                        break;
                    case 2:
                        MaxCustomer = MaxCustomer + 6;
                        EarnGold = EarnGold + 20;
                        gold = gold - UpgradeCost2;
                        UpdateGoldText(gold);
                        TotalGold.CurrentGold = gold;
                        createBuild.upgrade[Selected].gameObject.SetActive(false);
                        break;
                    case 3:
                        MaxCustomer = MaxCustomer + 8;
                        EarnGold = EarnGold + 35;
                        gold = gold - UpgradeCost2;
                        UpdateGoldText(gold);
                        TotalGold.CurrentGold = gold;
                        createBuild.upgrade[Selected].gameObject.SetActive(false);
                        break;
                    case 4:
                        MaxCustomer = MaxCustomer + 10;
                        EarnGold = EarnGold + 10;
                        gold = gold - UpgradeCost2;
                        UpdateGoldText(gold);
                        TotalGold.CurrentGold = gold;
                        createBuild.upgrade[Selected].gameObject.SetActive(false);

                        break;
                    case 5:
                        MaxCustomer = MaxCustomer + 9;
                        EarnGold = EarnGold + 40;
                        gold = gold - UpgradeCost2;
                        UpdateGoldText(gold);
                        TotalGold.CurrentGold = gold;
                        createBuild.upgrade[Selected].gameObject.SetActive(false);
                        break;
                    case 6:
                        MaxCustomer = MaxCustomer + 8;
                        EarnGold = EarnGold + 50;
                        gold = gold - UpgradeCost2;
                        UpdateGoldText(gold);
                        TotalGold.CurrentGold = gold;
                        createBuild.upgrade[Selected].gameObject.SetActive(false);
                        break;
                    case 7:
                        MaxCustomer = MaxCustomer + 20;
                        EarnGold = EarnGold + 75;
                        gold = gold - UpgradeCost2;
                        UpdateGoldText(gold);
                        TotalGold.CurrentGold = gold;
                        createBuild.upgrade[Selected].gameObject.SetActive(false);
                        break;
                    case 8:
                        MaxCustomer = MaxCustomer + 20;
                        EarnGold = EarnGold + 75;
                        gold = gold - UpgradeCost2;
                        UpdateGoldText(gold);
                        TotalGold.CurrentGold = gold;
                        createBuild.upgrade[Selected].gameObject.SetActive(false);
                        break;


                }
            }
       }
        
        

    }
    string UpdateGoldText(int gld)
    {
        return goldText.text = "Gold: " + gld.ToString();
    }

}
