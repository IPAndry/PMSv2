using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Cell2048 : MonoBehaviour
{
    // X и Y которые показывают располежние плитки в массиве
    // Х - по вертикали 
    public int X { get; private set; }
    // Y - по горизонтали
    public int Y { get; private set; }
    // Value - хранит номинал плитки в виде степени двойки, потому что при присоединении двух плиток - их значение удваивается
    public int Value { get; private set; }
    // Points - храние номинала плитки в понятном виде (возведение двойки в степень Value)
    public int Points => Value == 0 ? 0 : (int)Mathf.Pow(2, Value);
    // Исключение, если Value = 0
    public bool IsEmpty => Value == 0;
    // MaxValue - константа определяющее максимальное значение плитки

    public bool HasMerged { get; private set; }

    
    public const int MaxValue = 11;

    // Image - изображение нашей плитки, от номинала меняющая цвет
    [SerializeField] private Image image;

    // Points - отображение номинала
    [SerializeField] private TextMeshProUGUI points;

    private CellAnimation2048 currentAnimation;

    public void SetValue(int x, int y, int value, bool updateUI = true)
    {
        X = x;
        Y = y;
        Value = value;

        if (updateUI)
            UpdateCells();
    }

    public void IncreaseValue()
    {
        Value++;
        HasMerged = true;

        GameController2048.Instance.AddPoints(Points);
    }

    public void ResetFlags()
    {
        HasMerged = false;
    }

    public void MergeWithCell(Cell2048 otherCell)
    {
        CellAnimationController2048.Instance.SmoothTransition(this, otherCell, true);

        otherCell.IncreaseValue();
        SetValue(X, Y, 0);
    }

    public void MoveToCell(Cell2048 target)
    {
        CellAnimationController2048.Instance.SmoothTransition(this, target, true);

        target.SetValue(target.X, target.Y, Value, false);
        SetValue(X, Y, 0);
    }

    public void UpdateCells()
    {
        points.text = IsEmpty ? string.Empty : Points.ToString();

        points.color = Value <= 2 ? ColorManager2048.Instance.PointsDarkColor :
            ColorManager2048.Instance.PointsLightColor;

        image.color = ColorManager2048.Instance.CellColors[Value];
    }

    public void SetAnimation(CellAnimation2048 animation)
    {
        currentAnimation = animation;
    }
    
    public void CancelAnimation()
    {
        if (currentAnimation != null)
        {
            currentAnimation.Destroy();
        }
    }
}
