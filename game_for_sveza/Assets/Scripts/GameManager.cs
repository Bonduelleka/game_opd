using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;
    private DataSaver dataSaver;
    public int woodXP = 0;
    public TextMeshProUGUI woodXPText; // UI-������� ��� ����������� �����
    public BuildingManager buildingManager;

    private void Awake()
    {
        dataSaver = FindObjectOfType<DataSaver>();
        Debug.Log(dataSaver.woodXP);
        woodXP = dataSaver.woodXP;
        if (Instance == null) Instance = this;
    }

    private void Start()
    {
        Debug.Log("START XP: " + dataSaver.woodXP);
        UpdateUI();
    }

    public void AddWoodXP(int amount)
    {
        woodXP += amount;
        UpdateUI();
        Debug.Log("������� XP: " +  woodXP);
        dataSaver.woodXP = woodXP;
    }

    void UpdateUI()
    {
        //woodXPText.text = "WoodXP: " + woodXP;
        // � ������� �� ��������
    }
}
