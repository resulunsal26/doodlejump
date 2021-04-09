using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class seviyeolusturucu : MonoBehaviour
{
    public GameObject platformobjesi;
    public int platformsayisi;
    public float minx, maxx;
    public float miny, maxy;
    void Start()
    {
        Vector3 klon = new Vector3();
        for(int i = 0; i < platformsayisi; i++)
        {
            klon.x = Random.Range(minx, maxx);
            klon.y = Random.Range(miny, maxy);
            Instantiate(platformobjesi, klon, Quaternion.identity);
        }
      
       
    }

    
   
}
