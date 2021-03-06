﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactManager
{
    public abstract class MessageSendDatabase : IMessageServices
    {
        //Email validator 
       bool IsValidEmail (string source)
        {
            try
            {
                new System.Net.Mail.MailAddress(source);
                return true;
            }catch
            { };
            return false;
        }

        //retrives message from MMD
        public void Send(Message message)
        {
            if (message == null)
                return;

            SendCore(message);
        }

        public IEnumerable<Message> GetAll()
        {
            return GetAllCore();
        }

        protected abstract void SendCore(Message message);
        protected abstract IEnumerable<Message> GetAllCore();
    }
}
