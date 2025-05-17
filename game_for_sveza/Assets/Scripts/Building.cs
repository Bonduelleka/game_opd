using System;
using UnityEngine;
using UnityEngine.UI;

public class Building : MonoBehaviour
{
    [SerializeField] private string name;
    private int woodXPPerSecond = 20;
    public bool isOpened { get; private set; }
    public int price;
    private DataSaver dataSaver;
    public Sprite openedSprite;
    public Sprite lockedSprite;
    private SpriteRenderer spriteRenderer;
    public GameManager gameManager;

    private void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        UpdateVisual();
        if (price == 0)
        { 
            isOpened = true;
            dataSaver.countOfActiveBuildings++;
        }
        if (isOpened)
        {
            InvokeRepeating("GenerateXP", 1f, 1f);
        }
    }

    private void Awake()
    {
        gameManager = gameManager.GetComponent<GameManager>();
        dataSaver = FindObjectOfType<DataSaver>();
    }

    public string GetName()
    {
        return name;
    }
    private void GenerateXP()
    {
        if (isOpened)
        {
            GameManager.Instance.AddWoodXP(woodXPPerSecond);
        }
    }
    private void UpdateVisual()
    {
        if (spriteRenderer == null)
            spriteRenderer = GetComponent<SpriteRenderer>();

        spriteRenderer.sprite = isOpened ? openedSprite : lockedSprite;

        if (TryGetComponent<Animator>(out var animator))
        {
            animator.enabled = isOpened;
            animator.SetBool("isActive", isOpened);
        }
    }

    public bool ChangeStatus()
    {
        if (gameManager.woodXP >= price)
        {
            isOpened = true;
            gameManager.woodXP -= price;
            dataSaver.woodXP = (gameManager.woodXP);
            UpdateVisual();
            dataSaver.countOfActiveBuildings++;

            SoundManager.PlaySound(SoundType.PURCHASE);
            return true;
        }
        else
        { 
            SoundManager.PlaySound(SoundType.FAIL,1); 
        }
        return false;
    }
}
