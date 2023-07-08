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
        // if(transform.position.Equals(target.transform.position)) {
        if(Vector2.Distance(transform.position, target.transform.position) < 0.01f) {
            Debug.Log("At " + target.name + " : has " + target.childCount + " children");
            target = chooseTarget();
            Debug.Log("Going to " + target.name);
        } else {
            transform.position = Vector2.MoveTowards(transform.position, target.transform.position, speed * Time.deltaTime);
        }
    }

    Transform chooseTarget() {
        // if(target.parent != null) {
        //     if(Random.value < (1 / (target.childCount + 1))) return target.parent;
        // }
        // return target.GetChild(Mathf.FloorToInt(Random.value * target.childCount));
        List<Transform> options = new List<Transform>();
        if(target.parent != null) options.Add(target.parent);
        for(int i = 0; i < target.childCount; i++) options.Add(target.GetChild(i));
        return options[Mathf.FloorToInt(Random.value * options.Count)];
    }
}
