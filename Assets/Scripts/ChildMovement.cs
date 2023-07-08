using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChildMovement : MonoBehaviour
{
    [SerializeField] Transform [] Points;
    [SerializeField] private float speed = 2.0f;
    private int pointsIndex;

    void Start()
    {
        transform.position = Points[pointsIndex].transform.position;
    }

    void Update()
    {
        if(pointsIndex <= Points.Length - 1)
        {
            transform.position = Vector2.MoveTowards(transform.position, Points[pointsIndex].transform.position, speed * Time.deltaTime);
            if(transform.position == Points[pointsIndex].transform.position)
            {
                pointsIndex++;
            }
        }
    }
}
