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
    public GameObject target4_6;
    public GameObject target4_7;
    public GameObject target5;
    public GameObject target5_1;
    public GameObject target5_2;
    public GameObject target5_3;
    public GameObject target6;
    public GameObject target6_1;


    private Tween cameraMove = null;
    int pauseCount =0;


    void Start()
    {



        /*Sequence sequence = DOTween.Sequence();

        // 3•b‚©‚¯‚Ä(5,0,0)‚ÖˆÚ“®‚·‚é
        //this.transform.DOMove(new Vector3(5f, 0f, 0f), 3f);
        sequence.Append(
        cameraMove = this.transform.DOPath(new Vector3[] { target1.transform.position, target1_5.transform.position, target2.transform.position, target3.transform.position, target4.transform.position, target4_5.transform.position, target1.transform.position, target1.transform.position, target1_5.transform.position, target2.transform.position, target5.transform.position,target6.transform.position,target1.transform.position}, 600f, PathType.Linear).SetLookAt(0.01f)).SetEase(Ease.Linear) ;
        
        sequence.SetLoops(-1,LoopType.Restart);

        //sequence.stop();*/

        DG.Tweening.DOTween.SetTweensCapacity(tweenersCapacity: 2500, sequencesCapacity: 200);


    }

    void Update()
    {
        
        
       
        if (Input.GetKeyDown(KeyCode.S))
        {
            if (pauseCount== 0)
            {
                
                
                // 3•b‚©‚¯‚Ä(5,0,0)‚ÖˆÚ“®‚·‚é
                //this.transform.DOMove(new Vector3(5f, 0f, 0f), 3f);
                
                cameraMove = this.transform.DOPath(new Vector3[] { target1.transform.position, target1_5.transform.position, target2.transform.position, target3.transform.position, target4.transform.position, target4_5.transform.position, target1.transform.position, target1.transform.position, target1_5.transform.position, target4_6.transform.position, target4_7.transform.position, target5.transform.position, target5_1.transform.position, target5_2.transform.position,  target5_3.transform.position,target6.transform.position, target6_1.transform.position, target1.transform.position }, 480f, PathType.Linear).SetLookAt(0.01f);
                cameraMove.SetEase(Ease.Linear);

                cameraMove.SetLoops(-1, LoopType.Restart);

            }
            if(pauseCount %2 ==1 )
            {
                cameraMove.Pause();
                float elapsed = ProcessTimer.Stop ();

                Debug.Log(elapsed);

            }
            else
            {
                cameraMove.Play();
                
            }
            pauseCount++;
           
            

            /*if(LogitechPath.stopflag == 2)
            {
                cameraMove.Pause();
                float elapsed = ProcessTimer.Stop();

                Debug.Log(elapsed);
            }

            if (LogitechPath.stopflag == 1)
            {
                cameraMove.Play();
            }
            */
        }

        /*if(LogitechPath.stopflag == 2)
        {
            cameraMove.Pause();
            float elapsed = ProcessTimer.Stop();

            Debug.Log(elapsed);
        }
        else
        {
            cameraMove.Play();
        }*/
    }

    
}