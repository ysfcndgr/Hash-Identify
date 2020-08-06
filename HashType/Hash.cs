using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HashType
{
    class Hash
    {

        public static void Length4()
        {
            Console.WriteLine("ADLER32\nCRC32\nCRC32B\nCRC32C\nFNV132\nFNV1A32\nJOAAT ");
        }

        public static void Length8()
        {
            Console.WriteLine("FNV164\nFNV1A64", "Possible Species");
        }
        public static void Lenghth16()
        {
            Console.WriteLine("MD2\nMD4\nMD5\nTIGER128,3\nTIGER128,4\nHAVAL128,3\nHAVAL128,4\nHAVAL128,5\nRIPEDMD128\n");
        }
        public static void Length20()
        {
            Console.WriteLine("SHA1\nRIPEMD160\nTIGER160,3\nTIGER160,4\nHAVAL160,3\nHAVAL160,4\nHAVAL160,5\n");
        }

        public static void Length24()
        {
            Console.WriteLine("TIGER192,3\nTIGER192,4\nHAVAL192,3\nHAVAL192,4\nHAVAL192,5");
        }
        public static void Length28()
        {
            Console.WriteLine("SHA224\nSHA512/224\nSHA3-224\nHAVAL224,3\nHAVAL224,4\nHAVAL224,5");
        }
        public static void Length32()
        {
            Console.WriteLine("SHA256\nSHA512/256\nSHA3-256\nRIPEMD256\nSNEFRU\nSNEFRU256\nGOST\nGOST-CRYPTO\nHAVAL256,3\nHAVAL256,4\nHAVAL256,5");
        }
        public static void Length40()
        {
            Console.WriteLine("RIPEMD320");
        }
        public static void Length48()
        {
            Console.WriteLine("SHA384\nSHA3-384");
        }
        public static void Length64()
        {
            Console.WriteLine("SHA512\nSHA3-512\nWHIRLPOOL\n");
        }
        public static void WhichType(string type)
        {
            switch (type.Length)
            {
                case 8: Length4(); break;
                case 16: Length8(); break;
                case 32: Lenghth16(); break;
                case 40: Length20(); break;
                case 48: Length24(); break;
                case 56: Length28(); break;
                case 64: Length32(); break;
                case 80: Length40(); break;
                case 96: Length48(); break;
                case 128: Length64(); break;
                default: Console.WriteLine("Hash Type Not Found"); break;
            }

        }
    }
}
