using System.Collections.Generic;

namespace Sedc.FaceApi.Models
{
    public class FaceAttributes
    {
        public float Smile { get; set; }
        public HeadPose HeadPose { get; set; } = new HeadPose();
        public string Gender { get; set; }
        public float Age { get; set; }
        public FacialHair FacialHair { get; set; } = new FacialHair();
        public string Glasses { get; set; }
        public Emotion Emotion { get; set; } = new Emotion();
        public Blur Blur { get; set; } = new Blur();
        public Exposure Exposure { get; set; } = new Exposure();
        public Noise Noise { get; set; } = new Noise();
        public Makeup Makeup { get; set; } = new Makeup();
        public Occlusion Occlusion { get; set; } = new Occlusion();
        public Hair Hair { get; set; } = new Hair();
        public List<Accessory> Accessories { get; set; } = new List<Accessory>();

    }

}
