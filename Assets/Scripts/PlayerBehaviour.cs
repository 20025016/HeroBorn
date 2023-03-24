using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBehaviour : MonoBehaviour
{
    public float MoveSpeed = 10f;
    public float RotateSpeed = 75f;

    private float _verticalInput;
    private float _horizontalInput;

    private void Update()
    {
        _verticalInput = Input.GetAxis("Vertical") * MoveSpeed;
        _horizontalInput = Input.GetAxis("Horizontal") * RotateSpeed;

        this.transform.Translate(Vector3.forward * _verticalInput * Time.deltaTime);

        this.transform.Rotate(Vector3.up * _horizontalInput * Time.deltaTime);
    }
}
