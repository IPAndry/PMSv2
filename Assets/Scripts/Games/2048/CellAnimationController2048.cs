using DG.Tweening;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CellAnimationController2048 : MonoBehaviour
{
    public static CellAnimationController2048 Instance { get; private set; }

    [SerializeField] private CellAnimation2048 animationPref;

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }
        DOTween.Init();
    }

    public void SmoothTransition(Cell2048 from, Cell2048 to, bool isMerging)
    {
        Instantiate(animationPref, transform, false).Move(from, to, isMerging);
    }

    public void SmoothAppear(Cell2048 cell)
    {
        Instantiate(animationPref, transform, false).Appear(cell);
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
