using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ActiveUp.Net.Imap4
{
  public static class ExceptionsExtensions
  {

    public static string HideSensitiveData(this string message)
    {
      if (!string.IsNullOrEmpty(message))
      {
        var loginToken = "login";
        var idx = message.IndexOf(loginToken, StringComparison.InvariantCultureIgnoreCase);
        if (idx > 0)
        {
          message = message.Substring(0, idx + loginToken.Length);
          message += " *** SENSITIVE DATA *** ";
        }
      }
      return message;
    }
  }
}
