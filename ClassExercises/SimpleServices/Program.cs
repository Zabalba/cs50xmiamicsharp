using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleServices
{
    public interface SimpleService
    {
        void AddEvent(string eventName, DateTime eventDate);
        void RemoveEvent(string eventID);
        void ModifyEvent(string eventID);
    }
    public class MobileSimpleService : SimpleService
    {
        public void AddEvent(string eventName, DateTime eventDate)
        {
            throw new NotImplementedException();
        }

        public void ModifyEvent(string eventID)
        {
            throw new NotImplementedException();
        }

        public void RemoveEvent(string eventID)
        {
            throw new NotImplementedException();
        }
    }
    public class DesktopSimpleService : SimpleService
    {
        public void AddEvent(string eventName, DateTime eventDate)
        {
            throw new NotImplementedException();
        }

        public void ModifyEvent(string eventID)
        {
            throw new NotImplementedException();
        }

        public void RemoveEvent(string eventID)
        {
            throw new NotImplementedException();
        }
    }
}
