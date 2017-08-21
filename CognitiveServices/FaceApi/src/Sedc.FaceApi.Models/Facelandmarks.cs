namespace Sedc.FaceApi.Models
{
    public class FaceLandmarks
    {
        public PixelCoordinate PupilLeft { get; set; }
        public PixelCoordinate PupilRight { get; set; }
        public PixelCoordinate NoseTip { get; set; }
        public PixelCoordinate MouthLeft { get; set; }
        public PixelCoordinate MouthRight { get; set; }
        public PixelCoordinate EyebrowLeftOuter { get; set; }
        public PixelCoordinate EyebrowLeftInner { get; set; }
        public PixelCoordinate EyeLeftOuter { get; set; }
        public PixelCoordinate EyeLeftTop { get; set; }
        public PixelCoordinate EyeLeftBottom { get; set; }
        public PixelCoordinate EyeLeftInner { get; set; }
        public PixelCoordinate EyebrowRightInner { get; set; }
        public PixelCoordinate EyebrowRightOuter { get; set; }
        public PixelCoordinate EyeRightInner { get; set; }
        public PixelCoordinate EyeRightTop { get; set; }
        public PixelCoordinate EyeRightBottom { get; set; }
        public PixelCoordinate EyeRightOuter { get; set; }
        public PixelCoordinate NoseRootLeft { get; set; }
        public PixelCoordinate NoseRootRight { get; set; }
        public PixelCoordinate NoseLeftAlarTop { get; set; }
        public PixelCoordinate NoseRightAlarTop { get; set; }
        public PixelCoordinate NoseLeftAlarOutTip { get; set; }
        public PixelCoordinate NoseRightAlarOutTip { get; set; }
        public PixelCoordinate UpperLipTop { get; set; }
        public PixelCoordinate UpperLipBottom { get; set; }
        public PixelCoordinate UnderLipTop { get; set; }
        public PixelCoordinate UnderLipBottom { get; set; }
    }

}
