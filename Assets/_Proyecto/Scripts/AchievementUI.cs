using MoreMountains.Tools;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

[CreateAssetMenu(fileName = "AchievementList", menuName = "MoreMountains/Achievement List")]
public class AchievementUI : MonoBehaviour
{
    public string AchievementsListID = "AchievementsList";
    public MMAchievementList AchievementList;
    public GameObject achievementItemPrefab;
    public Transform achievementsParent;

    private void Start()
    {
        PopulateAchievements();
    }

    void PopulateAchievements()
    {
        foreach(MMAchievement achievement in MMAchievementManager.AchievementsList)
        {
            GameObject newAchievement = Instantiate(achievementItemPrefab, achievementsParent);
            Text achievementText = newAchievement.GetComponentInChildren<Text>();
            if (achievementText != null)
            {
                string status = achievement.UnlockedStatus ? "unlocked" : "locked";
                achievementText.text = achievement.Title + ", Estado del logro: " + status + ", progreso: " + achievement.ProgressCurrent + "/" + achievement.ProgressTarget;
            }
            Image statusImage = newAchievement.GetComponentInChildren<Image>();
            if (statusImage != null)
            {
                statusImage.sprite = achievement.UnlockedStatus ? achievement.UnlockedImage : achievement.LockedImage;
            }
        }
    }

    public void ResetAchievement()
    {
        MMAchievementManager.ResetAchievements(AchievementsListID);
        SceneManager.LoadScene("Logros");
    }

    public void ExitScene()
    {
        SceneManager.LoadScene("Main");
    }
        
}
