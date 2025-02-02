using System;
using Unity.VisualScripting;
using UnityEngine;

public class ObjectHit : MonoBehaviour
{
    private void OnCollisionEnter(Collision other)
    {
        GetComponent<MeshRenderer>().material.color = Color.red;
        Debug.Log("stg hit me! " + other.body.name);
        other.body.GetComponent<MeshRenderer>().material.color = Color.green;
    }
}
