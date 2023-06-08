using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    public Transform target;

    private Vector3 offset = new Vector3(0, 2.7f, -7f);
    // Start is called before the first frame update
    void Start()
    {

    }
    private void Update()
    {

    }
    // Update is called once per frame
    void lateUpdate()
    {
        transform.position = target.transform.position + offset;
    }
}
