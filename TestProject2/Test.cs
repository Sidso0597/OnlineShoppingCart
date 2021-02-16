using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.IO;
using System.Linq;
using System.Net;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace TestProject2
{
    class Test
    {
       public void Test1()
        {
            //    HttpWebRequest request = (HttpWebRequest)
            //WebRequest.Create("https://github.com/GoogleCloudPlatform/kubernetes-engine-samples/blob/master/hello-app/manifests/helloweb-deployment.yaml");

            //    // execute the request
            //    HttpWebResponse response = (HttpWebResponse)
            //        request.GetResponse();
            //    // we will read data via the response stream
            //    Stream resStream = response.GetResponseStream();
            //    string tempString = null;
            //    int count = 0;
            //    StringBuilder sb = new StringBuilder();
            //    do
            //    {
            //        byte buf[];
            //        // fill the buffer with data
            //        count = resStream.Read(buf, 0, buf.Length);

            //        // make sure we read some data
            //        if (count != 0)
            //        {
            //            // translate from bytes to ASCII text
            //            tempString = Encoding.ASCII.GetString(buf, 0, count);

            //            // continue building the string
            //            sb.Append(tempString);
            //        }
            //    }
            //    while (count > 0); // any more data to read?

            //    // print out page source
            //    Console.WriteLine(sb.ToString());

            WebClient client = new WebClient();
            Stream stream = client.OpenRead("https://github.com/GoogleCloudPlatform/kubernetes-engine-samples/blob/master/hello-app/manifests/helloweb-deployment.yaml");
            StreamReader reader = new StreamReader(stream);
            String content = reader.ReadToEnd();
            content = Regex.Replace(content, "<.*?>", string.Empty);
            content = content.Trim();
            //content = Regex.Replace(content, "\t", string.Empty);

            var url = "https://github.com/GoogleCloudPlatform/kubernetes-engine-samples/blob/master/hello-app/manifests/helloweb-deployment.yaml";
            var web = new HtmlWeb();
            var doc = web.Load(url);
           /*string text = doc.DocumentNode.InnerText;
            int xy = text.IndexOf("#");
            string pehla = text.Substring(0, xy);
            text = text.Replace(pehla, string.Empty);*/



            string testkrado = "A  B";
            //HttpCookie my = new HttpCookie("Sensitive cookie");
            //my.HttpOnly = false;
            var p = new Program();
            var hashProvider2 = (HashAlgorithm)CryptoConfig.CreateFromName("MD5");
            string path = "C:\\Users\\devNXT\\source\\repos\\Remediationtest\\Remediationtest\\test.txt";
            string var = File.ReadAllText(path);
            //var kom = File.ReadAllLines(path);
            //Console.WriteLine(index);
            string naya = p.CheckHttp(var);
            File.WriteAllText(path, naya);
            string path1 = "C:\\Users\\devNXT\\source\\repos\\Remediationtest\\Remediationtest\\test1.txt";
            string var1 = File.ReadAllText(path1);
            //var kom1 = File.ReadAllLines(path1);
            //Console.WriteLine(index);
            string naya1 = p.cwe327(var1);
            File.WriteAllText(path1, naya1);
            var pomo = ImmutableArray<int>.Empty.Add(1);
            char ch = 'a';
            string emp = "";
            switch (ch)
            {
                case 'a':
                    return;
                case 'b':
                case 'c':
                    return;
                case 'd':
                    return;
                case 'e':
                    return;
                case 'f':
                case 'g':
                case 'h':
                    return;
                case 'i':
                default:
                    return;
            }
            try
            {

            }
            finally
            {
                /* clean up */
                throw new InvalidOperationException();
            }
            try
            {

            }
            finally
            {
                /* clean up */
                //throw new InvalidOperationException();
            }

        }
        public void WriteMatrix(int[][] matrix)
        {
            return;
        }
        public string CheckHttp(string var)
        {
            int flag = 0;
            string[] str = var.Split(';');
            int index = var.IndexOf("HttpCookie");
            index += 11;
            int index1 = var.IndexOf("=", index);
            string subbed = "";
            if (var[index1 - 1] == ' ')
            {
                index1--;
            }
            var len = index1 - index;
            subbed = var.Substring(index, len);
            string httponly = subbed + ".HttpOnly";
            //Console.WriteLine(httponly);
            foreach (string str2 in str)
            {
                if (str2.Contains(httponly))
                {
                    if (str2.Contains("false"))
                    {
                        //Console.WriteLine(str2);
                        string corrected = httponly + "= true;";
                        var = var.Replace(str2 + ";", "\n\t" + corrected + "// Fixed:this sensitive cookie was created with the httponly flag set to false and so it can be stolen easily in case of XSS vulnerability thus it has been set to true to improve the security");
                    }
                    else if (str2.Contains("true"))
                    {
                        var = var.Replace(str2 + ";", str2 + ";// Compliant: the sensitive cookie is protected against theft thanks to the HttpOnly property set to true (HttpOnly = true)");
                    }
                }
                else
                {
                    flag++;
                }
                //Console.WriteLine(str2);
            }
            //Console.WriteLine(str.Length);
            //Console.WriteLine(var);

            int i = 0;
            if (flag == str.Length)
            {
                int index2 = var.IndexOf(";", index);
                //var.Insert(index2+1,httponly + "= true;");
                string var2 = var.Substring(0, index2 + 1) + "\n\t" + httponly + "= true; // Fixed:The object of HttpCookie was not defined in the program, Thus added the value to improve security" + var.Substring(index2 + 1);
                //File.WriteAllText(path, var2);
                return var2;
            }
            else
            {
                //File.WriteAllText(path, var);
                return var;
            }
        }
        public string cwe327(string var)
        {
            int flag = 0;
            String[] str = var.Split(';');
            foreach (string str2 in str)
            {
                if (str2.Contains("MD5CryptoServiceProvider()"))
                {
                    int index = str2.IndexOf("var");
                    if (index == -1)
                    {
                        break;
                    }
                    index += 4;
                    int index1 = str2.IndexOf("=", index);
                    if (str2[index1 - 1] == ' ')
                    {
                        index1--;
                    }
                    var len = index1 - index;
                    string subbed = str2.Substring(index, len);
                    var = var.Replace(str2 + ";", str2 + ";//Noncompliant \n\t/* Below are the compliant solutions that can be used- \n\t var " + subbed + "= new SHA256Managed();\n\t var " + subbed + "= (HashAlgorithm)CryptoConfig.CreateFromName(\"SHA256Managed\");\n\t var " + subbed + "= HashAlgorithm.Create(\"SHA256Managed\");*/");
                }
                if (str2.Contains("(HashAlgorithm)CryptoConfig.CreateFromName(\"MD5\")"))
                {
                    int index = str2.IndexOf("var");
                    if (index == -1)
                    {
                        break;
                    }
                    index += 4;
                    int index1 = str2.IndexOf("=", index);
                    if (str2[index1 - 1] == ' ')
                    {
                        index1--;
                    }
                    var len = index1 - index;
                    string subbed = str2.Substring(index, len);
                    var = var.Replace(str2 + ";", str2 + ";//Noncompliant \n\t/* Below are the compliant solutions that can be used- \n\t var " + subbed + "= new SHA256Managed();\n\t var " + subbed + "= (HashAlgorithm)CryptoConfig.CreateFromName(\"SHA256Managed\");\n\t var " + subbed + "= HashAlgorithm.Create(\"SHA256Managed\");*/");

                }
                if (str2.Contains("SHA1Managed()"))
                {

                    int index = str2.IndexOf("var");
                    if (index == -1)
                    {
                        break;
                    }
                    index += 4;
                    int index1 = str2.IndexOf("=", index);
                    if (str2[index1 - 1] == ' ')
                    {
                        index1--;
                    }
                    var len = index1 - index;
                    string subbed = str2.Substring(index, len);
                    var = var.Replace(str2 + ";", str2 + ";//Noncompliant \n\t/* Below are the compliant solutions that can be used- \n\t var " + subbed + "= new SHA256Managed();\n\t var " + subbed + "= (HashAlgorithm)CryptoConfig.CreateFromName(\"SHA256Managed\");\n\t var " + subbed + "= HashAlgorithm.Create(\"SHA256Managed\");*/");
                }
                if (str2.Contains("HashAlgorithm.Create(\"SHA1\")"))
                {

                    int index = str2.IndexOf("var");
                    if (index == -1)
                    {
                        break;
                    }
                    index += 4;
                    int index1 = str2.IndexOf("=", index);
                    if (str2[index1 - 1] == ' ')
                    {
                        index1--;
                    }
                    var len = index1 - index;
                    string subbed = str2.Substring(index, len);
                    var = var.Replace(str2 + ";", str2 + ";//Noncompliant \n\t/* Below are the compliant solutions that can be used- \n\t var " + subbed + "= new SHA256Managed();\n\t var " + subbed + "= (HashAlgorithm)CryptoConfig.CreateFromName(\"SHA256Managed\");\n\t var " + subbed + "= HashAlgorithm.Create(\"SHA256Managed\");*/");

                }
                else
                {
                    flag++;
                }

            }
            return var;
        }


    }
}
