using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace CPS
{
    class FileHandler
    {
        public void Serialize(object o) {
            BinaryFormatter bf = new BinaryFormatter();
            FileStream fsout = new FileStream(@"E:\new.bin", FileMode.Create, FileAccess.Write, FileShare.None);

            try {
                using (fsout) {
                    bf.Serialize(fsout, o);
                }
            }
            catch (Exception e) {
                Console.WriteLine(e.StackTrace);
            }
            finally {
                fsout.Dispose();
            }
        }
    }
}
