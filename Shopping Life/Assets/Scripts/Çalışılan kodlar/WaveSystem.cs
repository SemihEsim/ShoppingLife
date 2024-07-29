using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
using TMPro;

[System.Serializable]  // class �n inspector de g�z�kmesi i�in 
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
   HumanWave s�n�f�, bir dalgan�n temel �zelliklerini i�erir.
   waveName: Dalga ad�n� temsil eder.
   Humanitem i� i�e s�n�f�, dalgada yer alacak insanlarla ilgili bilgileri i�erir.
   Human: Dalga i�indeki insanlar�n oyun nesnelerinin dizisi.
   noOfHuman: O dalgadaki toplam insan say�s�n� belirtir.
   SpawnTime: Her bir insan�n spawnerda ne s�kl�kla olu�turulaca��n� belirleyen s�re.
   Spawnpoint: �nsanlar�n spawnerlarda nerede olu�turulaca��n� belirleyen noktalar�n dizisi.
     */


    /*
    waves: T�m dalgalar�n bir dizisi.
    CurrentWaveNumber: Mevcut dalgan�n dizindeki konumunu takip eder.
    CurrentWave: Mevcut dalgan�n kendisi.
    CurrentHumanNumber: Mevcut dalga i�indeki insan�n dizindeki konumunu takip eder.
    CurrentHuman: Mevcut insan grubunun kendisi.
    NextSpawnTime: Bir sonraki insan�n spawnerda olu�turulaca�� zaman.
    TotalHuman: O an sahnede bulunan t�m insan nesnelerinin dizisi.
    WaveStart: Dalga ba�lat�lacak m� sorusuna yan�t verir.
    NextWaveButton: Bir sonraki dalgay� ba�latmak i�in kullan�lacak d��me nesnesi.
     */





    //E�er dalga ba�lat�lm��sa, SpawnWave() fonksiyonu �a�r�l�r ve sahnede bulunan t�m insanlar� takip eden TotalHuman dizisi g�ncellenir.
    private void Update()
    {
        if (WaveStart)
        {
            SpawnWave();
            TotalHuman = GameObject.FindGameObjectsWithTag("Human");
        }
    }

    /*
     CurrentHumanandCurrentWave() fonksiyonu �a�r�l�r ve mevcut dalga ve insan gruplar� al�n�r.
E�er mevcut insan say�s�, mevcut dalga i�indeki insanlar�n say�s�na e�itse ve sahnede hi� insan kalmam��sa, bir sonraki dalga i�in haz�rl�k yap�l�r ve dalga ba�latma d��mesi g�r�n�r hale getirilir.
E�er mevcut insan say�s� s�f�rdan b�y�kse, bir sonraki insan�n olu�turulma zaman� gelip gelmedi�i kontrol edilir. E�er gelmi�se, rastgele bir spawn noktas� ve insan se�ilerek o noktada insan olu�turulur ve noOfHuman de�eri bir azalt�l�r.
E�er mevcut insan grubu tamamen olu�turulmu�sa ve mevcut dalga i�indeki insanlar�n say�s� s�n�rdan k���kse, bir sonraki insan grubuna ge�ilir.

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
                //reklam ��kcak
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
    void CurrentHumanandCurrentWave() //de�i�kenleri e�itleme yap�yoruz.
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
    Dalga ba�latma d��mesi t�kland���nda �a�r�l�r ve dalga ba�latma bayra�� etkinle�tirilir.*/


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



