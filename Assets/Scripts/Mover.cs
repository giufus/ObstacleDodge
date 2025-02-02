using System;
using UnityEditor.Searcher;
using UnityEngine;
using UnityEngine.UIElements;

public class Mover : MonoBehaviour
{
    private const String HORIZONTAL = "Horizontal";
    private const String VERTICAL = "Vertical";
    private const String JUMP = "Jump";
    [SerializeField] private float moveSpeed = 0f;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created

    void Start()
    {
        this.moveSpeed = Time.deltaTime;
    }

    // Update is called once per frame

    void Update()
    {
        float xValue = Input.GetAxis(HORIZONTAL) * moveSpeed;
        float yValue = Input.GetAxis(VERTICAL) * moveSpeed;
        float zValue = Input.GetAxis(JUMP) * moveSpeed;
        transform.Translate(xValue, yValue, zValue);
    }

     
}
