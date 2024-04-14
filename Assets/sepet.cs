using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class sepet : MonoBehaviour
{
    public float hiz;
    int skor = 0;

    public TextMeshProUGUI skor_txt;

    public ParticleSystem efekt;

    public AudioSource ses;
    public AudioClip pat;

    private void Start()
    {
        efekt.Stop();
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "elma")
        {
            ses.PlayOneShot(pat);
            efekt.Play();
            skor += 10;
            skor_txt.text = skor.ToString();
            Destroy(collision.gameObject);
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.Translate(hiz * Time.deltaTime, 0, 0);
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Translate(-hiz * Time.deltaTime, 0, 0);
        }
    }
}
