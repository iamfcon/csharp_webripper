﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace WebRipGUI
{
    class HTTPConnect
    {

        // This will have the methods to check if a valid URL (that is, if a URL
        // begins with http:// or https://
        // RegEx may be necessary, although could use a string.equals with a substring slice

        public static Boolean isValidURL(String URLInput)
        {
            String prefix = URLInput.Substring(0, 6);
            //MessageBox.Show("Prefix = " + prefix, "isValidURL");

            if (prefix.ToLower().Equals("http:/") || prefix.ToLower().Equals("https:"))
            {
                return true;

            }
            else
            {
                return false;
            }
        }
        public static String GetHTML(String URL)
        {
            HttpWebRequest request = (HttpWebRequest)HttpWebRequest.Create(URL);

            WebResponse response = request.GetResponse();

            Stream stream = response.GetResponseStream();

            StreamReader sReader = new StreamReader(stream);

            string htmlText = sReader.ReadToEnd();

            return htmlText;

            
        }

        public static void FindPledges(String htmlText)
        {

            //Once a successful HTML String is found, we need to find each of these:
            //<div class="pledge__info">....</div>
            //The Pledge__info class is what makes each Pledge tile



        }
    }
}
