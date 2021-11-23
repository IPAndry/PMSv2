using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DateChecker : MonoBehaviour
{
    public Image photoHolder;
    public Sprite[] photo;

    int scoreDate;
    public float howMuchNeedScore;
    int saberSympathyNow;
    int saberSympathyPlus = 10;

    static int SaberDatesFinished;

    bool isDone = false;



    void Start()
    {
        SaberDatesFinished = PlayerPrefs.GetInt("SaberDateFinished");
    }

    void Update()
    {
        scoreDate = Mathf.RoundToInt(ScoreManager.score);

        print("ScoreDate " + scoreDate);

        if (scoreDate == howMuchNeedScore && isDone == false)
        {
            isDone = true;
            DateComplete();
        }

        print("SaberSymp" + PlayerPrefs.GetInt("SaberSympathy"));
    }

    public void DateComplete()
    {
        int saberPhotoTwo = PlayerPrefs.GetInt("saberPhotoTwo");
        int saberPhotoThree = PlayerPrefs.GetInt("saberPhotoThree");

        saberSympathyNow = PlayerPrefs.GetInt("SaberSympathy");

        PlayerPrefs.SetInt("SaberSympathy", saberSympathyNow + 10);

        saberSympathyNow = PlayerPrefs.GetInt("SaberSympathy");

        PlayerPrefs.SetInt("SaberDateFinished", ++SaberDatesFinished);
        PlayerPrefs.Save();
        if (SaberDatesFinished == 1)
        {
            PlayerPrefs.Save();
            photoHolder.color = new Vector4(255, 255, 255, 255);
            photoHolder.sprite = photo[0];
        }
        else if (saberSympathyNow >= 50 && saberPhotoTwo == 0)
        {
            ++saberPhotoTwo;
            PlayerPrefs.SetInt("saberPhotoTwo", saberPhotoTwo);
            PlayerPrefs.Save();
            photoHolder.color = new Vector4(255, 255, 255, 255);
            photoHolder.sprite = photo[1];
        }
        else if (saberSympathyNow >= 100 && saberPhotoThree == 0)
        {
            ++saberPhotoThree;
            PlayerPrefs.SetInt("saberPhotoThree", saberPhotoThree);
            PlayerPrefs.Save();
            photoHolder.color = new Vector4(255, 255, 255, 255);
            photoHolder.sprite = photo[2];
        }
        else
        {
            PlayerPrefs.Save();
        }
        //print("SaberDate" + SaberDatesFinished);
        print("SaberSymp" + saberSympathyNow);
    }
}
