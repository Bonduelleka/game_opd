using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System.Collections.Generic;

public class ButtonManager : MonoBehaviour
{
    public GameObject buttonPrefab;
    public Transform contentParent;

    [System.Serializable]
    public class BuildingButtonData
    {
        public string buildingName;
        public int requiredXP;
    }

    public List<BuildingButtonData> buildings;

    void Start()
    {
        foreach (var data in buildings)
        {
            GameObject buttonGO = Instantiate(buttonPrefab, contentParent);
            var button = buttonGO.GetComponent<BuildingButton>();
            button.SetData(data.buildingName, data.requiredXP);
        }
    }
}
