using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HUDController : MonoBehaviour
{
    [Header("Items")]
    [SerializeField]
    private Image waterUI;
    [SerializeField]
    private Image woodUI;
    [SerializeField]
    private Image carrotUI;

    [Header("Tools")]
    //[SerializeField]
    //private Image AxeUI;
    //[SerializeField]
    //private Image ShovelUI;
    //[SerializeField]
    //private Image BucketUI;
    //[SerializeField]
    public List<Image> ToolsUI = new List<Image>();

    private PlayerItems playerItems;
    private Player player;
    [SerializeField]
    private Color AlphaColor;
    [SerializeField]
    private Color SelectedColorItem;


    private void Awake()
    {
        playerItems = FindObjectOfType<PlayerItems>();
        player = playerItems.GetComponent<Player>();
    }

    void Start()
    {
        waterUI.fillAmount = 0f;
        woodUI.fillAmount = 0f;
        carrotUI.fillAmount = 0f;
    }

    void Update()
    {
        waterUI.fillAmount = playerItems.waterPlayer / playerItems._WaterLimit;
        carrotUI.fillAmount = playerItems.carrotPlayer / playerItems._CarrotLimit;
        woodUI.fillAmount = playerItems.woodPlayer / playerItems._WoodLimit;

        //ToolsUI[player.tools].color = SelectedColorItem;

        for (int i = 0; i < ToolsUI.Count; i++)
        {
            if (i == player.tools)
            {
                ToolsUI[i].color = SelectedColorItem;
            }
            else
            {
                ToolsUI[i].color = AlphaColor;
            }
        }
    }
}
