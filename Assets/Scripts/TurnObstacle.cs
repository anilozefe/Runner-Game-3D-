using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurnObstacle : MonoBehaviour
{
    [SerializeField] public float turnSpeed = 1f;
    public Transform PartToRotate;
 
    private void Update () {
        transform.Rotate(0, 5,  turnSpeed * Time.deltaTime);
    }
}
