using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class CreateBuild : MonoBehaviour
{
  
    public List<GameObject> create = new List<GameObject>();
    public List<GameObject> builds = new List<GameObject>();
    public List<GameObject> close = new List<GameObject>();
    public List<GameObject> upgrade = new List<GameObject>();
    public BuildSystem buildSystem;
    int gold;
    int build_cost;
    public  bool Builded;
    
    public TextMeshProUGUI goldText;

    //Bu deðiþkenler sýnýfýn üyeleridir. create, builds ve close, GameObject türünden nesneleri içeren listelerdir.
    //buildSystem, BuildSystem sýnýfýna bir referans tutar.
    //Builded, bir yapý inþa edilip edilmediðini belirtir.






    //Bu metod, bir inþaat oluþturur. create listesindeki seçili nesneyi aktifleþtirir ve Builded deðiþkenini true yapar.
    //Daha sonra, builds listesindeki her nesneyi kontrol eder ve aktif durumunu tersine çevirir.
    //Son olarak, CloseBuilds metodunu çaðýrarak diðer yapýlarý kapatýr.
    public void CreateBuilds()
    {


        gold = TotalGold.CurrentGold;
        build_cost = create[buildSystem.SelectedObject].GetComponent<ShopInfo>().BuildCost;
        if (gold >= build_cost)
        { 
        create[buildSystem.SelectedObject].gameObject.SetActive(true);
            upgrade[buildSystem.SelectedObject].gameObject.SetActive(true);
        gold -= build_cost;
            
            UpdateGoldText(gold);
            TotalGold.CurrentGold = gold;
            Builded = true;

            for (int i = 0; i < builds.Count; i++)
            {

                if (builds[i].active == true)
                {
                    builds[i].SetActive(false);
                    
                }
                else
                {
                    builds[i].SetActive(true);
                    
                }

            }
            CloseBuilds();
        }
        
    }





    //Bu metod, inþaatlarý kapatýr. close listesindeki her nesneyi kontrol eder. Eðer bir nesne aktif ise, onu kapatýr.
    //Eðer bir nesne aktif deðilse ve bir yapý inþa edilmemiþse, onu aktifleþtirir.
    public void CloseBuilds()
    {
        for (int i = 0; i < close.Count; i++)
        {

            if (close[i].active == true)
            {
                close[i].SetActive(false);
            }
            else if (close[i].active == false && Builded == false)
            {
                close[i].SetActive(true);
            }
        }
    }
    string UpdateGoldText(int gld)
    {
        return goldText.text = "Gold: " + gld.ToString();
    }
    public void Upgrade() {
        for (int i = 0; i < builds.Count; i++)
        {

            if (builds[i].active == true)
            {
                upgrade[i].SetActive(true);
            }
            else
            {
                upgrade[i].SetActive(false);
            }

        }


    }
}


