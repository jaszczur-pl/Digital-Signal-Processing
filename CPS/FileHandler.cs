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
        public void Serialize(object o, string path) {
            BinaryFormatter bf = new BinaryFormatter();
            FileStream fsout = new FileStream(path, FileMode.Create, FileAccess.Write, FileShare.None);

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

        public Sygnal Deserialize(string path) {

            Sygnal signal = new Sygnal();
            BinaryFormatter bf = new BinaryFormatter();
            FileStream fsin = new FileStream(path, FileMode.Open, FileAccess.Read, FileShare.None);

            try {
                using (fsin) {
                    signal = (Sygnal)bf.Deserialize(fsin);        
                }
            }
            catch (Exception e) {
                Console.WriteLine(e.StackTrace);
            }
            finally {
                fsin.Dispose();
            }

            return signal;
        }
    }
}
