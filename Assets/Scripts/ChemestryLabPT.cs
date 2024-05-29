using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class NewBehaviourScript : MonoBehaviour
{
    public Button btn;
    public GameObject PTButton;
    public GameObject Beaker;
    public GameObject BrownBottle;
    public TextMeshProUGUI robotInstructions;
    public TextMeshProUGUI PTInstructions;

    // Start is called before the first frame update
    void Start()
    {
        Beaker.SetActive(false);
        BrownBottle.SetActive(false);
        PTButton.SetActive(true);
        btn.onClick.AddListener(PTButtonOnClick);
    }

    void PTButtonOnClick()
    {
        Debug.Log("clicked");
        PTButton.SetActive(false);
        Beaker.SetActive(true);
        BrownBottle.SetActive(true);
        robotInstructions.text="Grab the brown bottle with bromie with the controller  and pour the bromine into the beaker";

        StartCoroutine(StartTimer());
    }

    IEnumerator StartTimer()
    {
        yield return new WaitForSeconds(10.0f);
        Beaker.SetActive(false);
        BrownBottle.SetActive(false);
        PTInstructions.text="Proctice completed, you will now complete a calibration process before conducting this study.";
        robotInstructions.text="Well done for completing  this practice trial";
        PTButton.SetActive(true);
    }


    // Update is called once per frame
    void Update()
    {
        
    }
}
