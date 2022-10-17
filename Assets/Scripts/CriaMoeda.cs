using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;

public class CriaMoeda : MonoBehaviour
{
    public GameObject moeda;
    
    // Start is called before the first frame update
    void Start()
    {
        
        CriaReta();
        CriaRetaVertical();
    }

   
    void CriaReta(){
        float y;
        for (float x = -3.0f; x < 4.0f; x+=1.0f)
        {            
                // reta
                y = 0.0f*x+1;
                Instantiate(moeda, new Vector3(x,y,-2), Quaternion.identity);
        }
    }
    void CriaRetaVertical()
    {
        float y;
        for (float x = -2.0f; x < 5; x += 1.0f)
        {
            // reta
            y = 0.0f * x + 0;
            Instantiate(moeda, new Vector3(y, x, -2), Quaternion.identity);
        }
    }
    void CriaReta(float b, float minX, float maxX){
            float y;
            for (float x = minX; x < maxX; x+=1.9f)
            {            
                    // reta
                    y = 0.0f*x+b;
                    Instantiate(moeda, new Vector3(x,y,-2), Quaternion.identity);
            }
        }
    void CriaRetaVertical(float b, float minX, float maxX)
    { 
   
        float y;
        for (float x = 0.0f; x < 5; x += 1.9f)
        {
            // reta
            y = 0.0f * x + 0.9f;
            Instantiate(moeda, new Vector3(y,x, -2), Quaternion.identity);
        }
    }

    void CriaParabola(){
        float y;

        for (float x = -4; x < 10; x+=0.9f)
        {
            
                // parábola
                y = (float)(-0.1*x*x+2*x+0);
            
                Instantiate(moeda, new Vector3(x,y,-2), Quaternion.identity);
                
            
        }
    }
   

    // Update is called once per frame
    void Update()
    {
        
    }
}
