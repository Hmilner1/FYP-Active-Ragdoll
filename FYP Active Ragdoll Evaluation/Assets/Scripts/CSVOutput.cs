using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using UnityEngine.SceneManagement;
public class CSVOutput : MonoBehaviour
{
    public string FileName;
    private string m_fileName;
    [SerializeField]
    private GameObject Player;
    [SerializeField]
    private GameObject hip;
    [SerializeField]
    private GameObject leftShoulder;
    [SerializeField]
    private GameObject rightShoulder;
    [SerializeField]
    private GameObject head;
    [SerializeField]
    private GameObject leftLeg;
    [SerializeField]
    private GameObject rightLeg;
    [SerializeField]
    private GameObject leftFoot;
    [SerializeField]
    private GameObject rightFoot;
    [SerializeField]
    private GameObject spine;

    private bool m_FirstOpen;
    private TextWriter tw;
    // Start is called before the first frame update
    void Start()
    {
        m_fileName = Application.dataPath + "/" + FileName + ".csv";
        m_FirstOpen = true;

        tw = new StreamWriter(m_fileName, false);
        tw.WriteLine("Head x, Head y, Head z, Spine x, Spine y, Spine z, Left Shoulder x, Left Shoulder y, Left Shoulder z, Right Shoulder x, Right Shoulder y, Right Shoulder z, Hips x, Hips y, Hips z, Left Leg x, Right Leg x, Left Leg y, Right Leg y, Left Leg z, Right Leg z");
        tw.Close();

        tw = new StreamWriter(m_fileName, true);
    }

    // Update is called once per frame
    void Update()
    {
        //tw.WriteLine(head.transform.position.x.ToString() + "," + head.transform.position.y.ToString() + "," + head.transform.position.z.ToString() + "," + spine.transform.position.x.ToString() + "," + spine.transform.position.y.ToString() + "," + spine.transform.position.z.ToString() + "," + rightLeg.transform.position.x.ToString() + "," + leftShoulder.transform.position.y.ToString() + "," + leftShoulder.transform.position.z.ToString() + "," + rightShoulder.transform.position.x.ToString() + "," + rightShoulder.transform.position.y.ToString() + "," + rightShoulder.transform.position.z.ToString() + "," + hip.transform.position.x.ToString() + "," + hip.transform.position.y.ToString() + "," + hip.transform.position.z.ToString() + "," + leftLeg.transform.position.x.ToString() + "," + leftLeg.transform.position.y.ToString() + "," + leftLeg.transform.position.z.ToString() + "," + rightLeg.transform.position.x.ToString() + "," + rightLeg.transform.position.y.ToString() + "," + leftShoulder.transform.position.z.ToString());

    }
    private void FixedUpdate()
    {
        tw.WriteLine(head.transform.position.x.ToString() + "," + head.transform.position.y.ToString() + "," + head.transform.position.z.ToString() + "," + spine.transform.position.x.ToString() + "," + spine.transform.position.y.ToString() + "," + spine.transform.position.z.ToString() + "," + rightLeg.transform.position.x.ToString() + "," + leftShoulder.transform.position.y.ToString() + "," + leftShoulder.transform.position.z.ToString() + "," + rightShoulder.transform.position.x.ToString() + "," + rightShoulder.transform.position.y.ToString() + "," + rightShoulder.transform.position.z.ToString() + "," + hip.transform.position.x.ToString() + "," + hip.transform.position.y.ToString() + "," + hip.transform.position.z.ToString() + "," + leftLeg.transform.position.x.ToString() + "," + leftLeg.transform.position.y.ToString() + "," + leftLeg.transform.position.z.ToString() + "," + rightLeg.transform.position.x.ToString() + "," + rightLeg.transform.position.y.ToString() + "," + leftShoulder.transform.position.z.ToString());

    }

    //public void WriteToDoc()
    //{
    //    if (m_FirstOpen = true)
    //    {
    //        tw = new StreamWriter(m_fileName, false);
    //        tw.WriteLine("Head x, Head y, Head z, Spine x, Spine y, Spine z, Left Shoulder x, Left Shoulder y, Left Shoulder z, Right Shoulder x, Right Shoulder y, Right Shoulder z, Hips x, Hips y, Hips z, Left Leg x, Right Leg x, Left Leg y, Right Leg y, Left Leg z, Right Leg z");
    //        tw.Close();
    //        m_FirstOpen = false;
    //    }

    //    tw = new StreamWriter(m_fileName, true);
    //    tw.WriteLine(head.transform.position.x.ToString() + "," + head.transform.position.y.ToString() + "," + head.transform.position.z.ToString() + "," + spine.transform.position.x.ToString() + "," + spine.transform.position.y.ToString() + "," + spine.transform.position.z.ToString() + "," + rightLeg.transform.position.x.ToString() + "," + leftShoulder.transform.position.y.ToString() + "," + leftShoulder.transform.position.z.ToString() + "," + rightShoulder.transform.position.x.ToString() + "," + rightShoulder.transform.position.y.ToString() + "," + rightShoulder.transform.position.z.ToString() + "," + hip.transform.position.x.ToString() + "," + hip.transform.position.y.ToString() + "," + hip.transform.position.z.ToString() + "," + leftLeg.transform.position.x.ToString() + "," + leftLeg.transform.position.y.ToString() + "," + leftLeg.transform.position.z.ToString() + "," + rightLeg.transform.position.x.ToString() + "," + rightLeg.transform.position.y.ToString() + "," + leftShoulder.transform.position.z.ToString());
    //}
}
