using ObserverPattern.Base;

namespace ObserverPattern.Notifiers
{
    public class FaceBookNotifier : Observer
    {
        public FaceBookNotifier(Subject subject)
        {
            Subject = subject;
            Subject.AttachObserver(this);
        }

        public override void Notify(Subject subject, object arg)
        {
            if(subject is VideoData videoData)
            {
                Console.WriteLine("Notify all subscribers via FACEBOOK with new data" +
                                      "\n\tName: {0}" +
                                      "\n\tDescription: {1}" +
                                      "\n\tFile name: {2}", videoData.GetTitle(), videoData.GetDescription(), videoData.GetFileName());
            }
        }
    }
}
