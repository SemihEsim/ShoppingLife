using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelMenu : MonoBehaviour
{
    // Butonlarýn sahne adlarýný tutmak için bir dizi
    public string[] hedefSahneAdlari;
    int gold = 5050;
    int current_gold=0;

    // Butonlarýn indeksine göre sahne deðiþtirme iþlemi
    public void SahneDegistir(int butonIndex)
    {
        // Geçerli buton indeksi, hedef sahne adlarý dizisinin boyutundan büyükse çýk
        if (butonIndex >= hedefSahneAdlari.Length)
        {
            Debug.LogError("Hedef sahne adý bulunamadý!");
            return;
        }
        // Belirtilen sahneye geçiþ yap
        SceneManager.LoadScene(hedefSahneAdlari[butonIndex]);
        TotalGold.CurrentGold = gold;
        TotalGold.TotalEarnGold= current_gold;
    }
}
