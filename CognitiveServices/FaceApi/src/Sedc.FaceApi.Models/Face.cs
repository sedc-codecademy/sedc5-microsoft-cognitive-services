using System;

namespace Sedc.FaceApi.Models
{
    public class Face
    {
        public string FaceId { get; set; }
        public Facerectangle FaceRectangle { get; set; }
        public Facelandmarks FaceLandmarks { get; set; }
        public Faceattributes FaceAttributes { get; set; }
    }
}
