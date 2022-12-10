using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Carrousel : MonoBehaviour
{
    public GameObject [] models;
    public int selector;
    void Start()
    {
        if (models == null) 
        { 
            return; 
        }

        if (models.Length == 0) 
        { 
            Debug.LogWarning("No se ha configurado ningún objeto");
            return;
        }
        selector = 0;
        models[selector].SetActive(true);

        //Debug.Log("El modelo cero está activo? "+models[0].active);
    }   
    
    public void Next() 
    {   
        models[selector].SetActive(false);
        selector = selector +1;
        if( selector == models.Length ) 
        { 
            selector = 0;
        } 
        models[selector].SetActive(true);
    }

    public void Previous() 
    { 
        models[selector].SetActive(false);
        selector = selector - 1;
        if (selector < 0) 
        { 
            selector = models.Length -1;
        }
        models[selector].SetActive(true);
    }

}
