using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.Events;

public class SwitchController : MonoBehaviour
{
    public GameObject handle;
    private Camera mainCamera;
    private float cameraZDistance;
    public bool isSwitchedOn = false;
    public UnityEvent switchedOn;



    void Start()
    {
        mainCamera = Camera.main;
        cameraZDistance = mainCamera.WorldToScreenPoint(transform.position).z;

    }

    void OnMouseDrag()
    {
        Vector3 ScreenPosition = new Vector3(Input.mousePosition.x, Input.mousePosition.y, cameraZDistance);
        Vector3 NewWorldPosition = mainCamera.ScreenToWorldPoint(ScreenPosition);

    }

    void OnMouseDown()
    {
        Vector3 ScreenPosition = new Vector3(Input.mousePosition.x, Input.mousePosition.y, cameraZDistance);

    }
    void OnMouseUp()
    {
        Vector3 ScreenPosition = new Vector3(Input.mousePosition.x, Input.mousePosition.y, cameraZDistance);

        Vector3 NewWorldPosition = mainCamera.ScreenToWorldPoint(ScreenPosition);

        if (NewWorldPosition.y > 2.5)
        {
            if (!isSwitchedOn)
            {
                turnOn();
                switchedOn.Invoke();
            }

        }

    }

    public void turnOn()
    {
        handle.transform.eulerAngles = new Vector3(
            handle.transform.eulerAngles.x,
            handle.transform.eulerAngles.y,
            handle.transform.eulerAngles.z + 75

        );
        isSwitchedOn = true;
        StartCoroutine(AutoSwitchOff());
    }
    public void turnOff()
    {
        handle.transform.eulerAngles = new Vector3(
            handle.transform.eulerAngles.x,
            handle.transform.eulerAngles.y,
            handle.transform.eulerAngles.z - 75

        );
        isSwitchedOn = false;
    }

    IEnumerator AutoSwitchOff()
    {
        yield return new WaitForSeconds(1);
        turnOff();
    }

}
