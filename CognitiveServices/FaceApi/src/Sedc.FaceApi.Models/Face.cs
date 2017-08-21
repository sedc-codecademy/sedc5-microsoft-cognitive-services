using System;

namespace Sedc.FaceApi.Models
{
    public class Face
    {
        public string FaceId { get; set; }
        public FaceRectangle FaceRectangle { get; set; }
        public Facelandmarks FaceLandmarks { get; set; }
        public FaceAttributes FaceAttributes { get; set; }
    }
}
