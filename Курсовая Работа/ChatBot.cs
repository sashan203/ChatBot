using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Курсовая_Работа
{
    public class ChatBot
    {
        string q, path;
        List<string> sempls = new List<string>();
        public bool talk = true;

        public event Action<string> GetStr;
        public ChatBot(string pat)
        {
            path = pat;
            try
            {
                sempls.AddRange(File.ReadAllLines(@path, System.Text.Encoding.GetEncoding(1251)));
            }
            catch
            {
            
            }
            GetStr += ChatBot_GetStr;
        }
        private string Answer(string qw)
        {
            var f = new Form1();
            string tr = ")(:^^=!&?,.*";
            string ans =string.Empty;
            qw = qw.ToLower();
            qw = sort(qw, tr.ToCharArray());
            for (int i = 0; i < sempls.Count; i += 2)
            {
                if (sempls[i].Contains(qw))
                {
                    ans = sempls[i + 1];
                    break;
                }
            }
            if ((qw == "добавить пароль") || (qw == "добавить логин"))
            {
                GetStr("AddPass");
            }
            if ((qw == "найти пароль") || (qw == "найти логин"))
            {
                GetStr("FindPass");
            }
            GetStr(qw);
            return ans;
        }
        public void Teach(string a, string userAnswer)
        {
            sempls.Add(a);
            sempls.Add(userAnswer);
            File.WriteAllLines(path, sempls.ToArray(), System.Text.Encoding.GetEncoding(1251));
            talk = true;
        }
        public void Ans(string qw)
        {
            var f = new Form1();
            if (talk)
            {
                q = qw;
                string ans = Answer(qw);
                if(ans == String.Empty & q != "")
                {
                    talk = false;
                    GetStr("Trening");
                }
                else
                {
                    GetStr(ans);
                }

            }
                
        }
        string sort(string str, char[] chars)
        {
            string strA = str;
            for (int i = 0; i < chars.Length; i++)
            {
                strA = strA.Replace(char.ToString(chars[i]), "");
            }
            return strA;
        }
        void ChatBot_GetStr(string obj)
        {

        }
    }
}
