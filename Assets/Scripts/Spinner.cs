using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spinner : MonoBehaviour
{
[SerializeField] float xValue = 0;
[SerializeField] float yValue = 0;
[SerializeField] float zValue = 0;

    void Update()
    {
        transform.Rotate(xValue, yValue, zValue);
    }
}
