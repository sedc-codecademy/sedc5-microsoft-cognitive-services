namespace Sedc.FaceApi.Models
{
    public class FaceLandmarks
    {
        public PixelCoordinate PupilLeft { get; set; } = new PixelCoordinate();
        public PixelCoordinate PupilRight { get; set; } = new PixelCoordinate();
        public PixelCoordinate NoseTip { get; set; } = new PixelCoordinate();
        public PixelCoordinate MouthLeft { get; set; } = new PixelCoordinate();
        public PixelCoordinate MouthRight { get; set; } = new PixelCoordinate();
        public PixelCoordinate EyebrowLeftOuter { get; set; } = new PixelCoordinate();
        public PixelCoordinate EyebrowLeftInner { get; set; } = new PixelCoordinate();
        public PixelCoordinate EyeLeftOuter { get; set; } = new PixelCoordinate();
        public PixelCoordinate EyeLeftTop { get; set; } = new PixelCoordinate();
        public PixelCoordinate EyeLeftBottom { get; set; } = new PixelCoordinate();
        public PixelCoordinate EyeLeftInner { get; set; } = new PixelCoordinate();
        public PixelCoordinate EyebrowRightInner { get; set; } = new PixelCoordinate();
        public PixelCoordinate EyebrowRightOuter { get; set; } = new PixelCoordinate();
        public PixelCoordinate EyeRightInner { get; set; } = new PixelCoordinate();
        public PixelCoordinate EyeRightTop { get; set; } = new PixelCoordinate();
        public PixelCoordinate EyeRightBottom { get; set; } = new PixelCoordinate();
        public PixelCoordinate EyeRightOuter { get; set; } = new PixelCoordinate();
        public PixelCoordinate NoseRootLeft { get; set; } = new PixelCoordinate();
        public PixelCoordinate NoseRootRight { get; set; } = new PixelCoordinate();
        public PixelCoordinate NoseLeftAlarTop { get; set; } = new PixelCoordinate();
        public PixelCoordinate NoseRightAlarTop { get; set; } = new PixelCoordinate();
        public PixelCoordinate NoseLeftAlarOutTip { get; set; } = new PixelCoordinate();
        public PixelCoordinate NoseRightAlarOutTip { get; set; } = new PixelCoordinate();
        public PixelCoordinate UpperLipTop { get; set; } = new PixelCoordinate();
        public PixelCoordinate UpperLipBottom { get; set; } = new PixelCoordinate();
        public PixelCoordinate UnderLipTop { get; set; } = new PixelCoordinate();
        public PixelCoordinate UnderLipBottom { get; set; } = new PixelCoordinate();
    }

}
