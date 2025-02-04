using System;
using UnityEngine;

public class Scorer : MonoBehaviour
{
    private int collided = 0;
    private void OnCollisionEnter(Collision other)
    {
        ++collided;
        Debug.Log($"you have bumped into {other.gameObject.name} {collided} times"); 
    }
}
