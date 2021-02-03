using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class pulsador : MonoBehaviour
{
    public KeyCode key;
    bool active = false;
    GameObject note;
    static float puntos=0;
    public Text textoPuntos;
    public AudioClip sound;

    AudioSource audioSource;
    // Start is called before the first frame update
    void Start()
    {
         audioSource=GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(key)&&active){
            puntos++;
            textoPuntos.text="Total de puntos: "+puntos;
            Debug.Log("Total de puntos: "+puntos);
            audioSource.PlayOneShot(sound);
            Destroy(note);
        }
    }

    void OnTriggerEnter2D(Collider2D col){
        active = true;
        if (col.gameObject.tag=="Note")
        {
            note=col.gameObject;
            
        }
    }

    void OnTriggerExit2D(Collider2D col){
        active=false;
        Destroy(note);
    }
}
