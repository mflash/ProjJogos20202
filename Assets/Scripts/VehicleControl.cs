using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VehicleControl : MonoBehaviour
{
    [SerializeField] private float speed = 4f;
    [SerializeField] private float turnSpeed = 90f;
    private PlayerControls playerActionControls;

    private void Awake()
    {
        playerActionControls = new PlayerControls();
    }

    private void OnEnable()
    {
        playerActionControls.Enable();
    }

    private void OnDisable()
    {
        playerActionControls.Disable();
    }

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        float movementInput = speed * playerActionControls.MoveAndTurn.Move.ReadValue<float>();
        transform.Translate(Vector3.forward * movementInput * Time.deltaTime);
        float turnInput = turnSpeed * playerActionControls.MoveAndTurn.Turn.ReadValue<float>();
        transform.Rotate(Vector3.up, turnInput * Time.deltaTime);
    }
}
