using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace CommInfo.Models
{
    public class MessagesDbInitilizer : DropCreateDatabaseAlways<MessagesContext>
    {
        Forum forum = new Forum();
        protected override void Seed(MessagesContext context)
        {
            DateTime seedDate = new DateTime(2016, 01, 01);
            Forum frm001 = new Forum { ForumID = 01, ForumName = "Seed" };
            Thread trd001 = new Thread { ThreadID = 01, ThreadTitle = "Test Topics" };
            Message msg01 = new Message { MessageID = 001, Date = seedDate, From = "John", Subject = "Did you see the game?" };
            Message msg02 = new Message { MessageID = 002, Date = seedDate, From = "David", Subject = "Meeting at Aiea Library this Friday" };
            Message msg03 = new Message { MessageID = 003, Date = seedDate, From = "Carrie", Subject = "Bookclub meeting this week?" };
            trd001.Messages.Add(msg01);
            trd001.Messages.Add(msg02);
            trd001.Messages.Add(msg03);
            frm001.Threads.Add(trd001);
            context.Fora.Add(frm001);
            //context.Threads.Add(trd001);
            //forum.Threads.Add(trd001);

            base.Seed(context);  // default
        }
    }
}