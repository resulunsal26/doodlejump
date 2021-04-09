using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class kameratakip : MonoBehaviour
{
    public Transform playerpozisyon;
    
    void Update()
    {
        if(playerpozisyon.position.y>transform.position.y)
        {
            transform.position = new Vector3(transform.position.x, playerpozisyon.position.y,transform.position.z);
        }
    }
}
