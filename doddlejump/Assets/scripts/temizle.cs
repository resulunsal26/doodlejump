using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class temizle : MonoBehaviour
{
   
    

    private void OnTriggerEnter2D(Collider2D temas)
    {
        float rasty =11f;
        float rast=Random.Range(-6f,6f);
        if (temas.tag=="platform")
        {
            temas.transform.position = new Vector3(rast, temas.transform.position.y+rasty, temas.transform.position.z);
        }
      
    }
}
