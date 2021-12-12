using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PortalClose : MonoBehaviour
{
    public GameObject portal;
    public GameObject dialogBox;
    public bool playerInRange;
    public Text dialogText;
    public string dialog;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (dialogBox.activeInHierarchy)
            {
                dialogBox.SetActive(false);
            }
        }
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            dialogBox.SetActive(true);
            dialogText.text = dialog;
            playerInRange = true;
        }
    }
    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            dialogBox.SetActive(false);
            playerInRange = false;
            portal.SetActive(false);
        }
    }
}
