using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChildMovement : MonoBehaviour
{
    [SerializeField] Transform target;
    [SerializeField] private float speed = 2.0f;

    // enum State {
    //     WALKING,
    //     THINKING,
    //     BUSY,
    //     TO_BED
    // }

    void Start()
    {
        transform.position = target.transform.position;
    }

    void Update()
    {
        if(Vector2.Distance(transform.position, target.transform.position) < 0.01f) {
            target = chooseTarget();
            Debug.Log("Going to " + target.name);
        } else {
            transform.position = Vector2.MoveTowards(transform.position, target.transform.position, speed * Time.deltaTime);
        }
        StartCoroutine (());
    }

    Transform chooseTarget() {
        List<Transform> options = new List<Transform>();
        
        // Add options
        if(target.parent != null) options.Add(target.parent);
        for(int i = 0; i < target.childCount; i++) options.Add(target.GetChild(i));

        // Choose one randomly
        return options[Mathf.FloorToInt(Random.value * options.Count)];
    }
}
