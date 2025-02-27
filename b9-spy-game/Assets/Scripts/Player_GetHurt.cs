using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_GetHurt : MonoBehaviour
{

    public GameObject humanForm;
    public GameObject alienForm;


    // Start is called before the first frame update
    void Start()
    {
        alienForm.SetActive(true);
        humanForm.SetActive(false);
        StartCoroutine(TurnHuman(1f));
    }

    // Update is called once per frame
    public void GetHurtStart(float timeChange)
    {
       StartCoroutine(TurnBug(timeChange)); 
    }

   public void GetHurtStop()
    {
        StopCoroutine(TurnBug(0.01f));
        StartCoroutine(TurnHuman(0.3f));
    }

    IEnumerator TurnHuman(float timeChange){
        yield return new WaitForSeconds(timeChange);
        alienForm.SetActive(false);
        humanForm.SetActive(true); 
    }

    IEnumerator TurnBug(float timeChange){
        yield return new WaitForSeconds(timeChange/4);
        alienForm.SetActive(true);
        humanForm.SetActive(false); 
        yield return new WaitForSeconds(0.1f);
        alienForm.SetActive(false);
        humanForm.SetActive(true); 

        yield return new WaitForSeconds(timeChange/5);
        alienForm.SetActive(true);
        humanForm.SetActive(false); 
        yield return new WaitForSeconds(0.1f);
        alienForm.SetActive(false);
        humanForm.SetActive(true);

        yield return new WaitForSeconds(timeChange/6);
        alienForm.SetActive(true);
        humanForm.SetActive(false); 
        yield return new WaitForSeconds(0.1f);
        alienForm.SetActive(false);
        humanForm.SetActive(true);  

        yield return new WaitForSeconds(timeChange/7);
        alienForm.SetActive(true);
        humanForm.SetActive(false); 
        yield return new WaitForSeconds(0.1f);
        alienForm.SetActive(false);
        humanForm.SetActive(true); 

        yield return new WaitForSeconds(timeChange/8);
        alienForm.SetActive(true);
        humanForm.SetActive(false); 
        yield return new WaitForSeconds(0.1f);
        alienForm.SetActive(false);
        humanForm.SetActive(true); 

    }

}
