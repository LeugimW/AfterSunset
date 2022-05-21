using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Raycast : MonoBehaviour
{
    private int rango = 3;

    public bool fusible1 = true;
    public bool fusible2;
    public bool fusible3;

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

            if(hit.collider.GetComponent<CajaFusibles>() == true)
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



