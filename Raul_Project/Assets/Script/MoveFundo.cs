using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveFundo : MonoBehaviour {
    public float velocidade;
    public float tamanho;  
    void Start ()
    {
        
    }
    void Update ()
    {
        float quebra = Mathf.Repeat(Time.time * velocidade, tamanho);        
        transform.position =  new Vector2(0, -quebra);              
    }
}
