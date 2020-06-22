using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coins : MonoBehaviour
{
  
    public float rotationSpeed;

    private void Update()
    {

        transform.rotation = Quaternion.Euler(transform.rotation.eulerAngles + new Vector3(0f, rotationSpeed * Time.deltaTime, 0f));

    }

}
