﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveAviao : MonoBehaviour
{
    public GameObject aviao;
    public float velocidade = 0.05f;
    

    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {

          if(gameObject.transform.position.y>3){
           velocidade*= -1;
          }else if(gameObject.transform.position.y< -3)
          {
           velocidade*= -1;
          }
          transform.Translate(new Vector2(0,velocidade*Time.deltaTime));

        if (Input.GetKey(KeyCode.UpArrow)){
            transform.Translate(new Vector3(0,0.1f,0));
        }
        if(Input.GetKey(KeyCode.DownArrow)){
            transform.Translate(new Vector3(0,-0.1f,0));
        }
        if(Input.GetKey(KeyCode.LeftArrow)){
            transform.Translate(new Vector3(-0.1f,0,0));
        }
        if(Input.GetKey(KeyCode.RightArrow)){
            transform.Translate(new Vector3(0.1f,0,0));
        }

    }
}
