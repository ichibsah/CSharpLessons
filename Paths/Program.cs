using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Paths
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = "C:\\stagelist.txt";

            string extension = Path.GetExtension(path);
            string filename = Path.GetFileName(path);
            string filenameNoExtension = Path.GetFileNameWithoutExtension(path);
            string root = Path.GetPathRoot(path);

            Console.WriteLine("{0}\n{1}\n{2}\n{3}",
                extension,
                filename,
                filenameNoExtension,
                root);

            string[] pages = new string[]
	{
	    "cat.aspx",
	    "really-long-page.aspx",
	    "test.aspx",
	    "invalid-page",
	    "something-else.aspx",
	    "Content/Rat.aspx",
	    "http://dotnetperls.com/Cat/Mouse.aspx",
	    "C:\\Windows\\File.txt",
	    "C:\\Word-2007.docx"
	};
            foreach (string page in pages)
            {
                string name = Path.GetFileName(page);
                string nameKey = Path.GetFileNameWithoutExtension(page);
                string directory = Path.GetDirectoryName(page);
                //
                // Display the Path strings we extracted.
                //
                Console.WriteLine("{0}, {1}, {2}, {3}",
                page, name, nameKey, directory);
            }
        }
    }
}
