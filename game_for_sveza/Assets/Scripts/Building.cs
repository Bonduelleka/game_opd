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

    private void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        UpdateVisual();
        if (isOpened)
        {
            InvokeRepeating("GenerateXP", 1f, 1f);
        }
    }

    void GenerateXP()
    {
        if (isOpened)
        {
            GameManager.Instance.AddWoodXP(woodXPPerSecond);
        }
    }
    void UpdateVisual()
    {
        if (spriteRenderer == null)
            spriteRenderer = GetComponent<SpriteRenderer>();

        spriteRenderer.sprite = isOpened ? openedSprite : lockedSprite;
    }
}
