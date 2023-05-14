using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColliderEvent : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "FirstPersonController" || other.gameObject.CompareTag("car"))
        {
            Debug.Log("Player Enter");
        }
    }
}
