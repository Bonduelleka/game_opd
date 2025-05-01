using UnityEngine;
using UnityEngine.UI;

public class Building : MonoBehaviour
{
    public int woodXPPerSecond;
    public bool isOpened = false;
    public int price;

    public Sprite openedSprite;
    public Sprite lockedSprite;
    private SpriteRenderer spriteRenderer;
    public GameManager gameManager;

    private void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        UpdateVisual();
        if (isOpened)
        {
            InvokeRepeating("GenerateXP", 1f, 1f);
        }
    }

    private void Update()
    {
        ChangeStatus();
    }

    void GenerateXP()
    {
        if (isOpened)
        {
            GameManager.Instance.AddWoodXP(woodXPPerSecond);
        }
    }
    public void UpdateVisual()
    {
        if (spriteRenderer == null)
            spriteRenderer = GetComponent<SpriteRenderer>();

        spriteRenderer.sprite = isOpened ? openedSprite : lockedSprite;
    }

    private void ChangeStatus()
    {
        if (gameManager.GetComponent<GameManager>().woodXP >= price)
        {
            isOpened = true;
            gameManager.GetComponent<GameManager>().woodXP -= price;
            Debug.Log("STATUS HAS BEEN CHANCHED");
        }
    }
}
