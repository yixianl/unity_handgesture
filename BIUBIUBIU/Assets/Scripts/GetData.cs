using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using System.Timers;
using UnityEditor;
using Leap;


public class GetData : MonoBehaviour
{
    public int iframe = 0;
    public Hand hand;
    
    public Transform left_handpalm;
    public Transform left_thumb_tip;
    public Transform left_index_tip;
    public Transform left_middle_tip;
    public Transform left_ring_tip;
    public Transform left_pinky_tip;
    public Transform left_thumb_joint;
    public Transform left_index_joint;
    public Transform left_middle_joint;
    public Transform left_ring_joint;
    public Transform left_pinky_joint;

    public Transform right_handpalm;
    public Transform right_thumb_tip;
    public Transform right_index_tip;
    public Transform right_middle_tip;
    public Transform right_ring_tip;
    public Transform right_pinky_tip;
    public Transform right_thumb_joint;
    public Transform right_index_joint;
    public Transform right_middle_joint;
    public Transform right_ring_joint;
    public Transform right_pinky_joint;

    static string path = "D:\\8110project\\New Unity Project\\Assets\\Data\\test.txt";
    static FileStream fs = new FileStream(path, FileMode.Create, FileAccess.Write);
    StreamWriter writer = new StreamWriter(fs);
    /*
    FileInfo file = new FileInfo(path);
    StreamWriter writer = new StreamWriter(path, true);
    public TextAsset a;
    FileStream file;
    */

    // Start is called before the first frame update
    void Start()
    {
        writer.WriteLine("frame "+
            /*
            "left_handpalm "+ "left_thumb_tip "+ "left_index_tip "+ "left_middle_tip "+ "left_ring_tip "+ "left_pinky_tip "+
          "left_thumb_joint " + "left_index_joint " + "left_middle_joint " + "left_ring_joint " + "left_pinky_joint "+
          */
          "right_handpalm " + "right_thumb_tip " + "right_index_tip " + "right_middle_tip " + "right_ring_tip " + "right_pinky_tip "+
          "right_thumb_joint " + "right_index_joint " + "right_middle_joint " + "right_ring_joint " + "right_pinky_joint ");   
    }
    //-----------------------real time  feature start ---------------------------------------------//
    //P: standard deviation of palm position
    /*
    private void GetPalmPosition()
    {
        int numberofframe = 10;
        int totalframe = 600;
        Vector3[] right_palmposition = new Vector3[totalframe];
        double[] palm_feature = new double[totalframe];

        for (int i = 0; i < totalframe; i++)
        {
            right_palmposition[i] = right_handpalm.position;
        }
        //get average palm position
        Vector3[] average_right_palmposition = new Vector3[totalframe / numberofframe];
        for (int i = 0; i < totalframe/numberofframe; i++)
        {
            average_right_palmposition[i] = (right_palmposition[10 * i] + right_palmposition[10 * i + 1]
                 + right_palmposition[10 * i + 2] + right_palmposition[10 * i + 3] + right_palmposition[10 * i + 4]
                 + right_palmposition[10 * i + 5] + right_palmposition[10 * i + 6] + right_palmposition[10 * i + 7]
                 + right_palmposition[10 * i + 8] + right_palmposition[10 * i + 9]) / 10;
        }
        //get palm feature
        for (int i = 0; i < totalframe/ numberofframe; i++)
        {
           for (int j = 0; j < numberofframe; j++)
            {
                palm_feature[10*i+j] =
                Mathf.sqrt(((right_palmposition[10 * i + j] - average_right_palmposition[Mathf.FloorToInt(i / 10)]).sqrMagnitude) / 9);
            }
        }   
    }
    */
    //D: distance between palm center and fingertips

    //A: the angle between fingertips and the center is the palm position


    //F: distance between two fingertips


    //J: distance between the joint of two adjacent fingers

    //------------------------------------real time feature end -------------------------------------------------//
    

    


