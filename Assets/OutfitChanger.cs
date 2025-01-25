using UnityEngine;
using UnityEngine.UI;

public class OutfitChanger : MonoBehaviour
{
    [SerializeField] private Transform[] Base;
    public bool isMale = true;

    public int headNum;
    public int bodyNum;
    public int legNum;
    
    [Header("Male Parts")]
    [SerializeField] private Image[] MHead;
    [SerializeField] private Image[] MBody;
    [SerializeField] private Image[] MLegs;

    [Header("Female Parts")]
    [SerializeField] private Image[] FHead;
    [SerializeField] private Image[] FBody;
    [SerializeField] private Image[] FLegs;

    public void ChangeGen()
    {
        if(isMale)
        {
            Base[0].gameObject.SetActive(false);
            Base[1].gameObject.SetActive(true);
            isMale = false;
        }
        else
        {
            Base[0].gameObject.SetActive(true);
            Base[1].gameObject.SetActive(false);
            isMale = true;
        }
    }

    public void ChangeHead()
    {
        headNum++;

        if(isMale)
        {
            if(headNum == MHead.Length)
            {
                headNum = 0;
            }

            foreach (Image head in MHead)
            {
                head.gameObject.SetActive(false);
            }

            MHead[headNum].gameObject.SetActive(true);
        }
        else
        {
            if(headNum == FHead.Length)
            {
                headNum = 0;
            }

            foreach (Image head in FHead)
            {
                head.gameObject.SetActive(false);
            }

            FHead[headNum].gameObject.SetActive(true);
        }
    }

    public void ChangeBody()
    {
        bodyNum++;

        if(isMale)
        {
            if(bodyNum == MBody.Length)
            {
                bodyNum = 0;
            }

            foreach (Image body in MBody)
            {
                body.gameObject.SetActive(false);
            }

            MBody[bodyNum].gameObject.SetActive(true);
        }
        else
        {
            if(bodyNum == FBody.Length)
            {
                bodyNum = 0;
            }

            foreach (Image body in FBody)
            {
                body.gameObject.SetActive(false);
            }

            FBody[bodyNum].gameObject.SetActive(true);
        }
    }

    public void ChangeLegs()
    {
        legNum++;

        if(isMale)
        {
            if(legNum == MLegs.Length)
            {
                legNum = 0;
            }

            foreach (Image leg in MLegs)
            {
                leg.gameObject.SetActive(false);
            }

            MLegs[legNum].gameObject.SetActive(true);
        }
        else
        {
            if(legNum == FLegs.Length)
            {
                legNum = 0;
            }

            foreach (Image leg in FLegs)
            {
                leg.gameObject.SetActive(false);
            }

            FLegs[legNum].gameObject.SetActive(true);
        }
    }
}
