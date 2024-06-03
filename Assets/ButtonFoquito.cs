using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonFoquito : MonoBehaviour
{
    public GameObject[] luces;
    public float delay = 0.5f;
    private int ciclosCompletos = 0;

    public void IniciarPrueba()
    {
        StartCoroutine(ActivateRepeating(delay));
    }

    IEnumerator ActivateRepeating(float delay)
    {
        for (int ciclo = 0; ciclo < 3; ciclo++)
        {
            for (int i = 0; i < luces.Length; i++)
            {
                luces[i].SetActive(true);
                yield return new WaitForSeconds(delay);
                luces[i].SetActive(false);
            }

            ciclosCompletos++;
        }

        if (ciclosCompletos >= 3)
        {
            foreach (GameObject luz in luces)
            {
                Destroy(luz);
            }
            Destroy(gameObject);
        }
    }
}
