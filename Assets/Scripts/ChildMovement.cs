using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChildMovement : MonoBehaviour
{
    // [SerializeField] Transform [] Points;
    [SerializeField] Transform target;
    [SerializeField] private float speed = 2.0f;
    // private int pointsIndex;

    void Start()
    {
        // transform.position = Points[pointsIndex].transform.position;
        transform.position = target.transform.position;
    }

    void Update()
    {
        // if(pointsIndex <= Points.Length - 1)
        // {
        //     transform.position = Vector2.MoveTowards(transform.position, Points[pointsIndex].transform.position, speed * Time.deltaTime);
        //     if(transform.position == Points[pointsIndex].transform.position)
        //     {
        //         pointsIndex++;
        //     }
        // }
        
		// yield new WaitForSeconds (0.5f);

        // Target won't change until child has reached last target
        if(transform.position == target.transform.position) {
            int options = target.childCount;
            // if(target.parent != null) options++;
            if(options == 0) {
                target = target.parent;
            } else {
                target = target.GetChild(Mathf.FloorToInt(Random.value * options));
            }
            Debug.Log("Going to " + target.name);
        } else {
            // transform.position = Vector2.MoveTowards(transform.position, target.transform.position, speed * Time.deltaTime);
            transform.position = target.transform.position;
        }
    }
}
