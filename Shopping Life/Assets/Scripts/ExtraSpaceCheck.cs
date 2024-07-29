using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ExtraSpaceCheck : MonoBehaviour
{
    public int TotalEarnGold; 
    public int CurrentCustomer = 0;
    public GameObject[] Extra;
    bool Building;
    public TextMeshProUGUI goldText;
    int gold;
    int Earngold;
    Animator animator;
    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Human")
            CurrentCustomer++;
    }
    public void OnTriggerExit2D(Collider2D collision)
    {
        gold = TotalGold.CurrentGold;
        if (collision.tag == "Human")
        {
            animator = collision.gameObject.GetComponent<Animator>();
            animator.SetBool("is_stop", false);

            if (CurrentCustomer > 0)
            {
                for (int i = 0; i < Extra.Length; i++)
                {
                    if (Extra[i].active == true)
                    {
                        Building = true;
                        Earngold = Extra[i].GetComponent<ShopInfo>().EarnGold;

                        
                    }
                }
                TotalEarnGold=TotalGold.TotalEarnGold+Earngold;
                TotalGold.TotalEarnGold = TotalEarnGold;
               gold = TotalGold.CurrentGold+Earngold;
                UpdateGoldText(gold);
                TotalGold.CurrentGold = gold;
                CurrentCustomer--;
            }
                
        }
    }
    string UpdateGoldText(int gld)
    {
        return goldText.text = "Gold: " + gld.ToString();
    }
}
