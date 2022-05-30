using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Raycast : MonoBehaviour
{
    private int rango = 4;

    public bool fusible1 = true;
    public bool fusible2;
    public bool fusible3;

    public LlaveCeleste onC;

    private void Update()
    {
        RaycastHit hit;
        if (Physics.Raycast(Camera.main.transform.position, Camera.main.transform.forward, out hit, rango))
        {
            if(hit.collider.GetComponent<Esconderse>() == true)
            {
                if (Input.GetKeyDown(KeyCode.E))
                {
                    hit.collider.GetComponent<Esconderse>().entra = true;
                }
            }

            if(hit.collider.tag == "Door")
            {
                if(Input.GetKeyDown(KeyCode.E))
                {
                    hit.collider.transform.GetComponent<Puerta>().ChangeDoorState();
                }
            }
            if (hit.collider.tag == "LlaveC")
            {
                if (Input.GetKeyDown(KeyCode.E))
                {
                    hit.collider.transform.GetComponent<LlaveCeleste>().Obtenida = true;
                }
            }
            if (hit.collider.tag == "PCeleste")
            {
                if (Input.GetKeyDown(KeyCode.E))
                {
                    hit.collider.transform.GetComponent<PCeleste>().ChangeDoorState();
                }
            }
            if (hit.collider.tag == "LlaveP")
            {
                if (Input.GetKeyDown(KeyCode.E))
                {
                    hit.collider.transform.GetComponent<LlavePurpura>().Obtenida = true;
                }
            }
            if (hit.collider.tag == "PPurpura")
            {
                if (Input.GetKeyDown(KeyCode.E))
                {
                    hit.collider.transform.GetComponent<PPurpura>().ChangeDoorState();
                }
            }
            if (hit.collider.tag == "Ganzua")
            {
                if (Input.GetKeyDown(KeyCode.E))
                {
                    hit.collider.transform.GetComponent<LlaveGanzua>().Obtenida = true;
                }
            }
            if (hit.collider.tag == "PGanzua")
            {
                if (Input.GetKeyDown(KeyCode.E))
                {
                    hit.collider.transform.GetComponent<PGanzua>().ChangeDoorState();
                }
            }
            if (hit.collider.tag == "LlaveR")
            {
                if (Input.GetKeyDown(KeyCode.E))
                {
                    hit.collider.transform.GetComponent<LlaveRombo>().Obtenida = true;
                }
            }
            if (hit.collider.tag == "PRombo")
            {
                if (Input.GetKeyDown(KeyCode.E))
                {
                    hit.collider.transform.GetComponent<PRombo>().ChangeDoorState();
                }
            }

            if (hit.collider.GetComponent<CajaFusibles>() == true)
            {
                if(Input.GetKeyDown(KeyCode.E))
                {
                    if(fusible1 == true)
                    {
                        hit.collider.GetComponent<CajaFusibles>().fusible1();
                    }

                    if (fusible2 == true)
                    {
                        hit.collider.GetComponent<CajaFusibles>().fusible1();
                    }

                    if (fusible3 == true)
                    {
                        hit.collider.GetComponent<CajaFusibles>().fusible1();
                    }

                }
                
            }
        }
    }

    private void OnDrawGizmos()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawRay(Camera.main.transform.position, Camera.main.transform.forward * rango);
    }
}



