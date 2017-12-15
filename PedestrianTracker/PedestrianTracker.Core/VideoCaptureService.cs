using Emgu.CV;

namespace PedestrianTracker.Core
{
    public class VideoCaptureService
    {
        Capture _capture;

        public VideoCaptureService()
        {
            _capture = new Capture("test.avi");
        }

        public Image<Emgu.CV.Structure.Bgr, byte> GetNextFrame()
        {
            var frame = _capture.QueryFrame();
            return frame;
        }
    }
}
