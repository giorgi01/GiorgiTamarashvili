using System;
using System.Text;

namespace Practical_2
{
    public static class ExceptionsManager
    {
        public static string GetLastInnerExMessage(Exception ex)
        {
            if(ex.InnerException != null)
            {
                return GetLastInnerExMessage(ex.InnerException);
            }
            else
            {
                return ex.Message;
            }
        }

        public static string GetAllInnerExMessageTogether(Exception ex)
        {
            if(ex.InnerException != null)
            {
                return ex.Message + ". " + GetAllInnerExMessageTogether(ex.InnerException);
            }
            else
            {
                return ex.Message;
            }
        }
    }
}
