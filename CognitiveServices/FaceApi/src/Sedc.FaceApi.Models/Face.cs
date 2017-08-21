using System;

namespace Sedc.FaceApi.Models
{
    public class Face
    {
        public string FaceId { get; set; }
        public FaceRectangle FaceRectangle { get; set; } = new FaceRectangle();
        public FaceLandmarks FaceLandmarks { get; set; } = new FaceLandmarks();
        public FaceAttributes FaceAttributes { get; set; } = new FaceAttributes();
    }
}
