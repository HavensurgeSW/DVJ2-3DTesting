using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class CamCollider : MonoBehaviour
{
    [SerializeField]private Camera cam;
     private void OnTriggerEnter(Collider other)
    {
        Debug.Log("Enter Camera");
        cam.gameObject.SetActive(true);
    
    }
     private void OnTriggerExit(Collider other)
    {
        cam.gameObject.SetActive(false);
    }

}
