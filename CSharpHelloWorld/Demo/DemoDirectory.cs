using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpHelloWorld.Demo
{
    class DemoDirectory
    {
        public void SampleDirectory()
        {
            Directory.CreateDirectory(@"D:\PROECT-ASP\PROJECT-PUBLISH-VS15\SampleDirectory");

            //var files =  Directory.GetFiles(@"D:\PROECT-ASP\PROJECT-PUBLISH-VS15","*.sln", SearchOption.AllDirectories);
            // foreach (var file in files)
            //     Console.WriteLine(file);


            var directories = Directory.GetDirectories(@"D:\PROECT-ASP\PROJECT-PUBLISH-VS15", "*.*",
                SearchOption.AllDirectories);
            foreach (var directory in directories)
                Console.WriteLine(directory);

            //check apakah directory ada
            Directory.Exists("...");

            var directoryInfo = new DirectoryInfo("...");
            directoryInfo.GetFiles();
            directoryInfo.GetDirectories();

        }
    }
}
