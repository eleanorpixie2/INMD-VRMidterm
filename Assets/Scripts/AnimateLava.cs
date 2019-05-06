using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimateLava : MonoBehaviour
{
    public enum MoveDirection { x,y,z};
    public MoveDirection directionAxis;
    private float amountToMove=.1f;
    private Vector3 originalPosition;
    bool positiveDirection;
    // Start is called before the first frame update
    void Start()
    {
        originalPosition = transform.position;
        positiveDirection = true;
    }

    // Update is called once per frame
    void Update()
    {
        switch(directionAxis)
        {
            case MoveDirection.x:
                MoveX();
                break;
            case MoveDirection.y:
                MoveY();
                break;
            case MoveDirection.z:
                MoveZ();
                break;
        }
    }

    void MoveX()
    {
        if(positiveDirection)
        {
            if(originalPosition.x+amountToMove>transform.position.x)
            {
                transform.position += new Vector3(.05f*Time.deltaTime, 0, 0);
            }
            else
            {
                positiveDirection = false;
            }
        }
        else if (!positiveDirection)
        {
            if (originalPosition.x - amountToMove < transform.position.x)
            {
                transform.position += new Vector3(-.05f*Time.deltaTime, 0, 0);
            }
            else
            {
                positiveDirection = true;
            }
        }
    }
    void MoveY()
    {
        if (positiveDirection)
        {
            if (originalPosition.y + amountToMove > transform.position.y)
            {
                transform.position += new Vector3(0,.1f, 0);
            }
            else
            {
                positiveDirection = false;
            }
        }
        else if (!positiveDirection)
        {
            if (originalPosition.y - amountToMove < transform.position.y)
            {
                transform.position += new Vector3(0,-.1f, 0);
            }
            else
            {
                positiveDirection = true;
            }
        }
    }
    void MoveZ()
    {
        if (positiveDirection)
        {
            if (originalPosition.z + amountToMove > transform.position.z)
            {
                transform.position += new Vector3(0, 0,.1f);
            }
            else
            {
                positiveDirection = false;
            }
        }
        else if (!positiveDirection)
        {
            if (originalPosition.z - amountToMove < transform.position.z)
            {
                transform.position += new Vector3(0, 0 ,- .1f);
            }
            else
            {
                positiveDirection = true;
            }
        }
    }
}
