using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class NPC : MonoBehaviour
    
{
    //vidas
    int lives = 100;
    //nivel
    int level = 100;
    //la suma de los dos =  200
  
    void Start()
    {
        lives = level + lives;
        //lo puedes leer
        print("lives of the NPC:" + lives);

    }

    // Update is called once per frame
    void Update()
    {
        float speed = 5f;
        Vector3 newPosition = transform.position;
        newPosition.z += speed * Time.deltaTime;
        transform.position = newPosition;
    }
}