using System;
namespace newprogram.Domain
{
    public class NotDivisionCeroException:Exception
    {
        public NotDivisionCeroException (string message):base(message)
        {
            
        }
    }
}