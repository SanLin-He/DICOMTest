using UnityEngine;
using System.Collections;
using Dicom.Imaging;
using Dicom.IO;
using Dicom;

public class DICOMTest1 : MonoBehaviour {

    IImage iImage;
	// Use this for initialization
	void Start () {

       
        var image = new DicomImage(Application.streamingAssetsPath + @"\77005069.dcm");
        
         var texture2d =  image.RenderImage().As<Texture2D>();

        byte[] bytes = texture2d.EncodeToPNG();
        string filename = Application.dataPath + "/Screenshot.png";
        System.IO.File.WriteAllBytes(filename, bytes);
        Debug.Log(string.Format("save a screenshot: {0}", filename));
    }
	
	// Update is called once per frame
	void Update () {
	
	}
}