    // Update is called once per frame
    void Update()
    {

        if (iframe >= 0 && iframe < 100)
        {
            iframe++;
            print(iframe);
        }
        else if (iframe >= 100 && iframe < 700)
        {
            writer.WriteLine((iframe - 100).ToString() + " " +
            /*
            " " +left_handpalm.position.x.ToString() + " " + left_handpalm.position.y.ToString() + " " + left_handpalm.position.z.ToString() + " " +
            left_thumb_tip.position.x.ToString() + " " + left_thumb_tip.position.y.ToString() + " " + left_thumb_tip.position.z.ToString() + " " +
            left_index_tip.position.x.ToString() + " " + left_index_tip.position.y.ToString() + " " + left_index_tip.position.z.ToString() + " " +
            left_middle_tip.position.x.ToString() + " " + left_middle_tip.position.y.ToString() + " " + left_middle_tip.position.z.ToString() + " " +
            left_ring_tip.position.x.ToString() + " " + left_ring_tip.position.y.ToString() + " " + left_ring_tip.position.z.ToString() + " " +
            left_pinky_tip.position.x.ToString() + " " + left_pinky_tip.position.y.ToString() + " " + left_pinky_tip.position.z.ToString() + " " +
            left_thumb_joint.position.x.ToString() + " " + left_thumb_joint.position.y.ToString() + " " + left_thumb_joint.position.z.ToString() + " " +
            left_index_joint.position.x.ToString() + " " + left_index_joint.position.y.ToString() + " " + left_index_joint.position.z.ToString() + " " +
            left_middle_joint.position.x.ToString() + " " + left_middle_joint.position.y.ToString() + " " + left_middle_joint.position.z.ToString() + " " +
            left_ring_joint.position.x.ToString() + " " + left_ring_joint.position.y.ToString() + " " + left_ring_joint.position.z.ToString() + " " +
            left_pinky_joint.position.x.ToString() + " " + left_pinky_joint.position.y.ToString() + " " + left_pinky_joint.position.z.ToString() + " " +
            */
            right_handpalm.position.x.ToString() + " " + right_handpalm.position.y.ToString() + " " + right_handpalm.position.z.ToString() + " " +
            right_thumb_tip.position.x.ToString() + " " + right_thumb_tip.position.y.ToString() + " " + right_thumb_tip.position.z.ToString() + " " +
            right_index_tip.position.x.ToString() + " " + right_index_tip.position.y.ToString() + " " + right_index_tip.position.z.ToString() + " " +
            right_middle_tip.position.x.ToString() + " " + right_middle_tip.position.y.ToString() + " " + right_middle_tip.position.z.ToString() + " " +
            right_ring_tip.position.x.ToString() + " " + right_ring_tip.position.y.ToString() + " " + right_ring_tip.position.z.ToString() + " " +
            right_pinky_tip.position.x.ToString() + " " + right_pinky_tip.position.y.ToString() + " " + right_pinky_tip.position.z.ToString() + " " +
            right_thumb_joint.position.x.ToString() + " " + right_thumb_joint.position.y.ToString() + " " + right_thumb_joint.position.z.ToString() + " " +
            right_index_joint.position.x.ToString() + " " + right_index_joint.position.y.ToString() + " " + right_index_joint.position.z.ToString() + " " +
            right_middle_joint.position.x.ToString() + " " + right_middle_joint.position.y.ToString() + " " + right_middle_joint.position.z.ToString() + " " +
            right_ring_joint.position.x.ToString() + " " + right_ring_joint.position.y.ToString() + " " + right_ring_joint.position.z.ToString() + " " +
            right_pinky_joint.position.x.ToString() + " " + right_pinky_joint.position.y.ToString() + " " + right_pinky_joint.position.z.ToString()
            );
            iframe += 1;
            print(iframe);
            //GetPalmPosition();
        }
        else if (iframe >= 700)//Time.time
        {
            print("collection complete");
            writer.Close();
            fs.Close();
        }

        /*
        AssetDatabase.ImportAsset(path);
        TextAsset a = Data.Load("test");
        */

    }
}
