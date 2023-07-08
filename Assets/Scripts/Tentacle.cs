using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tentacle : MonoBehaviour
{
    [SerializeField] public int length;
    [SerializeField] public LineRenderer lineRend;
    [SerializeField] public Vector3[] segmentPoses;
    private Vector3[] segmentV;

    [SerializeField] public Transform targetDir;
    [SerializeField] public float targetDist;
    [SerializeField] public float smoothSpeed;

    // Start is called before the first frame update
    void Start()
    {
        lineRend.positionCount = length;
        segmentPoses = new Vector3[length];
        segmentV = new Vector3[length];
        
        // for(int i = 1; i < segmentPoses.Length; i++) {
        //     gameObject.AddComponent<CircleCollider2D>();
        // }
    }

    // Update is called once per frame
    void Update()
    {
        segmentPoses[0] = targetDir.position;
        for(int i = 1; i < segmentPoses.Length; i++) {
            segmentPoses[i] = Vector3.SmoothDamp(segmentPoses[i], segmentPoses[i - 1] + targetDir.right * targetDist, ref segmentV[i], smoothSpeed);
        }
        lineRend.SetPositions(segmentPoses);
    }
}
