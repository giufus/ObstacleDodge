using System;
using UnityEngine;

public class Dropper : MonoBehaviour
{
    [SerializeField]
    private float timeToWait = 2f;

    private MeshRenderer _myMeshRenderer;
    private Rigidbody _myRigidBody;

    private void Start()
    {
        _myMeshRenderer = GetComponent<MeshRenderer>();
        _myMeshRenderer.enabled = false;

        _myRigidBody = GetComponent<Rigidbody>();
        _myRigidBody.useGravity = false;
    }

    private void Update()
    {
        if (Time.time > timeToWait)
        {
            Debug.Log("Lookout below!");
            _myMeshRenderer.enabled = true;
            _myRigidBody.useGravity = true;
        }

    }
}
