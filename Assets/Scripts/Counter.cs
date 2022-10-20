using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Counter : MonoBehaviour
{
    public int buttonClicks = 0;
    public int onSwitches = 0;
    public int totalInteractions = 0;
    public UnityEvent reachTenInteractions;


    // Update is called once per frame
    void Update()
    {
        totalInteractions = buttonClicks + onSwitches;
        checkMaxInteractions();
    }

    public void increaseButtonCount()
    {
        buttonClicks += 1;
    }
    public void increaseSwitchCount()
    {
        onSwitches += 1;
    }

    public void checkMaxInteractions()
    {
        if (totalInteractions >= 10)
        {
            reachTenInteractions.Invoke();
        }

    }
}
