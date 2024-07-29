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

    //Bu de�i�kenler s�n�f�n �yeleridir. create, builds ve close, GameObject t�r�nden nesneleri i�eren listelerdir.
    //buildSystem, BuildSystem s�n�f�na bir referans tutar.
    //Builded, bir yap� in�a edilip edilmedi�ini belirtir.






    //Bu metod, bir in�aat olu�turur. create listesindeki se�ili nesneyi aktifle�tirir ve Builded de�i�kenini true yapar.
    //Daha sonra, builds listesindeki her nesneyi kontrol eder ve aktif durumunu tersine �evirir.
    //Son olarak, CloseBuilds metodunu �a��rarak di�er yap�lar� kapat�r.
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





    //Bu metod, in�aatlar� kapat�r. close listesindeki her nesneyi kontrol eder. E�er bir nesne aktif ise, onu kapat�r.
    //E�er bir nesne aktif de�ilse ve bir yap� in�a edilmemi�se, onu aktifle�tirir.
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


