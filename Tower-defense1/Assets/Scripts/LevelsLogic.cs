using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelsLogic : MonoBehaviour
{
    public List<object> Levels = new List<object>();

    string jsonContent;

    private void Start()
    {
        readJson();
    }

    public interface level
    {
        string Name { get; set; }
        int Level { get; set; }
        int Waves { get; set; }
        string[] Enemies { get; set; }
        float SpawnRate { get; set; }
        float FrequencyWaves { get; set; }
        List<object> DetailEnemies { get; set; }

    }

    public class levelDetails : level
    {

        public string Name { get; set; }
        public int Level { get; set; }
        public int Waves { get; set; }
        public string[] Enemies { get; set; }
        public float SpawnRate { get; set; }
        public float FrequencyWaves { get; set; }
        public List<object> DetailEnemies { get; set; }


        // method in class to create new level
        public void setLevel(string name, int level, int waves, string[] enemies, float frequencyWaves, List<object> detailEnemies, float spawnRate)
        {

            Name = name;
            Level = level;
            Waves = waves;
            Enemies = enemies;
            FrequencyWaves = frequencyWaves;
            DetailEnemies = detailEnemies;
            SpawnRate = spawnRate;

        }

    }


    public void readJson()
    {
        TextAsset jsonFile = Resources.Load<TextAsset>("levels");

        if (jsonFile != null)
        {
            string Levels = jsonFile.text;
            Debug.Log(Levels);


        }
        else
        {
            Debug.LogError("Plik JSON nie zosta³ za³adowany.");
        }
    }


}
