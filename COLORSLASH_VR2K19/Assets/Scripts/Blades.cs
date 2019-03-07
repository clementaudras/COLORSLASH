using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Blades : MonoBehaviour {

    public BladePositions bladePosition;
    public BladeColors bladeColor;
    public float breakVelocity = 1f;
    public GameManager gm;

    Rigidbody bladeRigidbody;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter(Collider other)
    {
        if (bladeRigidbody.velocity.magnitude < breakVelocity)
            return;

        // if the blade is blue
        if(bladeColor == BladeColors.blue)
        {
            if (other.CompareTag("BlueZub"))
            {
                Debug.Log("BlueZub cut!");
                gm.currentScore++;
            }

            if (other.CompareTag("YellowZub"))
            {
                Debug.Log("YellowZub cut!");
            }

            if (other.CompareTag("RedZub"))
            {
                Debug.Log("RedZub cut!");
            }

            if (other.CompareTag("GreenZub"))
            {
                Debug.Log("GreenZub cut!");
            }
        }

        // if the blade is yellow
        if (bladeColor == BladeColors.yellow)
        {
            if (other.CompareTag("BlueZub"))
            {
                Debug.Log("BlueZub cut!");
            }

            if (other.CompareTag("YellowZub"))
            {
                Debug.Log("YellowZub cut!");
                gm.currentScore++;
            }

            if (other.CompareTag("RedZub"))
            {
                Debug.Log("RedZub cut!");
            }

            if (other.CompareTag("GreenZub"))
            {
                Debug.Log("GreenZub cut!");
            }
        }

        // if the blade is red
        if (bladeColor == BladeColors.red)
        {
            if (other.CompareTag("BlueZub"))
            {
                Debug.Log("BlueZub cut!");
            }

            if (other.CompareTag("YellowZub"))
            {
                Debug.Log("YellowZub cut!");
            }

            if (other.CompareTag("RedZub"))
            {
                Debug.Log("RedZub cut!");
                gm.currentScore++;
            }

            if (other.CompareTag("GreenZub"))
            {
                Debug.Log("GreenZub cut!");
            }
        }

        // if the blade is green
        if (bladeColor == BladeColors.green)
        {
            if (other.CompareTag("BlueZub"))
            {
                Debug.Log("BlueZub cut!");
            }

            if (other.CompareTag("YellowZub"))
            {
                Debug.Log("YellowZub cut!");
            }

            if (other.CompareTag("RedZub"))
            {
                Debug.Log("RedZub cut!");
            }

            if (other.CompareTag("GreenZub"))
            {
                Debug.Log("GreenZub cut!");
                gm.currentScore++;
            }
        }
    }
}

public enum BladeColors
{
    blue,
    yellow,
    red,
    green
}

public enum BladePositions
{
    right,
    left
}
