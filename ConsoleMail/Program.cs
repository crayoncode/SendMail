using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleMail
{
    class Program
    {
        static void Main(string[] args)
        {
                       
            EmailModel eModel = new EmailModel()
            {
                From = "492118114@qq.com",
                Body = "<div style=\"background:red\"><h2>这是一个测试实例!  " + DateTime.Now + "</h2></div>",
                DisplayName = "Jackie",
                Host = "smtp.qq.com",
                Subject = "测试",
                To = "809968268@qq.com",
                UserPwd = "",//发送邮箱的密码
                UserID = "492118114@qq.com"
            };
            //发送邮件
            new MailTool().Send(eModel);
        }
    }
}
