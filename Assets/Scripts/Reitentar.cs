using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Reitentar : MonoBehaviour
{
    public GameObject menu;

    void Start()
    {
        Cursor.lockState = CursorLockMode.None;

        menu.SetActive(false);

        StartCoroutine("Esperar");
    }
    public void BotonStart()
    {
        SceneManager.LoadScene("Sotano");
    }

    public void BotonQuit()
    {
        Debug.Log("Salir");
        Application.Quit();
    }

    IEnumerator Esperar()
    {
        yield return new WaitForSeconds(6);
        menu.SetActive(true);
    }
}
