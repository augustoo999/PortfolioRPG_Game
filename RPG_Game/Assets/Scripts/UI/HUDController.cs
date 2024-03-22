using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HUDController : MonoBehaviour
{
    [SerializeField]
    private Image waterUI;
    [SerializeField]
    private Image woodUI;
    [SerializeField]
    private Image carrotUI;

    private PlayerItems playerItems;

    // Start is called before the first frame update
    void Start()
    {
        waterUI.fillAmount = 0;
        woodUI.fillAmount = 0;
        carrotUI.fillAmount = 0;
    }

    // Update is called once per frame
    void Update()
    {
        waterUI.fillAmount = playerItems.waterPlayer;
    }
}
