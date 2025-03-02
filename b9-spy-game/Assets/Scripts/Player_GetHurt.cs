using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_GetHurt : MonoBehaviour
{

    public GameObject humanForm;
    public GameObject alienForm;

    private float timeChange;

    // Start is called before the first frame update
    void Start()
    {
        alienForm.SetActive(true);
        humanForm.SetActive(false);
        StartCoroutine(TurnHuman());
    }

    // Update is called once per frame
    public void GetHurtStart()
    {
        Debug.Log("> START COROUTINE");
    //    StartCoroutine(TurnBug(timeChange)); 
       StartCoroutine(TurnBug()); 
    }

   public void GetHurtStop()
    {
        Debug.Log("> STOP COROUTINE");
        StopCoroutine(TurnBug());
        StartCoroutine(TurnHuman());
    }

    IEnumerator TurnHuman(){
        timeChange = 1f;
        yield return new WaitForSeconds(timeChange);
        alienForm.SetActive(false);
        humanForm.SetActive(true); 
    }

    // This is ugly as hell, but it allows the Coroutine to be stopped.
    IEnumerator TurnBug(){
        timeChange = 1f;
        yield return new WaitForSeconds(timeChange/ 4 );
        alienForm.SetActive(true);
        humanForm.SetActive(false); 
        yield return new WaitForSeconds(0.1f);
        alienForm.SetActive(false);
        humanForm.SetActive(true); 

        yield return new WaitForSeconds(timeChange/ 5 );
        alienForm.SetActive(true);
        humanForm.SetActive(false); 
        yield return new WaitForSeconds(0.1f);
        alienForm.SetActive(false);
        humanForm.SetActive(true); 

        yield return new WaitForSeconds(timeChange/ 6 );
        alienForm.SetActive(true);
        humanForm.SetActive(false); 
        yield return new WaitForSeconds(0.1f);
        alienForm.SetActive(false);
        humanForm.SetActive(true); 

        yield return new WaitForSeconds(timeChange/ 7 );
        alienForm.SetActive(true);
        humanForm.SetActive(false); 
        yield return new WaitForSeconds(0.1f);
        alienForm.SetActive(false);
        humanForm.SetActive(true); 

        yield return new WaitForSeconds(timeChange/ 8 );
        alienForm.SetActive(true);
        humanForm.SetActive(false); 
        yield return new WaitForSeconds(0.1f);
        alienForm.SetActive(false);
        humanForm.SetActive(true); 

        yield return new WaitForSeconds(timeChange/ 9 );
        alienForm.SetActive(true);
        humanForm.SetActive(false); 
        yield return new WaitForSeconds(0.1f);
        alienForm.SetActive(false);
        humanForm.SetActive(true); 

        yield return new WaitForSeconds(timeChange/ 10 );
        alienForm.SetActive(true);
        humanForm.SetActive(false); 
        yield return new WaitForSeconds(0.1f);
        alienForm.SetActive(false);
        humanForm.SetActive(true); 

        yield return new WaitForSeconds(timeChange/ 11 );
        alienForm.SetActive(true);
        humanForm.SetActive(false); 
        yield return new WaitForSeconds(0.1f);
        alienForm.SetActive(false);
        humanForm.SetActive(true); 

        yield return new WaitForSeconds(timeChange/ 12 );
        alienForm.SetActive(true);
        humanForm.SetActive(false); 
        yield return new WaitForSeconds(0.1f);
        alienForm.SetActive(false);
        humanForm.SetActive(true); 

        yield return new WaitForSeconds(timeChange/ 13 );
        alienForm.SetActive(true);
        humanForm.SetActive(false); 
        yield return new WaitForSeconds(0.1f);
        alienForm.SetActive(false);
        humanForm.SetActive(true); 

        yield return new WaitForSeconds(timeChange/ 14 );
        alienForm.SetActive(true);
        humanForm.SetActive(false); 
        yield return new WaitForSeconds(0.1f);
        alienForm.SetActive(false);
        humanForm.SetActive(true); 

        yield return new WaitForSeconds(timeChange/ 15 );
        alienForm.SetActive(true);
        humanForm.SetActive(false); 
        yield return new WaitForSeconds(0.1f);
        alienForm.SetActive(false);
        humanForm.SetActive(true); 

        humanForm.SetActive(false); 
        alienForm.SetActive(true);
        // yield return new WaitForSeconds(timeChange/5);
        // alienForm.SetActive(true);
        // humanForm.SetActive(false); 
        // yield return new WaitForSeconds(0.1f);
        // alienForm.SetActive(false);
        // humanForm.SetActive(true);

        // yield return new WaitForSeconds(timeChange/6);
        // alienForm.SetActive(true);
        // humanForm.SetActive(false); 
        // yield return new WaitForSeconds(0.1f);
        // alienForm.SetActive(false);
        // humanForm.SetActive(true);  

        // yield return new WaitForSeconds(timeChange/7);
        // alienForm.SetActive(true);
        // humanForm.SetActive(false); 
        // yield return new WaitForSeconds(0.1f);
        // alienForm.SetActive(false);
        // humanForm.SetActive(true); 

        // yield return new WaitForSeconds(timeChange/8);
        // alienForm.SetActive(true);
        // humanForm.SetActive(false); 
        // yield return new WaitForSeconds(0.1f);
        // alienForm.SetActive(false);
        // humanForm.SetActive(true); 

    }

}
