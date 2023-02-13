using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamFollow : MonoBehaviour
{
    public enum State
    {
        Idle, Ready, Tracking
    }
    private State state
    {
        set
        {
            switch(value)
            {
                case State.Idle:
                    break;
                case State.Ready:
                    break;
                case State.Tracking:
                    break;
            }
        }
    }
    private Transform target;
    public float smoothTime = 0.2f;

    private Vector3 movingVelocity;
    private Vector3 targetPosition;

    private Camera cam;
    private float targetZoomSize = 5f;
    private const float roundReadyZoomSize = 14.5f;
    private const float readyShotZoomSize = 5f;
    private const float trackingZoomSize = 10f;
    private void Awake()
    {
        state = State.Idle;
    }
}
