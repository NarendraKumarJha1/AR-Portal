using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GateOpen : MonoBehaviour
{
     Animator myDoor;
    // Start is called before the first frame update
    void Start()
    {
        myDoor = gameObject.GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("Entered gate");
        if (other.gameObject.CompareTag("MainCamera"))
        {
            Debug.Log("triggered anim gate");
            myDoor.SetTrigger("Open");
            myDoor.SetBool("OpenG", true);
        }
    }
    public void Open()
    {
        myDoor.SetTrigger("Open");
    }
}
