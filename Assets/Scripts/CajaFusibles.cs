using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CajaFusibles : MonoBehaviour
{
    private int fusibles = 0;
    private bool palancaActiva;
    [SerializeField]
    private GameObject fusibleuno;
    [SerializeField]
    private GameObject fusible1Espectro;


    private void Start()
    {
        palancaActiva = false;
    }

    private void Update()
    {
        if (fusibles == 1)
        {
            palancaActiva = true;
        }

        if(palancaActiva == true)
        {
            Debug.Log("Luces encendidas");
        }
    }


    public void fusible1()
    {
        fusibles += 1;
        fusibleuno.SetActive(true);
        fusible1Espectro.SetActive(false);
    }

    public void fusible2()
    {
        fusibles += 1;
    }

    public void fusible3()
    {
        fusibles += 1;
    }
}
