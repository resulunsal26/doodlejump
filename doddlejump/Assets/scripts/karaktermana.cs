using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class karaktermana : MonoBehaviour
{
    public float hiz;
    public Rigidbody2D player;
    private float hareketinput;
    public TextMeshProUGUI skortext;
    int skor;

    void Update()
    {
        skortext.text ="Skor : "+ skor.ToString();
        hareketinput = Input.GetAxis("Horizontal");
        player.velocity = new Vector2(hiz * hareketinput, player.velocity.y);
      
    }
    private void OnCollisionEnter2D(Collision2D temas)
    {
        if(temas.gameObject.tag=="bitis")
        {
            SceneManager.LoadScene("SampleScene");
        }
        if(temas.gameObject.tag=="platform")
        {
            skor += Random.Range(9,49);
          
        }
    }
}
