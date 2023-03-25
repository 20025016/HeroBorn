using System.Collections;
using System.Collections.Generic;
using TMPro.EditorUtilities;
using UnityEngine;

public class PlayerBehaviour : MonoBehaviour
{
    public float MoveSpeed = 10f;
    public float RotateSpeed = 75f;

    private float _verticalInput;
    private float _horizontalInput;

    public float JumpVelocity = 5f;
    private bool _isJumping;

    private Rigidbody _rb;

    public float DistanceToGround = 0.1f;

    public LayerMask GroundLayer;

    private CapsuleCollider _capsuleCollider;

    public GameObject Bullet;
    public float BulletSpeed = 100f;

    private bool _isShooting;

    private void Start()
    {
        _rb = GetComponent<Rigidbody>();

        _capsuleCollider = GetComponent<CapsuleCollider>();
    }

    private void Update()
    {
        _verticalInput = Input.GetAxis("Vertical") * MoveSpeed;
        _horizontalInput = Input.GetAxis("Horizontal") * RotateSpeed;

        _isJumping |= Input.GetKeyDown(KeyCode.J);

        _isShooting |= Input.GetKeyDown(KeyCode.Space);

        //this.transform.Translate(Vector3.forward * _verticalInput * Time.deltaTime);

        //this.transform.Rotate(Vector3.up * _horizontalInput * Time.deltaTime);
    }

    private void FixedUpdate()
    {
        Vector3 rotation = Vector3.up * _horizontalInput;

        Quaternion angleRotation = Quaternion.Euler(rotation * Time.fixedDeltaTime);

        _rb.MovePosition(this.transform.position + this.transform.forward * _verticalInput * Time.fixedDeltaTime);

        _rb.MoveRotation(_rb.rotation * angleRotation);

        if (IsGrounded() && _isJumping)
        {
            _rb.AddForce(Vector3.up * JumpVelocity, ForceMode.Impulse);
        }

        _isJumping = false;

        if (_isShooting)
        {
            GameObject newBullet = Instantiate(Bullet, 
                this.transform.position + new Vector3(0, 0, 1),
                this.transform.rotation);

            Rigidbody bulletRB = newBullet.GetComponent<Rigidbody>();

            bulletRB.velocity = this.transform.forward * BulletSpeed;
        }

        _isShooting = false;
    }

    private bool IsGrounded()
    {
        Vector3 capsuleBottom = new Vector3(_capsuleCollider.bounds.center.x,
            _capsuleCollider.bounds.min.y, _capsuleCollider.bounds.center.z);

        bool grounded = Physics.CheckCapsule(_capsuleCollider.bounds.center,
            capsuleBottom, DistanceToGround, GroundLayer, 
            QueryTriggerInteraction.Ignore);

        return grounded;
    }
}
