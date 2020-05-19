using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FrameCamera : MonoBehaviour
{

    public Transform Pivot;
    public Bounds bound;
    public Vector2 screenSize;
    public Vector2 boardSize;

    public float minOrthoSize;
    public float Margin;

    public Vector2 res = new Vector2();



    private void Start()
    {
        SetFrame();
    }

    public void SetFrame()
    {
        bound = Pivot.GetBounds();
        var center = bound.center;
        center.z = -10;
        Camera.main.transform.position = center;
        screenSize = new Vector2(Screen.width, Screen.height);
        boardSize = new Vector2(bound.size.x, bound.size.y);

        var screenRatio = screenSize.x / screenSize.y;
        var targetRatio = boardSize.x / boardSize.y;

        if (screenRatio >= targetRatio)
        {
            Camera.main.orthographicSize = Mathf.Max((boardSize.y / 2) + Margin, minOrthoSize);
        }
        else
        {
            float differenceInSize = targetRatio / screenRatio;
            Camera.main.orthographicSize = Mathf.Max((boardSize.y / 2 * differenceInSize) + Margin, minOrthoSize);
        }
        res = new Vector2(Screen.width, Screen.height);
    }

    private void Update()
    {
        var currentRes = new Vector2(Screen.width, Screen.height);
        if(res == Vector2.zero)
        {
            res = currentRes;
        }
        if (currentRes != res)
        {
            SetFrame();
        }
    }
}
