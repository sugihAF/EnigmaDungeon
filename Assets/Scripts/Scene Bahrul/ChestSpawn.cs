using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChestSpawn : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject[] enemies;
    public GameObject chest;

    private void Update()
    {
        if (!enemies[0].activeSelf && !enemies[1].activeSelf && !enemies[2].activeSelf)
        {
            chest.SetActive(true);
        }
    }
}
