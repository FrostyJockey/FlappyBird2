using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    [SerializeField] private KeyCode up = KeyCode.W;
    //[SerializeField] private KeyCode left = KeyCode.A;
    //[SerializeField] private KeyCode down = KeyCode.S;
    //[SerializeField] private KeyCode right = KeyCode.D;
    private TranslateMover translateMover;

    private void Awake()
    {
        translateMover = GetComponent<TranslateMover>();
    }

    // Use this for initialization
    void Start()
    {

        var position = transform.position;
    }

    // Update is called once per frame
    void Update()
    {

        translateMover.Move(Vector3.right);

        if (Input.GetKeyDown(up))
        {
            translateMover.Move(Vector3.up);
        }

    }
}
