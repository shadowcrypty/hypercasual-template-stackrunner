using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camcontroller : MonoBehaviour
{
    public GameObject tekerler;
    public Transform target;
    public Vector3 offset;

    private void LateUpdate()
    {
        offset = new Vector3(-target.position.x, 3f, -tekerler.transform.childCount * .8f -9);

        transform.position = target.position + offset;
    }
}
