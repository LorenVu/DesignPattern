using ObserverPattern;
using ObserverPattern.Notifiers;

VideoData videoData = new VideoData();

_ = new EmailNotifier(videoData);
_ = new FaceBookNotifier(videoData);
var utubeNotify = new YoutubeNotifier(videoData);

videoData.SetTitle("TEST 123-456");
videoData.DetachObserver(utubeNotify);

Console.WriteLine("----------------- \n");

videoData.SetTitle("TEST 1000");

