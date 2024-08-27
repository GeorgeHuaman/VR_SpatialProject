using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIManager : MonoBehaviour
{
    public GameObject map;
    
    public void OpenCloseMap()
    {
        if (map.activeSelf)
            map.SetActive(false);
        else
            map.SetActive(true);

    }
}
