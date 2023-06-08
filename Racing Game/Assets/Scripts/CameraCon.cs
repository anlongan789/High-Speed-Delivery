using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraCon : MonoBehaviour
{
    public Transform camTarget;
    public float pLerp = 7.5f;
    public float rLerp = 5f;

    // Update is called once per frame
    void FixedUpdate()
    {
        transform.position = Vector3.Lerp(transform.position, camTarget.position, pLerp * Time.deltaTime);
        transform.rotation = Quaternion.Lerp(transform.rotation, camTarget.rotation, rLerp * Time.deltaTime);
    }
}
