using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            bool isDebugging = false;
            bool isSyscoinInstalled = false;

            if (isDebugging) Console.WriteLine("Writing/Replacing syscoin.conf file...");
            #region Create/Replace %APPDATA%Syscoin/syscoin.conf
            try
            {
                // Create an instance of StreamReader to read from a file. 
                // The using statement also closes the StreamReader. 
                //using (StreamWriter outPut = new StreamWriter("C:\\Users\\KamronK\\AppData\\Roaming\\Syscoin\\syscoin2.conf"))
                using (StreamWriter outPut = new StreamWriter(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "Syscoin\\syscoin.conf")))
                {

                    outPut.WriteLine("rpcuser=anyusername");
                    outPut.WriteLine("rpcpassword=anypasswordyouwant");
                    outPut.WriteLine("rpcallowip=127.0.01");
                    outPut.WriteLine("rpcport=9368");
                    outPut.WriteLine("listen=1");
                    outPut.Write("server=1");
                    outPut.Close();
                    isSyscoinInstalled = true;
                }
            }
            catch (DirectoryNotFoundException ex)
            {
                // Write error.
                Process.Start("Syscoin_v0.1.5\\Syscoin-Qt.exe");
                Console.WriteLine("Please Allow the Syscoin Wallet to open\n(should be opening now, or opened by the time you see this)\n\nAllow it to download (or 'sync with' rather) the block chain\n\nThen please run this file again.");
            }
            catch (Exception e)
            {
                // Let the user know what went wrong.
                Console.WriteLine("The file could not be written: syscoin.conf :");
                Console.WriteLine(e.Message);
            }
            #endregion Create/Replace %APPDATA%Syscoin/syscoin.conf
            if (isDebugging) Console.WriteLine("Wrote/Replaced syscoin.conf file.");

            if (isSyscoinInstalled)
            {
                if (isDebugging) Console.WriteLine("Writing/Replacing settings.inc file...");
                #region Create/Replace ./sysmarket-v0.5.2-alpha/settings.inc

                try
                {
                    // Create an instance of StreamReader to read from a file. 
                    // The using statement also closes the StreamReader. 
                    using (StreamWriter outPut = new StreamWriter("sysmarket-v0.5.2-alpha\\settings.inc"))
                    {

                        outPut.WriteLine("walleturl=http://127.0.0.1");
                        outPut.WriteLine("rpcport=9368");
                        outPut.WriteLine("rpcuser=anyusername");
                        outPut.Write("rpcpassword=anypasswordyouwant");
                        outPut.Close();
                    }
                }
                catch (Exception e)
                {
                    // Let the user know what went wrong.
                    Console.WriteLine("The file could not be written: settings.inc :");
                    Console.WriteLine(e.Message);
                }


                #endregion Create/Replace ./sysmarket-v0.5.2-alpha/settings.inc
                if (isDebugging) Console.WriteLine("Wrote/Replaced settings.inc file.");

                if (isDebugging) Console.WriteLine("Writing The Marketplace.bat file...");
                #region Create/Replace ./sysmarket-v0.5.2-alpha/settings.inc

                try
                {
                    // Create an instance of StreamReader to read from a file. 
                    // The using statement also closes the StreamReader. 
                    using (StreamWriter outPut = new StreamWriter("The Marketplace.bat"))
                    {

                        outPut.WriteLine("echo 'Calling the marketplace exe file'");
                        outPut.Write("start \"\" sysmarket-v0.5.2-alpha/SysMarket.exe");
                        outPut.Close();
                    }
                }
                catch (Exception e)
                {
                    // Let the user know what went wrong.
                    Console.WriteLine("The file could not be written: The Marketplace.bat :");
                    Console.WriteLine(e.Message);
                }


                #endregion Create/Replace ./The Marketplace.bat
                if (isDebugging) Console.WriteLine("Wrote The Marketplace.bat file.");

                Console.WriteLine("Installation success, Please delete this file now.");
            }

            if (isDebugging) Console.WriteLine("Writing Your Syscoin Wallet.bat file...");
            #region Create/Replace ./Your Syscoin Wallet.bat

            try
            {
                // Create an instance of StreamReader to read from a file. 
                // The using statement also closes the StreamReader. 
                using (StreamWriter outPut = new StreamWriter("Your Syscoin Wallet.bat"))
                {

                    outPut.WriteLine("echo 'Calling wallet exe file'");
                    outPut.Write("start \"\" Syscoin_v0.1.5/Syscoin-Qt.exe");
                    outPut.Close();
                }
            }
            catch (Exception e)
            {
                // Let the user know what went wrong.
                Console.WriteLine("The file could not be written: Your Syscoin Wallet.bat:");
                Console.WriteLine(e.Message);
            }


            #endregion Create/Replace ./Your Wallet.bat
            if (isDebugging) Console.WriteLine("Wrote Your Syscoin Wallet.bat file.");


            Console.ReadLine();
        }
    }
}
