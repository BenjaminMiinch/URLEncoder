using System;


namespace URLEncoder
{
    class Program
    {
        static void Main()
        {
            string project_name = " ";

            string activity_name = " ";

            try
            {
                Console.WriteLine("Enter the project name");

                project_name = Console.ReadLine();
               /* do
                {
                    input = Console.ReadLine();
                    if (IsValid(input)) return input;
                    Console.Write("The input contains invalid characters. Enter again: ");
                } while (true);
                */

                project_name = project_name.Replace("<", "%3C");
                project_name = project_name.Replace(">", "%3E");
                project_name = project_name.Replace("#", "%23");
                project_name = project_name.Replace(" ", "%20");
                project_name = project_name.Replace("%", "%25");
                project_name = project_name.Replace("\"", "%22");
                //; / ? : @ & = + $ ,
                project_name = project_name.Replace(";", "%3B");
                project_name = project_name.Replace("/", "%2F");
                project_name = project_name.Replace("?", "%3F");
                project_name = project_name.Replace(":", "%3A");
                project_name = project_name.Replace("@", "%40");
                project_name = project_name.Replace("&", "%26");
                project_name = project_name.Replace("=", "%3D");
                project_name = project_name.Replace("+", "%2B");
                project_name = project_name.Replace("$", "%24");
                project_name = project_name.Replace(",", "%2C");
                // { } | \ ^ [ ] `
                project_name = project_name.Replace("}", "%7D");
                project_name = project_name.Replace("{", "%7B");
                project_name = project_name.Replace("|", "%7C");
                project_name = project_name.Replace("\\", "%5C");
                project_name = project_name.Replace("^", "%5E");
                project_name = project_name.Replace("[", "%5B");
                project_name = project_name.Replace("]", "%5D");
                project_name = project_name.Replace("`", "%60");



                Console.WriteLine("Enter name of the activity");

                //URLs cannot contain spaces. URL encoding normally replaces a space with a plus (+) sign or with %20.

                activity_name = Console.ReadLine();

                activity_name = activity_name.Replace("<", "%3C");
                activity_name = activity_name.Replace(">", "%3E");
                activity_name = activity_name.Replace("#", "%23");
                activity_name = activity_name.Replace(" ", "%20");
                activity_name = activity_name.Replace("%", "%25");
                activity_name = activity_name.Replace("\"", "%22");
                //; / ? : @ & = + $ ,
                activity_name = activity_name.Replace(";", "%3B");
                activity_name = activity_name.Replace("/", "%2F");
                activity_name = activity_name.Replace("?", "%3F");
                activity_name = activity_name.Replace(":", "%3A");
                activity_name = activity_name.Replace("@", "%40");
                activity_name = activity_name.Replace("&", "%26");
                activity_name = activity_name.Replace("=", "%3D");
                activity_name = activity_name.Replace("+", "%2B");
                activity_name = activity_name.Replace("$", "%24");
                activity_name = activity_name.Replace(",", "%2C");
                // { } | \ ^ [ ] `
                activity_name = activity_name.Replace("}", "%7D");
                activity_name = activity_name.Replace("{", "%7B");
                activity_name = activity_name.Replace("|", "%7C");
                activity_name = activity_name.Replace("\\", "%5C");
                activity_name = activity_name.Replace("^", "%5E");
                activity_name = activity_name.Replace("[", "%5B");
                activity_name = activity_name.Replace("]", "%5D");
                activity_name = activity_name.Replace("`", "%60");


                string url = "https://companyserver.com/content/" + project_name + "/files/" + activity_name + "/" + activity_name + "Report.pdf";

                Console.WriteLine("\n");

                Console.WriteLine(url);

            }

            catch
            {
                Console.WriteLine("Give project a name: ");
            }

            Console.WriteLine("\n");
            {
                Console.WriteLine("Do you want another URL say y/n");

                String restart = Console.ReadLine();

                if (restart == "y")
                    Main();

            }

        }
    }

}


