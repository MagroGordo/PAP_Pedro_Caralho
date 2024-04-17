using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BolaDoPerigo : MonoBehaviour
{
   


    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            FindObjectOfType<GameManager>().ReiniciarPatida();

        }
    }
}
