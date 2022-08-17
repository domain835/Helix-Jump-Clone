using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Player Player;
    public Vector3 OffsetCameraToPlatform;
    public float Speed;

    // Update is called once per frame
    void Update()
    {
        if (Player.CurrentPlatform == null) return;

        Vector3 targetPosition = Player.CurrentPlatform.transform.position + OffsetCameraToPlatform;
        transform.position = Vector3.MoveTowards(transform.position, targetPosition, Speed * Time.deltaTime);
    }
}
