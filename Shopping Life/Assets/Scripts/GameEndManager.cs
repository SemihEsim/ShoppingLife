using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class GameEndManager : MonoBehaviour
{
    public int FinalGold;
    public TextMeshProUGUI FinalGoldText;
    int day;
    int FinishDay;
   public int CurrentFinalGold;
    bool check=false;
    public GameObject SuccessfulEnd;
    public GameObject FailureEnd;
    public WaveSystem WaveSystem;
    public GameObject[] Humans;
    // Update is called once per frame
    void Update()
    {
        CurrentFinalGold=TotalGold.TotalEarnGold;
        day= WaveSystem.Day;
        FinishDay=WaveSystem.FinishDay;
        check=WaveSystem.check;
        UpdateFinalGoldText(CurrentFinalGold);
        if (check == true)
        {
           
            if (FinishDay == day && FinalGold <= CurrentFinalGold)
            {
                Invoke("CalculatedHuman", 1f);
               //invoke istenilen süre kadar bekletiliyor sonra çalýþtýrýyor.
               
               
            }
            else
            {
                Invoke("CalculatedHuman2", 1f);
                
               
            }
        }
    }
    string UpdateFinalGoldText(int gld)
    {
        return FinalGoldText.text = "Goal: " + gld.ToString() + "/" + FinalGold.ToString();
    }
    void CalculatedHuman()
    {

        Humans = null;
        Humans = GameObject.FindGameObjectsWithTag("Human");
        if (Humans.Length <= 0)
        {
            SuccessfulEnd.SetActive(true);
        }
    }

    void CalculatedHuman2()
    {

        Humans = null;
        Humans = GameObject.FindGameObjectsWithTag("Human");
        if (Humans.Length <= 0)
        {
            FailureEnd.SetActive(true);
        }
    }
}
