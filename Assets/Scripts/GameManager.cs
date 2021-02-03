using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    float puntos=0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SetPuntos(float points){
        puntos=points;
        Debug.Log(""+points);
    }

    public float getPuntos(){
        return puntos;
    }
}
