using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Test1
{
    public class Manager
    {
        private static List<Message> messages = new List<Message>();
        private static List<User> users = new List<User>();
        private static List<SocialNet> socialnets = new List<SocialNet>();

        public static int Get_mes_for_user(int id)
        {
            int amount = 0;
            foreach (Message ms in messages)
            {
                if (ms.UserId == id)
                {
                    amount++;
                }
            }
            return amount;
        }

        public static Dictionary<string, int> Most_activ()
        {
            Dictionary<string, int> Nets_most_activ= new Dictionary<string, int>();
            foreach(SocialNet net in socialnets)
            {
                List<int> User_mes_am = new List<int>();
                foreach (User usr in users)
                {
                    User_mes_am.Add(Get_mes_for_user(usr.ID));
                }
                Nets_most_activ.Add(net.Name, User_mes_am.Max());
            }
            return Nets_most_activ;
        }
    }
}
