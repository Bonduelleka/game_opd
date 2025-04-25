using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;

    public int woodXP = 0; // Текущий опыт
    public TextMeshProUGUI woodXPText; // UI-элемент для отображения опыта
    public BuildingManager buildingManager;

    private void Awake()
    {
        if (Instance == null) Instance = this;
    }

    private void Start()
    {
        UpdateUI();
    }

    public void AddWoodXP(int amount)
    {
        woodXP += amount;
        UpdateUI();
    }

    void UpdateUI()
    {
        //woodXPText.text = "WoodXP: " + woodXP;
    }
}
