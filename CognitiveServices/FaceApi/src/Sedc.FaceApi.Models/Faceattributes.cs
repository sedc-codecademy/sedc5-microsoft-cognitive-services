namespace Sedc.FaceApi.Models
{
    public class Faceattributes
    {
        public float Smile { get; set; }
        public Headpose HeadPose { get; set; }
        public string Gender { get; set; }
        public float Age { get; set; }
        public Facialhair FacialHair { get; set; }
        public string Glasses { get; set; }
        public Emotion Emotion { get; set; }
        public Blur Blur { get; set; }
        public Exposure Exposure { get; set; }
        public Noise Noise { get; set; }
        public Makeup Makeup { get; set; }
        public object[] Accessories { get; set; }
        public Occlusion Occlusion { get; set; }
        public Hair Hair { get; set; }
    }

}
