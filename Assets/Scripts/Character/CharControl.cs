using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharControl : MonoBehaviour
{
    [SerializeField] GameObject _camera;
    [SerializeField] float forwardSpeed = 3;
    [SerializeField] float sideSpeed = 2;
    [SerializeField] float deadZoneAngle = 10;
    [SerializeField] float gravity = 1;



    private CharacterController _characterController;
    private Vector3 _velosity;

    void Start()
    {
        _characterController = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
        _velosity.z = forwardSpeed * Time.deltaTime;
        _velosity.y = -1 * gravity * Time.deltaTime;

        if (_camera.transform.rotation.eulerAngles.z > deadZoneAngle && _camera.transform.rotation.eulerAngles.z <= 180)
        {
            _velosity.x = _camera.transform.rotation.eulerAngles.z * -1 * Time.deltaTime * sideSpeed;
        }
        else if(_camera.transform.rotation.eulerAngles.z > 180 && _camera.transform.rotation.eulerAngles.z <= 360-deadZoneAngle)
        {
            _velosity.x = (360 -_camera.transform.rotation.eulerAngles.z) * Time.deltaTime * sideSpeed;
        }
        else
        {
            _velosity.x = 0;
            _velosity.x = Input.GetAxis("Horizontal") * sideSpeed * Time.deltaTime;
        }

        _characterController.Move(_velosity);
    }
}
