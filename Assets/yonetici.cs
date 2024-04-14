using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class yonetici : MonoBehaviour
{
    public GameObject elma;
    float zaman_araligi = 0.5f;
    float kalan_zaman = 0.0f;
    bool oyun_durduruldu = false;
    public GameObject panel;

    public void tekrar_oyna()
    {
        SceneManager.LoadScene("Scenes/SampleScene");
        Time.timeScale = 1.0f;
    }
    public void durdur()
    {
        oyun_durduruldu = !oyun_durduruldu;
        
        if (oyun_durduruldu)
        {
            Time.timeScale = 0.0f;
            panel.SetActive(true);
        }
        else
        {
            panel.SetActive(false);
            Time.timeScale = 1.0f;  
        }
    }
    void Start()
    {
      //  InvokeRepeating("elma_ekle", 0.0f, 1.0f);
    }

    void elma_ekle()
    {
        float rast = Random.Range(-3.3f, 13.3f);

        GameObject yeni_elma = Instantiate(elma, new Vector3(rast, 8, -6.6f), Quaternion.identity);

    }

    private void Update()
    {
        if(Time.time >= kalan_zaman + 0.3f)
        {
            
            elma_ekle();
            kalan_zaman = zaman_araligi + Time.time;
        }
    }
}
