using System.Collections.Generic;

namespace Sedc.FaceApi.Models
{
    public class Hair
    {
        public float Bald { get; set; }
        public bool Invisible { get; set; }
        public List<HairColor> HairColor { get; set; } = new List<HairColor>();
    }

}
