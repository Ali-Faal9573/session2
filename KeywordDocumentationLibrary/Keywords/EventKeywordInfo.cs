using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KeywordDocumentationLibrary.Keywords
{
    public class EventKeywordInfo : KeywordInfoBase
    {
        public EventKeywordInfo() :base("An event is a notification sent by an object to signal the occurrence of an action. Events in .NET follow the observer design pattern.\r\n\r\nThe class who raises events is called Publisher, and the class who receives the notification is called Subscriber. There can be multiple subscribers of a single event. Typically, a publisher raises an event when some action occurred. The subscribers, who are interested in getting a notification when an action occurred, should register with an event and handle it.")
        {
            Keyword = "event";
        }
    }
}
