using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using Newtonsoft.Json;
using ModelsFromApi;

namespace Sedc.ImageEditor
{
    public class Program
    {
        static void Main(string[] args)
        {
            var faceData = JsonConvert.DeserializeObject<List<FaceDetection>>(response).First();

            var from = faceData.faceLandmarks.eyeLeftOuter;
            var to = faceData.faceLandmarks.eyeRightOuter;

            var mrBeanImage = Image.FromFile("mr-bean.jpg");
            var image2 = Image.FromFile("glasses.png");
            var width = mrBeanImage.Width;
            var height = mrBeanImage.Height;

            Graphics graphicsMrBean = Graphics.FromImage(mrBeanImage);

            //graphicsMrBean.DrawLine(Pens.Black, new Point(0, 0),
            //    new Point(width, height));

            var glassesWidth = to.x - from.x;
            var glassesHeight = faceData.faceLandmarks.eyeLeftBottom.y - faceData.faceLandmarks.eyeLeftTop.y;

            glassesWidth *= 1.2f;
            glassesHeight *= 1.2f;
            var glassesWidthInPixels = Convert.ToInt32(Math.Floor(glassesWidth));
            var glassesHeightInPixels = Convert.ToInt32(Math.Floor(glassesHeight));


            graphicsMrBean.DrawImage(image2, (int)from.x, (int)from.y
                , glassesWidthInPixels, glassesHeightInPixels);

            graphicsMrBean.Save();
            mrBeanImage.Save("new.png");
            Console.ReadLine();
        }





        const string response = @"[
  {
    ""FaceId"": ""f6fd26dc-a9c9-459e-8a7c-9ed90ba8c436"",
    ""FaceRectangle"": {
      ""top"": 79,
      ""left"": 227,
      ""width"": 149,
      ""height"": 149
    },
    ""faceAttributes"": {
      ""hair"": {
        ""bald"": 0.01,
        ""invisible"": false,
        ""hairColor"": [
          {
            ""color"": ""black"",
            ""confidence"": 1.0
          },
          {
            ""color"": ""brown"",
            ""confidence"": 0.99
          },
          {
            ""color"": ""other"",
            ""confidence"": 0.12
          },
          {
            ""color"": ""gray"",
            ""confidence"": 0.11
          },
          {
            ""color"": ""red"",
            ""confidence"": 0.08
          },
          {
            ""color"": ""blond"",
            ""confidence"": 0.02
          }
        ]
      },
      ""smile"": 0.0,
      ""headPose"": {
        ""pitch"": 0.0,
        ""roll"": 0.4,
        ""yaw"": -1.4
      },
      ""gender"": ""male"",
      ""age"": 42.4,
      ""facialHair"": {
        ""moustache"": 0.3,
        ""beard"": 0.1,
        ""sideburns"": 0.2
      },
      ""glasses"": ""NoGlasses"",
      ""makeup"": {
        ""eyeMakeup"": false,
        ""lipMakeup"": false
      },
      ""emotion"": {
        ""anger"": 0.007,
        ""contempt"": 0.0,
        ""disgust"": 0.0,
        ""fear"": 0.007,
        ""happiness"": 0.0,
        ""neutral"": 0.016,
        ""sadness"": 0.0,
        ""surprise"": 0.969
      },
      ""occlusion"": {
        ""foreheadOccluded"": false,
        ""eyeOccluded"": false,
        ""mouthOccluded"": false
      },
      ""accessories"": [],
      ""blur"": {
        ""blurLevel"": ""low"",
        ""value"": 0.0
      },
      ""exposure"": {
        ""exposureLevel"": ""goodExposure"",
        ""value"": 0.6
      },
      ""noise"": {
        ""noiseLevel"": ""high"",
        ""value"": 0.78
      }
    },
    ""faceLandmarks"": {
      ""pupilLeft"": {
        ""x"": 267.0,
        ""y"": 118.8
      },
      ""pupilRight"": {
        ""x"": 337.3,
        ""y"": 118.9
      },
      ""noseTip"": {
        ""x"": 301.3,
        ""y"": 154.1
      },
      ""mouthLeft"": {
        ""x"": 275.0,
        ""y"": 190.6
      },
      ""mouthRight"": {
        ""x"": 323.8,
        ""y"": 189.7
      },
      ""eyebrowLeftOuter"": {
        ""x"": 243.5,
        ""y"": 104.7
      },
      ""eyebrowLeftInner"": {
        ""x"": 285.1,
        ""y"": 105.4
      },
      ""eyeLeftOuter"": {
        ""x"": 255.6,
        ""y"": 119.8
      },
      ""eyeLeftTop"": {
        ""x"": 265.7,
        ""y"": 112.4
      },
      ""eyeLeftBottom"": {
        ""x"": 266.1,
        ""y"": 125.3
      },
      ""eyeLeftInner"": {
        ""x"": 276.0,
        ""y"": 120.1
      },
      ""eyebrowRightInner"": {
        ""x"": 311.8,
        ""y"": 104.5
      },
      ""eyebrowRightOuter"": {
        ""x"": 358.2,
        ""y"": 106.6
      },
      ""eyeRightInner"": {
        ""x"": 324.9,
        ""y"": 121.0
      },
      ""eyeRightTop"": {
        ""x"": 335.4,
        ""y"": 112.9
      },
      ""eyeRightBottom"": {
        ""x"": 336.1,
        ""y"": 125.3
      },
      ""eyeRightOuter"": {
        ""x"": 347.0,
        ""y"": 120.3
      },
      ""noseRootLeft"": {
        ""x"": 292.3,
        ""y"": 122.6
      },
      ""noseRootRight"": {
        ""x"": 308.3,
        ""y"": 122.5
      },
      ""noseLeftAlarTop"": {
        ""x"": 288.2,
        ""y"": 144.5
      },
      ""noseRightAlarTop"": {
        ""x"": 313.9,
        ""y"": 144.1
      },
      ""noseLeftAlarOutTip"": {
        ""x"": 279.4,
        ""y"": 158.0
      },
      ""noseRightAlarOutTip"": {
        ""x"": 322.5,
        ""y"": 157.0
      },
      ""upperLipTop"": {
        ""x"": 299.4,
        ""y"": 180.6
      },
      ""upperLipBottom"": {
        ""x"": 299.4,
        ""y"": 186.9
      },
      ""underLipTop"": {
        ""x"": 299.8,
        ""y"": 192.7
      },
      ""underLipBottom"": {
        ""x"": 299.4,
        ""y"": 201.0
      }
    }
  }
]";
    }
}
