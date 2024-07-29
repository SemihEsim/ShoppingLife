using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
using TMPro;

[System.Serializable]  // class ýn inspector de gözükmesi için 
public class HumanWave
{
    
    public string waveName;
    [System.Serializable]
    public class Humanitem
    {
        public GameObject[] Human;
        public int noOfHuman;
        public float SpawnTime;
        public Transform[] Spawnpoint;
    }
    public HumanWave.Humanitem[] Humanitems;
}
public class WaveSystem : MonoBehaviour
{
    public int Day;
    public int FinishDay;
    public bool check=false;
    public TextMeshProUGUI DayText;
    public GameObject Bus;
    public HumanWave[] waves;
    public int CurrentWaveNumber=0;
    private HumanWave CurrentWave;
    private int CurrentHumanNumber;
    private HumanWave.Humanitem CurrentHuman;
    private float NextSpawnTime;
    private GameObject[] TotalHuman;
    public bool WaveStart;
    public GameObject NextWaveButton;

    /*
   HumanWave sýnýfý, bir dalganýn temel özelliklerini içerir.
   waveName: Dalga adýný temsil eder.
   Humanitem iç içe sýnýfý, dalgada yer alacak insanlarla ilgili bilgileri içerir.
   Human: Dalga içindeki insanlarýn oyun nesnelerinin dizisi.
   noOfHuman: O dalgadaki toplam insan sayýsýný belirtir.
   SpawnTime: Her bir insanýn spawnerda ne sýklýkla oluþturulacaðýný belirleyen süre.
   Spawnpoint: Ýnsanlarýn spawnerlarda nerede oluþturulacaðýný belirleyen noktalarýn dizisi.
     */


    /*
    waves: Tüm dalgalarýn bir dizisi.
    CurrentWaveNumber: Mevcut dalganýn dizindeki konumunu takip eder.
    CurrentWave: Mevcut dalganýn kendisi.
    CurrentHumanNumber: Mevcut dalga içindeki insanýn dizindeki konumunu takip eder.
    CurrentHuman: Mevcut insan grubunun kendisi.
    NextSpawnTime: Bir sonraki insanýn spawnerda oluþturulacaðý zaman.
    TotalHuman: O an sahnede bulunan tüm insan nesnelerinin dizisi.
    WaveStart: Dalga baþlatýlacak mý sorusuna yanýt verir.
    NextWaveButton: Bir sonraki dalgayý baþlatmak için kullanýlacak düðme nesnesi.
     */





    //Eðer dalga baþlatýlmýþsa, SpawnWave() fonksiyonu çaðrýlýr ve sahnede bulunan tüm insanlarý takip eden TotalHuman dizisi güncellenir.
    private void Update()
    {
        if (WaveStart)
        {
            SpawnWave();
            TotalHuman = GameObject.FindGameObjectsWithTag("Human");
        }
    }

    /*
     CurrentHumanandCurrentWave() fonksiyonu çaðrýlýr ve mevcut dalga ve insan gruplarý alýnýr.
Eðer mevcut insan sayýsý, mevcut dalga içindeki insanlarýn sayýsýna eþitse ve sahnede hiç insan kalmamýþsa, bir sonraki dalga için hazýrlýk yapýlýr ve dalga baþlatma düðmesi görünür hale getirilir.
Eðer mevcut insan sayýsý sýfýrdan büyükse, bir sonraki insanýn oluþturulma zamaný gelip gelmediði kontrol edilir. Eðer gelmiþse, rastgele bir spawn noktasý ve insan seçilerek o noktada insan oluþturulur ve noOfHuman deðeri bir azaltýlýr.
Eðer mevcut insan grubu tamamen oluþturulmuþsa ve mevcut dalga içindeki insanlarýn sayýsý sýnýrdan küçükse, bir sonraki insan grubuna geçilir.

     */
    private void SpawnWave()
    {
        CurrentHumanandCurrentWave();
        if (CurrentHumanNumber>=CurrentWave.Humanitems.Length && TotalHuman.Length<= 0)//Wavedeki insanlar bitince 
        {
            NextWaveButton.SetActive(true);
            CurrentWaveNumber++;
            CurrentHumanNumber = 0;
            WaveStart = false;
            if (CurrentWaveNumber%3==0)
            { 
                //reklam çýkcak
            }

        }
        if (CurrentHuman.noOfHuman>0 ) 
        {
            NextSpawnTime += Time.deltaTime;
            if (NextSpawnTime > CurrentWave.Humanitems[CurrentHumanNumber].SpawnTime)
            {
                NextSpawnTime= 0;
                Transform RandomPoint = CurrentHuman.Spawnpoint[Random.Range(0, CurrentHuman.Spawnpoint.Length)];
                GameObject RandomHuman= CurrentHuman.Human[Random.Range(0, CurrentHuman.Human.Length)];
                Instantiate(RandomHuman, RandomPoint.position,Quaternion.identity);  //spawn kodu
                CurrentHuman.noOfHuman--;

            }
        }
        else
        {
            if (CurrentHumanNumber<CurrentWave.Humanitems.Length) 
            {
                CurrentHumanNumber++;
            }
        }

    }
    void CurrentHumanandCurrentWave() //deðiþkenleri eþitleme yapýyoruz.
    { 
        if (CurrentWaveNumber<waves.Length)
        {
            CurrentWave = waves[CurrentWaveNumber];
        }
        if (CurrentHumanNumber< CurrentWave.Humanitems.Length)
        {
            CurrentHuman= CurrentWave.Humanitems[CurrentHumanNumber];
        }

    }




    /*StartWave Metodu:
    Dalga baþlatma düðmesi týklandýðýnda çaðrýlýr ve dalga baþlatma bayraðý etkinleþtirilir.*/


    public void StartWave()
    {
        NextWaveButton.SetActive(false);
        WaveStart = true;
        Day++;
        if (Day==FinishDay)
        {
            check= true;
        }
        UpdateDayText(Day);
        if (Bus != null)
        {
            Bus.gameObject.SetActive(true);
        }
       
        
    }
    string UpdateDayText(int day)
    {
        return DayText.text = "Day: " + day.ToString()+"/"+ FinishDay.ToString();
    }

}



