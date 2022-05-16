// See https://aka.ms/new-console-template for more information
var lines = new List<string>();
using (StreamReader sr = new StreamReader("veci.txt"))
{
    string line;
 
    while ((line = sr.ReadLine()) != null)
    {
        lines.Add(line);

       string[] parts = line.Split('#');
        if (parts[0] == "1")
        {
            double output = 0;
            string[] bobr = parts[1].Split("-");
            List<int> vecivtom = new List<int>(bobr.Length);
            for (int i = 0; i < bobr.Length; i++)
            {
                vecivtom.Add(bobr[i].Length);
            }
            for (int i = 0; i < vecivtom.Count; i++)
            {

                output = output + vecivtom[i];
            }
            output = output / vecivtom.Count();
            Console.WriteLine(output);
        }
        else if(parts[0] == "3")
        {
            double output = 1;
            string[] bobr1 = parts[1].Split("$");
            List<int> output2 = new List<int>();
       
            for (int i = 0; i < bobr1.Length; i++)
            {
                output2.Add(Convert.ToInt32(bobr1[i]));
            }
            
            for (int i = 0; i < output2.Count; i++)
            {

                output = output * output2[i];
            }
            
            Console.WriteLine(output);
        }
        else if (parts[0] == "2")
        {
            double output = 0;
            string[] bobr1 = parts[1].Split("/");
           
            List<int> output2 = new List<int>();

            for (int i = 1; i < bobr1.Length; i++)
            {
                output2.Add(Convert.ToInt32(bobr1[i]));
            }

            for (int i = 0; i < output2.Count; i++)
            {

                output = output + output2[i];
            }

            Console.WriteLine(output);
        }

    }

}