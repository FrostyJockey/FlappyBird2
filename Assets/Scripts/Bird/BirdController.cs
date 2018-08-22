using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdController : MonoBehaviour
{
    [SerializeField] private KeyCode flap = KeyCode.W;

    private TranslateMover translateMover;
    private BirdPhysics birdPhysics;

    private void Awake()
    {
        translateMover = GetComponent<TranslateMover>();
        birdPhysics = GetComponent<BirdPhysics>();
    }

    // Use this for initialization
    void Start()
    {
        var position = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(flap))
        {
            birdPhysics.Flap();
        }
    }
}
