using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using DG.Tweening;  //DOTween‚ðŽg‚¤‚Æ‚«‚Í‚±‚Ìusing‚ð“ü‚ê‚é



public class CameraMove : MonoBehaviour
{

    public GameObject target1;
    public GameObject target1_5;
    public GameObject target2;
    public GameObject target3;
    public GameObject target4;
    public GameObject target4_5;
    public GameObject target5;
    public GameObject target6;
   
  
    private Tween cameraMove = null;
    int pauseCount =0;

    void Start()
    {

        Sequence sequence = DOTween.Sequence();

        // 3•b‚©‚¯‚Ä(5,0,0)‚ÖˆÚ“®‚·‚é
        //this.transform.DOMove(new Vector3(5f, 0f, 0f), 3f);
        sequence.Append(
        cameraMove = this.transform.DOPath(new Vector3[] { target1.transform.position, target1_5.transform.position, target2.transform.position, target3.transform.position, target4.transform.position, target4_5.transform.position, target1.transform.position, target1.transform.position, target1_5.transform.position, target2.transform.position, target5.transform.position,target6.transform.position,target1.transform.position}, 500f, PathType.Linear).SetLookAt(0.02f)).SetEase(Ease.Linear) ;
        
        sequence.SetLoops(-1,LoopType.Restart);

        //sequence.stop();
        

        
        
    }

    public void Pause()
    {
        if (Input.GetKeyDown(KeyCode.S))
        {
            if (pauseCount % 2 == 0)
            {
                cameraMove.Pause();

            }
            else
            {
                cameraMove.Play();
            }
            pauseCount++;
            Debug.Log("a");

        }

    }
}