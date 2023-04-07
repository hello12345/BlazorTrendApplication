using System.Reactive.Subjects;

namespace BlazorTrendApplication.Web.Services
{
    public class GlobalService
    {
        public BehaviorSubject<string> userName = new BehaviorSubject<string>("");
        public BehaviorSubject<string> userId = new BehaviorSubject<string>("");
    }
}
