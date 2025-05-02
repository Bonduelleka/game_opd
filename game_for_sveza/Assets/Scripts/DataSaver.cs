using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.SocialPlatforms.Impl;

public class DataSaver : MonoBehaviour
{
    public int woodXP;
    public int countOfActiveBuildings;
    public static DataSaver Instance { get; private set; }

    private void Awake()
    {
        LoadData();
    }

    void OnApplicationQuit()
    {
        SaveData();
    }

    void SaveData()
    {
        PlayerPrefs.SetInt("WoodXP", woodXP);
        PlayerPrefs.SetInt("Count", countOfActiveBuildings);
        PlayerPrefs.Save();
    }

    void LoadData()
    {
        woodXP = PlayerPrefs.GetInt("WoodXP", 0);
        countOfActiveBuildings = PlayerPrefs.GetInt("Count", 0);

        woodXP = 0; // сапюрэ опх опнбепйе янупюмемхъ пегскэрюрнб
        countOfActiveBuildings = 0; // сапюрэ опх опнбепйе янупюмемхъ пегскэрюрнб
    }
}
