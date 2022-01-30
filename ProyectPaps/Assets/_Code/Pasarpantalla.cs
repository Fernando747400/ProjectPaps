using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Pasarpantalla : MonoBehaviour
{
    public float tiempoInicial;
    public float TiempoLimite;
    public string sceneToLoad;


    // Update is called once per frame
    void Update()
    {
        tiempoInicial += Time.deltaTime;
        if (tiempoInicial >= TiempoLimite)
        {
            SceneManager.LoadScene(sceneToLoad);
        }
    }
}
