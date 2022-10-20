using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class UpdateCountUI : MonoBehaviour
{
    public TMP_Text buttonCounterUI;
    public TMP_Text switchCounterUI;
    public GameObject counter;
    
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        buttonCounterUI.text = counter.GetComponent<Counter>().buttonClicks.ToString();
        switchCounterUI.text = counter.GetComponent<Counter>().onSwitches.ToString();

    }
}
